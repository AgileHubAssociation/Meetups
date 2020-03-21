using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pizza_Demo.Pizzas;

namespace Decorator_Pizza_Demo.Decorators
{
    public class PizzaDecorator : Pizza
    {
        private Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string Name
        {
            get
            {
                return pizza.Name;
            }
        }
        public override double Price
        {
            get
            {
                return pizza.Price;
            }
        }
    }
}
