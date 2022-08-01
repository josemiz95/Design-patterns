namespace Adapter.PolygonDemo
{
    using System;
    using System.Collections.ObjectModel;

    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            if (start == null || end == null)
                throw new ArgumentNullException();

            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"[{Start.X},{Start.Y}]-[{End.X},{End.Y}]";
        }
    }

    public class Polygon : Collection<Line>
    {
    }

    public class Rectangle : Polygon
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Add(new Line(new Point(x, y), new Point(x + width, y)));
            Add(new Line(new Point(x + width, y), new Point(x + width, y + height)));
            Add(new Line(new Point(x, y), new Point(x, y + height)));
            Add(new Line(new Point(x, y + height), new Point(x + width, y + height)));
        }
    }
}
