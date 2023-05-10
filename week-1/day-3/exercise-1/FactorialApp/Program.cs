using System;
using System.Diagnostics.Metrics;

using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            long factorial = fact(number);
            Console.Write($"Factorial of {number}  is: {factorial}");
            Console.ReadLine();
        }
        static long fact(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
    }
}
