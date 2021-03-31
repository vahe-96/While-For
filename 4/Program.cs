using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Enter positive integer number ");
            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
                {
                    for (int i = 1; i <= n; i++)               // kam aranc cikl if n=1 (s=1) else (s=(1+n)/2*n) 
                    {
                        s += i;
                    }

                    Console.WriteLine($"The sum of all numbers from 1 to {n} is {s}");
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong, please enter again");
                }
            }
        }
    }
}
