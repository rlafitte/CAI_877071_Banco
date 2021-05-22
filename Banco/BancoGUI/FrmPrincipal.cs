using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoEntidades.Entidades;
using BancoNegocio;

namespace BancoGUI
{
    public partial class FrmPrincipal : Form
    {
        private Form1 form1;
        private ClienteNegocio _clNeg;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Form1 form1)
        {
            InitializeComponent();
            this.Owner = form1;
            _clNeg = new ClienteNegocio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
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
            Actualizar();

        }

        private void Actualizar()
        {
            //este método va a hacer el GET de la API
            lstClientes.DataSource = null;
            lstClientes.DataSource = _clNeg.Traer();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            int _id=0;
            Cliente c = new Cliente();
            c.Ape = tbApellido.Text;
            c.Nombre = tbNombre.Text;
            c.DNI = tbDni.Text;
            
            int.TryParse(tbUser.Text, out _id);
            c.id = _id;

            Limpiar();
            Actualizar();
        }
    }
}
