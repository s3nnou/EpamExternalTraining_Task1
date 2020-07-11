using System;

namespace FiguresClassLibrary
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

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

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, A = {1}, B ={2}, C ={3}, Square = {4}, Perimeter = {5}", GetType().ToString(), A, B, C, GetSquare(), GetPerimeter());
        }

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
