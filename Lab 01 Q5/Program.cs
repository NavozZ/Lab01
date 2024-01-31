using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to display its multiplication table:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                DisplayMultiplicationTable(number);
            }
            else
            {
                Console.WriteLine("ERROR: Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("");
            Console.ReadKey();
        }

        static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
