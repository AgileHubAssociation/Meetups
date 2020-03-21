using Decorator_Pizza_End.Pizzas;

namespace Decorator_Pizza_End.Decorators
{
    public class PeperoniPizza : PizzaDecorator
    {
        public override string Name
        {
            get
            {
                return $"{base.Name} with Peperoni";
            }
        }

        public override double Price
        {
            get
            {
                return base.Price + 5;
            }
        }

        public PeperoniPizza(Pizza pizza) : base(pizza)
        {
        }
    }
}
