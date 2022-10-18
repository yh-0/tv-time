using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Network
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("country")]
        public Country Country;

        [JsonProperty("officialSite")]
        public string OfficialSite;
    }
}
