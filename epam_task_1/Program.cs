using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EuclidMethods euclid = new EuclidMethods();
            long time = 0;
            int y =
            euclid.GetGDC(-5, -15, out time);
        }
    }
}
