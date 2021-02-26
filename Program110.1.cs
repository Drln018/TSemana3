using System;

namespace EJER110._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero ");
            num= Convert.ToByte (Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("El numero es par ");
            else
                Console.WriteLine("El numero es impar ");
            Console.ReadKey();
        }
    }
}
