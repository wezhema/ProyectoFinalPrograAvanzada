using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessLayer.Entidades;

namespace DataAccessLayer
{
    //Aquí realizamos todas las funciones y constructores de la base de datos, lectura y escritura
    public class DatosDB
    {
        private string cadena;//Variable para almacenar el string de la DB
        public DatosDB()
        {
            cadena = ConfigurationManager.ConnectionStrings["conexionBaseDeDatos"].ConnectionString;
        }

        public bool LoginCliente(string username, string password)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            string sentenciaSQL;//Variable que almacenara la sentencia
            SqlDataReader reader;//Ejecuta sentencias SQL

            sentenciaSQL = @"select Contrasenia from Conductor where NombreUsuario = @username";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentenciaSQL;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@username", username);

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)//Si hay datos los agrega a la lista para luego desplegarlas en la GUI
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            conexion.Close();
            return false;
        }

        public bool LoginAdministrador(string username, string password)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            string sentenciaSQL;//Variable que almacenara la sentencia
            SqlDataReader reader;//Ejecuta sentencias SQL

            sentenciaSQL = @"select Contrasenia from Administrador where Usuario = @username";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentenciaSQL;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@username", username);

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)//Si hay datos los agrega a la lista para luego desplegarlas en la GUI
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            
            conexion.Close();
            return false;
        }

        public List<Conductor> ConductoresPendientes()//Lee tabla de Conductores
        {
            List<Conductor> listaConductoresPendientes = new List<Conductor>();

            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            string sentenciaSQL;//Variable que almacenara la sentencia
            SqlDataReader reader;//Ejecuta sentencias SQL

            sentenciaSQL = @"select* from Alumno where Dsc_rol = 'PENDIENTE'";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentenciaSQL;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)//Si hay datos los agrega a la lista para luego desplegarlas en la GUI
            {
                while (reader.Read())
                {
                    listaConductoresPendientes.Add(new Conductor
                    {
						//TODO
                    });
                }
            }

            conexion.Close();
            return listaConductoresPendientes;
        }
    }


}
