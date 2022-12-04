using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radioactivity_decay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiation = 100;
            int year = 0;



            Console.WriteLine("Radioaktiver Zerfall");
            Console.WriteLine("");
            do
            {
                
                Console.WriteLine("After " + year + " years there are " + radiation + "% radioactivity still there.");

                radiation = radiation * 0.95;
                year++;
            } while (radiation >= 50);
            Console.WriteLine("");
            Console.WriteLine("After " + year + " years the raduiacticity decayed to half.");
            Console.ReadKey();
        }
    }
}
