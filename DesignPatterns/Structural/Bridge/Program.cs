using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var pixel = new PixelRenderer();

            var pixelCircle = new Circle(pixel, 5);
            pixelCircle.Draw();
            pixelCircle.Resize(2);
            pixelCircle.Draw();

            var vector = new VectorRenderer();
            var vectorCircle = new Circle(vector, 5);
            vectorCircle.Draw();
            vectorCircle.Resize(2);
            vectorCircle.Draw();
        }
    }
}
