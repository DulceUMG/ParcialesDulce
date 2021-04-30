using System;
using System.Threading;

namespace Programadia13
{
    class Program

    {

        public static string Mid(string parametro, int startindex, int length )
        {
            string result = parametro.Substring(startindex, length);
            return result; 
        }
        static void Main(string[] args)
        {
            string Nombre;
            string car;
            int SumaraUnCaracter = 0;
            int QuitarUnCaracter = 0;
            int TamañoDelcarater = 0;
            int PosiciondelCursor = 0;

            Console.Write("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.SetCursorPosition(1,12); // Escala del cursor 
            Console.Write(Nombre);
            TamañoDelcarater = Nombre.Length; // Determinara el tamaño del caracter ingresado 
            PosiciondelCursor = 70; // Le dara la posición al cursor, después de ingresar el dato 
            Nombre = Nombre.ToUpper(); // 
            for (QuitarUnCaracter = Nombre.Length; QuitarUnCaracter >= 1; QuitarUnCaracter--)

            {
                car = Mid(Nombre, QuitarUnCaracter -1, 1); // le quitara la cantidad calculada del tamaño del caracter 
                for (SumaraUnCaracter =TamañoDelcarater; SumaraUnCaracter <= PosiciondelCursor; SumaraUnCaracter++) // Aumentara un + 1 a la posicion del cursor 
                {
                    Console.SetCursorPosition(SumaraUnCaracter, 12); // El parametro se sumara a la posición 71 
                    Console.Write(" " + car);
                    Thread.Sleep(50); // Pausara la ejecucion durante ese minimo tiempo 
                }
                PosiciondelCursor = PosiciondelCursor = -1;
                TamañoDelcarater = TamañoDelcarater = -1; 
            }



        }
    }
}
