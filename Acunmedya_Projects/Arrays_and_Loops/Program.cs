using System;
using System.Reflection.Metadata;

namespace Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int[] numbers = new int[length];
           

            for (int ary = 0; ary < length; ary++)
            {
                Console.Write($"{ary+1}. sayıyı giriniz: ");
                numbers[ary] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            double result = (double)total / numbers.Length;
            Console.WriteLine($"Your entered the numbers is avarage : {result}");


        }
    }
}