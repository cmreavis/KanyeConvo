using KanyeAndRon;
using Newtonsoft.Json.Linq;
using System.Net.Http;

internal class Program
{
    private static void Main(string[] args)
    {
        var client = new HttpClient();
        var quote = new QuoteGrabber(client);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Kanye: {quote.KanyeQuote()}");
            Console.WriteLine();
            Console.WriteLine($"Ron Swanson: {quote.RonQuote()}");
            Console.WriteLine();
        }
    }
}