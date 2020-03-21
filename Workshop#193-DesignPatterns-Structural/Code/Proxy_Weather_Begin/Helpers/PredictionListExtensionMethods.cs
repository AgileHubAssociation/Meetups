using System;
using System.Collections.Generic;
using Proxy_Weather_Begin.Models;

namespace Proxy_Weather_Begin.Helpers
{
    public static class PredictionListExtensionMethods
    {
        public static Prediction GetPredictionByDate(this List<Prediction> predictions, DateTime referenceDate)
        {
            if (predictions.Count > 0)
            {
                if (referenceDate < predictions[0].Date)
                {
                    return predictions[0];
                }

                for (int i = 0; i < predictions.Count - 1; i++)
                {
                    if (predictions[i].Date <= referenceDate && referenceDate < predictions[i + 1].Date)
                    {
                        return predictions[i];
                    }
                }
            }
            return null;
        }
    }
}
