using DataAccessLayer.Entidades;
using System;
using System.Windows.Forms;
using Proyecto_Wei_Servidor;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaRegistrarCuenta : Form
    {
        public fmVistaRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (fmVistaServidor.servidorIniciado == true)
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtAnio.Text) && !string.IsNullOrEmpty(txt1Apellido.Text) && !string.IsNullOrEmpty(txt2Apellido.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtEstado.Text) && !string.IsNullOrEmpty(txtMarca.Text) && !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtPlaca.Text))
                {
                    Conductor conductor = new Conductor()
                    {
                        Nombre = txtNombre.Text,
                        Anio = txtAnio.Text,
                        Apellido1 = txt1Apellido.Text,
                        Apellido2 = txt2Apellido.Text,
                        Contrasenia = txtPass.Text,
                        Estado = txtEstado.Text,
                        Marca = txtMarca.Text,
                        NombreUsuario = txtUsuario.Text,
                        Placa = txtPlaca.Text
                    };
                    ClienteTCP.Registrar(conductor);
                    this.Close();
                    MessageBox.Show("Registro con éxito.", "Atención");//Mensaje de éxito
                }
                else
                {
                    MessageBox.Show("No puede haber campos vacíos.", "Error");
                }
                
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor.", "Error");
            } 
        }

        private void btnSalirRegistrarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fmVistaRegistrarCuenta_Load(object sender, EventArgs e)
        {
        }
    }
}
