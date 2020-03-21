using System.Collections.Generic;

namespace Composite_Files_Begin.Classes
{
    public class Folder
    {
        public string Name { get; set; }

        public List<File> Files { get; private set; }

        public Folder(string name)
        {
            Files = new List<File>();
            Name = name;
        }

        public void Add(File file)
        {
            Files.Add(file);
        }

        public void Remove(File file)
        {
            Files.Remove(file);
        }
    }
}
