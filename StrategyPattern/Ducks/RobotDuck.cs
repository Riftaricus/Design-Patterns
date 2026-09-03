using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            SetQuackBehavior(new MuteQuack());
            SetFlyBehavior(new FlyRocketPowered());
            SetSwimBehavior(new Sink());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a RobotDuck");
        }
    }
}
