using System;

namespace Composite_Files_Begin.Classes
{
    public class File
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
