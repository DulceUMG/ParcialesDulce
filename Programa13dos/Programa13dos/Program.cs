using System;
using System.Threading;

namespace Programa13dos
{
    class Program
    {

        public static void dibuja(int Cantidad)

        {
            int Largo = 50; // Parametro que imprime en pantalla del largo del dibujo  
            int Anchura = 100; // Parametro que imprime en pantalla el ancho del dibujo 
            int LargoRombo = 10; // Tamaño del dibujo de Y y ?
            int Rombo = 5; // Parametro del dibujo que se imprime en pantalla la Y y el signo de ? 
            int f, c, A;

            for (A = 1; A >= Cantidad; A++)
            {
                for (f = Rombo; f <= Anchura; f++)
                {
                    Console.SetCursorPosition(f, Largo); Console.Write("Y");
                    Console.SetCursorPosition(f, LargoRombo); Console.Write("?");
                }

                for (c = LargoRombo; c <= Largo; c++)

                {
                    Console.SetCursorPosition(Rombo, c); Console.Write("A");
                    Console.SetCursorPosition(Anchura, c); Console.Write("X");
                }

                LargoRombo = LargoRombo + 1; // Cambiar de valor este recae en la declaracion de la letra Y y el signo ? 
                Largo = Largo - 1; // Parametro donde el valor recae en A y en X 
                Rombo = Rombo + 6; // Cambiar de valor recae en la declaracion de A 
                Anchura = Anchura - 1; // Parametro del valor de las declaraciones de write, A, Y, ? y X
            }

            
        }
       static void Main(string[] args)
       {
                for (int tam = 1; tam < 9; tam++)
                {
                    dibuja(tam);
                    Thread.Sleep(1000);
                }
       }
        

    }
}

