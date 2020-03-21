using System.Collections.Generic;

namespace UniversityLibrary
{
    public class Group
    {
        private List<Student> _students;

        public string Name { get; private set; }
        internal char StartChar { get; private set; }
        internal char EndChar { get; private set; }

        internal Group(string name, char startChar, char endChar)
        {
            _students = new List<Student>();
            Name = name;
            StartChar = startChar;
            EndChar = endChar;
        }

        internal void AddStudentInGroup(Student student)
        {
            _students.Add(student);
        }
    }
}
