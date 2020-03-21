using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pizza_Demo.Pizzas;

namespace Decorator_Pizza_Demo.Decorators
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza)
        {

        }

        public override string Name
        {
            get
            {
                return base.Name + " Cheese";
            }
        }
        public override double Price
        {
            get
            {
                return base.Price + 10;
            }
        }
    }
}
