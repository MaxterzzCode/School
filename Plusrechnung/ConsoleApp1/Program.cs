using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string zahlstring;
            string zahlstring2;
            int zahl;
            int zahl2;
            int summe;

            Console.WriteLine("Rätselhaftes Programm");
            Console.WriteLine("");
            Console.Write("Bitte geben Sie eine 1. Zahl ein: ");
            zahlstring = Console.ReadLine();
            zahl = Convert.ToInt32(zahlstring);
            Console.Write("Bitte geben Sie eine 2. Zahl ein: ");
            zahlstring2 = Console.ReadLine();
            zahl2 = Convert.ToInt32(zahlstring2);
            summe = zahl + zahl2;
            Console.WriteLine("Das Ergebnis ist " + summe);
            Console.ReadKey();
           







     
        }
    }
}
