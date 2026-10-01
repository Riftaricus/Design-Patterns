using System;
using System.Collections.Generic;
using DecoratorPattern;
using DecoratorPattern.BeverageTypes;
using DecoratorPattern.Condiments;

namespace AbstractFactoryPattern
{
    public enum BeverageTypes
    {
        BLOOD,
        CREAM,
        HALF_MILK,
        HONEY,
        ICE,
        ICECREAM,
        KETCHUP,
        LEMON,
        MILK_FOAM,
        MOCHA,
        SYRUP,
        VANILLA_SUGAR,
        WHIP,
        BLACK_CHOCOLATE,
        CHOCOLATE,
        WHITE_CHOCOLATE,
        ESPRESSO,
        LIQUOR,
        MILK,
        STEAMED_MILK,
        WATER,
        WHISKEY
    }

    public enum DRINKS
    {
        ESPRESSO,
        DOPPIO,
        LUNGO,
        MACCHIATO,
        CORRETTA,
        CON_PANNA,
        CAPPUCINNO,
        AMERICANO,
        CAFFE_LATTE,
        FLAT_WHITE,
        ROMANA,
        MOROCCHINO,
        MOCHA,
        BICERIN,
        BREVE,
        RAF_COFFEE,
        MEAD_RAF,
        GALAO,
        CAFFE_AFFOGATO,
        VIENNA_COFFEE,
        GLACE,
        CHOCOLATE_MILK,
        DEMI_CREME,
        LATTE_MACCHIATO,
        FREDDO,
        FRAPPUCCINO,
        CARAMEL_FRAPPUCCINO,
        FRAPPE,
        IRISH_COFFEE
    }

    public abstract class BeverageFactory
    {
        public Beverage CreateDrink(DRINKS drink)
        {
            return drink switch
            {
                DRINKS.ESPRESSO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [],
                        Size.GRANDE
                    ),

                DRINKS.DOPPIO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.ESPRESSO],
                        Size.GRANDE
                    ),

