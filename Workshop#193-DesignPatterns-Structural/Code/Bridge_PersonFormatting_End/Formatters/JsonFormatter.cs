using Newtonsoft.Json;

namespace Bridge_PersonFormatting_End.Formatters
{
    public class JsonFormatter : IFormatter
    {
        public string GetFormattedObject(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
