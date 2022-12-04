using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userinputa;
            int userinputb;
            int sum;
            char yorn;

            do
            {
                Console.WriteLine("--------------------------------");
                Console.Write("Please type in the 1 number: ");
                userinputa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type in the 1 number: ");
                userinputb = Convert.ToInt32(Console.ReadLine());
                sum = userinputa + userinputb;
                Console.WriteLine("The sum is: " + sum + "");
                Console.WriteLine("--------------------------------");
                Console.Write("Do you want to do it again? (Y/N) ");
                yorn = Convert.ToChar(Console.ReadLine());
                

            } while (yorn == 'Y');
            Console.ReadKey();

        }
    }
}
