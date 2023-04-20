using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTOCLASSI_Rettangolo
{
    internal class Rectangle : Parallelogram
    {
        public Rectangle(double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
        }

        public double Area()
        {
            return Side1 * Side2;
        }
    }
}
