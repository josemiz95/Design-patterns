using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo.RunProtectionProxy();
            Demo.RunPropertyProxy();
        }
    }

    class Demo
    {
        public static void RunProtectionProxy()
        {
            ICar car = new CarProxy(new Driver(12));
            car.Drive();

            ICar car2 = new CarProxy(new Driver(20));
            car2.Drive();
        }

        public static void RunPropertyProxy()
        {
            var c = new Creature();
            c.Agility = 10;
            c.Agility = 10;
        }
    }
}
