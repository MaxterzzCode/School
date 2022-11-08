namespace Zahlen_1_bis_100_ausgeben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int zahl = 0; zahl <= 100; ++zahl)
                if (zahl == 100)
                    Console.Write("{0}", zahl);
                else
                    Console.Write("{0},", zahl);
        }
    }
}
