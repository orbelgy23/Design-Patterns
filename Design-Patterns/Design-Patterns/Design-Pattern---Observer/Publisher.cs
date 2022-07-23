namespace Design_Pattern___Observer
{

    public class Publisher : IPublisher
    {
        #region // FIELDS & PROPERTIES //


        List<ISubscriber> Subscribers { get; set; } = new List<ISubscriber>();


        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                NotifySubscribers();
            }
        }


        #endregion


        
        #region // METHODS //


        public void Register(ISubscriber newSubscriber)
        {
            Subscribers.Add(newSubscriber);
            Console.WriteLine($"Subscriber Number {newSubscriber.Id} Registered!");
        }

        public void Unregister(ISubscriber registeredSubscriber)
        {
            Subscribers.Remove(registeredSubscriber);
            Console.WriteLine($"Subscriber Number {registeredSubscriber.Id} Unregistered");
        }

        public void NotifySubscribers()
        {
            foreach(var subscriber in Subscribers)
            {
                subscriber.Update(Price);
            }
        }


        #endregion
    }
}
