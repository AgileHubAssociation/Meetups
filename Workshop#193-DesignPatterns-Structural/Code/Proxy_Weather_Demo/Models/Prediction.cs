using System;
using System.Diagnostics;

namespace Proxy_Weather_Demo.Models
{
    [DebuggerDisplay("Date = {Date} - Temp: {TemperatureInCelsius} C / {TemperatureInKelvin} K")]
    public class Prediction
    {
        private double _tempInK;

        public DateTime Date { get; set; }

        public double TemperatureInKelvin
        {
            get { return _tempInK; }
            set { _tempInK = Math.Round(value, 1); }
        }

        public double TemperatureInCelsius { get { return Math.Round(_tempInK - 273.15); } }
    }
}
