using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity of numbers");
            int n = int.Parse(Console.ReadLine());
            int s = 0;

            Console.WriteLine($"Enter {n} integer numbers");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter number {i}");
                s += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum of this {n} numbers is {s}");
        }
    }
}
