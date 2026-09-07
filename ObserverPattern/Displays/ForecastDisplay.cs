using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
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
