using System;
using Decorator_Pizza_Demo.Decorators;
using Decorator_Pizza_Demo.Pizzas;

namespace Decorator_Pizza_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza smallPizza = new SmallPizza();
            smallPizza = new CheesePizza(smallPizza);
            Console.WriteLine($"{smallPizza.Name} - {smallPizza.Price} ron");

            Pizza mediumPizza = new MediumPizza();
            mediumPizza = new PeperoniPizza(mediumPizza);
            Console.WriteLine($"{mediumPizza.Name} - {mediumPizza.Price} ron");

            Pizza largePizza = new LargePizza();
            largePizza = new CheesePizza(largePizza);
            largePizza = new PeperoniPizza(largePizza);
            largePizza = new CheesePizza(largePizza);
            Console.WriteLine($"{largePizza.Name} - {largePizza.Price} ron");
        }
    }
}
