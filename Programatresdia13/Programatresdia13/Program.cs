using System;

namespace Programatresdia13
{
    class Program
    {
        public static string generaletra(int min, int max) 

        {
            Random ran = new Random(); // Generara numeros aleatorios, en este caso generará codigo y la letra aleatoriamente 
           int  NUM = Convert.ToInt32(ran.Next(100)); // Generará el inicio y el final del parametro ingresado, genera numeros seudo-aleatorios 
            string LetraRespueta = " "; 
            if (((NUM > min) & (NUM < max))) 

            {
                LetraRespueta = Convert.ToString((char)NUM); // Convertira el valor del cararacter de la cantidad ingresada para representarla en pantalla 
         
            }
            return LetraRespueta; 
        }
        static void Main(string[] args)

        {

            byte Cantidad, k;
            
            string linea;
            Console.Write("Cuantos numeros?");
            linea = Console.ReadLine();
            Cantidad = byte.Parse(linea);
           

            string letra = ""; 
            for (k = 1; k <= Cantidad; k++) // 

            {
                letra = letra + generaletra(0,250); // Cantidad que permitira ingresar o parametro permitido a ingresar 
                

            }

            Console.WriteLine($" Token generado={letra}");


        }
    }
}
