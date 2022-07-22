using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Visitor
{
    public class Car : IVisitable
    {
        public double Price { get; set; }



        public Car(double item)
        {
            Price = item;
        }



        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
