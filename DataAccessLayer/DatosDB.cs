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

            sentenciaSQL = @"select* from Conductor where Estado = 'PENDIENTE'";

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
						Id_Conductor = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Apellido1 = reader.GetString(2),
                        Apellido2 = reader.GetString(3),
                        Estado = reader.GetString(4),
                        NombreUsuario = reader.GetString(5),
                        Contrasenia = reader.GetString(6),
                        Placa = reader.GetString(7),
                        Marca = reader.GetString(8),
                        Anio = reader.GetString(9),
                    });
                }
            }

            conexion.Close();
            return listaConductoresPendientes;
        }

        public bool AprobarConductores()
        {

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand comando = new SqlCommand();
                string sentenciaSQL;//Variable que almacenara la sentencia

                sentenciaSQL = @"update Conductor set Estado = 'APROBADO' where Estado = 'PENDIENTE'";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.Connection = conexion;

                conexion.Open();

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }
        public bool DenegarConductores()
        {

            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand comando = new SqlCommand();
                string sentenciaSQL;//Variable que almacenara la sentencia

                sentenciaSQL = @"update Conductor set Estado = 'DENEGADO' where Estado = 'PENDIENTE'";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.Connection = conexion;

                conexion.Open();

                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool RegistrarConductor(Conductor conductor)//Lee tabla de Conductores
        {
			try
			{
				SqlConnection conexion = new SqlConnection(cadena);
				SqlCommand comando = new SqlCommand();
				string sentenciaSQL;//Variable que almacenara la sentencia 

				sentenciaSQL = @"INSERT INTO [dbo].[Conductor]
						([Nombre]
						,[Apellido1]
						,[Apellido2]
						,[Estado]
						,[NombreUsuario]
						,[Contrasenia]
						,[Placa]
						,[Marca]
						,[Anio])
					VALUES
						(@Nombre 
						,@Apellido1 
						,@Apellido2 
						,@Estado 
						,@NombreUsuario 
						,@Contrasenia 
						,@Placa 
						,@Marca 
						,@Anio)";

				comando.CommandType = CommandType.Text;
				comando.CommandText = sentenciaSQL;
				comando.Parameters.AddWithValue("@Nombre", conductor.Nombre);
				comando.Parameters.AddWithValue("@Apellido1", conductor.Apellido1);
				comando.Parameters.AddWithValue("@Apellido2", conductor.Apellido2);
				comando.Parameters.AddWithValue("@Estado", conductor.Estado);
				comando.Parameters.AddWithValue("@NombreUsuario", conductor.NombreUsuario);
				comando.Parameters.AddWithValue("@Contrasenia", conductor.Contrasenia);
				comando.Parameters.AddWithValue("@Placa", conductor.Placa);
				comando.Parameters.AddWithValue("@Marca", conductor.Marca);
				comando.Parameters.AddWithValue("@Anio", conductor.Anio);
				comando.Connection = conexion;

				conexion.Open();

				comando.ExecuteNonQuery();

				conexion.Close();

				return true;
			}
			catch (System.Exception ex)
			{
				return false;
			}
        } 
	} 
} 