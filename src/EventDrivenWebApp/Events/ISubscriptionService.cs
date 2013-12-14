using System.Collections.Generic;

namespace EventDrivenWebApp.Events
{
    public interface ISubscriptionService
    {
        IEnumerable<IConsumer<T>> GetSubscriptions<T>();
    }
}