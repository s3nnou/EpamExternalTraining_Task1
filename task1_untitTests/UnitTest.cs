using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using epam_task_1;

namespace task1_untitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGDCWith2PositiveValues1()
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

        public void TestGDCWith2PositiveValues2()
        {
            //arrange
            int valueA = 542;
            int valueB = 7316;
            int expectedResult = 2;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        public void TestGDCWith2PositiveValues3()
        {
            //arrange
            int valueA = 756214;
            int valueB = 7316;
            int expectedResult = 62;

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

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGDCWith1Negative1PositiveValues()
        {
            //arrange
            int valueA = -5;
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
        public void TestGDCWith2PositiveEqualValues()
        {
            //arrange
            int valueA = 5;
            int valueB = 5;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith3PositiveValues1()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 1455;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith3PositiveValues2()
        {
            //arrange
            int valueA = 42;
            int valueB = 72526;
            int valueC =782412;
            int expectedResult = 2;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith3PositiveValues3()
        {
            //arrange
            int valueA = 1;
            int valueB = 732641351;
            int valueC = 52451;
            int expectedResult = 1;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGDCWith2Positive1NegativeValues()
        {
            //arrange
            int valueA = 5;
            int valueB = -155;
            int valueC = 1455;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith4PositiveValues1()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 1455;
            int valueD = 204520;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith4PositiveValues2()
        {
            //arrange
            int valueA = 5;
            int valueB = 76522;
            int valueC = 1455;
            int valueD = 40;
            int expectedResult = 1;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith4PositiveValues3()
        {
            //arrange
            int valueA = 2;
            int valueB = 4;
            int valueC = 32;
            int valueD = 246;
            int expectedResult = 2;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith4EqualValues()
        {
            //arrange
            int valueA = 4312;
            int valueB = 4312;
            int valueC = 4312;
            int valueD = 4312;
            int expectedResult = 4312;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith2Equal2DifferentValues()
        {
            //arrange
            int valueA = 4312;
            int valueB = 4312;
            int valueC = 541;
            int valueD = 24;
            int expectedResult = 1;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGDCWith3Positive1NegativeValues()
        {
            //arrange
            int valueA = 5;
            int valueB = -155;
            int valueC = 1455;
            int valueD = 204520;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith5PositiveValues1()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int valueC = 1455;
            int valueD = 204520;
            int valueE = 4581200;

            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, valueE, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGDCWith4Positive1NegativeValues()
        {
            //arrange
            int valueA = 5;
            int valueB = -155;
            int valueC = 1455;
            int valueD = 204520;
            int valueE = 4581200;

            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, valueE, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }


        [TestMethod]
        public void TestGDCWith5PositiveValues2()
        {
            //arrange
            int valueA = 4325;
            int valueB = 7625;
            int valueC = 641;
            int valueD = 204520;
            int valueE = 100;

            int expectedResult = 1;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, valueE, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestGDCWith5PositiveValues3()
        {
            //arrange
            int valueA = 4;
            int valueB = 7625;
            int valueC = 64513;
            int valueD = 2732561;
            int valueE = 100;

            int expectedResult = 1;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetGDC(valueA, valueB, valueC, valueD, valueE, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestSteinWith2PositiveValues1()
        {
            //arrange
            int valueA = 5;
            int valueB = 155;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestSteinWith2PositiveValues2()
        {
            //arrange
            int valueA = 542;
            int valueB = 7316;
            int expectedResult = 2;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestSteinWith2PositiveValues3()
        {
            //arrange
            int valueA = 756214;
            int valueB = 7316;
            int expectedResult = 62;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestSteinWith2NegativeValues()
        {
            //arrange
            int valueA = -5;
            int valueB = -155;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestSteinWith2ZeroValues()
        {
            //arrange
            int valueA = 0;
            int valueB = 0;
            int expectedResult = 0;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestSteinWith1Negative1PositiveValues()
        {
            //arrange
            int valueA = -5;
            int valueB = 155;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }

        [TestMethod]
        public void TestSteinWith2PositiveEqualValues()
        {
            //arrange
            int valueA = 5;
            int valueB = 5;
            int expectedResult = 5;

            long time = 0;

            //act
            EuclidMethods euclid = new EuclidMethods();
            int result = euclid.GetStein(valueA, valueB, out time);

            //assert
            Assert.AreEqual(expectedResult, result, 0.001, "Something went wrong");
        }
    }
}
