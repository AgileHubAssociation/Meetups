using System;
using System.Collections.Generic;

namespace Composite_Files_End.Classes
{
    public class Folder : IDiskItem
    {
        private List<IDiskItem> _items;

        public string Name { get; set; }

        public int SizeInKB
        {
            get
            {
                int childrenSize = 0;
                foreach (var child in _items)
                {
                    childrenSize += child.SizeInKB;
                }
                return childrenSize;
            }
        }

        public Folder(string name)
        {
            _items = new List<IDiskItem>();
            Name = name;
        }

        public void Add(IDiskItem item)
        {
            _items.Add(item);
        }

        public void Remove(IDiskItem item)
        {
            _items.Remove(item);
        }

        public void Display(int indent)
        {
            Console.WriteLine($"{new String(' ', indent)} + {Name}");
            foreach (var item in _items)
            {
                item.Display(indent + 1);
            }
        }
    }
}
