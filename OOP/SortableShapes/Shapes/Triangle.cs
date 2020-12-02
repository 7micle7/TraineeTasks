using System;

namespace SortableShapes
{
    class Triangle : Shape
    {
        private double _base { get; set; }
        private double _side { get; set; }

        public Triangle(double Base, double side)
        {
            _base = Base;
            _side = side;
        }

        public override double Area()
        {
            return (_base * _side) / 2;
        }
    }
}
