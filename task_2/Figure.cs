using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public abstract class Figure
    {
        public abstract int GetPerimeter();
        public abstract int GetSquare();
    }

    public class Square: Figure
    {
        public int A { get => A; set => A = value; }
        public int B { get => B; set => B = value; }
        public int C { get => C; set => C = value; }
        public int D { get => D; set => D = value; }

        public override int GetPerimeter()
        {
            return a * 4;
        }


    }
}
