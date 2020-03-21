using Bridge_PersonFormatting_End.Formatters;

namespace Bridge_PersonFormatting_End.FormattedObjects
{
    public abstract class FormattedObject
    {
        public IFormatter Formatter { get; set; }
        public abstract string GetObjectAsString();
    }
}
