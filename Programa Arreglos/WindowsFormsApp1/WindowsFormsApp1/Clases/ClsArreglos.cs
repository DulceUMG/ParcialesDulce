using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
    class ClsArreglos
    {
        private int[] Arreglotemporal;
        private int[] Datos;
        private int o, l, Datotemporal;
        private int TamanoArreglo = 0;

        public int GetTamanoArreglo()
        {
            return Datos.Length;
        }

        public ClsArreglos(int[] ArregloParametro)
        {
            Datos = ArregloParametro;
            TamanoArreglo = Datos.Length;
        }

        public int[] MetodoBurbuja()
        {
            Arreglotemporal = Datos;
            for (o = 0; o < TamanoArreglo - 1; o++)
            {
                for (l = o + 1; l < TamanoArreglo; l++)
                {
                    if (Arreglotemporal[o] < Arreglotemporal[l])
                    {
                        Datotemporal = Arreglotemporal[o];
                        Arreglotemporal[o] = Arreglotemporal[l];
                        Arreglotemporal[l] = Datotemporal;
                    }
                }
            }
            return Arreglotemporal;
        }

        private string[] DatosN;
        private string[] DatoR;
        private string Datosf;

        public ClsArreglos(string[] arreglos)
        {
            DatoR = arreglos;
            TamanoArreglo = DatoR.Length;
        }

        public string[] Burbujita()  // Nuevo metodo Burbujita para, nos ayudara a ordenar los nombres de la A a la Z 
        {
            DatosN = DatoR;

            for (o = 0; o < TamanoArreglo - 1; o++)
            {
                for (l = o + 1; l < TamanoArreglo; l++)
                {
                    if (DatosN[o].CompareTo(DatosN[l]) > 0) // Compara el primer objeto que implementa con el otro objeto
                    {

                        Datosf = DatosN[o];
                        DatosN[o] = DatosN[l];
                        DatosN[l] = Datosf;

                    }
                }
            }

            return DatosN;
        }
    }
}
