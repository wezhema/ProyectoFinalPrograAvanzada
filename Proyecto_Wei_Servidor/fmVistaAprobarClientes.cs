using DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaAprobarClientes : Form
    {
		DatosDB datos = new DatosDB();

        public fmVistaAprobarClientes()
        {
            InitializeComponent();
            dgtClientesSinAprobar.DataSource = datos.ObtenerConductores();//Obtiene todos los conductores de la DB
        }

        private void btnSalirAprobarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAprobarCliente_Click(object sender, EventArgs e)
        {
            //Llama el método para aprobar conductores
            bool resultado = datos.AprobarConductores();
            if (resultado)
            {
                MessageBox.Show("Los conductores pendientes han sido aprobados con éxito.", "Alerta");
            }
            else
            {
                MessageBox.Show("Error, no hay conductores por aprobar.", "Error");
            }

            dgtClientesSinAprobar.DataSource = datos.ObtenerConductores();
        }

        private void btnDenegarCliente_Click(object sender, EventArgs e)
        {
            //Llama el método para denegar conductores
            bool resultado = datos.DenegarConductores();
            if (resultado)
            {
                MessageBox.Show("Los conductores pendientes han sido denegados con éxito.", "Alerta");
            }
            else
            {
                MessageBox.Show("Error, no hay conductores por denegar.", "Error");
            }

            dgtClientesSinAprobar.DataSource = datos.ObtenerConductores();
        }

        private void fmVistaAprobarClientes_Load(object sender, EventArgs e)
        {
        }

        private void dgtClientesSinAprobar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
