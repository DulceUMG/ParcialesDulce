using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    class Cliente
    {
        private float descuento;
        private float precio;
        public void Inicio()
        {
            Console.WriteLine("INGRESE PRECIO: ");
            precio = float.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Descuento()
        {
            if (precio > 300)
            {
                float res = (precio * 20) / 100;
                descuento = precio - res;
                Console.WriteLine("MegaPalza");
                Console.WriteLine("DESCUENTO DEL 20% POR SUPERAR  LOS 300 QUETZALES");
                Console.WriteLine("Precio es: " + descuento);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("MegaPlaza");

                Console.WriteLine("Precio es: " + precio);
                Console.ReadLine();

            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("MegaPlaza");
            Cliente clie = new Cliente();
            clie.Inicio();
            clie.Descuento();

        }

    }
}