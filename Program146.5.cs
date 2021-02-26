using System;

namespace EJER146._5
{
    class Program
    {
        static void Main(string[] args)
        {
            float edad, acumulador = 0;
            float promedio;

            for (int x=1; x <= 5; x++)
            {
                Console.WriteLine("Ingrese la edad del grupo");
                edad = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + edad;
            }
            promedio = acumulador / 5;
            Console.WriteLine("El promedio de edad es: " + promedio);
            Console.ReadKey();
        }
    }
}
