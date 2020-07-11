using FiguresClassLibrary;
using System;

namespace ParsersLibrary
{
    /// <summary>
    /// Data parsers; Used by different figures to initialize themselfs
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// parses given array of data as a tringle
        /// </summary>
        /// <param name="dataToHandle"></param>
        /// <returns>new triangle</returns>
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

        /// <summary>
        /// parses given array of data as a  circle
        /// </summary>
        /// <param name="dataToHandle"></param>
        /// <returns>new circle</returns>
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

        /// <summary>
        /// parses given array of data as a rectangle
        /// </summary>
        /// <param name="dataToHandle"></param>
        /// <returns></returns>
        public Rectangle ParseAsRectangle(string[] dataToHandle)
        {
            if (dataToHandle.Length == 5)
            {
                return new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]));
            }
            else
            {
                return new Rectangle(int.Parse(dataToHandle[1]), int.Parse(dataToHandle[2]), int.Parse(dataToHandle[3]), int.Parse(dataToHandle[4]),
                    int.Parse(dataToHandle[5]), int.Parse(dataToHandle[6]), int.Parse(dataToHandle[7]), int.Parse(dataToHandle[8]));
            }
        }

    }
}
