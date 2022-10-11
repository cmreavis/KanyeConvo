using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace KanyeAndRon
{
    public class QuoteGrabber
    {
        private readonly HttpClient _client;

        public QuoteGrabber(HttpClient client)
        {
            _client = client;
        }

        public string KanyeQuote() //mine
        {
            var kanyeAPI = "https://api.kanye.rest/";

            var kanyeResponds = _client.GetStringAsync(kanyeAPI).Result;  //the JSON data object from kanye rest will arrive to be stored into kanyeResponds

            var kanyeSays = JObject.Parse(kanyeResponds).GetValue("quote").ToString();          //parses JSON response for a string

            return kanyeSays;
        }

        public string RonQuote() //mine
        {
            var ronAPI = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponds = _client.GetStringAsync(ronAPI).Result;

            var ronQuote = JArray.Parse(ronResponds);

            return ronQuote.ToString().Replace('[', ' ').Replace(']',' ');
        }
       
    }
}
