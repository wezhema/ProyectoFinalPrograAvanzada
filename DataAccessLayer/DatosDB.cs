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

            sentenciaSQL = @"SELECT Contrasenia FROM Conductor WHERE NombreUsuario = @username AND Estado = 'APROBADO'";

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

        public List<Conductor> ObtenerConductores()//Lee tabla de Conductores
        {
            List<Conductor> listaConductoresPendientes = new List<Conductor>();

            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            string sentenciaSQL;//Variable que almacenara la sentencia
            SqlDataReader reader;//Ejecuta sentencias SQL

            sentenciaSQL = @"SELECT* FROM Conductor";

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
                        Id_Conductor = reader.GetInt32(0),
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

                sentenciaSQL = @"UPDATE Conductor SET Estado = 'APROBADO' WHERE Estado = 'PENDIENTE'";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.Connection = conexion;

                conexion.Open();

                int numeroLineasAfectadas = comando.ExecuteNonQuery();//Devuelve el número de líneas afectadas

                if (numeroLineasAfectadas == 0)
                {
                    return false;
                }

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

                sentenciaSQL = @"UPDATE Conductor SET Estado = 'DENEGADO' WHERE Estado = 'PENDIENTE'";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.Connection = conexion;

                conexion.Open();

                int numeroLineasAfectadas = comando.ExecuteNonQuery();//Devuelve el número de líneas afectadas

                if (numeroLineasAfectadas == 0)
                {
                    return false;//Para indicar que hubo un error
                }

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

                sentenciaSQL = @"INSERT INTO Conductor (Nombre, Apellido1, Apellido2, Estado , NombreUsuario, Contrasenia, Placa, Marca, Anio)
					VALUES(@Nombre,@Apellido1,@Apellido2 ,@Estado ,@NombreUsuario ,@Contrasenia ,@Placa ,@Marca ,@Anio)";

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
        public bool CrearViaje(Viajes viajes)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                SqlCommand comando = new SqlCommand();
                string sentenciaSQL;//Variable que almacenara la sentencia 

                sentenciaSQL = @"INSERT INTO VIAJES (Id_Conductor, PuntoPartida, PuntoDestino, Desc_Viaje, Can_Horas, Estado) 
                            VALUES (@Id_Conductor, @PuntoPartida, @PuntoDestino, @Desc_Viaje, @Can_Horas, @Estado)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.Parameters.AddWithValue("@Id_Conductor", viajes.Id_Conductor);
                comando.Parameters.AddWithValue("@PuntoPartida", viajes.PuntoPartida);
                comando.Parameters.AddWithValue("@PuntoDestino", viajes.PuntoDestino);
                comando.Parameters.AddWithValue("@Desc_Viaje", viajes.Desc_Viaje);
                comando.Parameters.AddWithValue("@Can_Horas", viajes.Can_Horas);
                comando.Parameters.AddWithValue("@Estado", viajes.Estado);

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
        public List<Viajes> ObtenerViajes()
        {
            List<Viajes> listaViajesPendientes = new List<Viajes>();

            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand();
            string sentenciaSQL;//Variable que almacenara la sentencia
            SqlDataReader reader;//Ejecuta sentencias SQL

            sentenciaSQL = @"SELECT* FROM Viajes WHERE Estado = 'EN CURSO'";//falta poner la condicion para que llame solo los viajes de ese usuario

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentenciaSQL;
            //comando.Parameters.AddWithValue("@Id_Conductor", .Id_Conductor);
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)//Si hay datos los agrega a la lista para luego desplegarlas en la GUI
            {
                while (reader.Read())
                {
                    listaViajesPendientes.Add(new Viajes
                    {
                        Id_Conductor = reader.GetString(0),
                        Id_Viaje = reader.GetInt32(1),
                        PuntoPartida = reader.GetString(2),
                        PuntoDestino = reader.GetString(3),
                        Desc_Viaje = reader.GetString(4),
                        Can_Horas = reader.GetString(5),
                        Estado = reader.GetString(6),
                    });
                }
            }

            conexion.Close();
            return listaViajesPendientes;
        }
        //public List<Conductor> ObtenerIDConductor(Conductor conductor)
        //{
        //    List<Conductor> listaObtenerIDConductor = new List<Conductor>();

        //    SqlConnection conexion = new SqlConnection(cadena);
        //    SqlCommand comando = new SqlCommand();
        //    string sentenciaSQL;//Variable que almacenara la sentencia
        //    SqlDataReader reader;//Ejecuta sentencias SQL

        //    sentenciaSQL = @"SELECT Id_Conductor FROM Conductor WHERE NombreUsuario =  @Username";

        //    comando.CommandType = CommandType.Text;
        //    comando.CommandText = sentenciaSQL;
        //    comando.Parameters.AddWithValue("@Username", conductor.NombreUsuario);
        //    comando.Connection = conexion;

        //    conexion.Open();

        //    reader = comando.ExecuteReader();

        //    if (reader.HasRows)//Si hay datos los agrega a la lista para luego desplegarlas en la GUI
        //    {
        //        while (reader.Read())
        //        {
        //            listaObtenerIDConductor.Add(new Conductor
        //            {
        //                Id_Conductor = reader.GetInt32(0)
        //            });
        //        }
        //    }

        //    conexion.Close();
        //    return listaObtenerIDConductor;
        //}


    }
}