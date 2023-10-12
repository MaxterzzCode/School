using System;

namespace Geradenrechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            double steigungerste, steigungzweite, achsenabschnitterste, achsenabschnittzweite, xs, ys;
            string stringsterst, stringstzwei, stringachseeins, stringachsezwei;

            Console.WriteLine("Geradenberechnungen");
            Console.WriteLine("===================");
            Console.WriteLine("");
            Console.Write("1. Gerade: Bitte Steigung eingeben: ");
            stringsterst = Console.ReadLine();
            steigungerste = Convert.ToDouble(stringsterst);
            Console.Write("1. Gerade: Bitte y-Achsenabschnitt eingeben: ");
            stringachseeins = Console.ReadLine();
            achsenabschnitterste = Convert.ToDouble(stringachseeins);
            Console.Write("2. Gerade: Bitte Steigung eingeben: ");
            stringstzwei = Console.ReadLine();
            steigungzweite = Convert.ToDouble(stringstzwei);
            Console.Write("2. Gerade: Bitte y-Achsenabschnitt eingeben: ");
            stringachsezwei = Console.ReadLine();
            achsenabschnittzweite = Convert.ToDouble(stringachsezwei);
            Console.WriteLine("Ihre Geraden haben die folgenden Gleichungen: ");




            if (achsenabschnitterste < 0)
            {
                Console.WriteLine("y=" +steigungerste+ "x" + achsenabschnitterste);

            }
            else if (achsenabschnitterste > 0)
            {
                if (steigungerste != 1)
                Console.WriteLine("y=" + steigungerste + "x+" + achsenabschnitterste);
                else
                    Console.WriteLine("y=x" + achsenabschnitterste);
            }
            else if (achsenabschnitterste == 0)
            {
                Console.WriteLine("y=" + steigungerste + "x");
            }
            if (achsenabschnittzweite < 0)
            {
                Console.WriteLine("y=" + steigungzweite + "x" + achsenabschnittzweite);
            }
            else if (achsenabschnittzweite > 0)
            {
                Console.WriteLine("y=" + steigungzweite + "x+" + achsenabschnittzweite);
            }
            else if (achsenabschnittzweite == 0)
            {
                Console.WriteLine("y=" + steigungzweite + "x");
            }

            xs = (achsenabschnittzweite - achsenabschnitterste) / (steigungerste - steigungzweite);
            ys = steigungerste * xs + achsenabschnitterste;
            if (achsenabschnitterste == achsenabschnittzweite && steigungerste == steigungzweite)
            {
                Console.WriteLine("Die beiden Geraden sind identisch");
            }
            else {
                Console.WriteLine("Die beiden Geraden scheiden sich im Punkt S(" + xs + "/" + ys + ")");


            }   








        }
    }
}
