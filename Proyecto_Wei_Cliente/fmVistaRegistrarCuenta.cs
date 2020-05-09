using DataAccessLayer.Entidades;
using System;
using System.Windows.Forms;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaRegistrarCuenta : Form
    {
        public fmVistaRegistrarCuenta()
        {
            InitializeComponent();
        }

        private void btnSalirRegistrarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmVistaRegistrarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
            MessageBox.Show("Registro con éxito.", "Atención");
        }
    }
}
