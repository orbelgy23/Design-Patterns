using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern___Visitor
{
    public interface IVisitor
    {
        public double Visit(House house);
        public double Visit(Car car);
        public double Visit(Drink drink);
    }
}
