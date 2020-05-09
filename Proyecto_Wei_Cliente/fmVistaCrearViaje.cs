using System;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Entidades;

namespace Proyecto_Wei_Cliente
{
    public partial class fmVistaCrearViaje : Form
    {
        DatosDB datos = new DatosDB();
        public fmVistaCrearViaje()
        {
            InitializeComponent();
            cmbIDConductor.DataSource = datos.ObtenerConductores();
            cmbIDConductor.DisplayMember = "Id_Conductor";
        }

        private void btnSalirViaje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmVistaCrearViaje_Load(object sender, EventArgs e)
        {

        }

        private void cmbIDConductor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistrarViaje_Click(object sender, EventArgs e)
        {
            Viajes viaje = new Viajes()
            {
                Id_Conductor = cmbIDConductor.Text,
                PuntoPartida = txtPtoPartida.Text,
                PuntoDestino = txtPtoDestino.Text,
                Desc_Viaje = txtDescCliente.Text,
                Can_Horas = txtTiempoCliente.Text,
                Estado = txtEstado.Text,
            };
            ClienteTCP.CrearViaje(viaje);
            this.Close();
            MessageBox.Show("Viaje registrado con éxito.", "Atención");
        }
    }
    
}
