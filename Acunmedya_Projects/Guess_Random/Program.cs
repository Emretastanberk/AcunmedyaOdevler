using System;

namespace Guess_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            
            int randomNumber = random.Next(1,100);
            Console.WriteLine(randomNumber);
            
            Console.WriteLine("Enter the between 1-100 number:");
            
            int right = 4;

            for (int i = 1; i <= right; i++)
            {
                int guessNumber = int.Parse(Console.ReadLine());
                if (randomNumber > guessNumber)
                {
                    Console.WriteLine("Wrong! More Up..");
                }
                else if (randomNumber == guessNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                
                else if (randomNumber < guessNumber)
                {
                    Console.WriteLine("Wrong! More Down..");

                }

            }
                
            

        }
    }
}