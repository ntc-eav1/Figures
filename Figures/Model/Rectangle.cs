using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Rectangle : Parallelogram
    {
        private static string rectangleName = "прямоугольник";

        public Rectangle() : base()
        {
            _name = rectangleName;
        }

        public Rectangle(double firstSide, double secondSide) : base(firstSide, secondSide)
        {
            _name = rectangleName;
        }

        public override double GetSquare()
        {
            return _firstSide * _secondSide;
        }
    }
}
