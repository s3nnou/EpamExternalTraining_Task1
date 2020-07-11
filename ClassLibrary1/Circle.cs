using System;

namespace FiguresClassLibrary
{
    /// <summary>
    /// Child of the Figure class. Represents circle.
    /// </summary>
    public class Circle : Figure
    {
        private double _r;

        /// <summary>
        /// constructor for initializing cirlce class by R
        /// </summary>
        /// <param name="r"></param>
        public Circle(double r)
        {
            if( r > 0)
            {
                _r = r;
            }
            else
            {
                throw new Exception("R cannot be equal to 0");
            }
        }

        /// <summary>
        /// constructor for initializing cirlce class by a center coords and a point on the circle edge
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Circle(double x1, double y1, double x2, double y2)
        {
            if ( x1 != x2 && y1 != y2)
            {
                _r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
            else
            {
                throw new Exception("Wrong coordinats");
            }
        }

        /// <summary>
        /// Radius accessor 
        /// </summary>
        public double R { get => _r; set => _r = value; }

        /// <summary>
        /// Overriden method from the parent class. Calculates P.
        /// </summary>
        /// <returns>P</returns>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        /// <summary>
        /// Overriden method from the parent class. Calculates S.
        /// </summary>
        /// <returns>S</returns>
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        /// <summary>
        /// Generates HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode()
        {
            return R.GetHashCode();
        }

        /// <summary>
        /// Displays data about an object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Type: {0}, R = {1}, Square = {2}, Perimeter = {3}", GetType().ToString(), R, GetSquare(), GetPerimeter());
        }
        /// <summary>
        /// Compares given object and this object for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>if equal - true, else - false</returns>
        public override bool Equals(object obj)
        {
            if(obj is Circle circle)
            {
                return this.R == circle.R;
            }

            return false;
        }
    }
}
