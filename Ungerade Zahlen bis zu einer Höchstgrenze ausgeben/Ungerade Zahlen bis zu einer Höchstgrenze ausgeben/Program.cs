namespace Ungerade_Zahlen_bis_zu_einer_Höchstgrenze_ausgeben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 1;
            Console.WriteLine("Bitte geben sie eine Übergrenze ein, bis zu der die Summe aller ungeraden Zahlen gebildet werden soll.");
            int number = Convert.ToInt32(Console.ReadLine());
            while (i <= number)
            {
                sum += i;
                i += 2;
            }
            Console.Write($"Summe von Ungeraden zahlen von 1 bis {number} ist : {sum}");
            Console.ReadLine();
        }
    }
}