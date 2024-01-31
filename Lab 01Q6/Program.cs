using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter exam marks:");
            if (int.TryParse(Console.ReadLine(), out int marks))
            {
                string grade = CalculateGrade(marks);
                Console.WriteLine($"Grade for {name}: {grade}");
            }
            else
            {
                Console.WriteLine("ERROR.Please enter a valid integer for marks");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
                return "A";
            else if (marks >= 60 && marks <= 74)
                return "B";
            else if (marks >= 50 && marks <= 59)
                return "C";
            else if (marks >= 40 && marks <= 49)
                return "D";
            else
                return "Fail";
        }
    }
}
