using System;

namespace Zerfallsrate
{
    class Program
    {
        static void Main(string[] args)
        {

            double radiation = 100;
            int jahre = 0;



            Console.WriteLine("Radioaktiver Zerfall");
            Console.WriteLine("");
            do
            {
                jahre++;
                Console.WriteLine("Nach " + jahre + " sind noch " + radiation + " vorhanden");
                
                radiation = radiation * 0.95;

            } while (radiation >= 50);
            Console.WriteLine("");
            Console.WriteLine("Nach circa " + jahre + " Jahren ist die Haelfte des Materials zerfallen");

        }
    }
}
