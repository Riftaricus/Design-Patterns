using System.Drawing;
using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Espresso
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            // Corretta
            Beverage corretta = new Espresso();
            corretta = new Liquor(corretta);
            PrintBeverage(corretta);

            // Con Panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = new Espresso();
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // Caffé Latte
            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            // Morocchino
            Beverage morocchino = new Espresso();
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            // Mocha
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            // Raf Coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            // Mead Raf
            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            // Caffé Affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            // Vienna Coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            PrintBeverage(glace);

            // Chocolate Milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // Demi-Crème
            Beverage demiCreme = new Espresso();
            demiCreme = new Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte Macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = new Espresso();
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // Caramel Frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);

            // Ketchup
            Beverage ticketToSatan = new Whiskey();
            for (int i = 0; i < 15; i++)
            {
                ticketToSatan = new Ketchup(ticketToSatan);
                ticketToSatan = new Ice(ticketToSatan);
                ticketToSatan = new Chocolate(ticketToSatan);
                ticketToSatan = new Lemon(ticketToSatan);
                ticketToSatan = new Honey(ticketToSatan);
            }

            ticketToSatan.Size = DecoratorPattern.Beverages.Size.VENDI;
            PrintBeverage(ticketToSatan);

            Beverage coffeeDracula = new Espresso();
            coffeeDracula = new Blood(coffeeDracula);
            coffeeDracula = new Blood(coffeeDracula);
            PrintBeverage(coffeeDracula);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + (beverage.GetCost()).ToString("#.##") + " size " + beverage.Size);
        }
    }
}