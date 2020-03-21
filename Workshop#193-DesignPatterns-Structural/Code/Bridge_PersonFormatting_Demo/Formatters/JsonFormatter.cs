using Newtonsoft.Json;

namespace Bridge_PersonFormatting_Demo.Formatters
{
    public class JsonFormatter : IFormatter
    {
        public string GetFormattedObject(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
