using ConsoleApp1.Model;
using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FigureBase> figureList = new List<FigureBase>();
            figureList.Add(new Triangle());
            figureList.Add(new IsoscelesIriangle(1, 2));
            figureList.Add(new EquilateralTriangle(1));
            figureList.Add(new Quadrilateral());
            figureList.Add(new Parallelogram());
            figureList.Add(new Rectangle());
            figureList.Add(new Rhombus());
            figureList.Add(new Square());

            foreach (FigureBase figure in figureList)
            {
                Console.WriteLine(figure.GetInfo());
                Console.WriteLine("Периметр фигуры: " + figure.GetPerimeter());
                Console.WriteLine("Площадь фигуры: " + figure.GetSquare());
            }

            /*
            Triangle triangle = new Triangle(1, 2, 3);
            Console.WriteLine(triangle.GetInfo());
            Console.WriteLine("Периметр фигуры: " + triangle.GetPerimeter());
            Console.WriteLine("Площадь фигуры: " + triangle.GetSquare());
            IsoscelesIriangle isoscelesIriangle = new IsoscelesIriangle(1, 3);
            Console.WriteLine(isoscelesIriangle.GetInfo());
            Console.WriteLine("Периметр фигуры: " + isoscelesIriangle.GetPerimeter());
            Console.WriteLine("Площадь фигуры: " + isoscelesIriangle.GetSquare());
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(3);
            Console.WriteLine(equilateralTriangle.GetInfo());
            Console.WriteLine("Периметр фигуры: " + equilateralTriangle.GetPerimeter());
            Console.WriteLine("Площадь фигуры: " + equilateralTriangle.GetSquare());
            Quadrilateral quadrilateral = new Quadrilateral();
            Console.WriteLine(quadrilateral.GetInfo());
            Console.WriteLine("Периметр фигуры: " + quadrilateral.GetPerimeter());
            */
            /*try
            {
                Console.WriteLine("Площадь фигуры: " + quadrilateral.GetSquare());
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("невозможно вычислить площадь фигуры");
            }

            Parallelogram parallelogram = new Parallelogram();
            Console.WriteLine(parallelogram.GetInfo());
            Console.WriteLine("Периметр фигуры: " + parallelogram.GetPerimeter());
            try
            {
                Console.WriteLine("Площадь фигуры: " + parallelogram.GetSquare());
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("невозможно вычислить площадь фигуры");
            }

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.GetInfo());
            Console.WriteLine("Периметр фигуры: " + rectangle.GetPerimeter());
            Console.WriteLine("Площадь фигуры: " + rectangle.GetSquare());
            
            Rhombus rhombus = new Rhombus();
            Console.WriteLine(rhombus.GetInfo());
            Console.WriteLine("Периметр фигуры: " + rhombus.GetPerimeter());
            double rhombusSquare = rhombus.GetSquare();
            Console.WriteLine("Площадь фигуры: " + rhombus.GetSquare());

            Square square = new Square(2);
            Console.WriteLine(square.GetInfo());
            Console.WriteLine("Периметр фигуры: " + square.GetPerimeter());
            Console.WriteLine("Площадь фигуры: " + square.GetSquare());
            */
            Console.ReadKey();
        }
    }
}
