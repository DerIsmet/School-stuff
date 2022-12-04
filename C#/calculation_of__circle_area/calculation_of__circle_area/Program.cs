using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation_of__circle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diameter;
            double circlearea;

            Console.WriteLine("Program to calculate the area from a circle ");
            Console.Write("Please type in a diameter from the circle: ");
            diameter = Convert.ToDouble(Console.ReadLine());
            circlearea = (diameter * diameter) * Math.PI /4;
            Console.WriteLine("The Circle area is about "+circlearea);
           
            Console.ReadKey();
        }
    }
}
