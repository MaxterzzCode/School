namespace major_bag_alert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double StartKapital = 1000;
            int iyears = 0;
            for (int i = 0; i <= 12; i++)
            {
                StartKapital = StartKapital + (StartKapital * 0.05);
            }
            Console.WriteLine("Das Kapital nach 12 Jahren beträgt: {0} Euro", Math.Round(StartKapital, 2));

            StartKapital = 1000;
            for (int i = 0; StartKapital <= 2000; i++)
                {

                   StartKapital = StartKapital + (StartKapital * 0.05);
                   iyears++; 
                 
                }

                Console.WriteLine("Nach " + iyears + " Jahren hat sich das Kapital verdoppelt"); 
            
            }
        }
    }
