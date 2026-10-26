namespace TemplateMethodPattern
{
    public class Soda : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Sugar through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon and ice cubes");
        }
    }
}
