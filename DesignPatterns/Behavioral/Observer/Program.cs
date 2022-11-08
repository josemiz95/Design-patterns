using System;
using Observer.PersonObserver;
using Observer.PersonObserver1;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.EventHandler1Demo();
            Demo.EventHandler2Demo();
        }
    }

    public static class Demo
    {
        public static void EventHandler1Demo()
        {
            Console.WriteLine("DEMO 1");

            HumanObserverBuilder humanBuilder = new HumanObserverBuilder();

            humanBuilder.addEventHandler(EventHandlers.EventHandler1);

            HumanObserver human = humanBuilder.Build();

            human.CatchACold();
            Console.WriteLine("--------------------------------------");
        }

        public static void EventHandler2Demo()
        {
            Console.WriteLine("DEMO 2");
            PersonBuilder personBuilder = new PersonBuilder();

            personBuilder.addEventHandler(new FallsIllEventHandler());

            Person person = personBuilder.Build();

            person.CatchACold();
        }
    }
}
