using Proyecto_Wei_Cliente;
using Proyecto_Wei_Servidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Wei_Principal
{
    public partial class fmVistaPrincipal : Form
    {
        public fmVistaPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmVistaServidor vServidor = new fmVistaServidor();
            vServidor.Show();
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientePrincipal_Click(object sender, EventArgs e)
        {
            fmVistaCliente vCliente = new fmVistaCliente();
            vCliente.Show();
        }

        private void fmVistaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
