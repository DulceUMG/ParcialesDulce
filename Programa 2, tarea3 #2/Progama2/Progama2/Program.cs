using System;

namespace Progama2
{
    class Program
    {
        static int potenciaDedosnumeros(int a, int Exponente)

        {
            if (Exponente == 0)
                return 1;

            else
                return a * potenciaDedosnumeros(a, Exponente - 1);
        }
        static void Main(string[] args)
        {
            int a, Exponente;
            Console.WriteLine("Ingrese unb dato numerico: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la potencia: ");
            Exponente = int.Parse(Console.ReadLine());

            Console.WriteLine("La potencia de los numeros ingresado es: " + potenciaDedosnumeros(a, Exponente));

        }

    }

}