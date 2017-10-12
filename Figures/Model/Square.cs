using System;

namespace ConsoleApp1.Model
{
    class Square : Rhombus
    {
        public static string squareName = "квадрат";

        public Square()
        {
            _name = squareName;
        }

        public Square(double side) : base(side)
        {
            _name = squareName;
        }

        public override double GetSquare()
        {
            return Math.Pow(_firstSide, 2);
        }
    }
}
