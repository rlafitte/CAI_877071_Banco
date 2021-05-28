using BancoNegocio;
using System;
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
    public partial class FrmCuenta : Form
    {
        private Form1 form1;
        private ClienteNegocio _clNeg;
        public FrmCuenta()
        {
            InitializeComponent();
        }

        public FrmCuenta(Form1 form1)
        {
            InitializeComponent();
            this.Owner = form1;
            _clNeg = new ClienteNegocio();
        }

        private void btnAddCuenta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            lstCuentas.DataSource = null;
            lstCuentas.DataSource = _clNeg.TraerCuentas();
        }
    }
}
