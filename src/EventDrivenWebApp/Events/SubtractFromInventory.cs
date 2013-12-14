namespace EventDrivenWebApp.Events
{
    public class SubtractFromInventory : IConsumer<OrderSubmittedEvent>
    {
        public void Handle(OrderSubmittedEvent eventMessage)
        {
            int orderId = eventMessage.OrderId;
        }
    }
}