using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation_of__triangular_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trianglelength;
            double trianglehigh;
            double trianglearea;

            Console.WriteLine("Program to calculate the area of a triangular");
            Console.Write("Please type in the lenght of the basesite from the triangule: ");
            trianglelength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type in the high of the triangule: ");
            trianglehigh = Convert.ToDouble(Console.ReadLine());
            trianglearea = trianglelength * trianglehigh;
            trianglearea = trianglearea / 2;
            Console.WriteLine("The area is "+ trianglearea);

            Console.ReadKey();

        }
    }
}
