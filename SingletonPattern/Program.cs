using Singleton;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            Console.WriteLine(boiler.ToString());
            boiler.boil();
            Console.WriteLine(boiler.ToString());
            boiler.drain();
            Console.WriteLine(boiler.ToString());
            boiler.fill();
            Console.WriteLine(boiler.ToString());
            boiler.boil();
            Console.WriteLine(boiler.ToString());
        }
    }
}