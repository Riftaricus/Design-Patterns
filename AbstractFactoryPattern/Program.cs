using AbstractFactoryPattern;
using DecoratorPattern.BeverageTypes;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory starBucksFactory = new StarbucksFactory();

            foreach (DRINKS drink in Enum.GetValues<DRINKS>())
            {
                Beverage beverage = starBucksFactory.CreateDrink(drink);
            }

            BeverageFactory draculaFactory = new DraculaFactory();

            foreach (DRINKS drink in Enum.GetValues<DRINKS>())
            {
                Beverage beverage = draculaFactory.CreateDrink(drink);
            }
        }
    }
}