using ObserverPattern.Displays;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 

            DisplayElement currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            DisplayElement forecastDisplay = new ForecastDisplay(weatherData);
            DisplayElement statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.SetMeasurements(30, 90, 29.2f);
            weatherData.SetMeasurements(5, 90, 29.2f);
            weatherData.SetMeasurements(-10, 90, 29.2f);
            weatherData.SetMeasurements(0, 80, 30.1f);
            weatherData.SetMeasurements(3, 75, 30.0f);
            weatherData.SetMeasurements(7, 72, 29.9f);
            weatherData.SetMeasurements(12, 68, 29.8f);
            weatherData.SetMeasurements(16, 64, 29.7f);
            weatherData.SetMeasurements(20, 60, 29.6f);
            weatherData.SetMeasurements(24, 58, 29.5f);
            weatherData.SetMeasurements(27, 55, 29.4f);
            weatherData.SetMeasurements(31, 52, 29.3f);
            weatherData.SetMeasurements(33, 50, 29.1f);
            weatherData.SetMeasurements(35, 48, 29.0f);
            weatherData.SetMeasurements(32, 53, 29.2f);
            weatherData.SetMeasurements(26, 61, 29.5f);
            weatherData.SetMeasurements(18, 67, 29.8f);
            weatherData.SetMeasurements(11, 74, 30.0f);
            weatherData.SetMeasurements(6, 79, 30.2f);
            weatherData.SetMeasurements(2, 84, 30.3f);
            weatherData.SetMeasurements(-4, 88, 30.4f);
            weatherData.SetMeasurements(-8, 91, 30.5f);
            weatherData.SetMeasurements(4, 82, 30.0f);
            weatherData.SetMeasurements(9, 76, 29.9f);
            weatherData.SetMeasurements(14, 71, 29.7f);
            weatherData.SetMeasurements(19, 66, 29.6f);
            weatherData.SetMeasurements(23, 62, 29.4f);
            weatherData.SetMeasurements(28, 57, 29.3f);
            weatherData.SetMeasurements(34, 49, 29.1f);
            weatherData.SetMeasurements(37, 45, 28.9f);
            weatherData.SetMeasurements(39, 42, 28.8f);
            weatherData.SetMeasurements(30, 54, 29.2f);
            weatherData.SetMeasurements(22, 63, 29.5f);
            weatherData.SetMeasurements(15, 69, 29.8f);
            weatherData.SetMeasurements(8, 77, 30.1f);
            weatherData.SetMeasurements(1, 85, 30.3f);
            weatherData.SetMeasurements(-6, 89, 30.6f);
            weatherData.SetMeasurements(-12, 93, 30.7f);
            weatherData.SetMeasurements(-15, 95, 30.8f);
            weatherData.SetMeasurements(-9, 92, 30.5f);
            weatherData.SetMeasurements(-1, 87, 30.2f);
            weatherData.SetMeasurements(10, 78, 29.9f);
            weatherData.SetMeasurements(21, 65, 29.6f);
            weatherData.SetMeasurements(25, 59, 29.4f);
            weatherData.SetMeasurements(29, 56, 29.2f);
            weatherData.SetMeasurements(38, 44, 28.7f);
            weatherData.SetMeasurements(40, 40, 28.6f);
            weatherData.SetMeasurements(42, 37, 28.5f);
        }
    }
}