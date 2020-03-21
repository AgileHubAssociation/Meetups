using System;

namespace UniversityLibrary
{
    public class Student : Person, IComparable
    {
        public int RegistrationId { get; private set; }
        public Mentor Mentor { get; set; }
        public Group Group { get; set; }

        public Student(int id, string firstName, string lastName) : base(firstName, lastName)
        {
            RegistrationId = id;
        }

        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            if (otherStudent == null)
            {
                return -1;
            }
            return LastName.CompareTo(otherStudent.LastName);
        }
    }
}
