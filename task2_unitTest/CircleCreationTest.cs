using FiguresClassLibrary;
using FileExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace task2_unitTest
{
    [TestClass]
    public class CircleCreationTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationBySides1()
        {
            double r = -1;
            Circle circle = new Circle(r);
        }
    }
}
