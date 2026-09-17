using System.Drawing;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    public enum beverages
    {
        ESPRESSO,
        DOPPIO,
        LUNGO,
        MACCHIATO,
        CORRETTA,
        CON_PANNA,
        CAPPUCINO,
        AMERICANO,
        CAFFE_LATTE,
        FLAT_WHITE,
        ROMANA,
        MOROCCHINO,
        MOCHA,
        BICERIN,
        BREVE,
        RAF_COFFEE,
        MEAD_RAF,
        GALAO,
        CAFFE_AFFOGATTO,
        VIENNA_COFFEE,
        GLACE

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + (beverage.GetCost()).ToString("#.##") + " size " + beverage.Size);
        }
    }
}