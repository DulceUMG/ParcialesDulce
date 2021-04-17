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
        private int D, M, Datotemporal;
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
            for (D = 0; D < TamanoArreglo - 1; D++)
            {
                for (M = D + 1; M < TamanoArreglo; M++)
                {
                    if (Arreglotemporal[D] > Arreglotemporal[M])
                    {
                        Datotemporal = Arreglotemporal[D];
                        Arreglotemporal[D] = Arreglotemporal[M];
                        Arreglotemporal[M] = Datotemporal;
                    }
                }
            }
            return Arreglotemporal;
        }

        private string[] DNAME;
        private string[] DRESULT;
        private string DFINISH;

        public ClsArreglos(string[] arreglos)
        {
            DRESULT = arreglos;
            TamanoArreglo = DRESULT.Length;
        }

        public string[] BURBUJA()  // Nuevo metodo Burbujita para, nos ayudara a ordenar los nombres de la A a la Z 
        {
            DNAME = DRESULT;

            for (D = 0; D < TamanoArreglo - 1; D++)
            {
                for (M = D + 1; M < TamanoArreglo; M++)
                {
                    if (DNAME[D].CompareTo(DNAME[M]) > 0) // Compara el primer objeto que implementa con el otro objeto
                    {

                        DFINISH = DNAME[D];
                        DNAME[D] = DNAME[M];
                        DNAME[M] = DFINISH;

                    }
                }
            }

            return DNAME;
        }
    }
}
