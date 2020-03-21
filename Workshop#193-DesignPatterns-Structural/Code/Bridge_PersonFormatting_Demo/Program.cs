using System;
using Bridge_PersonFormatting_Demo.FormattedObjects;
using Bridge_PersonFormatting_Demo.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nadia", "Comanici");
            var student = new Student(123, "Simona", "Lungu");

            // person json formatting
            Console.WriteLine("-------- Person as JSON ---------------");
            var formattedPerson = new FormattedPerson(person);
            formattedPerson.Formatter = new JsonFormatter();
            Console.WriteLine(formattedPerson.GetFormattedObject());
            Console.WriteLine();

            // person xml formatting
            Console.WriteLine("--------Person as  XML ---------------");
            formattedPerson.Formatter = new XmlFormatter();
            Console.WriteLine(formattedPerson.GetFormattedObject());
            Console.WriteLine();

            // student json formatting
            Console.WriteLine("-------- Student as JSON ---------------");
            var formattedStudent = new FormattedStudent(student);
            formattedStudent.Formatter = new JsonFormatter();
            Console.WriteLine(formattedStudent.GetFormattedObject());
            Console.WriteLine();

            // student xml formatting
            Console.WriteLine("-------- Student as XML ---------------");
            formattedStudent.Formatter = new XmlFormatter();
            Console.WriteLine(formattedStudent.GetFormattedObject());
            Console.WriteLine();
        }
    }
}
