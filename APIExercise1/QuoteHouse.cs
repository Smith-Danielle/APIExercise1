using System;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIExercise1
{
    public class QuoteHouse
    {
        public QuoteHouse()
        {
        }

        public void Kayne()
        {
            var client = new HttpClient();

            string urlKanyeW = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(urlKanyeW).Result;

            var kWQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"Kayne: {kWQuote}");
        }

        public void Ron()
        {
            var client = new HttpClient();

            string urlRonS = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(urlRonS).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");
        }             
       
    }
}
