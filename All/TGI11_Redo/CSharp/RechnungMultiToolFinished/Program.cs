namespace RechnungMultiToolFinished
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input;

            while (true)
            {
                Console.WriteLine("Wollen Sie den Flächeninhalt für Kreis <k>, Dreieck <d> oder Rechteck <r> berechnen?");
                Console.WriteLine("Schreiben Sie <x> um das Programm zu beenden.");

                if (char.TryParse(Console.ReadLine()?.ToLower(), out input))
                {
                    switch (input)
                    {
                        case 'x':
                            Environment.Exit(0);
                            break;
                        case 'k':
                            Kreis();
                            break;
                        case 'd':
                            Dreieck();
                            break;
                        case 'r':
                            Rechteck();
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe.");
                            break;
                    }
                }
            }
        }

        static int Rechteck()
        {
            int laenge, breite, rsumme;
            Console.WriteLine("Programm zur Berechnung des Flächeninhaltes eines Rechtecks");

            Console.Write("Bitte geben Sie die Länge des Rechtecks an: ");
            laenge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben Sie die Breite des Rechtecks an: ");
            breite = Convert.ToInt32(Console.ReadLine());

            rsumme = laenge * breite;

            Console.WriteLine($"Die Fläche des Rechtecks beträgt: {rsumme}");

            return rsumme;
        }

        static double Dreieck()
        {
            double dsumme, grundseite, hoehe;

            Console.WriteLine("Programm zur Berechnung des Flächeninhalt eines Dreiecks");
            Console.Write("Bitte geben Sie die Länge der Grundseite des Dreiecks an: ");

            grundseite = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Höhe des Dreiecks an: ");

            hoehe = Convert.ToDouble(Console.ReadLine());

            dsumme = 0.5 * grundseite * hoehe;
            Console.WriteLine($"Die Fläche des Dreiecks beträgt: {dsumme}");
            return dsumme;
        }

        static double Kreis()
        {
            double durchmesser, ksumme;

            Console.WriteLine("Programm zur Berechnung des Flächeninhalts eines Kreises: ");

            Console.Write("Bitte geben Sie den Durchmesser des Kreises an: ");

            durchmesser = Convert.ToDouble(Console.ReadLine());

            ksumme = Math.PI / 4 * (durchmesser * durchmesser);

            Console.WriteLine($"Die Fläche des Kreises beträgt: {ksumme}");

            return ksumme;
        }
    }
}