using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class Penguin : Duck
    {
        public Penguin()
        {
            SetQuackBehavior(new MuteQuack());
            SetFlyBehavior(new FlyNoWay());
            SetSwimBehavior(new Float());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Penguin!");
        }
    }
}
