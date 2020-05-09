using System;
using System.Windows.Forms;
using System.Net.Sockets;
using DataAccessLayer;
using DataAccessLayer.Entidades;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaCliente : Form
    {
        //Instancia de la base de datos
        DatosDB datos = new DatosDB();

        //Variables que almacenarán los datos del conductor
        Conductor conductor;

        public fmVistaCliente()
        {
            InitializeComponent();
            //Al iniciar el form habilitamos el botón de iniciar sesión
            btnLoginCliente.Enabled = true;
            //Al iniciar el form deshabilitamos el botón de de cerrar sesión
            btnDesconectar.Enabled = false;
            //Al iniciar el form deshabilitamos el botón de crear viaje
            btnCrearViajeCliente.Enabled = false;
            //Al iniciar el form habilitamos el botón de registrarse
            btnRegistrarCliente.Enabled = true;
            
            //FALTA
            dgvViajeActivo.DataSource = datos.ObtenerViajes();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            //Botón de salir, salimos de la vista
            this.Close();
        }

        private void btnLoginCliente_Click(object sender, EventArgs e)
        {
            // Si el campo esta rellenado, continue, si no, arroja error
            if (!string.IsNullOrEmpty(txtUsuarioCliente.Text) && !string.IsNullOrEmpty(txtUsuarioCliente.Text) && !string.IsNullOrEmpty(txtContraseniaCliente.Text)) 
            {
                //Si los datos coinciden con la base de datos, continue
                if (datos.LoginCliente(txtUsuarioCliente.Text, txtContraseniaCliente.Text))
                {
                    //Se le asigna al conductor las variables, así se pueden desplegar en fmVistaServidor
                    conductor = new Conductor { NombreUsuario = txtUsuarioCliente.Text, Contrasenia = txtContraseniaCliente.Text };

                    //Se conecta con el cliente TCP
                    if (ClienteTCP.Conectar(conductor))
                    {
                        //Al conectarse:
                        MessageBox.Show("Conexión con éxito.", "Usuario conectado");//Muestra mensaje al conectarse
                        lblEstadoCliente.Text = "Conectado al servidor 127.0.0.1, 16830";//Cambia el label mostrando la conexión
                        //Los siguientes botones se habilitan:
                        btnDesconectar.Enabled = true;//Cerrar sesión
                        btnCrearViajeCliente.Enabled = true;//Crear viaje
                        txtUsuarioCliente.ReadOnly = true;//Usuario solo lectura
                        txtContraseniaCliente.ReadOnly = true;//Contraseña solo lectura
                        //Los siguientes botones se deshabilitan:
                        btnLoginCliente.Enabled = false;//Iniciar sesión
                        btnRegistrarCliente.Enabled = false;//Registrarse
                        btnSalirCliente.Enabled = false;//El botón de salir (necesita cerrar sesión primero)
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
            //Al hacer click en cerrar sesión:
            ClienteTCP.Desconectar(conductor);//Se desconecta de la conexión TCP
            MessageBox.Show(string.Format("Desconexión con éxito.", "Cliente desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information));
            lblEstadoCliente.Text = "Desconectado";
            //Los siguientes botones se habilitan:
            btnRegistrarCliente.Enabled = true;//Registrarse
            btnSalirCliente.Enabled = true;//Salir
            btnLoginCliente.Enabled = true;//Iniciar sesión
            txtUsuarioCliente.ReadOnly = false;//Campo usuario se vuelve editable
            txtContraseniaCliente.ReadOnly = false;//Campo contraseña se vuelve editable
            //Los siguientes botones se deshabilitan:
            btnDesconectar.Enabled = false;//Cerrar sesión
            btnCrearViajeCliente.Enabled = false;//Crear viaje
        }

        private void fmVistaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearViajeCliente_Click(object sender, EventArgs e)
        {
            //Al hacer click en Crear Viaje se muestra el formulario
            fmVistaCrearViaje vCrearViaje = new fmVistaCrearViaje();
            vCrearViaje.Show();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //Al hacer click en Registrarse se muestra dicho formulario
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
