using System;

namespace SortableShapes
{
    class Rectangle : Shape
    {
        private double _width { get; set; }
        private double _height { get; set; }

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }
    }
}
