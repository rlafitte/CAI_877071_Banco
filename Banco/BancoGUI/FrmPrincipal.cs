﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoGUI
{
    public partial class FrmPrincipal : Form
    {
        private Form1 form1;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Form1 form1)
        {
            InitializeComponent();
            this.Owner = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            tbApellido.Clear();
            tbNombre.Clear();
            tbDni.Clear();
            tbTel.Clear();
            tbUser.Clear();
            tbFecNac.Clear();
            tbMail.Clear();
            tbDire.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //este método va a hacer el GET de la API

        }
    }
}
