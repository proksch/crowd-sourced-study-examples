using Newtonsoft.Json;

namespace Json_Library
{
    public class Serializer : ISerializer
    {
        public string Serialize(object p)
        {
            var s = new JsonSerializerSettings
            {
               NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(p, s);
        }
    }
}