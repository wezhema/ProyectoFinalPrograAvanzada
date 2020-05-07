using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaServidor : Form
    {
        TcpListener tcpListener;
        Thread subprocesoEscucharClientes;
        bool servidorIniciado;//Bool para retornar si el servidor está iniciado o no

        public fmVistaServidor()
        {
            InitializeComponent();
            btnIniciarServidor.ForeColor = Color.Green;
            btnDetenerServidor.Enabled = false;//Botón de detener desabilitado cuando el de Iniciar esta habilitado
        }

        private void btnSalirServidor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmVistaServidor_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");//Se  pone la IP local
            tcpListener = new TcpListener(local, 16830);//Se declara el puerto
            subprocesoEscucharClientes = new Thread(new ThreadStart(EscucharClientes));//Se llama al subproceso
            subprocesoEscucharClientes.Start();//Se inicia el subproceso
            subprocesoEscucharClientes.IsBackground = true;
            servidorIniciado = true;//Se habilita el servidor
            btnIniciarServidor.Enabled = false;//Se deshabilita el botón de iniciar
            btnDetenerServidor.ForeColor = Color.Red;
            btnDetenerServidor.Enabled = true;//Se habilita el botón de deshabilitar
        }

        private void EscucharClientes()
        {
            tcpListener.Start();//Inicia el TCP
            while (servidorIniciado)//La acción se queda detenida hasta que un cliente se conecte al servidor
            {
                TcpClient client = tcpListener.AcceptTcpClient();//Cuando el cliente se conecta devuelve el llamado y lo almacena en la variable

                Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));//Administra la comunicación con el cliente
                clientThread.Start(client);
            }
        }

        private void ComunicacionCliente(object obj)//Proceso donde se lee lo que el cliente está enviando al servidor
        {
            TcpClient tcpCliente = (TcpClient)obj;
            NetworkStream clienteStream = tcpCliente.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();

            byte[] buffer = new byte[4096];
            int byteleidos;

            while (servidorIniciado)
            {
                byteleidos = 0;
                try
                {
                    byteleidos = clienteStream.Read(buffer, 0, buffer.Length);//Se asigna la información a la variable
                }
                catch (Exception)
                {
                    break;
                }

                string msj = encoder.GetString(buffer, 0, byteleidos);//Almacena los datos en un string y luego los imprime
            }
            tcpCliente.Close();//Cierra conexión
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            btnIniciarServidor.Enabled = true;
            btnDetenerServidor.Enabled = false;
        }
    }
}
