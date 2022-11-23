using System;

namespace Fakultätsberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int input;
           

            Console.WriteLine("Fakultaetsberechnung ");
            Console.WriteLine("");
            Console.Write("Natuerliche Zahl eingeben ");
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input ; i++)
            {
                n = n * i;
               
                if (i == input) ; {
                    Console.WriteLine(input + "! = " + n);
                }

            }


            
        }
    }
}
