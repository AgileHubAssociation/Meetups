using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Proxy_Weather_Begin.Helpers;
using Proxy_Weather_Begin.Models;

namespace Proxy_Weather_Begin.Retrievers
{
    public class WeatherApiRetriever
    {
        private static readonly string _apiUrlTemplate = "http://api.openweathermap.org/data/2.5/forecast?id={0}&appid={1}";
        private string _apiKey;

        public WeatherApiRetriever(string apiKey)
        {
            _apiKey = apiKey;
            Console.WriteLine("---> Api call to check user rights to the API...");
        }

        public double? GetPredictionForDate(string cityId, DateTime referenceDate)
        {
            var predictions = GetPredictionsForCity(cityId);
            return predictions.GetPredictionByDate(DateTime.Now)?.TemperatureInCelsius;
        }

        public List<Prediction> GetPredictionsForCity(string cityId)
        {
            JObject jsonData = GetJsonForCity(cityId);

            List<Prediction> predictions = new List<Prediction>();
            if (jsonData.SelectToken("cod").ToString() == "200")
            {
                foreach (JToken predictionJson in jsonData.SelectToken("list"))
                {
                    predictions.Add(GetPredictionFromJson(predictionJson));
                }
            }

            return predictions;
        }

        private static Prediction GetPredictionFromJson(JToken predictionJson)
        {
            var dtString = predictionJson.SelectToken("dt_txt").ToString();
            var mainJson = predictionJson.SelectToken("main");
            float temp = float.Parse(mainJson.SelectToken("temp").ToString());

            return new Prediction()
            {
                Date = DateTime.Parse(dtString),
                TemperatureInKelvin = temp
            };
        }

        private JObject GetJsonForCity(string cityId)
        {
            string apiUrl = string.Format(_apiUrlTemplate, cityId, _apiKey);
            using (var client = new System.Net.WebClient())
            {
                Console.WriteLine($"---> Call to API: {apiUrl}");
                return JObject.Parse(client.DownloadString(apiUrl));
            }
        }
    }
}
