using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public abstract class Figure
    {
        public abstract double GetPerimeter();
        public abstract double GetSquare();
    }

    public class Rectangle : Figure
    {
        public int A { get => A; set => A = value; }
        public int B { get => B; set => B = value; }
        public int C { get => C; set => C = value; }
        public int D { get => D; set => D = value; }

        public override double GetPerimeter()
        {
            return (A + B) * 2 ;
        }

        public override double GetSquare()
        {
            return A * B;
        }
    }

    public class Triangle : Figure
    {
        public int A { get => A; set => A = value; }
        public int B { get => B; set => B = value; }
        public int C { get => C; set => C = value; }

        public override double GetPerimeter()
        {
            return A * 4;
        }

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }  

    public class Circle: Figure
    {
        public int R { get => R; set => R = value; }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public override double GetSquare()
        {
            return Math.PI *Math.Pow( R, 2);
        }
    }
}
