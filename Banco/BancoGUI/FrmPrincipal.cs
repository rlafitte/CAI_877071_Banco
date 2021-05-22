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
    }
}
