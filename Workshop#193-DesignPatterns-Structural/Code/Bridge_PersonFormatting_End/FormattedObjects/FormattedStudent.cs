using Bridge_PersonFormatting_End.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_End.FormattedObjects
{
    public class FormattedStudent : FormattedObject
    {
        private Student _student;

        public FormattedStudent(Student student, IFormatter formatter)
        {
            _student = student;
            Formatter = formatter;
        }

        public override string GetObjectAsString()
        {
            return Formatter.GetFormattedObject(_student);
        }
    }
}
