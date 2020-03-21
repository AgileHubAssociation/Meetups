using System;
using UniversityLibrary;

namespace Facade_University
{
    class Program
    {
        static void Main(string[] args)
        {
            IUniversity university = new University();

            university.RegisterStudent("Nadia", "Comanici");
            university.RegisterStudent("Ion", "Ionescu");
            university.RegisterStudent("Maria", "Popescu");
            university.RegisterStudent("Valentin", "Tudor");
            university.RegisterStudent("Gigel", "Coman");
            university.RegisterStudent("Vasile", "Pop");

            foreach (var student in university.GetAllStudents())
            {
                Console.WriteLine($"{student.RegistrationId}. {student.FullName} - Mentor: {student.Mentor?.FullName} - Group: {student.Group.Name}");
            }
        }
    }
}
