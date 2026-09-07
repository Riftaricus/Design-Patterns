using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        private List<float> temperatures;
        public StatisticsDisplay(Subject weatherData)
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            temperatures = new List<float>();
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.temperatures.Add(temp);

            this.maxTemp = temperatures.Max();
            this.minTemp = temperatures.Min();
            this.sumTemperature = temperatures.Sum();
            
            Display();
        }

        public void Display()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            Console.WriteLine("[Statistics] " + "average: " + sumTemperature + " maximum: " + maxTemp + " minimum: " + minTemp);
        }
    }
}
