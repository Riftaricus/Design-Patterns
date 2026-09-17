using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay(Subject weatherData) : Display(weatherData)
    {

        public override void DisplayData()
        {
            string humidityBit = "";
            if (humidity > 80)
            {
                humidityBit = "It might rain soon!";
            }
            else if (humidity > 60)
            {
                humidityBit = "Slight chance of rain today";
            }
            else if (humidity > 30)
            {
                humidityBit = "It's going to be a great day!";
            }
            else if (humidity < 30)
            {
                humidityBit = "It's going to be very warm today!";
            }


            // Print a forecast message based on the current temperature and humidity
            Console.WriteLine("[Forecast] " + humidityBit);
        }
    }
}
