using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay(Subject weatherData) : Display(weatherData)
    {

        public override void DisplayData()
        {
            // Print the current conditions of the weather
            Console.WriteLine("[Current] " + "temp: " + temperature + " humidity: " + humidity);
        }
    }
}
