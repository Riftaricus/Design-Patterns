using AbstractFactoryPattern;
using DecoratorPattern.BeverageTypes;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new StarbucksFactory();

            Beverage beverage;

            foreach (DRINKS drink in Enum.GetValues<DRINKS>())
            {
                beverage = factory.CreateDrink(drink);
                PrintBeverage(beverage);
            }
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                beverage.GetDescription()
                + " $"
                + beverage.GetCost().ToString("#.##")
                + " size "
                + beverage.Size
            );
        }
    }
}