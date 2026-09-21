using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        WHISKEY,

    }
    public abstract class BeverageFactory
    {

        public abstract Beverage PrepareDrink(Beverage beverage);

        public Beverage CreateBeverage(BeverageTypes beverageBase, List<BeverageTypes> extras, Size size)
        {
            Beverage? bev = null;

            if (beverageBase == BeverageTypes.ESPRESSO)
                bev = new Espresso();

            else if (beverageBase == BeverageTypes.CHOCOLATE)
                bev = new Chocolate();

            if (bev == null)
            {
                throw new ArgumentException("Unknown beverage base.", nameof(beverageBase));
            }

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
                }
            }

            bev.Size = size;

            bev = PrepareDrink(bev);

            return bev;
        }
    }
}