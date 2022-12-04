using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomnumber = random.Next(1, 101);
            int tries = 0;
            int olddiff = 100;
            int number;
            int newdiff;

            Console.WriteLine("Guess my number, wich is between 1 and 100.");
            Console.WriteLine();
            Console.WriteLine("The diff to the number is firstly 100");
            do
            {
                Console.Write("Please type in a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                newdiff = Math.Abs(randomnumber - number);
                if(newdiff < olddiff)
                {
                    if(newdiff > 0)
                    {
                        Console.WriteLine("  ...warmer --> You got closer to the number");

                    }
                }else
                {
                    if(newdiff > olddiff)
                    {
                        Console.WriteLine("  ...colder --> You got further to the number");
                    }
                    else
                    {
                        
                            Console.WriteLine("  ...same --> Nothing chanched");
                        
                    }
                }
                Console.WriteLine();
                tries++;
                olddiff = newdiff;
            }while(newdiff != 0);
            Console.WriteLine("Congratulations");
            Console.WriteLine("You tried " + tries+" times");

            Console.ReadKey();
        }
    }
}
