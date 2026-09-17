using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Displays
{
    public abstract class Display
    {
        public float temperature;
        public float humidity;

        protected Subject weatherData;

        public Display(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public virtual void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            DisplayData();
        }

        public abstract void DisplayData();
    }
}