namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyWithRocket : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying using my rocket!");
        }
    }

}