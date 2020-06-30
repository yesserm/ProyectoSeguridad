using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKDC
{
    public partial class Form1 : Form
    {
        public static TcpListener server;

        public Form1()
        {
            InitializeComponent();
        }

        private async void bt_escuchar_Click(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text);
            IPAddress direccion = IPAddress.Parse(tb_nombre.Text);

            server = new TcpListener(direccion,puerto);
            server.Start();
            rtb_log.Text = "Iniciado";
            while (true)
            {
                Byte[] mensaje = new byte[20];
                string obtenido = "";

                rtb_log.AppendText("\nEsperando clientes");
                TcpClient cliente = await server.AcceptTcpClientAsync();
                rtb_log.AppendText("\nconectado");

                NetworkStream stream = cliente.GetStream();
                int i = 0;

                while ((i = stream.Read(mensaje, 0, mensaje.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    obtenido = System.Text.Encoding.ASCII.GetString(mensaje, 0, i);
                    rtb_log.AppendText("Recibido: "+ obtenido);
                }

                cliente.Close();
            }
        }
    }
}
