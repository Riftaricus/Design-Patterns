using TemplateMethodPattern.CompareTo;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleTea simpleTea = new SimpleTea();
            SimpleCoffee simpleCoffee = new SimpleCoffee();
            SimpleSoda simpleSoda = new SimpleSoda();

            simpleTea.prepareRecipe();
            simpleCoffee.PrepareRecipe();
            simpleSoda.PrepareRecipe();

            Console.WriteLine("\n\nNow with abstracted classes\n\n");

            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage soda = new Soda();

            tea.PrepareRecipe();
            coffee.PrepareRecipe();
            soda.PrepareRecipe();

            Console.WriteLine("\n\n Now with hooked classes\n\n");

            CaffeineBeverageWithHook teaWithHook = new TeaWithHook();
            CaffeineBeverageWithHook coffeeWithHook = new CoffeeWithHook();
            CaffeineBeverageWithHook sodaWithHook = new SodaWithHook();

            teaWithHook.PrepareRecipe();
            coffeeWithHook.PrepareRecipe();
            sodaWithHook.PrepareRecipe();

            // You'll need this method for the second part of the Template Method Pattern
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);
            ducks.Sort();
            
            Console.WriteLine("After sorting:");
            Display(ducks);
        }

        // You'll need this method for the second part of the Template Method Pattern
        public static void Display(object[] objects)
        {
            foreach (object o in objects)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("");
        }
    }
}