using System.Xml.Linq;
using System.Xml.Serialization;
using Structural_Models;

namespace Bridge_PersonFormatting_Begin.Formatters
{
    public class StudentXmlFormatter
    {
        public string GetFormattedObject(Student student)
        {
            var serializer = new XmlSerializer(typeof(Student));
            var doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                serializer.Serialize(writer, student);
                writer.Close();
            }
            return doc.ToString();
        }
    }
}
