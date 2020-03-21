using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Files_Demo.Classes
{
    public interface IDiskItem
    {
        string Name { get; set; }
        int SizeInKB { get; }

        void Display(int indent);
    }
}
