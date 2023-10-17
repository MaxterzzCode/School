using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geradenberechnungen");
        Console.WriteLine("===================");

        // Eingabe der ersten Geraden
        Console.Write("1. Gerade: Bitte Steigung eingeben: ");
        double m1 = double.Parse(Console.ReadLine());
        Console.Write("1. Gerade: Bitte y-Achsenabschnitt eingeben: ");
        double b1 = double.Parse(Console.ReadLine());

        // Eingabe der zweiten Geraden
        Console.Write("2. Gerade: Bitte Steigung eingeben: ");
        double m2 = double.Parse(Console.ReadLine());
        Console.Write("2. Gerade: Bitte y-Achsenabschnitt eingeben: ");
        double b2 = double.Parse(Console.ReadLine());

        // Berechnung der Gleichungen
        string gleichung1 = GetGleichung(m1, b1);
        string gleichung2 = GetGleichung(m2, b2);

        // Ausgabe der Gleichungen
        Console.WriteLine("Ihre Geraden haben die folgenden Gleichungen:");
        Console.WriteLine(gleichung1);
        Console.WriteLine(gleichung2);

        // Überprüfen, ob die Geraden parallel, identisch oder sich schneiden
        if (m1 == m2 && b1 == b2)
        {
            Console.WriteLine("Die beiden Geraden sind identisch");
        }
        else if (m1 == m2)
        {
            Console.WriteLine("Die beiden Geraden sind parallel");
        }
        else
        {
            double xSchnittpunkt = (b2 - b1) / (m1 - m2);
            double ySchnittpunkt = m1 * xSchnittpunkt + b1;
            Console.WriteLine($"Die beiden Geraden schneiden sich im Punkt {xSchnittpunkt:F3}|{ySchnittpunkt:F3}");
        }
    }

    static string GetGleichung(double steigung, double yAchsenabschnitt)
    {
        string gleichung = "y ";
        if (steigung != 0)
        {
            gleichung += steigung == 1 ? "x" : $"{steigung}x";
        }
        if (yAchsenabschnitt != 0)
        {
            gleichung += yAchsenabschnitt > 0 ? $" + {yAchsenabschnitt}" : $" - {Math.Abs(yAchsenabschnitt)}";
        }
        return gleichung;
    }
}
