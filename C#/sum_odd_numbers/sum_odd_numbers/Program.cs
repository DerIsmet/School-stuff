using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int sum = 0;

            Console.WriteLine("Please type in the Max number, that will be sum all odd numbers under it. ");
            Console.Write("Max: ");
            userinput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userinput; i+=2)
            {
                sum = i + sum;
                if (i == userinput)
                {
                    Console.Write("" + i + "");
                }
                else
                {
                    Console.Write(" " + i + " + ");
                }
            }
            Console.Write(" = "+sum+"");
            Console.WriteLine();
            Console.WriteLine("The sum of all the odd number from 1 to " + userinput + " is " + sum);
            Console.ReadKey();
        }
    }
}
