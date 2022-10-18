using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Country
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("code")]
        public string Code;

        [JsonProperty("timezone")]
        public string Timezone;
    }
}
