using System;

namespace ConsoleApp1.Model
{
    class Parallelogram : Quadrilateral
    {
        private static string parallelogrammName = "параллелограмм";

        public Parallelogram()
        {
            _name = parallelogrammName;
            _firstSide = 2;
            _secondSide = 1;
        }

        public Parallelogram(double firstSide, double secondSide)
        {
            _name = parallelogrammName;
            _firstSide = firstSide;
            _secondSide = secondSide;
        }

        public override string GetInfo()
        {
            return String.Concat(_name, " со сторонами ",
                _firstSide, ", ", _secondSide);
        }

        public override double GetPerimeter()
        {
            return (_firstSide + _secondSide) * 2;
        }

        public override double GetSquare()
        {
            if (GetType().Equals(typeof(Parallelogram)))
            {
                Console.WriteLine("не задана высота параллелограмма");
            }
            return 0;
        }
    }
}
