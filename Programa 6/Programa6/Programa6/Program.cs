using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escriba un número mayor que 1: ");
            string leerlineauno = Console.ReadLine();
            int convertirenterouno = int.Parse(leerlineauno);

            int contador = 0;
            // Un número entero mayor que 1 es primo si es divisible únicamente por 1 y por sí mismo.
            if (convertirenterouno < 1)
            {
                Console.WriteLine("¡Le he pedido un número entero mayor que 1!");
            }

            for (int i = 1; i <= convertirenterouno; i++)
            {

                int numero = convertirenterouno % i;



                if (numero == 0)
                {
                    contador = contador + 1;
                }

                if (contador > 2)
                {
                    Console.WriteLine("NO es primo");
                    return;
                }
                if (convertirenterouno == i && contador <= 2)
                {


                    Console.WriteLine("Es primo");
                    return;


                }

            }

        }

    }


}

