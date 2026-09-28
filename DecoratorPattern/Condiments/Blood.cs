using DecoratorPattern.BeverageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Blood : CondimentDecorator
    {
        public Blood(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return 99.99 + baseBeverage.GetCost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Blood";
        }
    }
}
