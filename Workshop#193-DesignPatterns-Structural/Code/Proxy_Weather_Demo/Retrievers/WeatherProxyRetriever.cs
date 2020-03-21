using System;
using System.Collections.Generic;
using System.Configuration;
using Proxy_Weather_Demo.Helpers;
using Proxy_Weather_Demo.Models;

namespace Proxy_Weather_Demo.Retrievers
{
    public class WeatherProxyRetriever
    {
        private string _apiKey;
        private WeatherApiRetriever _realApiRetriever;
        private List<Prediction> _cachedPredictions;
        private DateTime _cachedExpirationTimestamp;

        private WeatherApiRetriever RealApiRetriever
        {
            get
            {
                if (_realApiRetriever == null)
                {
                    _realApiRetriever = new WeatherApiRetriever(_apiKey);
                }
                return _realApiRetriever;
            }
        }

        private bool IsCacheExpired
        {
            get
            {
                return _cachedPredictions == null || _cachedPredictions.Count == 0 || _cachedExpirationTimestamp < DateTime.Now;
            }
        }

        public WeatherProxyRetriever()
        {
            _apiKey = ConfigurationManager.AppSettings.Get("weatherApiKey");
        }

        public double? GetPredictionForDate(string cityId, DateTime referenceDate)
        {
            if (IsCacheExpired)
            {
                _cachedPredictions = RealApiRetriever.GetPredictionsForCity(cityId);
                _cachedExpirationTimestamp = DateTime.Now.AddMinutes(2);
            }
            return _cachedPredictions.GetPredictionByDate(referenceDate)?.TemperatureInCelsius;
        }
    }
}
