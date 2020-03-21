using System;
using System.Threading;
using Proxy_Weather_Demo.Retrievers;

namespace Proxy_Weather_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string brasovId = "683843";

            var weatherAPI = new WeatherProxyRetriever();
            Console.WriteLine($"---> I have an object for weather");

            while (true)
            {
                Console.WriteLine($"---> Entering loop");

                var predictionForNow = weatherAPI.GetPredictionForDate(brasovId, DateTime.Now);
                var predictionForTomorrow = weatherAPI.GetPredictionForDate(brasovId, DateTime.Now.AddDays(1));
                var predictionFor2Days = weatherAPI.GetPredictionForDate(brasovId, DateTime.Now.AddDays(2));

                Console.WriteLine($"The weather in Brasov now is: {predictionForNow} C");
                Console.WriteLine($"The weather in Brasov tomorrow is: {predictionForTomorrow} C");
                Console.WriteLine($"The weather in Brasov in 2 days is: {predictionFor2Days} C");

                Thread.Sleep(5000);
            }
        }
    }
}
