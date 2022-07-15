using System;
using Prototype.DeepCopyGeneralized;
using Prototype.PersonCopyable;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo.Employee();

            Demo.GeneralDeepCopy();
        }
    }

    public static class Demo
    {
        public static void Employee()
        {
            var josemi = new Employee();
            josemi.Names = new[] { "Josemi", "R" };
            josemi.Address = new Address { HouseNumber = 123, StreetName = "Calle falsa" };
            josemi.Salary = 32000;
            var copy = josemi.DeepCopy();

            copy.Names[1] = "L";
            copy.Address.HouseNumber++;
            copy.Salary = 12000;

            Console.WriteLine(josemi);
            Console.WriteLine(copy);
        }

        public static void GeneralDeepCopy()
        {
            Foo foo = new Foo { Stuff = 42, Whatever = "abc" };

            //Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
            Foo foo2 = foo.DeepCopyXml();

            foo2.Whatever = "xyz";
            Console.WriteLine(foo);
            Console.WriteLine(foo2);
        }
    }
}
