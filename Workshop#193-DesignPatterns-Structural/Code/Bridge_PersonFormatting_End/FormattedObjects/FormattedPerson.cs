using Bridge_PersonFormatting_End.Formatters;
using Structural_Models;

namespace Bridge_PersonFormatting_End.FormattedObjects
{
    public class FormattedPerson : FormattedObject
    {
        private Person _person;

        public FormattedPerson(Person person, IFormatter formatter)
        {
            _person = person;
            Formatter = formatter;
        }

        public override string GetObjectAsString()
        {
            return Formatter.GetFormattedObject(_person);
        }
    }
}
