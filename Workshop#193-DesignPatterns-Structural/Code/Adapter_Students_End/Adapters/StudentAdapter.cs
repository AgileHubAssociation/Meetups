using System.Collections.Generic;
using Adapter_Students_End.ViewModels;
using Structural_Models;

namespace Adapter_Students_End.Adapters
{
    public class StudentAdapter : IStudentsAdapter
    {
        private StudentViewModel GetStudentViewModel(Student student)
        {
            return new StudentViewModel(student.Id, student.FirstName, student.LastName);
        }

        public IEnumerable<StudentViewModel> GetStudentViewModelList(IEnumerable<Student> students)
        {
            var studentVMs = new List<StudentViewModel>();
            foreach (Student student in students)
            {
                studentVMs.Add(GetStudentViewModel(student));
            }
            return studentVMs;
        }
    }
}
