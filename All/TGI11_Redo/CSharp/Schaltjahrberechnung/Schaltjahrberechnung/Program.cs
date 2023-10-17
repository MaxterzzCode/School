namespace Schaltjahrberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jahr;
            bool schaltjahr = false;

            Console.WriteLine("Bitte geben Sie das Jahr ein was berechnet werden soll.");
            jahr = Convert.ToInt32(Console.Read());


            if (jahr % 4 == 0)
            {
                schaltjahr = true;

                if (jahr % 100 == 0 && jahr % 400 != 0)
                {
                    schaltjahr = false;
                }
                 
            }




            if (schaltjahr == true)
            {
                Console.WriteLine($"Das Jahr {jahr} ist ein Schaltjahr");
            }
            else
            {
                Console.WriteLine($"Das Jahr {jahr} ist kein Schaltjahr");
            }

        }

    }
}
