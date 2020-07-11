using FiguresClassLibrary;
using ParsersLibrary;
using System;
using System.IO;
using System.Linq;

namespace FileExtensions
{
    public class FileReader
    {
        public Figure[] ReadFile()
        {
            Figure[] figures;

            FileInfo fileInfo = new FileInfo(@"..\..\..\..\epam_training_tasks\FileExtensionsLibrary1\Res\Data.txt");
            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\..\epam_training_tasks\FileExtensionsLibrary1\Res\Data.txt"))
                {
                    int objectsToHandleCount = File.ReadLines(@"..\..\..\..\epam_training_tasks\FileExtensionsLibrary1\Res\Data.txt").Count();

                    figures = new Figure[objectsToHandleCount];
                    Parser parser = new Parser();

                    string line;
                    int index = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] dataToHandle = line.Split();

                        switch (dataToHandle[0])
                        {
                            case "Triangle":

                                figures[index] = parser.ParseAsTriangle(dataToHandle);
                                index++;
                                break;

                            case "Circle":

                                figures[index] = parser.ParseAsCircle(dataToHandle);
                                index++;
                                break;

                            case "Rectnagle":

                                figures[index] = parser.ParseAsRectangle(dataToHandle);
                                index++;
                                break;
                        }      
                    }

                    return figures;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error. Message = {0}",e.Message);
            }

            return null;
        }


    }
}
