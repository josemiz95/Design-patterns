namespace Builder
{
    using System;
    using Builder.Car;
    using Builder.Html;

    class Program
    {
        static void Main(string[] args)
        {
            //Demo.RunHtmlBuilder();

            //Demo.RunPersonBuilder();

            Demo.RunCarBuilder();
        }

        
    }

    class Demo
    {
        public static void RunHtmlBuilder()
        {
            var builder = new HtmlBuilder("ul");

            builder.AddChild("li", "Name 1")
                   .AddChild("li", "Name 2")
                   .AddChild("li", "Name 3");

            Console.WriteLine(builder.ToString());
        }

        public static void RunPersonBuilder()
        {
            // Builder with inheritance
            var me = Person.Person.New
                    .Called("Josemi")
                    .WorksAsA("Developer")
                    .Build();

            Console.WriteLine(me.ToString());
        }

        public static void RunCarBuilder()
        {
            // Builder created step by step
            var car = Carbuilder.New
                                .OfType(CarType.Crossover)
                                .WithWheels(17)
                                .Build();

            Console.WriteLine(car.ToString());
        }
    }
}
