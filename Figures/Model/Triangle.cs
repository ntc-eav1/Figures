using System;

namespace ConsoleApp1.Model
{
    public class Triangle : FigureBase
    {
        public static string triangleName = "треугольник";

        double _firstSide;
        double _secondSide;
        double _thirdSide;

        internal Triangle()
        {
            _name = triangleName;
            _firstSide = 1;
            _secondSide = 1;
            _thirdSide = 1;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _name = triangleName;
            if (Validate(firstSide, secondSide, thirdSide)) {
                _firstSide = firstSide;
                _secondSide = secondSide;
                _thirdSide = thirdSide;
            }
        }

        public override string GetInfo()
        {
            return Validate(_firstSide, _secondSide, _thirdSide)
                ? String.Concat(_name, " со сторонами ",
                _firstSide, ", ", _secondSide, ", ", _thirdSide)
                : GetErrorMessage();
        }

        public override double GetPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        public override double GetSquare()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * 
                (halfPerimeter - _firstSide) *
                (halfPerimeter - _secondSide) *
                (halfPerimeter - _thirdSide));
        }

        protected string GetErrorMessage()
        {
            return _name + " не существует";
        }

        bool Validate(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide;
        }

    }
}
