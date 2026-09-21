using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BeverageTypes
{
    public enum Size
    {
        ANT = 1,
        TALL,
        GRANDE,
        VENDI
    }
    public abstract class Beverage
    {

        public Size Size
        {
            get
            {
                if (size == 0)
                {
                    return Size.ANT;
                }
                else
                {
                    return size;
                }
            }
            set { size = value; }
        }
        private Size size;

        protected string description = "Unknown";
        protected Beverage? baseBeverage = null;


        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();

        public double GetCost()
        {
            return cost() * 1 + (int)Size / 10;
        }
    }
}
