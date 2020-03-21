using System.Xml.Linq;
using System.Xml.Serialization;
using Structural_Models;

namespace Bridge_PersonFormatting_Begin.Formatters
{
    public class PersonXmlFormatter
    {
        public string GetFormattedObject(Person person)
        {
            var serializer = new XmlSerializer(typeof(Person));
            var doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                serializer.Serialize(writer, person);
                writer.Close();
            }
            return doc.ToString();
        }
    }
}
