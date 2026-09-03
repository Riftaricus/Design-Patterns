namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying using my rocket!");
        }
    }

}