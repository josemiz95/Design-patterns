using System;
using Facade.systems;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //This can be injected
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            systems.Facade facade = new systems.Facade(subsystem1, subsystem2);


            Demo.RunOperations(facade);
            Demo.RunCalculate(facade);
        }
    }

    class Demo
    {
        public static void RunOperations(systems.Facade facade)
        {
            Console.Write(facade.Operation());
        }
        public static void RunCalculate(systems.Facade facade)
        {
            Console.Write(facade.Calculate());
        }
    }
}
