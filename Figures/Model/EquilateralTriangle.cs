using System;

namespace ConsoleApp1.Model
{
    class EquilateralTriangle : Triangle
    {
        double _side;
        
        public EquilateralTriangle(double side)
        {
            _name = "равносторонний треугольник";
            _side = side;
        }

        public override string GetInfo()
        {
            return String.Concat(_name, " со стороной ", _side);
        }

        public override double GetPerimeter()
        {
            return _side * 3;
        }

        public override double GetSquare()
        {
            return Math.Pow(_side, 2) * Math.Sqrt(3) / 4;
        }
    }
}
