namespace Builder
{
    using System;
    using Builder.Car;
    using Builder.Html;
    using Builder.Human;
    using Builder.MetaHuman;

    class Program
    {
        static void Main(string[] args)
        {
            //Demo.RunHtmlBuilder();

            //Demo.RunPersonBuilder();

            //Demo.RunCarBuilder();

            //Demo.RunHumanBuilder();

            Demo.RunMetaHumanBuilder();
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

        public static void RunHumanBuilder()
        {
            // Functional
            var human = new HumanBuilder()
                .Called("Josemi")
                .WorksAs("Dev")
                .Build();

            Console.WriteLine(human.ToString());
        }

        public static void RunMetaHumanBuilder()
        {
            // Faceted builder
            MetaHuman.MetaHuman metaHuman = new MetaHumanBuilder()
                .Human.Called("Josemi")
                      .Live("Somewhere")
                .Power.HasPower("Fire")
                      .HasEnergy(123);

            Console.WriteLine(metaHuman.ToString());
        }
    }
}
