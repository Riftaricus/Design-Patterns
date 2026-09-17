using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay(Subject weatherData) : Display(weatherData)
    {
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private List<float> temperatures = new List<float>();

        public override void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperatures.Add(temp);

            this.maxTemp = temperatures.Max();
            this.minTemp = temperatures.Min();
            this.sumTemperature = temperatures.Average();

            DisplayData();
        }

        public override void DisplayData()
        {
            // Print the average, maximum and minimum temperature. Use appropriate fields
            Console.WriteLine("[Statistics] " + "average: " + sumTemperature + " maximum: " + maxTemp + " minimum: " + minTemp);
        }
    }
}