                DRINKS.LUNGO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.WATER],
                        Size.GRANDE
                    ),

                DRINKS.MACCHIATO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.MILK_FOAM],
                        Size.GRANDE
                    ),

                DRINKS.CORRETTA =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.LIQUOR],
                        Size.GRANDE
                    ),

                DRINKS.CON_PANNA =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.WHIP],
                        Size.GRANDE
                    ),

                DRINKS.CAPPUCINNO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.MILK_FOAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.AMERICANO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.WATER,
                            BeverageTypes.WATER
                        ],
                        Size.GRANDE
                    ),

                DRINKS.CAFFE_LATTE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.MILK_FOAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.FLAT_WHITE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.STEAMED_MILK
                        ],
                        Size.GRANDE
                    ),

                DRINKS.ROMANA =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.LEMON],
                        Size.GRANDE
                    ),

                DRINKS.MOROCCHINO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.CHOCOLATE,
                            BeverageTypes.MILK_FOAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.MOCHA =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.CHOCOLATE,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.WHIP
                        ],
                        Size.GRANDE
                    ),

                DRINKS.BICERIN =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.BLACK_CHOCOLATE,
                            BeverageTypes.WHITE_CHOCOLATE,
                            BeverageTypes.WHIP
                        ],
                        Size.GRANDE
                    ),

                DRINKS.BREVE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.MILK_FOAM,
                            BeverageTypes.HALF_MILK
                        ],
                        Size.GRANDE
                    ),

                DRINKS.RAF_COFFEE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.VANILLA_SUGAR,
                            BeverageTypes.CREAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.MEAD_RAF =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.HONEY,
                            BeverageTypes.CREAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.GALAO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.MILK_FOAM,
                            BeverageTypes.MILK_FOAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.CAFFE_AFFOGATO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.ESPRESSO,
                            BeverageTypes.ICECREAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.VIENNA_COFFEE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.ESPRESSO,
                            BeverageTypes.WHIP,
                            BeverageTypes.WHIP
                        ],
                        Size.GRANDE
                    ),

                DRINKS.GLACE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [BeverageTypes.ICECREAM],
                        Size.GRANDE
                    ),

                DRINKS.CHOCOLATE_MILK =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.CHOCOLATE,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.STEAMED_MILK
                        ],
                        Size.GRANDE
                    ),

                DRINKS.DEMI_CREME =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.ESPRESSO,
                            BeverageTypes.CREAM,
                            BeverageTypes.CREAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.LATTE_MACCHIATO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.MILK_FOAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.FREDDO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.LIQUOR,
                            BeverageTypes.ICE
                        ],
                        Size.GRANDE
                    ),

                DRINKS.FRAPPUCCINO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.ICE,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.WHIP
                        ],
                        Size.GRANDE
                    ),

                DRINKS.CARAMEL_FRAPPUCCINO =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.ICE,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.CREAM,
                            BeverageTypes.SYRUP
                        ],
                        Size.GRANDE
                    ),

                DRINKS.FRAPPE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.STEAMED_MILK,
                            BeverageTypes.ICECREAM
                        ],
                        Size.GRANDE
                    ),

                DRINKS.IRISH_COFFEE =>
                    CreateBeverage(
                        BeverageTypes.ESPRESSO,
                        [
                            BeverageTypes.WHISKEY,
                            BeverageTypes.WHIP
                        ],
                        Size.GRANDE
                    ),

                _ => throw new ArgumentOutOfRangeException(
                    nameof(drink),
                    drink,
                    null
                )
            };
        }

        public abstract Beverage PrepareDrink(Beverage beverage);

        public Beverage CreateBeverage(
            BeverageTypes beverageBase,
            List<BeverageTypes> extras,
            Size size)
        {
            Beverage? bev = null;

            // Create the base beverage
            if (beverageBase == BeverageTypes.ESPRESSO)
            {
                bev = new Espresso();
            }
            else if (beverageBase == BeverageTypes.CHOCOLATE)
            {
                bev = new Chocolate();
            }

            if (bev == null)
            {
                throw new ArgumentException(
                    "Unknown beverage base.",
                    nameof(beverageBase)
                );
            }

            // Add decorators
            foreach (BeverageTypes condiment in extras)
            {
                switch (condiment)
                {
                    case BeverageTypes.ESPRESSO:
                        bev = new Espresso(bev);
                        break;

                    case BeverageTypes.BLOOD:
                        bev = new Blood(bev);
                        break;

                    case BeverageTypes.WATER:
                        bev = new Water(bev);
                        break;

                    case BeverageTypes.MILK_FOAM:
                        bev = new MilkFoam(bev);
                        break;

                    case BeverageTypes.CREAM:
                        bev = new Cream(bev);
                        break;

                    case BeverageTypes.HALF_MILK:
                        bev = new HalfMilk(bev);
                        break;

                    case BeverageTypes.HONEY:
                        bev = new Honey(bev);
                        break;

                    case BeverageTypes.ICE:
                        bev = new Ice(bev);
                        break;

                    case BeverageTypes.ICECREAM:
                        bev = new IceCream(bev);
                        break;

                    case BeverageTypes.KETCHUP:
                        bev = new Ketchup(bev);
                        break;

                    case BeverageTypes.LEMON:
                        bev = new Lemon(bev);
                        break;

                    case BeverageTypes.MOCHA:
                        bev = new Mocha(bev);
                        break;

                    case BeverageTypes.SYRUP:
                        bev = new Syrup(bev);
                        break;

                    case BeverageTypes.VANILLA_SUGAR:
                        bev = new VanillaSugar(bev);
                        break;

                    case BeverageTypes.WHIP:
                        bev = new Whip(bev);
                        break;

                    case BeverageTypes.BLACK_CHOCOLATE:
                        bev = new BlackChocolate(bev);
                        break;

                    case BeverageTypes.CHOCOLATE:
                        bev = new Chocolate(bev);
                        break;

                    case BeverageTypes.WHITE_CHOCOLATE:
                        bev = new WhiteChocolate(bev);
                        break;

                    case BeverageTypes.LIQUOR:
                        bev = new Liquor(bev);
                        break;

                    case BeverageTypes.MILK:
                        bev = new Milk(bev);
                        break;

                    case BeverageTypes.STEAMED_MILK:
                        bev = new SteamedMilk(bev);
                        break;

                    case BeverageTypes.WHISKEY:
                        bev = new Whiskey(bev);
                        break;

                    default:
                        throw new ArgumentException(
                            $"Unknown condiment: {condiment}"
                        );
                }
            }

            bev.Size = size;

            PrintBeverage(bev);

            return PrepareDrink(bev);
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