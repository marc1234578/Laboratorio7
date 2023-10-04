namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            int añoInicio = 1900;
            int añoFinal = 2023;

            Console.WriteLine("Los años bisiestos desde el año 1900:");

            for (int año = añoInicio; año <= añoFinal; año++)
            {
                if (EsBisiesto(año))
                {
                    Console.WriteLine(año);
                }
            }

            Console.ReadLine();
        }

        static bool EsBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
    }

}