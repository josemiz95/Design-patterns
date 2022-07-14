namespace Factories.Points
{ 
    public class Point
    {
        public double x, y;

        internal Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => $"x: {x}, y: {y}";
    }
}
