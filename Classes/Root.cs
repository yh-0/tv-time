using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Root
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("language")]
        public string Language;

        [JsonProperty("genres")]
        public List<string> Genres;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("runtime")]
        public int Runtime;

        [JsonProperty("averageRuntime")]
        public int AverageRuntime;

        [JsonProperty("premiered")]
        public string Premiered;

        [JsonProperty("ended")]
        public string Ended;

        [JsonProperty("officialSite")]
        public string OfficialSite;

        [JsonProperty("schedule")]
        public Schedule Schedule;

        [JsonProperty("rating")]
        public Rating Rating;

        [JsonProperty("weight")]
        public int Weight;

        [JsonProperty("network")]
        public Network Network;

        [JsonProperty("webChannel")]
        public object WebChannel;

        [JsonProperty("dvdCountry")]
        public object DvdCountry;

        [JsonProperty("externals")]
        public Externals Externals;

        [JsonProperty("image")]
        public Image Image;

        [JsonProperty("summary")]
        public string Summary;

        [JsonProperty("updated")]
        public int Updated;

        [JsonProperty("_links")]
        public Links Links;

        [JsonProperty("_embedded")]
        public Embedded Embedded;
    }
}
