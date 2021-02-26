using System;

namespace EJER101._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion, producto;
            float precio;
            float resultado;

            Console.WriteLine("Ingrese el tipo de producto: ");
            Console.WriteLine("1. Alimentos, 12% de impuesto ");
            Console.WriteLine("2. Medicina, 0% de descuento ");
            opcion = Convert.ToString(Console.ReadLine());

            if (opcion == "1")
            {
                Console.WriteLine("Escriba el nombre del producto ");
                producto = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Escriba el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());
                resultado = (precio * 12) / 100;
                resultado = precio + resultado;

                Console.WriteLine("El total a pagar es de " + resultado);
            }

            if (opcion == "2")
            {
                Console.WriteLine("Escriba el nombre del producto ");
                producto = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Escriba el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El total a pagar es de:" + precio);
            }

            Console.ReadKey();





        }
    }
}
