using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.Sigleton1();

            Demo.Sigleton2();
        }
    }

    public static class Demo
    {
        public static void Sigleton1()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }

        public static void Sigleton2()
        {
            var person = new PersonSigleton();
            person.Name = "Josemi";
            person.Age = 27;

            var person2 = new PersonSigleton();
            Console.WriteLine(person2);
        }
    }
}
