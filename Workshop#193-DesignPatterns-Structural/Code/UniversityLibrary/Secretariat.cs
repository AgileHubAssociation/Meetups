using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityLibrary
{
    internal class Secretariat
    {
        private List<Group> _groups;
        private List<Student> _students;
        private int _nextStudentId;

        internal Secretariat()
        {
            _groups = new List<Group>();
            _students = new List<Student>();
            _nextStudentId = 0;

            _groups.Add(new Group("Group 1", 'a', 'g'));
            _groups.Add(new Group("Group 2", 'h', 'o'));
            _groups.Add(new Group("Group 3", 'p', 'z'));
        }

        internal Student RegisterStudent(string firstName, string lastName)
        {
            var student = new Student(_nextStudentId++, firstName, lastName);
            _students.Add(student);
            _students.Sort();
            
            AssignStudentToGroup(student);

            return student;
        }

        private void AssignStudentToGroup(Student student)
        {
            char lastNameInitial = student.LastName.ToLower()[0];
            var group = _groups.SingleOrDefault(g => g.StartChar <= lastNameInitial && lastNameInitial <= g.EndChar);
            if (group != null)
            {
                group.AddStudentInGroup(student);
                student.Group = group;
            }
            else
            {
                throw new InvalidOperationException("Cannot add student to group");
            }
        }

        internal IReadOnlyList<Student> GetAllStudents()
        {
            return _students.AsReadOnly();
        }
    }
}
