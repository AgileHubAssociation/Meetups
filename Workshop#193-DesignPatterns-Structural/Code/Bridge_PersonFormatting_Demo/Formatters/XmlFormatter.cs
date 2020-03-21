using System.Xml.Linq;
using System.Xml.Serialization;

namespace Bridge_PersonFormatting_Demo.Formatters
{
    public class XmlFormatter : IFormatter
    {
        public string GetFormattedObject(object obj)
        {
            var serializer = new XmlSerializer(obj.GetType());
            var doc = new XDocument();
            using (var writer = doc.CreateWriter())
            {
                serializer.Serialize(writer, obj);
                writer.Close();
            }
            return doc.ToString();
        }
    }
}
