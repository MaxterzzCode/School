using System;

namespace Flächenberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthrect, heightrect, lengthtriangle, heighttriangle;
            double arearect, areatriangle, diameter, area;
            string lengthstringrect, heightstringrect, lengthstringtriangle, heightstringtriangle, auswahlstring;
        Anfang:
            Console.WriteLine("Wollen Sie den Flächeninhalt");
            Console.WriteLine("- eines Kreises <k>");
            Console.WriteLine("- eines Dreiecks <d>");
            Console.WriteLine("- eines Rechtecks <r>");
            Console.WriteLine(" berechnen? ");
            Console.Write("Bitte k, d oder r eingeben: ");
            auswahlstring = Console.ReadLine();
            if (auswahlstring == "k")
            {
                //Kreis:
                Console.Clear();
                Console.WriteLine("Programm zur Berechnung des Flaecheninhaltes eines Kreises");
                Console.Write("Bitte geben Sie den Durchmesser des Kreises an: ");
                diameter = Convert.ToDouble(Console.ReadLine());
                area = (diameter * diameter) * Math.PI / 4;
                Console.WriteLine("Die Kreisfläche beträgt: " + area + " Flaecheneinheiten");
                Console.ReadKey();
                Environment.Exit(0);

            }

            else if (auswahlstring == "r")
            {
                //Rechteck
                Console.Clear();
                Console.WriteLine("Programm zur Berechnung des Flaecheninhaltes eines Rechtecks");
                Console.Write("Bitte geben Sie die Laenge des Rechtecks an: ");
                lengthstringrect = Console.ReadLine();
                lengthrect = Convert.ToInt32(lengthstringrect);
                Console.Write("Bitte geben Sie die Hoehe des Rechtecks an: ");
                heightstringrect = Console.ReadLine();
                heightrect = Convert.ToInt32(heightstringrect);
                arearect = lengthrect * heightrect;
                Console.WriteLine("Die Rechtecskflaeche beträgt: " + arearect + " Flaecheneinheiten");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else if (auswahlstring == "d")
            {
                //Dreieck
                Console.Clear();
                Console.WriteLine("Programm zur Berechnung des Flaecheninhaltes eines Rechtecks");
                Console.Write("Bitte geben Sie die Laenge des Rechtecks an: ");
                lengthstringtriangle = Console.ReadLine();
                lengthtriangle = Convert.ToInt32(lengthstringtriangle);
                Console.Write("Bitte geben Sie die Hoehe des Rechtecks an: ");
                heightstringtriangle = Console.ReadLine();
                heighttriangle = Convert.ToInt32(heightstringtriangle);
                areatriangle = lengthtriangle * heighttriangle;
                Console.WriteLine("Die Rechtecskflaeche beträgt: " + areatriangle + " Flaecheneinheiten");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {

                Console.WriteLine("Ungültige Eingabe, versuche erneut.");
                Console.WriteLine(" ");
                goto Anfang;



            }















        }
    }
}
