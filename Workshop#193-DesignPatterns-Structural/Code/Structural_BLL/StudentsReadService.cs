using System.Collections.Generic;
using Structural_DAL;
using Structural_Models;

namespace Structural_BLL
{
    public class StudentsReadService
    {
        private StudentsRepository _studentsRepository;

        public StudentsReadService()
        {
            _studentsRepository = new StudentsRepository();
        }

        public IReadOnlyList<Student> GetAllStudents()
        {
            return _studentsRepository.GetStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentsRepository.GetStudentById(id);
        }
    }
}
