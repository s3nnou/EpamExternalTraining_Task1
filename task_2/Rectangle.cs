using System;

namespace FiguresClassLibrary
{
    public class Rectangle : Figure
    {
        private int _a;
        private int _b;
        private int _c;
        private int _d;

        public Rectangle(int a, int b, int c, int d)
        {

        }

        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            _a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);

        }


        public int A { get => _a; set => _a = value; }
        public int B { get => _b; set => _b = value; }
        public int C { get => _c; set => _c = value; }
        public int D { get => _d; set => _d = value; }

        public override double GetPerimeter()
        {
            return (A + B) * 2;
        }

        public override double GetSquare()
        {
            return A * B;
        }
    }
}
