﻿using FiguresClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_unitTest
{
    
        [TestClass]
        public class RectangleCreationTests
        {
            [TestMethod]
            [ExpectedException(typeof(Exception))]
            public void WrongRectangleCreationBySides1()
            {
                double A = 0;
                double B = 2;
                double C = 3;
                double D = 4;

                Rectangle triangle = new Rectangle(A, B, C, D);
            }

            public void WrongRectangleCreationBySides2()
            {
                double A = 1;
                double B = 2;
                double C = -10;
                double D = 4;

                Rectangle triangle = new Rectangle(A, B, C, D);
            }

            public void WrongRectangleCreationBySides3()
            {
                double A = -5;
                double B = -5;
                double C = -1;
                double D = -4;

                Rectangle triangle = new Rectangle(A, B, C, D);
            }

        [TestMethod]
        public void RectangleCreationBySides1()
        {
            double t_A = 10;
            double t_B = 20;
            double t_C = 10;
            double t_D = 20;

            double ex_A = 10;
            double ex_B = 20;
            double ex_C = 10;
            double ex_D = 20;

            Rectangle triangleToTest = new Rectangle(t_A, t_B, t_C, t_D);

            Rectangle triangleToExcept = new Rectangle(ex_A, ex_B, ex_C, ex_D);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        [TestMethod]
        public void RectangleCreationBySides2()
        {
            double t_A = 4;
            double t_B = 4;
            double t_C = 4;
            double t_D = 4;

            double ex_A = 4;
            double ex_B = 4;
            double ex_C = 4;
            double ex_D = 4;

            Rectangle triangleToTest = new Rectangle(t_A, t_B, t_C, t_D);

            Rectangle triangleToExcept = new Rectangle(ex_A, ex_B, ex_C, ex_D);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        [TestMethod]
        public void RectangleCreationBySides3()
        {
            double t_A = 100;
            double t_B = 50;
            double t_C = 100;
            double t_D = 50;

            double ex_A = 100;
            double ex_B = 50;
            double ex_C = 100;
            double ex_D = 50;

            Rectangle triangleToTest = new Rectangle(t_A, t_B, t_C, t_D);

            Rectangle triangleToExcept = new Rectangle(ex_A, ex_B, ex_C, ex_D);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongRectangleCreationByCoords1()
        {
            double t_x1 = 100;
            double t_y1 = 50;
            double t_x2 = 100;
            double t_y2 = 50;
            double t_x3 = 100;
            double t_y3 = 50;
            double t_x4 = 100;
            double t_y4 = 50;


            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongRectangleCreationByCoords2()
        {
            double t_x1 = 1;
            double t_y1 = 1;
            double t_x2 = 1;
            double t_y2 = 1;
            double t_x3 = 1;
            double t_y3 = 1;
            double t_x4 = 1;
            double t_y4 = 1;


            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WrongRectangleCreationByCoords3()
        {
            double t_x1 = -100;
            double t_y1 = -50;
            double t_x2 = -100;
            double t_y2 = -50;
            double t_x3 = -100;
            double t_y3 = -50;
            double t_x4 = -100;
            double t_y4 = -50;


            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);
        }

        [TestMethod]
        public void RectangleCreationByCoords1()
        {
            double t_x1 = 0;
            double t_y1 = 0;
            double t_x2 = 0;
            double t_y2 = 20;
            double t_x3 = 10;
            double t_y3 = 10;
            double t_x4 = 10;
            double t_y4 = 0;

            double ex_x1 = 0;
            double ex_y1 = 0;
            double ex_x2 = 0;
            double ex_y2 = 20;
            double ex_x3 = 10;
            double ex_y3 = 10;
            double ex_x4 = 10;
            double ex_y4 = 0;

            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);

            Rectangle triangleToExcept = new Rectangle(ex_x1, ex_y1, ex_x2, ex_y2, ex_x3, ex_y3, ex_x4, ex_y4);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        [TestMethod]
        public void RectangleCreationByCoords2()
        {
            double t_x1 = 0;
            double t_y1 = 0;
            double t_x2 = 0;
            double t_y2 = 20;
            double t_x3 = -10;
            double t_y3 = 10;
            double t_x4 = -10;
            double t_y4 = 0;

            double ex_x1 = 0;
            double ex_y1 = 0;
            double ex_x2 = 0;
            double ex_y2 = 20;
            double ex_x3 = -10;
            double ex_y3 = 10;
            double ex_x4 =- 10;
            double ex_y4 = 0;

            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);

            Rectangle triangleToExcept = new Rectangle(ex_x1, ex_y1, ex_x2, ex_y2, ex_x3, ex_y3, ex_x4, ex_y4);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }

        [TestMethod]
        public void RectangleCreationByCoords3()
        {
            double t_x1 = 1;
            double t_y1 = 1;
            double t_x2 = 1;
            double t_y2 = 2;
            double t_x3 = 2;
            double t_y3 = 2;
            double t_x4 = 2;
            double t_y4 = 1;

            double ex_x1 = 1;
            double ex_y1 = 1;
            double ex_x2 = 1;
            double ex_y2 = 2;
            double ex_x3 = 2;
            double ex_y3 = 2;
            double ex_x4 = 2;
            double ex_y4 = 1;

            Rectangle triangleToTest = new Rectangle(t_x1, t_y1, t_x2, t_y2, t_x3, t_y3, t_x4, t_y4);

            Rectangle triangleToExcept = new Rectangle(ex_x1, ex_y1, ex_x2, ex_y2, ex_x3, ex_y3, ex_x4, ex_y4);

            Assert.AreEqual(triangleToExcept, triangleToTest);
        }
    }
}
