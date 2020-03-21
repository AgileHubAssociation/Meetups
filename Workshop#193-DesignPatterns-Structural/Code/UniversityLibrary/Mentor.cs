using System.Collections.Generic;

namespace UniversityLibrary
{
    public class Mentor : Person
    {
        private List<Student> _apprentices;

        internal int Id { get; private set; }

        internal Mentor(int id, string firstName, string lastName) : base(firstName, lastName)
        {
            Id = id;
            _apprentices = new List<Student>();
        }

        internal void TakeStudentAsApprentice(Student student)
        {
            _apprentices.Add(student);
        }
    }
}
