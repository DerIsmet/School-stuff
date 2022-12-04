using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool leapyear;

            Console.WriteLine("leap year calculator");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                leapyear = true;

                if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                    {
                        leapyear = false;
                    }
                    else
                    {
                        leapyear = true;
                    }
                }
                else
                {
                    leapyear = true;
                }
            }
            else
            {
                leapyear = false;
            }

            Console.WriteLine();
           
            if (leapyear == true)
            {
                Console.WriteLine("It is a lap year");
            } if (leapyear == false)
            {
                Console.WriteLine("It is not a lap year");
            }
            Console.ReadKey();
        }
    }
}
