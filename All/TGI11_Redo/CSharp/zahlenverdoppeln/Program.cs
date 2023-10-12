namespace zahlenverdoppeln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl, doppel;

            Console.Write("Bitte geben Sie die Zahl, die verdoppelt werden soll ein: ");

            zahl = Convert.ToInt32(Console.ReadLine());
            doppel = zahl * 2;

            Console.WriteLine($"Das doppelte von {zahl} ist {doppel}.");

            Console.ReadKey();
        }
    }
}