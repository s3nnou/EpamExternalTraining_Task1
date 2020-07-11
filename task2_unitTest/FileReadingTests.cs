using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresClassLibrary;
using System.IO;

namespace task2_unitTest
{
     [TestClass]
    public class FileReadingTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void FilePathValidTest()
        {
            string path = @"Dummy.txt";

            FileReader reader = new FileReader();

            Figure[] testArray = reader.ReadFile(path);
        }

        [TestMethod]
        public void PathValidWithInValidDataTest()
        {
            string path = @"..\..\..\..\epam_training_tasks\FileExtensionsLibrary1\Res\Data1.txt";

            FileReader reader = new FileReader();

            Figure[] t_array = reader.ReadFile(path);

        }

        [TestMethod]
        public void PathValidWithValidDataTest()
        {
            string path = @"..\..\..\..\epam_training_tasks\FileExtensionsLibrary1\Res\Data.txt";

            FileReader reader = new FileReader();

            Figure[] t_array = reader.ReadFile(path);

            Figure[] ex_array = { new Triangle(20, 40, 50), new Triangle(0, 0, 4, 5, 0, 1) };

            CollectionAssert.AreEqual(ex_array, t_array);
        }
    }
}
