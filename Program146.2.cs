using System;

namespace _146._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ba, expon, acum = 1;

            Console.WriteLine("Escriba el exponente");
            expon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la base");
            ba = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= expon; x++)

                acum = acum * ba;

            Console.WriteLine( ba + " elevado a " + expon + " = " + (acum));
            Console.ReadKey();
        } 

    }
}
