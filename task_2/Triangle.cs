using System;

namespace FiguresClassLibrary
{
    public class Triangle : Figure
    {
        public int A { get => A; set => A = value; }
        public int B { get => B; set => B = value; }
        public int C { get => C; set => C = value; }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
