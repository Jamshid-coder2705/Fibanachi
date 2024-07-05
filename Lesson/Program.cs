using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 0;
            int fib2 = 1;
            Console.Write(" Sonni kiriting: ");

            int userNum = Convert.ToInt32(Console.ReadLine());
            int nextFib;

            while(fib1 <= userNum)
            {
                nextFib = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextFib;

                if (nextFib == userNum)
                {
                    Console.Write("Fibanachi son !!! => " + userNum);
                }
                
            }
            if (fib1 != userNum)
            {
                Console.WriteLine(" Fibanachi son emas !!! => " + userNum);
            }

        }
    }
}