using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace APIExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteHouse quote = new QuoteHouse();
            Console.WriteLine("Conversation between Kayne West and Ron Swanson");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < 3; i++)
            {
                quote.Kayne();
                Thread.Sleep(1400);
                quote.Ron();
                Thread.Sleep(1400);
            }
            
        }
    }
}
