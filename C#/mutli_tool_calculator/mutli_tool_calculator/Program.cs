using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutli_tool_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diameter;
            double circlearea;
            double rectanglelength;
            double rectanglehigh;
            double rectanglearea;
            double trianglelength;
            double trianglehigh;
            double trianglearea;
            char choose;

            Console.WriteLine("Do you want to  calculate the area from ");
            Console.WriteLine(" -a circle (k)");
            Console.WriteLine(" -a triangle (d)");
            Console.WriteLine(" -a rectangle (r)");
            Console.WriteLine("?");
            Console.WriteLine();
            Console.Write("Please type k, d or r to choose: ");
            choose = Convert.ToChar(Console.ReadLine());

            if (choose == 'k')
            {
                Console.Clear(); //it delets the stuff before

                Console.WriteLine("Program to calculate the area from a circle ");
                Console.Write("Please type in a diameter from the circle: ");
                diameter = Convert.ToDouble(Console.ReadLine());
                circlearea = (diameter * diameter) * Math.PI / 4;
                Console.WriteLine("The Circle area is about " + circlearea);

            }
            else if (choose == 'd')
            {
                Console.Clear();

                Console.WriteLine("Program to calculate the area of a triangular");
                Console.Write("Please type in the lenght of the basesite from the triangule: ");
                trianglelength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please type in the high of the triangule: ");
                trianglehigh = Convert.ToDouble(Console.ReadLine());
                trianglearea = trianglelength * trianglehigh;
                trianglearea = trianglearea / 2;
                Console.WriteLine("The area is " + trianglearea);
            }
            else if (choose == 'r')
            {

                Console.Clear();

                Console.WriteLine("Program to calculate the area of a rectangle");
                Console.Write("Please type in the length of the rectangle: ");
                rectanglelength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please type in the high of the rectangle: ");
                rectanglehigh = Convert.ToDouble(Console.ReadLine());
                rectanglearea = rectanglehigh * rectanglelength;
                Console.WriteLine("The rectangle are is about " + rectanglearea);
            }
            Console.ReadKey();
        }

    }
}

