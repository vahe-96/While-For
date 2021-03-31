using System;

namespace _8
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
                int next = int.Parse(Console.ReadLine());
                if (next % 2 == 0)
                {
                    s += next;
                }
            }

            Console.WriteLine($"Sum of the even numbers is {s}");
        }
    }
}
