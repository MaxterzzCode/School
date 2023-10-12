internal class Program
{
    private static void Main(string[] args)
    {
        int alter;

        Console.Write("Wie alt sind Sie?: ");
        alter = Convert.ToInt16(Console.ReadLine());
       
        if (alter >= 18)
        {
            Console.WriteLine($"Sie sind {alter} jahre alt. Sie sind damit volljährig");
        }
        else
        {
            Console.WriteLine($"Sie sind {alter} jahre alt. Sie sind damit nicht volljährig");
        }
    }
}