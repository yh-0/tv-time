using GetTvShowTotalLength.Classes;
using Newtonsoft.Json;
using System.Text;

namespace GetTvShowTotalLength
{
    internal class Program
    {
        public static string buildUrl(string urlParam)
        {
            const string url = "https://api.tvmaze.com/singlesearch/shows?q=";
            StringBuilder stringBuilder = new StringBuilder(url);

            try
            {
                stringBuilder.Append(urlParam);
                stringBuilder.Append("&embed=episodes");
                return stringBuilder.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("No show name given as argument...");
                Environment.Exit(1);
            }
            return "";
        }

        public static string collectData(string url)
        {
            HttpClient client = new HttpClient();

            try
            {
                var response = client.GetStringAsync(url).Result;
                return response;
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't collect data...");
                Environment.Exit(10);
            }
            return "";
        }

        public static Root deserializeData(string response)
        {
            try
            {
                var resultRoot = JsonConvert.DeserializeObject<Root>(response);
                return resultRoot;
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't deserialize data...");
                Console.WriteLine(e);
                Environment.Exit(2);
            }
            return null;
        }

        public static int calculateTotalShowLength(Root root)
        {
            try
            {
                return root.Embedded.TotalEpisodesLength();
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't calculate total length...");
                Environment.Exit(3);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            var url = buildUrl(args[0]);
            var response = collectData(url);
            var resultRoot = deserializeData(response);
            var totalShowLength = calculateTotalShowLength(resultRoot);

            Console.WriteLine(totalShowLength);

            Environment.Exit(0);
        }
    }
}