using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.Points
{
    public class PointFactory
    {
        public static Point NewCartesian(double x, double y) => new Point(x, y);

        public static Point NewPolar(double d, double r)
        {
            var x = d * Math.Sin(r);
            var y = r * Math.Cos(d);

            return new Point(x, y);
        }
    }
}
