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
using Proyecto_Wei_Principal;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaCliente : Form
    {
        DatosDB datos = new DatosDB();//asd

        bool clienteConectado;
        TcpClient cliente;

        public fmVistaCliente()
        {
            InitializeComponent();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuarioCliente.Text))//Si el campo esta rellenado, continue, si no, arroja error
            {
                if (datos.Login(txtUsuarioCliente.Text, txtContraseniaCliente.Text))
                {
                    try
                    {
                        IPAddress ipServidor = IPAddress.Parse("127.0.0.1");//Se asigna la IP
                        cliente = new TcpClient();
                        IPEndPoint serverEndPoint = new IPEndPoint(ipServidor, 30000);//Se asigna el puerto

                        cliente.Connect(serverEndPoint);//Cliente se conecta al endpoint
                        NetworkStream clienteStream = cliente.GetStream();
                        ASCIIEncoding encoder = new ASCIIEncoding();

                        byte[] buffer = encoder.GetBytes(txtUsuarioCliente.Text);
                        clienteStream.Write(buffer, 0, buffer.Length);
                        clienteStream.Flush();

                        lblEstadoCliente.Text = "Conectado al servidor 127.0.0.1, 30000";
                        clienteConectado = true;
                        MessageBox.Show(string.Format("Conexión con éxito.", "Cliente conectado", MessageBoxButtons.OK, MessageBoxIcon.Information));
                        btnLoginCliente.Enabled = false;
                        btnDesconectar.Enabled = true;
                        btnCrearViajeCliente.Enabled = true;
                        txtUsuarioCliente.ReadOnly = true;
                        txtContraseniaCliente.ReadOnly = true;
                    }
                    catch (SocketException)
                    {
                        MessageBox.Show("Verifique la conexión al servidor.", "Error intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al iniciar sesión.", "Error intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar su nombre antes de iniciar la conexión.");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            cliente.Close();
            MessageBox.Show(string.Format("Desconexión con éxito.", "Cliente desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information));
            lblEstadoCliente.Text = "Desconectado";
            btnLoginCliente.Enabled = true;
            btnDesconectar.Enabled = false;
            btnCrearViajeCliente.Enabled = false;
            txtUsuarioCliente.ReadOnly = false;
            txtContraseniaCliente.ReadOnly = false;
        }

        private void fmVistaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
