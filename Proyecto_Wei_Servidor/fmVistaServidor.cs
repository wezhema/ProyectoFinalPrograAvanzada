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
using System.Text;

namespace Proyecto_Wei_Servidor
{
    public partial class fmVistaServidor : Form
    {
        TcpListener tcpListener;//Comando para escuchar clientes TCP
        Thread subprocesoEscucharClientes;//Subproceso que se utilizará para escuchar clientes
        public static bool servidorIniciado;//Bool para retornar si el servidor está iniciado o no
        ListBoxDelegado ListBoxClientes;//Se utiliza una lista de delegados para mostrar los conductores conectados

        DatosDB datos = new DatosDB();//Se instancia la DB

        public fmVistaServidor()
        {
            //Al mostrar la vista del servidor se deshabilitan los siguientes botones:
            InitializeComponent();
            btnIniciarServidor.Enabled = false;//Inicio del servidor
            btnIniciarServidor.ForeColor = Color.Green;//El color se pone en verde para cuando esté disponible
            btnDetenerServidor.Enabled = false;//Detener servidor
            btnVerViajesServidor.Enabled = false;//Ver viajes
            btnAprobarServidor.Enabled = false;//Aprobar conductores
            btnHistorial.Enabled = false;
            ListBoxClientes = new ListBoxDelegado(ModificarListBox);//La lista de delegados se instancia
            
        }

        //Pasará los parámetros a la lista de delegados para mostrar los usuarios conectados
        private delegate void ListBoxDelegado(string texto, bool agregar);
        private void ModificarListBox(string texto, bool agregar)
        {
            //Si se conectan se agregan
            if (agregar)
            {
                lstUsuariosConectados.Items.Add(texto);
            }
            //Si se desconectan se remueven
            else
            {
                lstUsuariosConectados.Items.Remove(texto);
            }
        }
        

        private void btnSalirServidor_Click(object sender, EventArgs e)
        {
            //Botón de salir, cierra la vista
            this.Close();
        }

        private void fmVistaServidor_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarServidor_Click(object sender, EventArgs e)
        {
            //Inicio de servidor
            IPAddress local = IPAddress.Parse("127.0.0.1");//Se pone la IP local
            tcpListener = new TcpListener(local, 16830);//Se declara el puerto
            subprocesoEscucharClientes = new Thread(new ThreadStart(EscucharClientes));//Se llama al subproceso
            subprocesoEscucharClientes.Start();//Se inicia el subproceso
            subprocesoEscucharClientes.IsBackground = true;
            servidorIniciado = true;//Se habilita el servidor
            btnIniciarServidor.Enabled = false;//Se deshabilita el botón de iniciar
            btnDetenerServidor.ForeColor = Color.Red;
            btnDetenerServidor.Enabled = true;//Se habilita el botón de deshabilitar
            lblServidor.Text = "Iniciado";//Ca,mbia el label
            btnSalirServidor.Enabled = false;

        }

        private void EscucharClientes()
        {
            tcpListener.Start();//Inicia el TCP
            while (servidorIniciado)//La acción se queda detenida hasta que un cliente se conecte al servidor
            {
                try
                {
                    TcpClient client = tcpListener.AcceptTcpClient();//Cuando el cliente se conecta devuelve el llamado y lo almacena en la variable

                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));//Administra la comunicación con el cliente
                    clientThread.Start(client);
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        //Proceso donde se lee lo que el cliente está enviando al servidor
        private void ComunicacionCliente(object obj)
        {
            TcpClient tcpCliente = (TcpClient)obj;
            StreamReader reader = new StreamReader(tcpCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcpCliente.GetStream());

            while (servidorIniciado)
            {
                try
                {
                    var mensajeTCP = reader.ReadLine();
                    //Se deserializa el mensaje en objeto para pasarlos por parámetros
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensajeTCP);
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
            //Switch para acceder a los métodos de la clase ClienteTCP
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<Conductor> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<Conductor>>(pMensaje);
                    VerificarConductor(mensajeConectar.Valor);
                    break;

                case "Registrarse":
                    MensajeSocket<Conductor> mensajeRegistrarConductor = JsonConvert.DeserializeObject < MensajeSocket<Conductor>> (pMensaje);
                    RegistrarConductor(mensajeRegistrarConductor.Valor, ref servidorStreamWriter);
                    break;

                case "CrearViaje":
                    MensajeSocket<Viajes> mensajeCrearViaje = JsonConvert.DeserializeObject<MensajeSocket<Viajes>>(pMensaje);
                    CrearViaje(mensajeCrearViaje.Valor, ref servidorStreamWriter);
                    break;

                case "Desconectar":
                    MensajeSocket<Conductor> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<Conductor>>(pMensaje);
                    DesconectarConductor(mensajeDesconectar.Valor);
                    break;

                default:
                    break;
            }
        }

        //Métodos que son llamados por el Switch
        private void VerificarConductor(Conductor empleado)
        {
            datos.LoginCliente(txtUsuarioAdmin.Text, txtPassAdmin.Text);
            lstUsuariosConectados.Invoke(ListBoxClientes, new object[] { empleado.NombreUsuario, true });//True para agregarlo a la lista
        }

        private void RegistrarConductor(Conductor valoresRegistrar, ref StreamWriter servidorStreamWriter)
        {
            datos.RegistrarConductor(valoresRegistrar);
        }

        private void CrearViaje(Viajes valoresRegistrar, ref StreamWriter servidorStreamWriter)
        {
            datos.CrearViaje(valoresRegistrar);
        }

        private void DesconectarConductor(Conductor empleado)
        {
            lstUsuariosConectados.Invoke(ListBoxClientes, new object[] { empleado.NombreUsuario, false });//False para eliminarlo de la lista
        }

        private void btnDetenerServidor_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            btnIniciarServidor.Enabled = true;
            btnDetenerServidor.Enabled = false;
            btnSalirServidor.Enabled = true;
            lblServidor.Text = "Desconectado";
        }

        private void btnLoginServidor_Click(object sender, EventArgs e)
        {
            //Inicio de sesión del administrador
            if (!string.IsNullOrEmpty(txtUsuarioAdmin.Text))//Si el campo esta rellenado, continue, si no, arroja error
            {
                if (datos.LoginAdministrador(txtUsuarioAdmin.Text, txtPassAdmin.Text))
                {
                    MessageBox.Show("Inicio de sesión con éxito.", "Administrador conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Habilita todos los botones excepto el de iniciar sesión
                    btnLoginServidor.Enabled = false;
                    txtUsuarioAdmin.ReadOnly = true;
                    txtPassAdmin.ReadOnly = true;
                    btnVerViajesServidor.Enabled = true;
                    btnAprobarServidor.Enabled = true;
                    lstUsuariosConectados.Enabled = true;
                    btnIniciarServidor.Enabled = true;
                    btnHistorial.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fallo al iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtUsuarioAdmin_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            fmVistaHistorial vVistaHistorial = new fmVistaHistorial();
            vVistaHistorial.Show();
        }
    }
}
