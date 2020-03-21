using System.Collections.Generic;
using Adapter_Students_End.ViewModels;
using Structural_Models;

namespace Adapter_Students_End.Adapters
{
    public interface IStudentsAdapter
    {
        IEnumerable<StudentViewModel> GetStudentViewModelList(IEnumerable<Student> students);
    }
}