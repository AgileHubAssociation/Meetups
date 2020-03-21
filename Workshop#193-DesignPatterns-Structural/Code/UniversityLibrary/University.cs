using System.Collections.Generic;

namespace UniversityLibrary
{
    // The Facade
    public class University : IUniversity
    {
        private MentorsDepartment _mentorsDepartment;
        private Secretariat _secretariat;

        public University()
        {
            _mentorsDepartment = new MentorsDepartment();
            _secretariat = new Secretariat();
        }

        public void RegisterStudent(string firstName, string lastName)
        {
            var student = _secretariat.RegisterStudent(firstName, lastName);
            _mentorsDepartment.AssignStudentToMentor(student);
        }

        public IReadOnlyList<Student> GetAllStudents()
        {
            return _secretariat.GetAllStudents();
        }
    }
}
