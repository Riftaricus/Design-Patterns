namespace TemplateMethodPattern
{
    internal class SimpleSoda
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewSugar();
            PourInCup();
            AddLemonAndIceCubes();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void BrewSugar()
        {
            Console.WriteLine("Dripping sugar through filter");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
        public void AddLemonAndIceCubes()
        {
            Console.WriteLine("Adding Lemon and Ice Cubes");
        }
    }
}
