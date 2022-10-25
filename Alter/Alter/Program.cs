using System;

namespace Alter
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter;
            string alterstring;
            Console.Write("Bitte geben Sie Ihr Alter ein: ");
            alterstring = Console.ReadLine();
            alter = Convert.ToInt32(alterstring);
            if (alter >= 18)
            {
                Console.WriteLine("Sie sind Volljährig");
            }
            else
            {
                Console.WriteLine("Sie sind nicht Volljährig");
                Console.ReadKey();
            }
        }
    }
}
