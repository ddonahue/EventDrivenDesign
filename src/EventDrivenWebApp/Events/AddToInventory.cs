using System;

namespace EventDrivenWebApp.Events
{
    public class AddToInventory : IConsumer<OrderRefundedEvent>
    {
        public void Handle(OrderRefundedEvent eventMessage)
        {
            throw new NotImplementedException();
        }
    }
}