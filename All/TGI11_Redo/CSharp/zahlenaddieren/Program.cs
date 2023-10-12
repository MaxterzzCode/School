namespace zahlenaddieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2, ergebnis;
            Console.WriteLine("Rätselhaftes Programm");
            Console.WriteLine("");

            Console.Write("Bitte geben sie die 1. Zahl ein: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben sie die 2. Zahl ein: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            ergebnis = zahl1 + zahl2;

            Console.WriteLine($"Das Ergebnis ist {ergebnis}");

            Console.ReadKey();
        }
    }
}