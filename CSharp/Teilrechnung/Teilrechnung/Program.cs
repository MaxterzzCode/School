using System;

namespace Teilrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            double summe;
            double teiler, zahl;
            string zahlsumme, teilersumme;


            Console.WriteLine("Programm Zur Quotientenrechnung");
            Console.Write("Welche Zahl wollen sie teilen? ");
            zahlsumme = Console.ReadLine();
            zahl = Convert.ToDouble(zahlsumme);
            Console.WriteLine("Mit welcher Zahl wollen sie diese Zahl teilen? ");
            teilersumme = Console.ReadLine();
            teiler = Convert.ToDouble(teilersumme);

            if (teiler == 0)
            {
                Console.WriteLine("Sie können nicht durch 0 teilen.");
            }
            else
            {
                summe = zahl / teiler;
                Console.WriteLine("Das Ergebnis ist " +summe);


            }



        }
    }
}
