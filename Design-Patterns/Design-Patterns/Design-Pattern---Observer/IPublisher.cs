namespace Design_Pattern___Observer
{

    public interface IPublisher
    {
        void Register(ISubscriber newSubscriber);
        void Unregister(ISubscriber registeredSubscriber);
        void NotifySubscribers();
    }
}
