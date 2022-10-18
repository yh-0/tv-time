using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace GetTvShowTotalLength.Classes
{
    public class Episode
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("season")]
        public int Season;

        [JsonProperty("number")]
        public int Number;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("airdate")]
        public string? Airdate;

        [JsonProperty("airtime")]
        public string? Airtime;

        [JsonProperty("airstamp")]
        public DateTime? Airstamp;

        [JsonProperty("runtime")]
        public int Runtime;

        [JsonProperty("rating")]
        public Rating Rating;

        [JsonProperty("image")]
        public Image Image;

        [JsonProperty("summary")]
        public string Summary;

        [JsonProperty("_links")]
        public Links Links;
    }
}
