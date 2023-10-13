namespace Rechtecksberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int laenge, breite, summe;
            
            Console.WriteLine("Programm zur Berechnung des Flächeninhaltes eines Rechtecks");
            
            Console.Write("Bitte geben sie die Länge des Rechtecks an: ");
            laenge = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Bitte geben sie die Breite des Rechtecks an: ");
            breite = Convert.ToInt32(Console.ReadLine());

            summe = laenge * breite;

            Console.WriteLine($"Die summe beträgt {summe} ");
        }
    }
}