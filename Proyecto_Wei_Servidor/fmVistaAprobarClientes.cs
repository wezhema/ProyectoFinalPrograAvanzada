using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaAprobarClientes : Form
    {
		DatosDB datos = new DatosDB();

        public fmVistaAprobarClientes()
        {
            InitializeComponent();
        }

        private void btnSalirAprobarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgtClientesSinAprobar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgtClientesSinAprobar.DataSource = datos.ConductoresPendientes();
        }

        private void btnAprobarCliente_Click(object sender, EventArgs e)
        {
            bool resultado = datos.AprobarConductores();
            if (resultado)
            {
                MessageBox.Show("Los conductores pendientes han sido aprobados con éxito.", "Alerta");
            }
            else
            {
                MessageBox.Show("Hubo un error, intente de nuevo.", "Error");
            }

            dgtClientesSinAprobar.DataSource = datos.ConductoresPendientes();
        }

        private void btnDenegarCliente_Click(object sender, EventArgs e)
        {
            bool resultado = datos.DenegarConductores();
            if (resultado)
            {
                MessageBox.Show("Los conductores pendientes han sido denegados con éxito.", "Alerta");
            }
            else
            {
                MessageBox.Show("Hubo un error, intente de nuevo.", "Error");
            }

            dgtClientesSinAprobar.DataSource = datos.ConductoresPendientes();
        }
    }
}
