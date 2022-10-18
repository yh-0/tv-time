using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Externals
    {
        [JsonProperty("tvrage")]
        public int Tvrage;

        [JsonProperty("thetvdb")]
        public int Thetvdb;

        [JsonProperty("imdb")]
        public string Imdb;
    }
}
