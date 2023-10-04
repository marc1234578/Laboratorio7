namespace Ejercicio2;
internal class Program
{
    static void Main(string[] args)
    {
        int e = 1;

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Divisor de Omar Orlandini " + e + ": " + i);
                e++;
            }
        }
        Console.ReadKey();
    }

}
