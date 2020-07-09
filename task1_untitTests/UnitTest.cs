using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using epam_task_1;

namespace task1_untitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGDCWith2PositiveValues()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGDCWith2NegativeValues()
        {
            //arrange
            int valueA = -5;
            int valueB = -155;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith2ZeroValues()
        {
            //arrange
            int valueA = 0;
            int valueB = 0;
            int expectedResult = 0;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }
    }
}
