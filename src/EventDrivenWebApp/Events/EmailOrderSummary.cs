namespace EventDrivenWebApp.Events
{
    public class EmailOrderSummary : IConsumer<OrderSubmittedEvent>
    {
        public void Handle(OrderSubmittedEvent eventMessage)
        {
            int orderId = eventMessage.OrderId;
        }
    }
}