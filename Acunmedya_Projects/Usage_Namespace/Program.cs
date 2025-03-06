using System;
using System.Numerics;
using Calculate_ns;

namespace Usage_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate add = new Calculate();
            int result1 = add.Add(5, 2);

            Calculate product = new Calculate();
            int result2 = product.Product(4, 2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}

namespace Calculate_ns
{
    class Calculate
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Product(int number1, int number2)
        {
            return number1 * number2;
        }

    }
}
 