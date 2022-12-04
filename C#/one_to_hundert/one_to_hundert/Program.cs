using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_to_hundert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int number = 0; number <= 100; number++)
            {
                if (number == 100)
                {
                    Console.Write(""+number+"");
                }
                else
                {
                    Console.Write("" + number + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
