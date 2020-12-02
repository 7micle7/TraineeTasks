using System;

namespace SortableShapes
{
    class Circle : Shape
    {
        private double _radius { get; set; }

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area()
        {
            return _radius * _radius * System.Math.PI;
        }
    }

}
