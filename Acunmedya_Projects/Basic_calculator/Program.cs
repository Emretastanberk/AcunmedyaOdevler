using System;

namespace Basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result=0;
            Console.WriteLine("Birinci tam sayı giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci tam sayı giriniz:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemin operatörünü tuşlayınız (+,-,*,/)");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine(result); 
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Hatalı işlem");
                    break;
            }
        }
    }
}

