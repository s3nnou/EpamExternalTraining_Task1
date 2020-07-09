using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using epam_task_1;

namespace task1_untitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGDCWith2Values()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int expectedResult = 5;

            DateTime startTime = DateTime.Now;
            DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
           // int result = euclid.GetGDC(valueA, valueB, out endTime);

            //assert
           // Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith3Values()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 20;

            int expectedResult = 5;

            DateTime startTime = DateTime.Now;
            DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
            //int result = euclid.GetGDC(valueA, valueB, valueC, out endTime);

            //assert
            //Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith4Values()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 20;
            int valueD = 1540;

            int expectedResult = 5;

            DateTime startTime = DateTime.Now;
            DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
           // int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out endTime);

            //assert
            //Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith5Values()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 20;
            int valueD = 1540;
            int valueE = 205875;

            int expectedResult = 5;

            DateTime startTime = DateTime.Now;
            DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
           // int result = euclid.GetGDC(valueA, valueB, valueC, valueD, valueE, out endTime);

            //assert
           // Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestStein()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            

            int expectedResult = 5;

            DateTime startTime = DateTime.Now;
            DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
            //int result = euclid.GetStein(valueA, valueB, out endTime);

            //assert
            //Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGetDataTimeCalculatuions()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;

            int expectedResult = 2;

            DateTime startTime = DateTime.Now;
           // DateTime endTime = new DateTime();

            //act
            EuclidMethods euclid = new EuclidMethods();
            //int result = euclid.GetDataTimeCalculatuions(valueA, valueB).Count;

            //assert
            //Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }
    }
}
