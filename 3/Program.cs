using System;

namespace _3
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
                    Console.WriteLine($"Odd numbers from 1 to {n} are");
                    for (int i = 1; i <= n; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    s = 1;
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong, please enter again");
                }
            }
        }
    }
}
