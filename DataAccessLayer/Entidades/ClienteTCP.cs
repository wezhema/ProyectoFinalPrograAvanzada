using System.IO;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace DataAccessLayer.Entidades
{
    //Clase para encapsular los datos que envía el cliente hacia el servidor
    public class ClienteTCP
    {
        private static IPAddress ipServidor; //Se declara la IP por la cual se enviarán los datos
        private static TcpClient clienteTCP; //Se declara la variable para la conexión TCP
        private static IPEndPoint serverEndPoint;//Variable para el puerto
        private static StreamWriter clienteStreamWriter;//Variable para la escritura en encapsulamiento
        private static StreamReader clienteStreamReader;//Variable para la lectura de encapsulamiento

        //Método para enviar la información de inicio de sesión del conductor
        public static bool Conectar(Conductor conductor)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");//Se declara la IP igual al servidor
                clienteTCP = new TcpClient();//Se abre una conexión TCP
                serverEndPoint = new IPEndPoint(ipServidor, 16830);//Se asigna el puerto
                clienteTCP.Connect(serverEndPoint);//Se utiliza el puerto en la conexión TCP

                //Se llama el switch realizado en el servidor que llamará dicha función o método
                MensajeSocket<Conductor> mensajeConectar = new MensajeSocket<Conductor> { Mensaje = "Conectar", Valor = conductor };

                clienteStreamReader = new StreamReader(clienteTCP.GetStream());//Se realiza la lectura de los datos
                clienteStreamWriter = new StreamWriter(clienteTCP.GetStream());//Se realiza la escritura de los datos
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));//Se encapsulan los datos para ser enviados
                clienteStreamWriter.Flush();//Se limpia el buffer o el canal para poder escribir en él luego

                return true;//Retorna verdadero si fue exitoso
            }
            catch (SocketException ex)
            {
                throw;
            }
        }

        //Método para indicar que el conductor cierra la sesión
        public static void Desconectar(Conductor conductor)
        {
            MensajeSocket<Conductor> mensajeDesconectar = new MensajeSocket<Conductor> { Mensaje = "Desconectar", Valor = conductor };
            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            
            //Función para cerrar la conexión TCP
            clienteTCP.Close();
        }

        //Método para enviar los datos del registro del conductor
		public static void Registrar(Conductor conductor)
		{
			try
			{
				ipServidor = IPAddress.Parse("127.0.0.1");
				clienteTCP = new TcpClient();
				serverEndPoint = new IPEndPoint(ipServidor, 16830);
				clienteTCP.Connect(serverEndPoint);

				MensajeSocket<Conductor> mensajeConectar = new MensajeSocket<Conductor> { Mensaje = "Registrarse", Valor = conductor };

				clienteStreamReader = new StreamReader(clienteTCP.GetStream());
				clienteStreamWriter = new StreamWriter(clienteTCP.GetStream());
				clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
				clienteStreamWriter.Flush(); 
			}
			catch (SocketException ex)
			{
				throw;
			}
		}

        //Método para enviar los datos del formulario al servidor sobre crear el viaje desde el conductor
        public static void CrearViaje (Viajes viajes)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                clienteTCP = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 16830);
                clienteTCP.Connect(serverEndPoint);

                MensajeSocket<Viajes> mensajeCrearViaje = new MensajeSocket<Viajes> { Mensaje = "CrearViaje", Valor = viajes };

                clienteStreamReader = new StreamReader(clienteTCP.GetStream());
                clienteStreamWriter = new StreamWriter(clienteTCP.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCrearViaje));
                clienteStreamWriter.Flush();
            }
            catch (SocketException ex)
            {
                throw;
            }
        }

    }

    
}
