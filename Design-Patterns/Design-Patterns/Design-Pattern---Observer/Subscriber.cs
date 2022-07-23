namespace Design_Pattern___Observer
{

    public class Subscriber : ISubscriber
    {

        #region // FIELDS & PROPERTIES //

        
        private int Price { get; set; }
        public int Id { get; }

        private static int IdGenerator = 0;


        #endregion


        #region // METHODS //


        public Subscriber()
        {
            Id = ++IdGenerator;
        }

        public void Update(int newItem)
        {
            Price = newItem;
            Console.WriteLine($"Subscriber {Id} State Changed! New Price is: {Price}");
        }


        #endregion

    }
}
