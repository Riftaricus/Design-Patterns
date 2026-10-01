using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorPattern.BeverageTypes;

namespace AbstractFactoryPattern
{
    public class DraculaFactory : BeverageFactory
    {
        public override Beverage PrepareDrink(Beverage beverage)
        {
            Console.WriteLine($"Preparing {beverage.GetDescription()} with the dracula way");
            return beverage;
        }


    }
}