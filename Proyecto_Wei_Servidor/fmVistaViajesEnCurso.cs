using System;
using DataAccessLayer;
using System.Windows.Forms;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaViajesEnCurso : Form
    {
        DatosDB datos = new DatosDB();
        public fmVistaViajesEnCurso()
        {
            InitializeComponent();
            dgvViajesEnCurso.DataSource = datos.ObtenerViajes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void fmVistaViajesEnCurso_Load(object sender, EventArgs e)
        {
        }
    }
}
