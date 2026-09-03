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
            this.quackBehavior = new MuteQuack();
            this.flyBehavior = new FlyWithRocket();
            this.swimBehavior = new Sink();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a RobotDuck");
        }
    }
}
