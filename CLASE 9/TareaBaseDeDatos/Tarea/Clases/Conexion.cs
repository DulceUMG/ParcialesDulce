using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Tarea.Clases
{
    public class Conexion
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection archivo = new SqlConnection(ConfigurationManager.ConnectionStrings["setting"].ConnectionString);

            if (archivo.State== ConnectionState.Open)
            {
                archivo.Close();
            }
            else
            {
                archivo.Open();
            }
            return archivo;
        }
    }
}
