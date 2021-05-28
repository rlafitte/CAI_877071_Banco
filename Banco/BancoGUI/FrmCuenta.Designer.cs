
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
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lstCuentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCuenta);
            this.Name = "FrmCuenta";
            this.Text = "FrmCuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnActualizar;
    }
}