using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace are_you_of_legal_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            
            if (age >= 18)
            {
                Console.WriteLine("You are of legal age");
            }
            else if(age < 18)
            {
                Console.WriteLine("You are not of legal age");
            }

            Console.ReadKey();
        }
    }
}
