using System;
using System.Windows.Forms;
using DataAccessLayer;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaHistorial : Form
    {
        DatosDB datos = new DatosDB();
        public fmVistaHistorial()
        {
            InitializeComponent();
            dtvHistorial.DataSource = datos.ObtenerHistorial();
        }

        private void fmVistaHistorial_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
