using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Clases
{
    class ClsAutomotor
    {
        public String marca { get; }
        public int vel_max { get; }

        public String color { get; set; }
        private int velocidadActual = 0;

        public int FrenarDespacio { get; }

        public bool encendido { get; set; } = false;


        public ClsAutomotor(string marcaCarro, int maxvel)
        {
            this.vel_max = maxvel;
            this.marca = marcaCarro;

        }

        public ClsAutomotor(string marcaCarro, int maxvel, string ColorCarro)
        {
            this.vel_max = maxvel;
            this.marca = marcaCarro;
            this.color = ColorCarro;

        }


        public string encender()
        {
            string respueta = "";
            if (encendido)
            {


                encendido = false;
                respueta = "Ahora el carro esta apagado";
            } else
            {

                encendido = true;
                respueta = "Listo, pon waze para que no te pierdas";
            }

            velocidadActual = 0;
            return respueta;
        }


        public string DetenerMarcha()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }

            velocidadActual = 0;
            return "AutoDetenido";

        }


        public string Acelerar()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }

            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"Parale chatio, ya llegaste al tope{vel_max} KPH";
            } else
            {
                velocidadActual = velocidadActual + 10;
                return $"Vas a  {velocidadActual} KPH";
            }

        }

        public string Frenarmaslento()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }

            if (velocidadActual == FrenarDespacio)
            {
                velocidadActual = FrenarDespacio; 
                return $"Bajaste a la velocidad de {FrenarDespacio} KPH";
            }
            else
            {
                velocidadActual = velocidadActual - 10;
                return $"Vas a  {velocidadActual} KPH";
            }

        }


    }
}
