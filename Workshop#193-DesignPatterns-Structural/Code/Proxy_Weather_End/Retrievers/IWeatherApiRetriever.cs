using System;
using System.Collections.Generic;
using Proxy_Weather_End.Models;

namespace Proxy_Weather_End.Retrievers
{
    public interface IWeatherApiRetriever
    {
        double? GetPredictionForDate(string cityId, DateTime referenceDate);
        List<Prediction> GetPredictionsForCity(string cityId);
    }
}