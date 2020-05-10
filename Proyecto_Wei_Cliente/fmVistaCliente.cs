using System;
using System.Windows.Forms;
using System.Net.Sockets;
using DataAccessLayer;
using DataAccessLayer.Entidades;
using System.Text;
using Proyecto_Wei_Servidor;

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
            btnFinalizarViaje.Enabled = false;
            btnRefrescar.Enabled = false;
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
                        if (/*datos.ViajeActivo() == null*/ dgvViajeActivo == null)//Verifica si hay viajes activos, si no habilita el botón de crear viaje
                        {
                            btnCrearViajeCliente.Enabled = true;//Crear viaje
                        }
                        txtUsuarioCliente.ReadOnly = true;//Usuario solo lectura
                        txtContraseniaCliente.ReadOnly = true;//Contraseña solo lectura
                        //Los siguientes botones se deshabilitan:
                        btnLoginCliente.Enabled = false;//Iniciar sesión
                        btnRegistrarCliente.Enabled = false;//Registrarse
                        btnSalirCliente.Enabled = false;//El botón de salir (necesita cerrar sesión primero)
                        dgvViajeActivo.DataSource = datos.ViajeActivo(txtUsuarioCliente.Text);
                        btnFinalizarViaje.Enabled = true;
                        btnRefrescar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Verifique la conexión al servidor.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al iniciar sesión, datos incorrectos o conexión no disponible.", "Error");
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
            MessageBox.Show("Desconexión con éxito.", "Cliente desconectado");
            lblEstadoCliente.Text = "Desconectado";
            //Los siguientes botones se habilitan:
            btnRegistrarCliente.Enabled = true;//Registrarse
            btnSalirCliente.Enabled = true;//Salir
            btnLoginCliente.Enabled = true;//Iniciar sesión
            txtUsuarioCliente.ReadOnly = false;//Campo usuario se vuelve editable
            txtContraseniaCliente.ReadOnly = false;//Campo contraseña se vuelve editable
            //Los siguientes botones se deshabilitan:
            btnDesconectar.Enabled = false;//Cerrar sesión
            dgvViajeActivo.Enabled = false;
            btnFinalizarViaje.Enabled = false;
            btnRefrescar.Enabled = false;
        }

        private void fmVistaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearViajeCliente_Click(object sender, EventArgs e)
        {
			if (datos.ValidarSoloUnViajePorConductor(txtUsuarioCliente.Text))
			{
				//Al hacer click en Crear Viaje se muestra el formulario
				fmVistaCrearViaje vCrearViaje = new fmVistaCrearViaje();
				vCrearViaje.Show();
				btnCrearViajeCliente.Enabled = false; 
			}
			else
			{
				MessageBox.Show("Este usuario ya tiene un viaje en curso.")
			}
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (fmVistaServidor.servidorIniciado == true)
            {
                //Al hacer click en Registrarse se muestra dicho formulario
                fmVistaRegistrarCuenta vRegistrarCuenta = new fmVistaRegistrarCuenta();
                vRegistrarCuenta.Show();
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor.", "Error");
            }
            
        }

        private void dgvViajeActivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richtxtbox_TextChanged(object sender, EventArgs e)
        {


            
        }

        private void btnFinalizarViaje_Click(object sender, EventArgs e)
        {
            if (fmVistaServidor.servidorIniciado == true)
            {
				//Llama el método para aprobar conductores
				if (datos.ValidarSoloUnViajePorConductor(txtUsuarioCliente.Text))
				{
					bool resultado = datos.FinalizarViaje(txtUsuarioCliente.Text);
					if (resultado)
					{
						MessageBox.Show("El viaje en curso del usuario: " + txtUsuarioCliente.Text + " ha sido finalizado con éxito.", "Alerta");
						btnCrearViajeCliente.Enabled = true;
					}
					else
					{
						MessageBox.Show("Error, no hay viajes por finalizar.", "Error");
					} 
				}
				else
				{
					MessageBox.Show("Este conductor tiene un viaje en curso.", "Error");
				}

				dgvViajeActivo.DataSource = datos.ViajeActivo(txtUsuarioCliente.Text);
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor.", "Error");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listViajesActivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgvViajeActivo.DataSource = datos.ViajeActivo(txtUsuarioCliente.Text);

            if (datos.ViajeActivo(txtUsuarioCliente.Text) == null)//Verifica si hay viajes activos, si no habilita el botón de crear viaje
            {
                btnCrearViajeCliente.Enabled = true;
            }
            else
            {
                btnCrearViajeCliente.Enabled = false;
            }
        }
    }
}
