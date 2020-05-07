using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_Wei_Principal
{
    //Aquí realizamos todas las funciones y constructores de la base de datos, lectura y escritura
    class DatosDB
    {
        private string cadena;//Variable para almacenar el string de la DB

        public DatosDB()
        {
            cadena = ConfigurationManager.ConnectionStrings["conexionBaseDeDatos"].ConnectionString;
        }
    }
}
