using System;

namespace Nullstellenberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Was ist der Wert für a?: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Was ist der Wert für b?: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Was ist der Wert für c?: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("a darf nicht gleich 0 sein, da dies keine quadratische Gleichung ist.");
            }
            else
            {
                double discriminant = diskriminante(a, b, c);

                if (discriminant > 0)
                {
                    double x1 = wertX1(a, b, discriminant);
                    double x2 = wertX2(a, b, discriminant);
                    Console.WriteLine($"2 Nullstellen vorhanden X1: {x1}, X2: {x2}.");
                }
                else if (discriminant == 0)
                {
                    double x1 = wertX1(a, b, discriminant);
                    Console.WriteLine($"Eine Nullstelle vorhanden X1: {x1}.");
                }
                else
                {
                    Console.WriteLine("Keine Nullstelle vorhanden.");
                }
            }

            Console.ReadKey();
        }

        static double wertX1(double a, double b, double discriminant)
        {
            double xWert = 0;
            xWert = (-b + Math.Sqrt(discriminant)) / (2 * a);
            return xWert;
        }

        static double wertX2(double a, double b, double discriminant)
        {
            double xWert = 0;
            xWert = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return xWert;
        }

        static double diskriminante(double a, double b, double c)
        {
            double discriminant = 0;

            discriminant = Math.Pow(b, 2) - 4 * a * c;

            return discriminant;
        }
    }
}
