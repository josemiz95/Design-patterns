using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.Drink_Machine
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Put in tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
            return new Tea();
        }
    }

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and sugar, enjoy!");
            return new Coffee();
        }
    }

    public class HotDrinkFactory
    {
        public List<string> HotDrinks = new List<string>();

        private Dictionary<string, IHotDrinkFactory> namedFactories =
          new Dictionary<string, IHotDrinkFactory>();

        public HotDrinkFactory()
        {
            foreach (var type in typeof(HotDrinkFactory).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
                {
                    var hotDrink = type.Name.Replace("Factory", string.Empty);

                    namedFactories.Add(
                      hotDrink, 
                      (IHotDrinkFactory)Activator.CreateInstance(type)
                    );

                    HotDrinks.Add(hotDrink);
                }
            }
        }

        public IHotDrink MakeDrink(string HotDrink, int amount)
        {
            if (HotDrinks.Find(x => x == HotDrink) == null)
                throw new Exception();

            return namedFactories[HotDrink].Prepare(amount);            
        }
    }
}
