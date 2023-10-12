namespace RechnungMultiTool
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            Console.Write("Wollen sie den Flächeninhalt für Kreis <k>, dreieck <d> oder Rechteck <r> berechnen?: ");
            input = Convert.ToChar(Console.ReadLine() ?? throw new Exception("Null"));

            if (input == 'k')
            {
                Kreis();
            }
            else if (input == 'd')
            {
                Dreieck();
            }
            else if (input == 'r')
            {
                Rechteck();
            }   
        }

        
        static int Rechteck()
        {
            
            int laenge, breite, rsumme;
            Console.WriteLine("Programm zur Berechnung des Flächeninhaltes eines Rechtecks");

            Console.Write("Bitte geben sie die Länge des Rechtecks an: ");
            laenge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitte geben sie die Breite des Rechtecks an: ");
            breite = Convert.ToInt32(Console.ReadLine());

           return rsumme = laenge * breite;
        }

        static double Dreieck()
        {
            double dsumme, grundseite, hoehe;

            Console.WriteLine("Programm zur Berechnung des Flächeninhalt eines Dreiecks");
            Console.Write("Bitte geben Sie die Länge der Grundseite des Dreiecks an: ");

            grundseite = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bitte geben Sie die Höhe des Dreiecks an: ");

            hoehe = Convert.ToDouble(Console.ReadLine());

            return dsumme = 0.5 * grundseite * hoehe;
        }

        static double Kreis()
        {
            double durchmesser, ksumme;

            Console.WriteLine("Programm zur Berechnung des Flächeninhalts eines Kreises: ");

            Console.Write("Bitte geben sie den Durchmesser des kreises an: ");

            durchmesser = Convert.ToDouble(Console.ReadLine());

           return ksumme = Math.PI / 4 * (durchmesser * durchmesser);
        }

    }
}
