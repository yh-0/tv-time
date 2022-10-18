using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Image
    {
        [JsonProperty("medium")]
        public string Medium;

        [JsonProperty("original")]
        public string Original;
    }
}
