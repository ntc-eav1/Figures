using System;

namespace ConsoleApp1.Model
{
    class IsoscelesIriangle : Triangle
    {
        double _side;
        double _baseSide;

        internal IsoscelesIriangle(double side, double baseSide)
        {
            _name = "равнобедренный треугольник";
            if (Validate(side, baseSide))
            {
                _side = side;
                _baseSide = baseSide;
            }
        }

        bool Validate(double side, double baseSide)
        {
            return side * 2 > baseSide;
        }

        public override string GetInfo()
        {
            return Validate(_side, _baseSide)
                ? String.Concat(_name, " с боковыми сторонами ",
                _side, " и основанием ", _baseSide)
                : GetErrorMessage();
        }

        public override double GetPerimeter()
        {
            return _side * 2 + _baseSide;
        }

        public override double GetSquare()
        {
            double height = Math.Sqrt(Math.Pow(_side, 2) - Math.Pow(_baseSide / 2, 2));
            return _side * height / 2;
        }
    }
}
