using System;
using System.Collections.Generic;
using Adapter.PolygonDemo;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.PolygonAdapter();
        }
    }

    internal static class Demo
    {
        public static void PolygonAdapter()
        {
            List<Polygon> Polygons = new List<Polygon>
            { 
                new Rectangle(1,1,10,10),
                new Rectangle(3,3,6,6)
            };

            DrawLinesOfPolygons(Polygons);
        }

        private static void DrawLinesOfPolygons(List<Polygon> polygons)
        {
            foreach (var vo in polygons)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                }
            }
        }
    }
}
