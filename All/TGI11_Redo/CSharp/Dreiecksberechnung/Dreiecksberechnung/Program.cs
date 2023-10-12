namespace Dreiecksberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double summe, grundseite, hoehe;

            Console.WriteLine("Programm zur Berechnung des Flächeninhalt eines Dreiecks");
            Console.Write("Bitte geben Sie die Länge der Grundseite des Dreiecks an: ");
            
            grundseite = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Bitte geben Sie die Höhe des Dreiecks an: ");
           
            hoehe = Convert.ToDouble(Console.ReadLine());

            summe = 0.5 * grundseite * hoehe;

            Console.WriteLine($"Die Rechtecksfläche beträgt {summe}");

        }
    }
}