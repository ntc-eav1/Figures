using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1.Model;

namespace FiguresTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestGetPerimetr()
        {
            Triangle triangle = new Triangle(2, 3, 3.606);
            Assert.AreEqual(3, triangle.GetPerimeter());
        }
        [TestMethod]
        public void TestGetSquare()
        {
        Triangle triangle = new Triangle(1, 2, 3);
            Assert.AreEqual(3, triangle.GetSquare());
        }
    }
}
