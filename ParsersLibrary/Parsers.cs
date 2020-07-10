using FiguresClassLibrary;
using System;

namespace ParsersLibrary
{
    public class Parser
    {
        public Triangle ParseAsTriangle(string[] dataToHandle)
        {
            if (dataToHandle.Length == 4)
            {
                return new Triangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]));
            }
            else
            {
                return  new Triangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]),
                    int.Parse(dataToHandle[4]), int.Parse(dataToHandle[5]), int.Parse(dataToHandle[6]));
            }
        }

        public Circle ParseAsCircle(string[] dataToHandle)
        {
            if (dataToHandle.Length == 2)
            {
                return new Circle(int.Parse(dataToHandle[1]));
            }
            else
            {
                return new Circle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]));
            }
        }

        public Rectangle ParseAsRectangle(string[] dataToHandle)
        {
            if (dataToHandle.Length == 5)
            {
                return new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]));
            }
            else
            {
                return new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]),
                    int.Parse(dataToHandle[5]), int.Parse(dataToHandle[5]), int.Parse(dataToHandle[6]), int.Parse(dataToHandle[7]));
            }
        }

    }
}
