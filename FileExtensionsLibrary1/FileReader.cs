using FiguresClassLibrary;
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
                using (StreamReader sr = new StreamReader(@"E:\\test.txt"))
                {
                    int objectsToHandleCount = File.ReadLines("test").Count();

                    figures = new Figure[objectsToHandleCount];
                    
                    string line;
                    int index = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] dataToHandle = line.Split();

                        switch (dataToHandle[0])
                        {
                            case "Triangle":
                                if(dataToHandle.Length < 4)
                                {
                                    figures[index] = new Triangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]));
                                }
                                else
                                {
                                    figures[index] = new Triangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), 
                                        int.Parse(dataToHandle[5]), int.Parse(dataToHandle[6]), int.Parse(dataToHandle[7]));
                                }

                                index++;
                                break;

                            case "Circle":
                                if (dataToHandle.Length < 2)
                                {
                                    figures[index] = new Circle(int.Parse(dataToHandle[1]));
                                }
                                else
                                {
                                    figures[index] = new Circle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]));
                                }

                                index++;
                                break;

                            case "Rectnagle":
                                if(dataToHandle.Length < 5)
                                {
                                    figures[index] = new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]));
                                }
                                else
                                {
                                    figures[index] = new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]), 
                                        int.Parse(dataToHandle[5]), int.Parse(dataToHandle[6]), int.Parse(dataToHandle[7]), int.Parse(dataToHandle[8]));
                                }

                                index++;
                                break;
                        }

                        return figures;
                    }
                }
            }
            catch (IOException e)
            {

            }

            return null;
        }


    }
}
