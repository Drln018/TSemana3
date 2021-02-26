using System;

namespace EJER101._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, c = 8;
            string opcion, opcion2;
            int perimetro, area;

            Console.WriteLine("Elija el poligono rectangular a resolver");
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Rectangulo");
            Console.WriteLine("4. Romboide");
            
            opcion = Convert.ToString(Console.ReadLine());

            switch (opcion)
            {
                case "1":
                    {
                        Console.WriteLine("¿Que desea calcular del triangulo? ");
                        Console.WriteLine("1. Area      2. Perímetro");
                        opcion2 = Convert.ToString(Console.ReadLine());
                        if (opcion2 == "1")
                        {
                            area = (b * a) / 2;
                            Console.WriteLine("El area del triangulo es: " + area);
                        }
                        if (opcion2 == "2")
                        {
                            perimetro = a + b + c;
                            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
                        }
                    }
                        break;

                case "2":
                    {

                        Console.WriteLine("¿Que desea calcular del cuadrado?");
                        Console.WriteLine("1. Area      2. Perímetro");

                        opcion2 = Convert.ToString(Console.ReadLine());

                        if (opcion2 == "1")
                        {
                            area = a * a;
                            Console.WriteLine("El area del triangulo es: " + area);
                        }
                        if (opcion2 == "2")
                        {
                            perimetro = (4 * a);
                            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
                        }
                    }
                        break;

                    case "3":
                    {
                        Console.WriteLine("¿Que desea calcular del rectangulo?");
                        Console.WriteLine("1. Area      2. Perímetro");

                        opcion2 = Convert.ToString(Console.ReadLine());

                        if (opcion2 == "1")
                        {
                            area = b * a;
                            Console.WriteLine("El area del rectangulo es: " + area);
                        }
                        if (opcion2 == "2")
                        {
                            perimetro = 2 * (a * b);
                            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);

                        }
                    }
                        break;


                    case "4":
                    {
                        Console.WriteLine("¿Que desea calcular del romboide?");
                        Console.WriteLine("1. Area      2. Perímetro");

                        opcion2 = Convert.ToString(Console.ReadLine());

                        if (opcion2 == "1")
                        {
                            area = b * a;
                            Console.WriteLine("El area del romboide es: " + area);
                        }
                        if (opcion2 == "2")
                        {
                            perimetro = 2 * (b+c);
                            Console.WriteLine("El perimetro del romboide es: " + perimetro);

                        }

                    }
                        break;

            } Console.ReadKey();
        } 
    } 
}
