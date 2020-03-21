using System;

namespace Flyweight_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Design Patterns";

            // Returns true, same reference
            //string string2 = string1;

            // Returns true, because string uses flyweight
            //string string2 = "Design Patterns";

            // Returns false, for input "Design Patterns"
            //string string2 = Console.ReadLine();

            // Returns true, for input "Design Patterns"
            string string2 = string.Intern(Console.ReadLine());

            Console.WriteLine(ReferenceEquals(string1, string2));
        }
    }
}
