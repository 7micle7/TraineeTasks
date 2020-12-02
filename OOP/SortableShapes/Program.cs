using System;
using System.Collections.Generic;
using System.Linq;

namespace SortableShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var Base = 5D;
            var height = 2D;
            var width = 4D;
            var shapes = new List<Shape>{
                new Square(side),
                new Circle(radius),
                new Rectangle(width, height),
                new Triangle(Base, height)
            };

            Console.WriteLine("Initial collection order:");

            shapes.ForEach(sh => Console.WriteLine($"{sh} {sh.Area()}"));

            Console.WriteLine("\nSorted collection order:");

            List<Shape> sortedCollection = shapes.OrderBy(x => x.Area()).ToList();
            sortedCollection.ForEach(s => Console.WriteLine($"{s} {s.Area()}"));
        }
    }
}
