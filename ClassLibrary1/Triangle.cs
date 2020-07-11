using System;

namespace FiguresClassLibrary
{
    /// <summary>
    /// Child of the Figure class. Represents Triagnle.
    /// </summary>
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Constructor. Initializes triangle by its sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            if( a + b > c && a + c > b && b + c > a )
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else
            {
                throw new Exception("Triangle cannot exsists with a such sides");
            }
        }

        /// <summary>
        /// Constructor. Initializes triangle by its coords
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            if (a + b > c && a + c > b && b + c > a )
            {
                _a = a;
                _b = b;
                _c = c;
            }
            else
            {
                throw new Exception("Triangle cannot exsists with a such sides");
            }
        }

        /// <summary>
        /// Sides accesors
        /// </summary>
        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }

        /// <summary>
        /// Overriden method from the parent class. Calculates P.
        /// </summary>
        /// <returns>P</returns>
        public override double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Overriden method from the parent class. Calculates S.
        /// </summary>
        /// <returns>S</returns>
        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// Generates HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
        }


        /// <summary>
        /// Displays data about an object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Type: {0}, A = {1}, B ={2}, C ={3}, Square = {4}, Perimeter = {5}", GetType().ToString(), A, B, C, GetSquare(), GetPerimeter());
        }

        /// <summary>
        /// Compares given object and this object for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>if equal - true, else - false</returns
        public override bool Equals(object obj)
        {
            if (obj is Triangle triangle)
            {
                if (this.A == triangle.A && this.B == triangle.B && this.C == triangle.C)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
