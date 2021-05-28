
namespace BancoGUI
{
    partial class FrmCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddCuenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNroCta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dtFecApertura = new System.Windows.Forms.DateTimePicker();
            this.dtFecMod = new System.Windows.Forms.DateTimePicker();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbIdBuscado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCuenta
            // 
            this.btnAddCuenta.Location = new System.Drawing.Point(649, 350);
            this.btnAddCuenta.Name = "btnAddCuenta";
            this.btnAddCuenta.Size = new System.Drawing.Size(75, 38);
            this.btnAddCuenta.TabIndex = 0;
            this.btnAddCuenta.Text = "Agregar Cuenta";
            this.btnAddCuenta.UseVisualStyleBackColor = true;
            this.btnAddCuenta.Click += new System.EventHandler(this.btnAddCuenta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.Location = new System.Drawing.Point(45, 38);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(287, 238);
            this.lstCuentas.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(45, 297);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(9, 238);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(87, 23);
            this.btnLimpiarCliente.TabIndex = 19;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Activo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Modif.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Apertura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saldo";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(119, 66);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(100, 20);
            this.tbSaldo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(119, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 5;
            this.tbId.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N° Cuenta";
            // 
            // tbNroCta
            // 
            this.tbNroCta.Location = new System.Drawing.Point(119, 14);
            this.tbNroCta.Name = "tbNroCta";
            this.tbNroCta.Size = new System.Drawing.Size(100, 20);
            this.tbNroCta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActivo);
            this.groupBox1.Controls.Add(this.dtFecMod);
            this.groupBox1.Controls.Add(this.dtFecApertura);
            this.groupBox1.Controls.Add(this.btnLimpiarCliente);
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSaldo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNroCta);
            this.groupBox1.Location = new System.Drawing.Point(413, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(153, 238);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(87, 23);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dtFecApertura
            // 
            this.dtFecApertura.Location = new System.Drawing.Point(120, 93);
            this.dtFecApertura.Name = "dtFecApertura";
            this.dtFecApertura.Size = new System.Drawing.Size(99, 20);
            this.dtFecApertura.TabIndex = 20;
            // 
            // dtFecMod
            // 
            this.dtFecMod.Location = new System.Drawing.Point(120, 121);
            this.dtFecMod.Name = "dtFecMod";
            this.dtFecMod.Size = new System.Drawing.Size(99, 20);
            this.dtFecMod.TabIndex = 21;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(119, 147);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(80, 17);
            this.chkActivo.TabIndex = 22;
            this.chkActivo.Text = "checkBox1";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Buscar cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbIdBuscado
            // 
            this.tbIdBuscado.Location = new System.Drawing.Point(255, 300);
            this.tbIdBuscado.Name = "tbIdBuscado";
            this.tbIdBuscado.Size = new System.Drawing.Size(77, 20);
            this.tbIdBuscado.TabIndex = 23;
            // 
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbIdBuscado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lstCuentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCuenta);
            this.Name = "FrmCuenta";
            this.Text = "FrmCuenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNroCta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DateTimePicker dtFecApertura;
        private System.Windows.Forms.DateTimePicker dtFecMod;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbIdBuscado;
    }
}