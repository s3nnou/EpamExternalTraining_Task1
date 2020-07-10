using System;

namespace FiguresClassLibrary
{
    public class Rectangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;

        public Rectangle(double a, double b, double c, double d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            _a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            _b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            _c = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            _d = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));         
        }


        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }
        public double D { get => _d; set => _d = value; }

        public override double GetPerimeter()
        {
            return (A + B) * 2;
        }

        public override double GetSquare()
        {
            return A * B;
        }

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, A = {1}, B ={2}, C ={3}, D ={4}, Square = {5}, Perimeter = {6}", GetType().ToString(), A, B, C, D, GetSquare(), GetPerimeter());
        }

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
