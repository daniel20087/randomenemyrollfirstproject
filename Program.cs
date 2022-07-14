using System;

namespace ConsoleApp2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1 = random.Next(1,21);
            int num2 = random.Next(1,21);
            Console.ReadLine();
            Console.WriteLine("your number is " + num1);
            Console.ReadLine();
            Console.WriteLine("their number is " + num2);
            if (num1 > num2)
            {
               Console.WriteLine("you win");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("you lose");
            }

            Console.ReadKey();
        }
    }
}
