using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Links
    {
        [JsonProperty("self")]
        public Self Self;

        [JsonProperty("previousepisode")]
        public Previousepisode Previousepisode;
    }
}
