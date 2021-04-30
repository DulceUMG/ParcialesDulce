using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo = 0;
            string seleccion = "";

            string valor = "";
            double pi = 3.14159;

            double radianes = 0;
            double grados = 0;

            Console.WriteLine("1. Radianes a grados, 2. grados a radianes");
            seleccion = Console.ReadLine();

            Console.WriteLine("Ingrese el anguno a convertir");
            valor = Console.ReadLine();
            angulo = Convert.ToDouble(valor);

            if (seleccion == "1")

            {
                grados = angulo * (180.0 / pi);

            }
            Console.WriteLine("{0} radianes son {1} grados", radianes, grados);

        

            if (seleccion == "2")

            {  
                radianes = angulo* (pi / 180.0);

            Console.WriteLine("{0} grados son {1} radianes", grados, radianes);

            }
        } 
    }
}









