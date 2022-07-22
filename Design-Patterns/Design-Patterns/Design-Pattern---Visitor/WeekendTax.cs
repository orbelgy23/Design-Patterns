using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Visitor
{
    public class WeekendTax : IVisitor
    {
        public double Visit(House house)
        {
            var taxPrice = house.Price * 0.5;
            return house.Price + taxPrice;
        }

        public double Visit(Car car)
        {
            var taxPrice = car.Price * 0.25;
            return car.Price + taxPrice;
        }

        public double Visit(Drink drink)
        {
            var taxPrice = drink.Price * 0.1;
            return drink.Price + taxPrice;
        }
    }
}
