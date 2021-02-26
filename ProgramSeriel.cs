using System;

namespace EJERSERIEFACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, j, i, auxiliar;
            Console.WriteLine("Ingrese numero ");
            j = Convert.ToInt32(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < j; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
