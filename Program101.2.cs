using System;

namespace EJER101._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            double rad, grad, resultado, pi = 3.1416;
            Console.WriteLine("Seleccione una opcion: ");
            Console.WriteLine("1. Convertir grados a radianes. ");
            Console.WriteLine("2. Convertir radianes a grados. ");
            opcion = Convert.ToString(Console.ReadLine());

            if (opcion == "1")
                Console.WriteLine("Escriba la cantidad de radianes a convertir ");
            rad = Convert.ToDouble(Console.ReadLine());
            resultado = (rad * 180) / pi;
                Console.WriteLine($"La conversion de {rad} es igual a " + resultado + "grados");

            if (opcion=="2")
                Console.WriteLine("Escriba la cantidad de grados a convertir ");
            grad = Convert.ToDouble(Console.ReadLine());
            resultado = (grad * pi) / 180;
                Console.WriteLine($"La conversion de {grad} es igual a " + resultado + "radianes ");

            Console.ReadKey();
        }
    }
}
