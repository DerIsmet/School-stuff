using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valla_teiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            int anzahl_teiler = 0;
            char jes;

            do
            {
                Console.WriteLine("Ausgabe der Teiler einer Zahl");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.Write("Bitte ganze Zahl > 0 eingeben: ");
                userinput = Convert.ToInt32(Console.ReadLine());
                for (int i = userinput; i != 0; i--)
                {
                    if (userinput % i == 0)
                    {
                        anzahl_teiler++;
                        Console.WriteLine("Der " + anzahl_teiler + ". Teiler ist: " + i);
                    }
                }
                    if (anzahl_teiler == 2)
                    {
                        Console.WriteLine("Es ist eine Primzahl");
                    }
                    anzahl_teiler = 0;
                
                Console.Write("Soll das Programm erneut ausgeführt werden? (j) ");
                jes = Convert.ToChar(Console.ReadLine());
            }while (jes == 'j');
        }
    }
}
