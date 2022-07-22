using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Visitor
{
    public class MidWeekTax : IVisitor
    {
        public double Visit(House house)
        {
            var taxPrice = house.Price * 0.17;
            return house.Price + taxPrice;
        }

        public double Visit(Car car)
        {
            var taxPrice = car.Price * 0.3;
            return car.Price + taxPrice;
        }

        public double Visit(Drink drink)
        {
            var taxPrice = drink.Price * 0;
            return drink.Price + taxPrice;
        }
    }
}
