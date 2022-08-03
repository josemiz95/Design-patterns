using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.DrawGraphcObjects();
        }
    }

    internal static class Demo
    {
        public static void DrawGraphcObjects()
        {
            var drawing = new GraphicObject { Name = "Drawing" };
            drawing.Children.Add(new Square { Color = "Red" });
            drawing.Children.Add(new Circle { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(new Square { Color = "Blue" });
            drawing.Children.Add(group);

            Console.WriteLine(drawing);
        }
    }
}
