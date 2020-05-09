using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using DataAccessLayer;
using DataAccessLayer.Entidades;
using System.IO;
using Newtonsoft.Json;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaServidor : Form
    {
        TcpListener tcpListener;
        Thread subprocesoEscucharClientes;
        bool servidorIniciado;//Bool para retornar si el servidor está iniciado o no
        ListBoxDelegado ListBoxClientes;

        DatosDB datos = new DatosDB();

        public fmVistaServidor()
        {
            InitializeComponent();
            btnIniciarServidor.ForeColor = Color.Green;
            btnIniciarServidor.Enabled = false;
            btnDetenerServidor.Enabled = false;//Botón de detener desabilitado cuando el de Iniciar esta habilitado
            btnEnviarMsjServidor.Enabled = false;
            btnVerViajesServidor.Enabled = false;
            btnAprobarServidor.Enabled = false;
            ListBoxClientes = new ListBoxDelegado(ModificarListBox);
        }

        private delegate void ListBoxDelegado(string texto, bool agregar);//Se crea mediante delegados el método que mostrará los conductores conectados
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                lstUsuariosConectados.Items.Add(texto);
            }
            else
            {
                lstUsuariosConectados.Items.Remove(texto);
            }
            
        }
        

        private void btnSalirServidor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmVistaServidor_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {

            IPAddress local = IPAddress.Parse("127.0.0.1");//Se  pone la IP local
            tcpListener = new TcpListener(local, 16830);//Se declara el puerto
            subprocesoEscucharClientes = new Thread(new ThreadStart(EscucharClientes));//Se llama al subproceso
            subprocesoEscucharClientes.Start();//Se inicia el subproceso
            subprocesoEscucharClientes.IsBackground = true;
            servidorIniciado = true;//Se habilita el servidor
            btnIniciarServidor.Enabled = false;//Se deshabilita el botón de iniciar
            btnDetenerServidor.ForeColor = Color.Red;
            btnDetenerServidor.Enabled = true;//Se habilita el botón de deshabilitar
            lblServidor.Text = "Iniciado";

        }

        private void EscucharClientes()
        {
            tcpListener.Start();//Inicia el TCP
            while (servidorIniciado)//La acción se queda detenida hasta que un cliente se conecte al servidor
            {
                TcpClient client = tcpListener.AcceptTcpClient();//Cuando el cliente se conecta devuelve el llamado y lo almacena en la variable

                Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));//Administra la comunicación con el cliente
                clientThread.Start(client);
            }
        }

        private void ComunicacionCliente(object obj)//Proceso donde se lee lo que el cliente está enviando al servidor
        {
            TcpClient tcpCliente = (TcpClient)obj;
            StreamReader reader = new StreamReader(tcpCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcpCliente.GetStream());

            while (servidorIniciado)
            {
                try
                {
                    var mensajeTCP = reader.ReadLine();
                    
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensajeTCP);//Se deserializa el mensaje en objeto para pasarlos por parametros
                    SeleccionarMetodo(mensajeRecibido.Mensaje, mensajeTCP, ref servidorStreamWriter);
                }
                catch (Exception)
                {
                    break;
                }
            }
            tcpCliente.Close();//Cierra conexión
        }

        private void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<Conductor> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<Conductor>>(pMensaje);
                    VerificarConductor(mensajeConectar.Valor);//Se muestra el conductor en la variable Valor y muestra el mensaje
                    break;

                case "Registrarse":
                    MensajeSocket<Conductor> mensajeRegistrarConductor = JsonConvert.DeserializeObject < MensajeSocket<Conductor>> (pMensaje);
                    RegistrarConductor(mensajeRegistrarConductor.Valor, ref servidorStreamWriter);//Para registrar al conductor y devolver mensaje
                    break;

                case "CrearViaje":
                    break;

                case "VerViaje":
                    break;

                case "Desconectar":
                    MensajeSocket<Conductor> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<Conductor>>(pMensaje);
                    DesconectarConductor(mensajeDesconectar.Valor);//Se muestra el conductor en la variable Valor y muestra el mensaje
                    break;

                default:
                    break;
            }
        }

        private void DesconectarConductor(Conductor empleado)
        {
            lstUsuariosConectados.Invoke(ListBoxClientes, new object[] { empleado.NombreUsuario, false });//False para eliminarlo de la lista
        }

        private void RegistrarConductor(Conductor valoresRegistrar, ref StreamWriter servidorStreamWriter)
        {
			datos.RegistrarConductor(valoresRegistrar);
        }


        private void VerificarConductor(Conductor empleado)
        {
            datos.LoginCliente(txtUsuarioAdmin.Text, txtPassAdmin.Text);
            lstUsuariosConectados.Invoke(ListBoxClientes, new object[] { empleado.NombreUsuario, true });//True para agregarlo a la lista
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            btnIniciarServidor.Enabled = true;
            btnDetenerServidor.Enabled = false;
            lblServidor.Text = "Desconectado";
        }

        private void btnLoginServidor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuarioAdmin.Text))//Si el campo esta rellenado, continue, si no, arroja error
            {
                if (datos.LoginAdministrador(txtUsuarioAdmin.Text, txtPassAdmin.Text))
                {

                    MessageBox.Show("Inicio de sesión con éxito.", "Administrador conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoginServidor.Enabled = false;
                    txtUsuarioAdmin.ReadOnly = true;
                    txtPassAdmin.ReadOnly = true;
                    btnEnviarMsjServidor.Enabled = true;
                    btnVerViajesServidor.Enabled = true;
                    btnAprobarServidor.Enabled = true;
                    lstUsuariosConectados.Enabled = true;
                    btnIniciarServidor.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Fallo al iniciar sesión.", "Error intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAprobarServidor_Click(object sender, EventArgs e)
        {
            fmVistaAprobarClientes vAprobarClientes = new fmVistaAprobarClientes();
            vAprobarClientes.Show();
        }

        private void btnEnviarMsjServidor_Click(object sender, EventArgs e)
        {

        }

        private void dgtUsuariosConectados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lstUsuariosConectados.Enabled = false;
        }

        private void btnVerViajesServidor_Click(object sender, EventArgs e)
        {
            fmVistaViajesEnCurso vVistaViajesEnCurso = new fmVistaViajesEnCurso();
            vVistaViajesEnCurso.Show();
        }
    }
}
