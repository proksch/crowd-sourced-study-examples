using Newtonsoft.Json;

namespace task1.priv
{
    public class SerializerSolution : ISerializer
    {
        public string Serialize(object p)
        {
            var s = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(p, s);
        }
    }
}