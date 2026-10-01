using Singleton;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            Console.WriteLine($"Nothing - {boiler.ToString()}");
            boiler.boil();
            Console.WriteLine($"Boiling - {boiler.ToString()}");
            boiler.fill();
            Console.WriteLine($"Filling - {boiler.ToString()}");
            boiler.boil();
            Console.WriteLine($"Boiling - {boiler.ToString()}");
            boiler.drain();
            Console.WriteLine($"Draining - {boiler.ToString()}");
        }
    }
}