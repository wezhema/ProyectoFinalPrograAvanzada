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
            if((Application.OpenForms["fmVistaServidor"] as fmVistaServidor) != null)
            {
                MessageBox.Show("El servidor ya se está ejecutando.", "Error");
            }
            else
            {
                //Llama a la vista del servidor y deshabilita su botón para que se ejecute 1 única vez
                fmVistaServidor vServidor = new fmVistaServidor();
                vServidor.Show();
            }
            
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            //Cierra la vista
            this.Close();
        }

        private void btnClientePrincipal_Click(object sender, EventArgs e)
        {
            //Llama la vista cliente
            fmVistaCliente vCliente = new fmVistaCliente();
            vCliente.Show();
        }

        private void fmVistaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
