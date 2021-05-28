using BancoEntidades.Entidades;
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

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cuenta c = new Cuenta();
            c.id = int.Parse(tbId.Text);
            c.NroCuenta = int.Parse(tbNroCta.Text);
            c.Saldo = float.Parse(tbSaldo.Text);
            c.Activo = chkActivo.Checked;
            c.FechaApertura = dtFecApertura.Value;
            _clNeg.AgregarCuenta(c);
            Limpiar();
        }

        private void Limpiar()
        {
            tbId.Clear();
            tbNroCta.Clear();
            tbSaldo.Clear();
            chkActivo.Checked = false;
            dtFecApertura.Value = System.DateTime.Now;
            dtFecMod.Value = System.DateTime.Now;
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
