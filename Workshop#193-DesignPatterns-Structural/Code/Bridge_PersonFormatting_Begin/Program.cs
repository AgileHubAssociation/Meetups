using System;
using Bridge_PersonFormatting_Begin.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nadia", "Comanici");
            var student = new Student(123, "Simona", "Lungu");

            // person json formatting
            Console.WriteLine("-------- Person as JSON ---------------");
            var formatterJson = new PersonJsonFormatter();
            Console.WriteLine(formatterJson.GetFormattedObject(person));
            Console.WriteLine();

            // person xml formatting
            Console.WriteLine("-------- Person as XML ---------------");
            var formatterXml = new PersonXmlFormatter();
            Console.WriteLine(formatterXml.GetFormattedObject(person));
            Console.WriteLine();

            // student json formatting
            Console.WriteLine("-------- Student as JSON ---------------");
            var formatterStudentJson = new StudentJsonFormatter();
            Console.WriteLine(formatterStudentJson.GetFormattedObject(student));
            Console.WriteLine();

            // student xml formatting
            Console.WriteLine("-------- Student as XML ---------------");
            var formatterStudentXml = new StudentXmlFormatter();
            Console.WriteLine(formatterStudentXml.GetFormattedObject(student));
            Console.WriteLine();
        }
    }
}
