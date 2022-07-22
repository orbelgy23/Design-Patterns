namespace Design_Pattern___Visitor
{
    public class Drink : IVisitable
    {
        public double Price { get; set; }



        public Drink(double item)
        {
            Price = item;
        }



        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}