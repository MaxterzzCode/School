using System;

namespace Wuerfel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random wuerf = new Random();
            int zahl;
            int zahl1 = 0;
            zahl = 0;
            Console.WriteLine("Würfelspiel");
            Console.WriteLine("===========");
            do
            {
                zahl = wuerf.Next(1, 7);
                Console.WriteLine("gewürfelte zahl: " + zahl);
                zahl1 = zahl1 + zahl;

            } while (zahl < 6);
            Console.WriteLine("");
            Console.WriteLine("Summe = " + zahl1);
        }
    }
}
