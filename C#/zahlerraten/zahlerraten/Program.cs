using System;

namespace zahlerraten
{
    class Program
    {
        static void Main(string[] args)
        {

            int anz_versuche = 0;
            int alte_differenz = 100;
            int zahl;
            int neue_differenz;

            Random zufall = new Random();
            int zufallszahl = zufall.Next(1, 101);


            Console.WriteLine("Rate meine Zahl, die zwischen 1 und 100 liegt");
            Console.WriteLine("");
            Console.WriteLine("Der Abstand zur Zahl wird Zuerst mit 100 angenommen");
            do
            {
                Console.Write("Bitte gib eine Zahl ein: ");
                zahl = Convert.ToInt32(Console.ReadLine());
                neue_differenz = Math.Abs(zufallszahl - zahl);
                if (neue_differenz < alte_differenz)
                {
                    if (neue_differenz > 0)
                    {

                        Console.WriteLine("waermer -> Du hast Dich in dieser Runde der Zahl genähert");
                        Console.WriteLine("");

                    }


                }
                else
                {
                    if (neue_differenz > alte_differenz)
                    {
                        Console.WriteLine("kaelter -> Du hast Dich in dieser Runde der Zahl entfernt");
                        Console.WriteLine("");

                    }
                    else
                    {
                        Console.WriteLine("unveraendert -> Der Abstand zur Zahl ist unverändert");
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("");
                anz_versuche++;
                alte_differenz = neue_differenz;

            } while (alte_differenz != 0);

            Console.WriteLine("Glueckwunsch");
            Console.WriteLine("Du hast die Zahl mit " + anz_versuche + " Versuch(en) erraten");
            Console.ReadKey();
        }

    }

}
