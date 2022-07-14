using System;
using Factories.Drink_Machine;
using Factories.Points;
using Factories.Themes;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo.GetPoint();

            //Demo.GetTheme();

            Demo.GetDrink();
        }
    }

    class Demo
    {
        public static void GetPoint()
        {
            var polar = PointFactory.NewPolar(1.0, 2.0);
            Console.WriteLine(polar);

            var cartesian = PointFactory.NewCartesian(1.0, 2.0);
            Console.WriteLine(cartesian);
        }

        public static void GetTheme()
        {
            var light = ThemeFactory.CreateTheme();
            Console.WriteLine(light);

            var dark = ThemeFactory.CreateTheme(true);
            Console.WriteLine(dark);
        }

        public static void GetDrink()
        {
            var factory = new HotDrinkFactory();
            var drink = factory.HotDrinks[0];
            Console.WriteLine($"Selected drink: {drink}");

            var hotDrink = factory.MakeDrink(drink, 100);

            hotDrink.Consume();
        }
    }
}
