using System;

namespace FiguresClassLibrary
{
    public class Circle : Figure
    {
        public int R { get => R; set => R = value; }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
