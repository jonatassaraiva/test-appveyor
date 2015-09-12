using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestAppveyor.ClassLibrary
{
    public class User
    {
        public string Name { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
