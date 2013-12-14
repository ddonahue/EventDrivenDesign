using System.Collections.Generic;
using System.Linq;
using StructureMap;

namespace EventDrivenWebApp.Events
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IContainer container;

        public SubscriptionService(IContainer container)
        {
            this.container = container;
        }

        public IEnumerable<IConsumer<T>> GetSubscriptions<T>()
        {
            var consumers = container.GetAllInstances(typeof(IConsumer<T>));
            return consumers.Cast<IConsumer<T>>();
        }
    }
}