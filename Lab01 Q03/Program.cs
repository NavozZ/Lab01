using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q03
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0)
            {
                int sum = CalculateSum(number);
                Console.WriteLine($"The sum of all numbers from 1 to {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
