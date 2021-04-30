using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int a;
            int P = 0;
            while (numero <=1000)
            {
                for (a = 1; a <= numero; a++)
                {
                    if (numero % a == 0)
                        {
                            P = P + 1;
                        }

                }
                if (P == 2)
                {
                    Console.WriteLine("numero primo");
                }
                else
                {
                    Console.WriteLine("No es numero primo");
                }
            }
            
        }
    }
}
