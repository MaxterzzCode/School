namespace Quotenzberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double zahl1, zahl2, quotient;
            while (true)
            {
                Console.Write("Was ist die Zahl die Sie teilen wollen?: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Was ist der teiler?: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());

                if (zahl2 != 0)
                {
                    quotient = zahl1 / zahl2;

                    Console.WriteLine($"Der Quotient ist {quotient}");
                    Console.WriteLine("Drücken sie eine beliebige Taste um das Program neu auszuführen.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sie dürfen nicht durch 0 teilen!");
                    Console.WriteLine("Drücken sie eine beliebige Taste um es erneut zu versuchen.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}