using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetQuackBehavior(new MuteQuack());
            SetFlyBehavior(new FlyNoWay());
            SetSwimBehavior(new Float());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck");
        }
    }
}
