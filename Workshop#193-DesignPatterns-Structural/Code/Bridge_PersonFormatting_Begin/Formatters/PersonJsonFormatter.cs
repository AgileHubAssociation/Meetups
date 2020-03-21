using Newtonsoft.Json;
using Structural_Models;

namespace Bridge_PersonFormatting_Begin.Formatters
{
    public class PersonJsonFormatter
    {
        public string GetFormattedObject(Person person)
        {
            return JsonConvert.SerializeObject(person);
        }
    }
}
