using Decorator_Pizza_End.Pizzas;

namespace Decorator_Pizza_End.Decorators
{
    public class CheesePizza : PizzaDecorator
    {
        public override string Name
        {
            get
            {
                return $"{base.Name} with Cheese";
            }
        }

        public override double Price
        {
            get
            {
                return base.Price + 3;
            }
        }

        public CheesePizza(Pizza pizza) : base(pizza)
        {
        }
    }
}
