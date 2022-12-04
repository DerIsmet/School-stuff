using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_doubler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zahlstring;
            int zahl;
            int doppel;

            Console.WriteLine("Program: double the numbers");
            Console.WriteLine();
            Console.Write("Please type a number in: ");
            zahlstring = Console.ReadLine();
            zahl = Convert.ToInt32(zahlstring);
            doppel = 2 * zahl;
            Console.Write("The doubled value from ");
            Console.Write(Convert.ToString(zahl));
            Console.Write(" is ");
            Console.Write(Convert.ToString(doppel));

            Console.ReadKey();
        
        
        }
    }
}
