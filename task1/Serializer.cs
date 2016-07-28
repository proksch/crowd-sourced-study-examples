using Newtonsoft.Json;

namespace task1
{
    public class Serializer : ISerializer
    {
        public string Serialize(object p)
        {
            return JsonConvert.SerializeObject(p);
        }
    }
}