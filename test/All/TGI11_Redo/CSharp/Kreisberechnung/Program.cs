namespace Kreisberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double durchmesser, summe;
            
            Console.WriteLine("Programm zur Berechnung des Flächeninhalts eines Kreises: ");
            
            Console.Write("Bitte geben sie den Durchmesser des kreises an: ");
            
            durchmesser = Convert.ToDouble(Console.ReadLine());

            summe = Math.PI / 4 * (durchmesser * durchmesser);

            Console.WriteLine($"Die Kreisfläche beträgt {summe} ");

        }
    }
}