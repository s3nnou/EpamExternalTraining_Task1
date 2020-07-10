namespace FiguresClassLibrary
{
    public class Rectangle : Figure
    {
        private int _a;
        private int _b;
        private int _c;
        private int _d;



        public int A { get => A; set => A = value; }
        public int B { get => B; set => B = value; }
        public int C { get => C; set => C = value; }
        public int D { get => D; set => D = value; }

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
