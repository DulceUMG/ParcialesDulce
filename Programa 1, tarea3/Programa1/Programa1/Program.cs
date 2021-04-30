using System;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese cualquier numero");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }

            else
            {
                Console.WriteLine("El numero no es par");
            }
        
        }
    }
}
