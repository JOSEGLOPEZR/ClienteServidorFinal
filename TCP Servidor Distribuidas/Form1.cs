using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TCP_Servidor_Distribuidas{
    public partial class Servidor : Form{
        public Servidor(){
            InitializeComponent();
            txtIP.Text = obtenerIP(); //metodo que obtiene mi ip de la maquina y asigna al cliente
            lbClientesConectados.Text = "Numero De  Clientes IP Conectados: 0";//inicia la aplicacion con 0 conectados
        }

        private string obtenerIP() {
            String strHostName = string.Empty;//creo un string que contendra el hostname
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());//obtengo las ip del hostname
            IPAddress[] addr = ipEntry.AddressList;//guardo en un vector la entra de ips
            return addr[1].ToString()+":9000";//retorna la ip con el puerto 9000
        }

        int numConectados = 0;//variable para sabe cuantos clientes estan conectados
        SimpleTcp.SimpleTcpServer server;//////Creo Una Variable Tcp De Tipo Servidor


        private void btnIniciar_Click(object sender, EventArgs e){
            server = new SimpleTcp.SimpleTcpServer(txtIP.Text);// asigno ala variable server lo del txt que tiene la IP
            ////////////////////////////////////////////////////////
            //Creo metodos segun el evento de conectado desconectado y el mensaje del servidor
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            server.Start();///Inicio El Servidor
            txtInfo.Text += $"Inciando Servidor.....{Environment.NewLine}";//Mensaje De Que se Inicio El Servidor TCP
            //HABILITO Y DESABILITO LOS BOTONES Y TXT SEGUN SEA EL CASO
            btnIniciar.Enabled = false;
            btnEnviar.Enabled = true;
            txtIP.Enabled = false;
        }

        private void Cliente_Load(object sender, EventArgs e){
            btnEnviar.Enabled = false;//desactivo el de envio al incio del programa
        }



        private void Events_DataReceived(object sender, SimpleTcp.DataReceivedEventArgs e){
            this.Invoke((MethodInvoker)delegate {
                //Guardo el mensaje recibido en txt con la ip 
                txtInfo.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, SimpleTcp.ClientDisconnectedEventArgs e)  {
             this.Invoke((MethodInvoker)delegate {
                //guardo un mesaje que se desconecto el cliente en el txt info y lo elimino d ela llista de cliente conectados
                txtInfo.Text += $"{e.IpPort}: Desconectado.{Environment.NewLine}";//mensaje de conectado
                lstClienteIP.Items.Remove(e.IpPort);///elimino la ip ala lista 
                numConectados -= 1;//elimino un conectado de la suma
                lbClientesConectados.Text = "Numero De  Clientes IP Conectados:" + numConectados.ToString();//convierto a string el numero de conectados
             });
        }

        private void Events_ClientConnected(object sender, SimpleTcp.ClientConnectedEventArgs e)  {
            this.Invoke((MethodInvoker)delegate {
                //guardo un mesaje que se conecto el cliente en el txt info y lo añado a la lista de cliente conectados
                txtInfo.Text += $"{e.IpPort}: Conectado.{Environment.NewLine}";//mensaje de conectado
                lstClienteIP.Items.Add(e.IpPort);//añanado la ip que de conecto ala lista
                numConectados +=1;
                lbClientesConectados.Text = "Numero De  Clientes IP Conectados:"+numConectados.ToString();
            });
        }


        private void button1_Click(object sender, EventArgs e){
            if (server.IsListening){//if que si esta escuchando el servidor realize una operacion
                if (!string.IsNullOrEmpty(txtMensage.Text) && lstClienteIP.SelectedItem != null){//chequeo el mensaje y si estoy seleccionado una ip cliente del ListBox
                    server.Send(lstClienteIP.SelectedItem.ToString(),txtMensage.Text);//envio  de datos al cliente por la ip y un mensaje
                    txtMensage.Text = string.Empty;//vacio el txt mensaje luego de enviar el mensaje al cliente
                }
            }
        }

    }
}
