using System;
using System.Collections.Generic;
using Composite_Files_Begin.Classes;

namespace Composite_Files_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            var readMeFile = new File("readme.txt", 130);
            var instructionsDoc = new File("instructions.doc", 3200);
            var fileGit = new File("file.git", 50);
            List<File> files = new List<File>() { readMeFile, instructionsDoc, fileGit };

            var folderVisualStudio = new Folder("ProjectFolder");
            folderVisualStudio.Add(new File("app.config", 215));
            folderVisualStudio.Add(new File("Project1.csproj", 15));
            folderVisualStudio.Add(new File("Program.cs", 1600));

            var folderSolution = new Folder("Properties");
            folderSolution.Add(new File("AssemblyInfo.cs", 56));

            int totalSizeInKB = 0;

            foreach (var file in files)
            {
                totalSizeInKB += file.SizeInKB;
                file.Display(0);
            }

            Console.WriteLine($" + {folderVisualStudio.Name}");
            foreach (var file in folderVisualStudio.Files)
            {
                totalSizeInKB += file.SizeInKB;
                file.Display(1);
            }

            Console.WriteLine($" + {folderSolution.Name}");
            foreach (var file in folderSolution.Files)
            {
                totalSizeInKB += file.SizeInKB;
                file.Display(1);
            }

            Console.WriteLine($"Total size: {totalSizeInKB} KB");
        }
    }
}
