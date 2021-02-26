using System;

namespace EJER101._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escriba un numero del 1-7 ");
            num = Convert.ToChar(Console.ReadLine());

            switch (num)
            {

                case '1':
                    Console.WriteLine("Dia lunes");
                    break;
                case '2':
                    Console.WriteLine("Dia Martes");
                    break;
                case '3':
                    Console.WriteLine("Dia Miercoles");
                    break;
                case '4':
                    Console.WriteLine("Dia Jueves");
                    break;
                case '5':
                    Console.WriteLine("Dia Viernes");
                    break;
                case '6':
                    Console.WriteLine("Dia Sabado");
                    break;
                case '7':
                    Console.WriteLine("Dia Domingo");
                    break;
            }
            Console.ReadLine();


            }
    }
}
