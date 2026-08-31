using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal class Float : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I'm floating...");
        }
    }

}