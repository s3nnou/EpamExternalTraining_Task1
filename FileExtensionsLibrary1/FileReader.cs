using FiguresClassLibrary;
using ParsersLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExtensions
{
    public class FileReader
    {
        public Figure[] ReadFile()
        {
            Figure[] figures;
            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\..\epam_task_1\FileExtensionsLibrary1\Data.txt"))
                {
                    int objectsToHandleCount = File.ReadLines(@"..\..\..\..\epam_task_1\FileExtensionsLibrary1\Data.txt").Count();

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
                 
            }

            return null;
        }


    }
}
