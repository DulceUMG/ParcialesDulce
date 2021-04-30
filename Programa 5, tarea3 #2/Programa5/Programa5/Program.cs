using System;

namespace Programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad1, edad2, edad3;
            Console.WriteLine("Ingrese la primera edad del la persona: ");
            edad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda edad de la persona: ");
            edad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera edad de la persona: ");
            edad3 = int.Parse(Console.ReadLine());

            if (edad1 > edad2)

            {
                if (edad1 > edad3)
                {
                    Console.WriteLine("La primera edad es mayor" + edad1);
                }

            }

            else
            {
                if (edad2 > edad3)
                {
                    Console.WriteLine("La segunda edad es mayor" + edad2);
                }

                else
                {
                    Console.WriteLine("La tercera edad es mayor " + edad3);
                }
            }
        }

    }

}

