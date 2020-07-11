using System;

namespace FiguresClassLibrary
{
    /// <summary>
    /// Child of the Figure class. Represents Rectangle.
    /// </summary>
    public class Rectangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;

        /// <summary>
        /// Constructor. Initializes rectangle by its sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public Rectangle(double a, double b, double c, double d)
        {
            if(a + b + c > d && b + c + d > a && a + d + c > b && a + b + d > c && a > 0 && b > 0 && c>0 && d>0)
            {
                _a = a;
                _b = b;
                _c = c;
                _d = d;
            }
            else
            {
                throw new Exception("Invalid rectagle sides");
            }
        }

        /// <summary>
        /// Constructor. Initializes rectangle by its coords.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="x4"></param>
        /// <param name="y4"></param>
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            double d = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));

            if (a + b + c > d && b + c + d > a && a + d + c > b && a + b + d > c && a > 0 && b > 0 && c > 0 && d > 0)
            {
                _a = a;
                _b = b;
                _c = c;
                _d = d;
            }
            else
            {
                throw new Exception("Invalid rectagle sides");
            }
        }

        /// <summary>
        /// Sides accesors
        /// </summary>
        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }
        public double D { get => _d; set => _d = value; }

        /// <summary>
        /// Overriden method from the parent class. Calculates P.
        /// </summary>
        /// <returns>P</returns>
        public override double GetPerimeter()
        {
            return (A + B) * 2;
        }

        /// <summary>
        /// Overriden method from the parent class. Calculates S.
        /// </summary>
        /// <returns>S</returns>
        public override double GetSquare()
        {
            return A * B;
        }

        /// <summary>
        /// Generates HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode();
        }

        /// <summary>
        /// Displays data about an object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Type: {0}, A = {1}, B ={2}, C ={3}, D ={4}, Square = {5}, Perimeter = {6}", GetType().ToString(), A, B, C, D, GetSquare(), GetPerimeter());
        }

        /// <summary>
        /// Compares given object and this object for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>if equal - true, else - false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Rectangle rectangle)
            {
                if (this.A == rectangle.A && this.B == rectangle.B && this.C == rectangle.C && this.D == rectangle.D)
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
