using System.Collections.Generic;

namespace UniversityLibrary
{
    public interface IUniversity
    {
        IReadOnlyList<Student> GetAllStudents();
        void RegisterStudent(string firstName, string lastName);
    }
}