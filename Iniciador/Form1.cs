﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iniciador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            int puerto = Int32.Parse(tb_puerto.Text);
            string nombre = tb_nombre.Text;

            rtb_log.Text = "Iniciando";
            TcpClient cliente = new TcpClient(nombre,puerto);
            if (cliente.Connected)
            {
                rtb_log.AppendText("conectado");
            }
        }
    }
}
