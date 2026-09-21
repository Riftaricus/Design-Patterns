using AbstractFactoryPattern;
using DecoratorPattern.BeverageTypes;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageFactory factory = new StarbucksFactory();

            Beverage beverage;

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.ESPRESSO],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.WATER],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.MILK_FOAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.LIQUOR],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.WHIP],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.STEAMED_MILK, AbstractFactoryPattern.BeverageTypes.MILK_FOAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.WATER, AbstractFactoryPattern.BeverageTypes.WATER],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.MILK_FOAM
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.STEAMED_MILK, AbstractFactoryPattern.BeverageTypes.STEAMED_MILK],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.LEMON],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.CHOCOLATE, AbstractFactoryPattern.BeverageTypes.MILK_FOAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.CHOCOLATE,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.WHIP
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.BLACK_CHOCOLATE,
                    AbstractFactoryPattern.BeverageTypes.WHITE_CHOCOLATE,
                    AbstractFactoryPattern.BeverageTypes.WHIP
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.MILK_FOAM, AbstractFactoryPattern.BeverageTypes.HALF_MILK],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.VANILLA_SUGAR, AbstractFactoryPattern.BeverageTypes.CREAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.HONEY, AbstractFactoryPattern.BeverageTypes.CREAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.MILK_FOAM, AbstractFactoryPattern.BeverageTypes.MILK_FOAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.ESPRESSO, AbstractFactoryPattern.BeverageTypes.ICECREAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                    AbstractFactoryPattern.BeverageTypes.WHIP,
                    AbstractFactoryPattern.BeverageTypes.WHIP
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.ICECREAM],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(


                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.CHOCOLATE,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                    AbstractFactoryPattern.BeverageTypes.CREAM,
                    AbstractFactoryPattern.BeverageTypes.CREAM
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.MILK_FOAM
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.LIQUOR, AbstractFactoryPattern.BeverageTypes.ICE],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.ICE,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.WHIP
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.ICE,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.CREAM,
                    AbstractFactoryPattern.BeverageTypes.SYRUP
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.STEAMED_MILK,
                    AbstractFactoryPattern.BeverageTypes.ICECREAM
                ],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.ESPRESSO,
                [AbstractFactoryPattern.BeverageTypes.WHISKEY, AbstractFactoryPattern.BeverageTypes.WHIP],
                BeverageTypes.Size.GRANDE
            );
            PrintBeverage(beverage);

            beverage = factory.CreateBeverage(
                AbstractFactoryPattern.BeverageTypes.CHOCOLATE,
                [
                    AbstractFactoryPattern.BeverageTypes.KETCHUP,
                    AbstractFactoryPattern.BeverageTypes.KETCHUP,
                    AbstractFactoryPattern.BeverageTypes.KETCHUP,
                    AbstractFactoryPattern.BeverageTypes.BLOOD
                ],
                BeverageTypes.Size.VENDI
            );
            PrintBeverage(beverage);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                beverage.GetDescription()
                + " $"
                + beverage.GetCost().ToString("#.##")
                + " size "
                + beverage.Size
            );
        }
    }
}