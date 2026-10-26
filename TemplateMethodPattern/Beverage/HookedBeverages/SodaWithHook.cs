namespace TemplateMethodPattern
{
    internal class SodaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Sugar through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon and ice cubes");
        }

        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like lemons and ice cubes with your coffee (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
