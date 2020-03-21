using System.Collections.Generic;
using System.Linq;
using Structural_Models;

namespace Structural_DAL
{
    public class StudentsRepository
    {
        private List<Student> _students;
        private int _nextId;

        public StudentsRepository()
        {
            _students = new List<Student>();
            _nextId = 0;

            // simulate loading data from database
            _students.Add(new Student(_nextId++, "Nadia", "Comanici"));
            _students.Add(new Student(_nextId++, "Andrei", "Popescu"));
            _students.Add(new Student(_nextId++, "Maria", "Ionescu"));
        }

        public IReadOnlyList<Student> GetStudents()
        {
            return _students.AsReadOnly();
        }

        public Student GetStudentById(int id)
        {
            return _students.SingleOrDefault(s => s.Id == id);
        }

        public Student AddStudent(string name, string surname)
        {
            var student = new Student(_nextId++, name, surname);
            _students.Add(student);
            return student;
        }
    }
}
