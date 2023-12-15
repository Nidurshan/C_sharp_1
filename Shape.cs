using C_sharp_1.Practice_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1
{
    public abstract class Shape
    {
        public int d1, d2;

        public Shape()
        {
        }

        public Shape(int d1, int d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public override string ToString()
        {
            return "D1: " + d1 + "\t" + "D2: " + d2;
        }

        abstract public int Area();
    }
}
