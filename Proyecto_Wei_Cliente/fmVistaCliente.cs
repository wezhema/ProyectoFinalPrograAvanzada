using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SqlClient;
using DataAccessLayer;
using DataAccessLayer.Entidades;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaCliente : Form
    {
        DatosDB datos = new DatosDB();

        bool clienteConectado;
        TcpClient cliente;
        Conductor conductor;

        public fmVistaCliente()
        {
            InitializeComponent();
            btnLoginCliente.Enabled = true;
            btnDesconectar.Enabled = false;
            btnCrearViajeCliente.Enabled = false;
            btnRegistrarCliente.Enabled = true;
            dgvViajeActivo.DataSource = datos.ObtenerViajes();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginCliente_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUsuarioCliente.Text) && !string.IsNullOrEmpty(txtUsuarioCliente.Text) && !string.IsNullOrEmpty(txtContraseniaCliente.Text)) // Si el campo esta rellenado, continue, si no, arroja error
            {
                if (datos.LoginCliente(txtUsuarioCliente.Text, txtContraseniaCliente.Text))
                {
                    conductor = new Conductor { NombreUsuario = txtUsuarioCliente.Text, Contrasenia = txtContraseniaCliente.Text };//Se le asigna al conductor las variables, así se pueden desplegar en fmVistaServidor

                    if (ClienteTCP.Conectar(conductor))
                    {

                        MessageBox.Show("Conexión con éxito.", "Usuario conectado");
                        clienteConectado = true;
                        lblEstadoCliente.Text = "Conectado al servidor 127.0.0.1, 16830";
                        clienteConectado = true;
                        btnLoginCliente.Enabled = false;
                        btnDesconectar.Enabled = true;
                        btnCrearViajeCliente.Enabled = true;
                        txtUsuarioCliente.ReadOnly = true;
                        txtContraseniaCliente.ReadOnly = true;
                        btnRegistrarCliente.Enabled = false;
                        btnSalirCliente.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Verifique la conexión al servidor.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al iniciar sesión, datos incorrectos.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar su usuario y contraseña.", "Alerta");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {

            ClienteTCP.Desconectar(conductor);
            MessageBox.Show(string.Format("Desconexión con éxito.", "Cliente desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information));
            lblEstadoCliente.Text = "Desconectado";
            btnLoginCliente.Enabled = true;
            btnDesconectar.Enabled = false;
            btnCrearViajeCliente.Enabled = false;
            txtUsuarioCliente.ReadOnly = false;
            txtContraseniaCliente.ReadOnly = false;
            clienteConectado = false;
            btnRegistrarCliente.Enabled = true;
            btnSalirCliente.Enabled = true;
        }

        private void fmVistaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearViajeCliente_Click(object sender, EventArgs e)
        {
            fmVistaCrearViaje vCrearViaje = new fmVistaCrearViaje();
            vCrearViaje.Show();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            fmVistaRegistrarCuenta vRegistrarCuenta = new fmVistaRegistrarCuenta();
            vRegistrarCuenta.Show();
        }

        private void dgvViajeActivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
