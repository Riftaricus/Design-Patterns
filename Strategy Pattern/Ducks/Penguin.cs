using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern.Ducks
{
    internal class Penguin : Duck
    {
        public Penguin()
        {
            this.quackBehavior = new MuteQuack();
            this.flyBehavior = new FlyNoWay();
            this.swimBehavior = new Float();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Penguin!");
        }
    }
}
