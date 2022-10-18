using Newtonsoft.Json;

namespace GetTvShowTotalLength.Classes
{
    public class Embedded
    {
        [JsonProperty("episodes")]
        public List<Episode> Episodes;

        public int TotalEpisodesLength()
        {
            int result = 0;
            foreach (var episode in Episodes)
            {
                if (episode.Runtime != null)
                {
                    result += episode.Runtime;
                }
            }
            return result;
        }
    }
}
