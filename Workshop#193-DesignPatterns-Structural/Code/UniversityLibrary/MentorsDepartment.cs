using System;
using System.Collections.Generic;

namespace UniversityLibrary
{
    internal class MentorsDepartment
    {
        private List<Mentor> _mentors;
        private int _nextId;
        private Random _random = new Random();

        internal MentorsDepartment()
        {
            _mentors = new List<Mentor>();
            _nextId = 0;

            _mentors.Add(new Mentor(_nextId++, "Vasile", "Vasile"));
            _mentors.Add(new Mentor(_nextId++, "Gica", "Petrescu"));
            _mentors.Add(new Mentor(_nextId++, "Maria", "Stanescu"));
        }

        private Mentor GetAvailableMentor()
        {
            // TODO: implement more complex logic here
            return _mentors[_random.Next(_mentors.Count)];
        }

        public void AssignStudentToMentor(Student student)
        {
            var mentor = GetAvailableMentor();
            mentor.TakeStudentAsApprentice(student);
            student.Mentor = mentor;
        }
    }
}
