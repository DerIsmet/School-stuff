using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice = 0;
            int sum = 0;
                
            Console.WriteLine("Würfelspiel");
            Console.WriteLine("===========");

            while (dice != 6)
            {
                dice = random.Next(1, 7);
                Console.WriteLine("diced number: " + dice + "");
                sum += dice;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: "+sum);
            Console.ReadKey();

        }
    }
}
