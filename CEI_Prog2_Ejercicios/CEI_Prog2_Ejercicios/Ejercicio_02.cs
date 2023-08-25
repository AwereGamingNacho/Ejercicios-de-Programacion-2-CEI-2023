using System;

namespace Dia
{
    class Program
    {
        public static void Main(string[] args)
        {

            int lados;

            Console.Write("Ingrese la cantidad de lados: ");

            lados = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < lados; i++)
            {
                if (i < lados - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
            for (int i = 0;i < lados-1; i++)
            {
                if (i < lados-2)
                {
                    for (int j = 0; j < lados; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("*");
                        }
                        else if (j == lados - 1)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < lados; j++)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Aca tenes tu cuadradito.");
            Console.WriteLine();
        }
    }
}