using System;
using Bridge_PersonFormatting_End.FormattedObjects;
using Bridge_PersonFormatting_End.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nadia", "Comanici");
            var student = new Student(123, "Simona", "Lungu");
            var jsonFormatter = new JsonFormatter();
            var xmlFormatter = new XmlFormatter();

            // person json formatting
            Console.WriteLine("-------- Person as JSON ---------------");
            var formattedPerson = new FormattedPerson(person, jsonFormatter);
            Console.WriteLine(formattedPerson.GetObjectAsString());
            Console.WriteLine();

            // person xml formatting
            Console.WriteLine("-------- Person as XML ---------------");
            formattedPerson.Formatter = xmlFormatter;
            Console.WriteLine(formattedPerson.GetObjectAsString());
            Console.WriteLine();

            // student json formatting
            Console.WriteLine("-------- Student as JSON ---------------");
            var formattedStudent = new FormattedStudent(student, jsonFormatter);
            Console.WriteLine(formattedStudent.GetObjectAsString());
            Console.WriteLine();

            // student xml formatting
            Console.WriteLine("-------- Student as XML ---------------");
            formattedStudent.Formatter = xmlFormatter;
            Console.WriteLine(formattedStudent.GetObjectAsString());
            Console.WriteLine();
        }
    }
}
