using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle:");
            double length=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            double width=double.Parse(Console.ReadLine());

            double area=Area(length,width);

            Console.WriteLine("The area is:"+ area );
            Console.ReadLine();
        }
        static double Area(double length,double width)
        {
            return length*width;
        }
    }
}
