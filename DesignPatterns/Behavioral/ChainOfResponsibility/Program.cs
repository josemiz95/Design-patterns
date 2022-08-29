using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.EatFood();
        }
    }

    class Demo
    {
        public static void EatFood()
        {
            // Handler
            var handler = new Handler();
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            handler.SetNext(monkey).SetNext(squirrel).SetNext(dog);

            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                Console.Write($"...{result}");
            }
        }
    }
}
