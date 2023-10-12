using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahl_erraten
{
    class Program
    {
        static void Main(string[] args)
        {
            int zufallszahl;
            int anz_versuche = 0;
            int alte_differenz = 100;
            int zahl;
            int neue_differenz;


            Random zufall = new Random();
            zufallszahl = zufall.Next(1, 101);

            Console.WriteLine("Rate meine Zahl, die zwischen 1 und 100 liegt");
            Console.WriteLine();
            Console.WriteLine("Der Abstand zur Zahl wird zuerst mit 100 angenommen.");

            do
            {
                Console.Write("Bitte gib eine zahl ein: ");
                zahl = Convert.ToInt32(Console.ReadLine());
                neue_differenz = Math.Abs(zufallszahl - zahl);

                if (neue_differenz < alte_differenz)
                {
                    if (neue_differenz > 0)
                    {
                        Console.WriteLine(". . . wärmer -> Du hast Dich in dieser Runde der Zahl genähert");
                    }
                    else
                    {
                        Console.WriteLine(". . . unverändert -> Der Abstand zur Zahl ist unverändert");
                    }
                }
                else
                {
                    if (neue_differenz > alte_differenz)
                    {
                        Console.WriteLine(". . . kälter -> Du hast Dich in dieser Runde von der Zahl entfernt");
                    }
                    else
                    {
                        Console.WriteLine(". . . unverändert -> Der Abstand zur Zahl ist unverändert");
                    }
                }

                Console.WriteLine();
                anz_versuche++;
                alte_differenz = neue_differenz;
            }
            while (neue_differenz != 0);
            Console.WriteLine("Glückwunsch");
            if (anz_versuche == 1)
            {
                Console.WriteLine("Du hast die Zahl mit " + anz_versuche + " Versuch erraten");
            }
            else
            {
                Console.WriteLine("Du hast die Zahl mit " + anz_versuche + " Versuchen erraten");
            }


            Console.ReadKey();
        }
    }
}