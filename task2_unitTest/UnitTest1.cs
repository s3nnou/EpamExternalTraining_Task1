using System;
using FiguresClassLibrary;
using FileExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task2_unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FileReader reader = new FileReader();

            Figure[] figures = reader.ReadFile();
        }


    }
}
