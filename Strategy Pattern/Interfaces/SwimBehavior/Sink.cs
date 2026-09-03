using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class Sink : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I can't swim! I'm sinking aaaaa");
        }
    }

}