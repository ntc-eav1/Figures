using System;

namespace ConsoleApp1.Model
{
    class Quadrilateral : FigureBase
    {
        private static string quadrilateralName = "четырёхугольник";

        protected double _firstSide;
        protected double _secondSide;
        double _thirdSide;
        double _fourthSide;

        internal Quadrilateral()
        {
            _name = quadrilateralName;
            _firstSide = 1;
            _secondSide = 2;
            _thirdSide = 3;
            _fourthSide = 4;
        }

        internal Quadrilateral(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            _name = quadrilateralName;
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
            _fourthSide = fourthSide;
        }

        public override string GetInfo()
        {
            return String.Concat(_name, " со сторонами ",
                _firstSide, ", ", _secondSide, ", ", 
                _thirdSide, ", ", _fourthSide);
        }

        public override double GetPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide + _fourthSide;
        }
        
        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
