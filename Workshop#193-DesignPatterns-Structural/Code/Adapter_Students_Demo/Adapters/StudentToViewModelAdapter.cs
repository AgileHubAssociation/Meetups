using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Students_Demo.ViewModels;
using Structural_Models;

namespace Adapter_Students_Demo.Adapters
{
    public static class StudentExtensionMethods
    {
        public static StudentViewModel ToStudentViewModel(this Student student)
        {
            return new StudentViewModel
            {
                Id = student.Id,
                Name = student.FirstName,
                Surname = student.LastName
            };
        }
    }

    class StudentToViewModelAdapter
    {
        public static IEnumerable<StudentViewModel> ConvertStudentsToStudentsViewModels(IEnumerable<Student> students)
        {
            List<StudentViewModel> result = new List<StudentViewModel>();

            foreach (var s in students)
            {
                result.Add(s.ToStudentViewModel());
            }

            return result;
        }
    }
}
