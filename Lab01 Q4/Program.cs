using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for Fibonacci series:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine("Fibonacci Series:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
            }
            else
            {
                Console.WriteLine("Error. enter positive integer.");
            }

            Console.WriteLine("");
            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
