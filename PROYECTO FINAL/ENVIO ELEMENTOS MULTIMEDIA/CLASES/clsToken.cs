using System;
using System.Collections.Generic;
using System.Text;

namespace CHAT_BOT.CLASES
{
    class clsToken
    {
        public string GenerarCodigo()
        {
            Random obj = new Random();
            String sCadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            int longitud = sCadena.Length;
            int nlongitud = 5;
            string sNuevacadena = "";

            for (int i=0; i< nlongitud; i++)
            {
                int a = obj.Next(sCadena.Length);
                sNuevacadena += sCadena[a];
            }
            return sNuevacadena;

        }  
    }
}
