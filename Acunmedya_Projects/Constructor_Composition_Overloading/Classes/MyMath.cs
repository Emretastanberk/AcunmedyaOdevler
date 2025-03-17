using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Composition_Overloading.Classes
{
    public class MyMath
    {
        public double Product(double x, double y)
        {
            return x * y;
        }

        public int Product(int x, int y, int z)
        {
            return x * y * z;
        }

        public double Add(double x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z ;
        }
    }
}
