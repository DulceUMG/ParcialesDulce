using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {

                int año;

                Console.WriteLine("Ingrese año");
                año = int.Parse(Console.ReadLine());
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine("El año {0} es bisiesto", año);
                }

                else
                {
                    Console.WriteLine("El año {0} no es bisiesto", año);
                }

                Console.ReadLine();
            }

           
        }
    }

