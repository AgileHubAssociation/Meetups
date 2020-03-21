using Structural_Models;

namespace Bridge_PersonFormatting_Demo.FormattedObjects
{
    public class FormattedPerson : FormattedObject
    {
        private Person _person;

        public FormattedPerson(Person person)
        {
            _person = person;
        }

        public override string GetFormattedObject()
        {
            return Formatter.GetFormattedObject(_person);
        }
    }
}
