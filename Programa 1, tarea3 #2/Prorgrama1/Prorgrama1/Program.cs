using System;

namespace Prorgrama1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, r;
            Console.WriteLine("Ingrese un numero para mostrar la tabla de multiplicar");
            a = float.Parse(Console.ReadLine());

                for ( int i = 0; i <= 10; i++)

            {
                r = (float)(a * i);
                Console.WriteLine($"La tabla de {a} POR {i} = " + r); 
            }
        }
    }
}
