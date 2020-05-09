using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace DataAccessLayer.Entidades
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient clienteTCP;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        public static bool Conectar(Conductor conductor)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                clienteTCP = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 16830);
                clienteTCP.Connect(serverEndPoint);

                MensajeSocket<Conductor> mensajeConectar = new MensajeSocket<Conductor> { Mensaje = "Conectar", Valor = conductor };

                clienteStreamReader = new StreamReader(clienteTCP.GetStream());
                clienteStreamWriter = new StreamWriter(clienteTCP.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();

                return true;
            }
            catch (SocketException ex)
            {
                throw;
            }
            
        }

        public static void Desconectar(Conductor conductor)
        {
            MensajeSocket<Conductor> mensajeDesconectar = new MensajeSocket<Conductor> { Mensaje = "Desconectar", Valor = conductor };
            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();

            clienteTCP.Close();
        }

    }

    
}
