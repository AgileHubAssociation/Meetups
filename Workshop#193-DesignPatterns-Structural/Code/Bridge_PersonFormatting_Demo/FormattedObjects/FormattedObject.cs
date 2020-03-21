using Bridge_PersonFormatting_Demo.Formatters;

namespace Bridge_PersonFormatting_Demo.FormattedObjects
{
    public abstract class FormattedObject
    {
        public IFormatter Formatter { get; set; }

        public abstract string GetFormattedObject();
    }
}
