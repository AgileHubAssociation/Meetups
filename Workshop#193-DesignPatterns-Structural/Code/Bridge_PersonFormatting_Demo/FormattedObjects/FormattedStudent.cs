using Structural_Models;

namespace Bridge_PersonFormatting_Demo.FormattedObjects
{
    public class FormattedStudent : FormattedObject
    {
        private Student _student;

        public FormattedStudent(Student student)
        {
            _student = student;
        }

        public override string GetFormattedObject()
        {
            return Formatter.GetFormattedObject(_student);
        }
    }
}
