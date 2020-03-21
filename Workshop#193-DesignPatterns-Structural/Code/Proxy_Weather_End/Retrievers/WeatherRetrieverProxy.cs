using System;
using System.Collections.Generic;
using Proxy_Weather_End.Helpers;
using Proxy_Weather_End.Models;

namespace Proxy_Weather_End.Retrievers
{
    public class WeatherRetrieverProxy : IWeatherApiRetriever
    {
        private static readonly TimeSpan _expirationPeriod = TimeSpan.FromMinutes(1);

        private string _apiKey;
        private WeatherApiRetriever _apiRetriever;

        private List<Prediction> _cachedPredictions;
        private DateTime _cacheExpirationDate;

        public WeatherRetrieverProxy(string apiKey)
        {
            _apiKey = apiKey;
            _cachedPredictions = new List<Prediction>();
        }

        public WeatherApiRetriever ApiRetriever
        {
            get
            {
                if (_apiRetriever == null)
                {
                    _apiRetriever = new WeatherApiRetriever(_apiKey);
                }
                return _apiRetriever;
            }
        }

        public double? GetPredictionForDate(string cityId, DateTime referenceDate)
        {
            var predictions = GetPredictionsForCity(cityId);
            return predictions.GetPredictionByDate(DateTime.Now)?.TemperatureInCelsius;
        }

        public bool AreCachedPredictionExpired
        {
            get
            {
                return _cachedPredictions == null || _cachedPredictions.Count == 0 || _cacheExpirationDate < DateTime.Now;
            }
        }

        public List<Prediction> GetPredictionsForCity(string cityId)
        {
            if (AreCachedPredictionExpired)
            {
                _cachedPredictions = ApiRetriever.GetPredictionsForCity(cityId);
                _cacheExpirationDate = DateTime.Now.Add(_expirationPeriod);
                Console.WriteLine($"---> Cached predictions until {_cacheExpirationDate}");
            }
            return _cachedPredictions;
        }
    }
}
