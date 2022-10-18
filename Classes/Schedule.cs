using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Schedule
    {
        [JsonProperty("time")]
        public string Time;

        [JsonProperty("days")]
        public List<string> Days;
    }
}
