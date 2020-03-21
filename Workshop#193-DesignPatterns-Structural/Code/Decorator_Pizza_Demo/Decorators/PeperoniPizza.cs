using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pizza_Demo.Pizzas;

namespace Decorator_Pizza_Demo.Decorators
{
    public class PeperoniPizza : PizzaDecorator
    {
        public PeperoniPizza(Pizza pizza) : base(pizza)
        {

        }

        public override string Name
        {
            get
            {
                return base.Name + " Peperoni";
            }
        }
        public override double Price
        {
            get
            {
                return base.Price + 15;
            }
        }
    }
}
