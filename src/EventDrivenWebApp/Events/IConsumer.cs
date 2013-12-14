namespace EventDrivenWebApp.Events
{
    public interface IConsumer<T>
    {
        void Handle(T eventMessage);
    }
}