using System;
using System.Collections.Generic;
using Composite_Files_Demo.Classes;

namespace Composite_Files_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("app");
            root.Add(new File("readme.txt", 130));
            root.Add(new File("instructions.doc", 3200));
            root.Add(new File("file.git", 50));

            var folderVisualStudio = new Folder("ProjectFolder");
            folderVisualStudio.Add(new File("app.config", 215));
            folderVisualStudio.Add(new File("Project1.csproj", 15));
            folderVisualStudio.Add(new File("Program.cs", 1600));

            var folderSolution = new Folder("Properties");
            folderSolution.Add(new File("AssemblyInfo.cs", 56));
            folderVisualStudio.Add(folderSolution);

            root.Add(folderVisualStudio);

            root.Display(0);

            Console.WriteLine($"Total size: {root.SizeInKB} KB");
        }
    }
}
