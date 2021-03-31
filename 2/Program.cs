using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Enter positive integer number ");
            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int n) && n >= 2)
                {
                    Console.WriteLine($"Even numbers from 1 to {n} are");
                    for (int i = 2; i <= n; i += 2)
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
