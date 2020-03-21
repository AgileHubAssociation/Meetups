using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite_Files_Demo.Classes
{
    public class Folder : IDiskItem
    {
        public string Name { get; set; }

        public List<IDiskItem> Items { get; private set; }
        public int SizeInKB
        {
            get
            {
                return Items.Sum(t => t.SizeInKB);
            }
        }

        public Folder(string name)
        {
            Items = new List<IDiskItem>();
            Name = name;
        }

        public void Add(IDiskItem item)
        {
            Items.Add(item);
        }

        public void Remove(IDiskItem item)
        {
            Items.Remove(item);
        }

        public void Display(int indent)
        {
            Console.WriteLine($"{new String(' ', indent)} + {Name}");
            foreach (var item in Items)
            {
                item.Display(indent + 1);
            }
        }
    }
}
