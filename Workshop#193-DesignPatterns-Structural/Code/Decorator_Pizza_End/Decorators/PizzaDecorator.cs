using Decorator_Pizza_End.Pizzas;

namespace Decorator_Pizza_End.Decorators
{
    public class PizzaDecorator : Pizza
    {
        private Pizza _pizza;

        public override string Name => _pizza.Name;

        public override double Price => _pizza.Price;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
    }
}
