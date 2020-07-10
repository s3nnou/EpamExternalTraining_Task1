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
            try
            {
                using (StreamReader sr = new StreamReader("test.txt"))
                {
                    int objectsToHandleCount = File.ReadLines("test").Count();

                    Figure[] figures = new Figure[objectsToHandleCount];
                    
                    string line;
                    int index = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] dataToHandle = line.Split();

                        switch (dataToHandle[0])
                        {
                            case "Triangle":
                                figures[index] = new Triangle();
                                index++;
                                break;
                            case "Circle":
                                figures[index] = new Triangle();
                                index++;
                                break;
                            case "Rectnagle":
                                figures[index] = new Triangle();
                                index++;
                                break;
                        }
                    }
                }
            }
            catch (IOException e)
            {

            }
        }

        
    }
}
