using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Enter first integer number");
            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Enter second integer number");
                    while (s == 0)
                    {
                        if (int.TryParse(Console.ReadLine(), out int b) && a <= b)
                        {
                            for (int i = a; i <= b; i++)
                            {
                                s += i;
                            }

                            Console.WriteLine($"The sum of all numbers from {a} to {b} is {s}");
                        }
                        else
                        {
                            Console.WriteLine("Entered expression is wrong for the second number, please enter again");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for the first number, please enter again");
                }
            }
        }
    }
}
