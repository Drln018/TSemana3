using System;

namespace EJER146._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Los numeros primos del 1-100: ");

            for (int i = 2; i <= 100; i++)
            {  
                for (int j = 1; j <= i; j++)
                { 
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }

                if (cont <= 2)
                {
                    Console.WriteLine(i);
                }      
                cont = 0;               


            }//cierre del for1


            Console.ReadKey();
            
        }
    }
}
