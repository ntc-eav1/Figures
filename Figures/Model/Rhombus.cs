using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    class Rhombus : Parallelogram
    {
        private static string rhombusName = "ромб";

        public Rhombus()
        {
            _name = rhombusName;
            _firstSide = 1;
        }

        public Rhombus(double side)
        {
            _name = rhombusName;
            _firstSide = side;
        }

        public override string GetInfo()
        {
            return String.Concat(_name, " со стороной ", _firstSide);
        }

        public override double GetPerimeter()
        {
            return _firstSide * 4;
        }

        public override double GetSquare()
        {
            if (GetType().Equals(typeof(Rhombus))) {
                Console.WriteLine("не заданы диагонали ромба");
                }
            return base.GetSquare();
        }
    }
}
