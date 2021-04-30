using System;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            string promedio, medicina;
            float P, R;
            Console.WriteLine("El producto es la medicina (1. si, 2. no) Escriba 1 si lo es, si no 2");
            medicina = Console.ReadLine();

            if (medicina == "1")

            {
                Console.WriteLine("Estimado usuario, no debe de pagar el impuesto de esta categoria");
            }

            else
            {
                Console.WriteLine("Ingrese el nombre del producto");
                promedio = Console.ReadLine();

                Console.WriteLine("Ingrese el precio del producto");
                P = float.Parse(Console.ReadLine());

                R = (float)(P * 0.12);

                Console.WriteLine("Nombre del pruducto:" + P );
                Console.WriteLine("Impuesto a pagar: " + R);

             }
         
        }
    }
}
