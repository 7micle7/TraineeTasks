using System;

namespace SortableShapes
{
    class Square : Shape
    {
        private double _side { get; set; }

        public Square(double side)
        {
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }
    }
}
