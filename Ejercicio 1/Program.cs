namespace Ejercicio1;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());

        float resultado;
        float sumtotal = 0.0f;

        for (int i = 1; i <= n; i++)
        {
            resultado = (16.00f - i) / (3f * i);
            Console.WriteLine("resultado : " + resultado);
            sumtotal += resultado;
        }

        Console.WriteLine("Suma total: " + sumtotal);
        Console.ReadKey();
    }
}