using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            long p = 1;

            for (int i = 1; i <= 15; i++)
            {
                p *= i;
            }

            Console.WriteLine($"Product of the numbers from 1 to 15 is {p}");
        }
    }
}
