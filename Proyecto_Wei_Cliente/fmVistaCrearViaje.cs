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
            cmbIDConductor.DisplayMember = "Id_Conductor";//Combo box que llama todos los ID de conductor de la BD
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
            //Parámetros recibidos del cliente para ser introducidos en la base de datos posterior a ser enviados al servidor
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
            MessageBox.Show("Viaje registrado con éxito.", "Atención");//Mensaje de éxito
        }
    }
    
}
