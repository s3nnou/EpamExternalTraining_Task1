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

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationBySides2()
        {
            double r = 0;
            Circle circle = new Circle(r);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationBySides3()
        {
            double r = -300;
            Circle circle = new Circle(r);
        }

        [TestMethod]
        public void CircleCreationBySides1()
        {
            double r = 1;

            double rExpected = 1;

            Circle circleToTest = new Circle(r);

            Circle circleToExcept = new Circle(rExpected);

            Assert.AreEqual(circleToExcept, circleToTest);
        }

        [TestMethod]
        public void CircleCreationBySides2()
        {
            double r = 5;

            double rExpected = 5;

            Circle circleToTest = new Circle(r);

            Circle circleToExcept = new Circle(rExpected);

            Assert.AreEqual(circleToExcept, circleToTest);
        }

        [TestMethod]
        public void CircleCreationBySides3()
        {
            double r = 2000;

            double rExpected = 2000;

            Circle circleToTest = new Circle(r);

            Circle circleToExcept = new Circle(rExpected);

            Assert.AreEqual(circleToExcept, circleToTest);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationByCoords1()
        {
            double x1 = 0;
            double y1 = 0;

            double x2 = 0;
            double y2 = 0;
            Circle circle = new Circle(x1,y1,x2,y2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationByCoords2()
        {
            double x1 = 1;
            double y1 = 1;

            double x2 = 1;
            double y2 = 1;
            Circle circle = new Circle(x1, y1, x2, y2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongCircleCreationByCoords3()
        {
            double x1 = -110;
            double y1 = -110;

            double x2 = -110;
            double y2 = -110;
            Circle circle = new Circle(x1, y1, x2, y2);
        }

        [TestMethod]
         public void CircleCreationByCoords1()
        {
            double t_x1 = 1;
            double t_y1 = 1;

            double t_x2 = -1;
            double t_y2 = -1;

            double ex_x1 = 1;
            double ex_y1 = 1;

            double ex_x2 = -1;
            double ex_y2 = -1;

            Circle circleToTest = new Circle(t_x1, t_y1, t_x2, t_y2);

            Circle circleToExcept = new Circle(ex_x1, ex_y1, ex_x2, ex_y2);

            Assert.AreEqual(circleToExcept, circleToTest);
        }

        [TestMethod]
        public void CircleCreationByCoords2()
        {
            double t_x1 = -5;
            double t_y1 = 1;

            double t_x2 = 4;
            double t_y2 = 4;

            double ex_x1 = -5;
            double ex_y1 = 1;

            double ex_x2 = 4;
            double ex_y2 = 4;

            Circle circleToTest = new Circle(t_x1, t_y1, t_x2, t_y2);

            Circle circleToExcept = new Circle(ex_x1, ex_y1, ex_x2, ex_y2);

            Assert.AreEqual(circleToExcept, circleToTest);
        }

        [TestMethod]
        public void CircleCreationByCoords3()
        {
            double t_x1 = -1;
            double t_y1 = 0;

            double t_x2 = 5;
            double t_y2 = 5;

            double ex_x1 = -1;
            double ex_y1 = 0;

            double ex_x2 = 5;
            double ex_y2 = 5;

            Circle circleToTest = new Circle(t_x1, t_y1, t_x2, t_y2);

            Circle circleToExcept = new Circle(ex_x1, ex_y1, ex_x2, ex_y2);

            Assert.AreEqual(circleToExcept, circleToTest);
        }
    }
}
