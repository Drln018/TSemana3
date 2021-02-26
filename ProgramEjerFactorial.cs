using System;

namespace EJERFACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
                Console.Write("Escriba un numero ");
                n= Convert.ToInt32(Console.ReadLine());
            
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El Factorial de " + n + " es: " + fact);

            Console.ReadKey();
        } 
    } 
}
