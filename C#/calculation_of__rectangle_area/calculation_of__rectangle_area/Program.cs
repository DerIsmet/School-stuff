using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation_of__rectangle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rectanglelength;
            double rectanglehigh;
            double rectanglearea;

            Console.WriteLine("Program to calculate the area of a rectangle");
            Console.Write("Please type in the length of the rectangle: ");
            rectanglelength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type in the high of the rectangle: ");
            rectanglehigh = Convert.ToDouble(Console.ReadLine());
            rectanglearea = rectanglehigh * rectanglelength;
            Console.WriteLine("The rectangle are is about " + rectanglearea);

            Console.ReadKey();
        }
    }
}
