using System;

namespace Composite_Files_Demo.Classes
{
    public class File : IDiskItem
    {
        public string Name { get; set; }
        public int SizeInKB { get; set; }

        public File(string name, int sizeInKB)
        {
            Name = name;
            SizeInKB = sizeInKB;
        }
        public void Display(int indent)
        {
            Console.WriteLine($"{new String(' ', indent)} - {Name}");
        }
    }
}
