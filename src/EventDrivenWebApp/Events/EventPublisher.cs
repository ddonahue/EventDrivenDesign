using System;
using System.Linq;

namespace EventDrivenWebApp.Events
{
    public class EventPublisher : IEventPublisher
    {
        private readonly ISubscriptionService subscriptionService;

        public EventPublisher(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }

        public void Publish<T>(T eventMessage)
        {
            var subscriptions = subscriptionService.GetSubscriptions<T>();
            subscriptions.ToList().ForEach(x => PublishToConsumer(x, eventMessage));
        }

        private static void PublishToConsumer<T>(IConsumer<T> x, T eventMessage)
        {
            try
            {
                x.Handle(eventMessage);
            }
            catch (Exception e)
            {
                //log and handle internally
            }
            finally
            {
                var instance = x as IDisposable;
                if (instance != null)
                {
                    instance.Dispose();
                }
            }
        }
    }
}