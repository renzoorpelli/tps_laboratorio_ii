namespace SistemaAtencionAlPublico
{
    partial class FormWhiteHatCS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdministracionClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdministracionClientes
            // 
            this.btnAdministracionClientes.BackColor = System.Drawing.Color.Plum;
            this.btnAdministracionClientes.Font = new System.Drawing.Font("Noto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdministracionClientes.Location = new System.Drawing.Point(167, 160);
            this.btnAdministracionClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdministracionClientes.Name = "btnAdministracionClientes";
            this.btnAdministracionClientes.Size = new System.Drawing.Size(360, 72);
            this.btnAdministracionClientes.TabIndex = 1;
            this.btnAdministracionClientes.Text = "Administración Clientes";
            this.btnAdministracionClientes.UseVisualStyleBackColor = false;
            this.btnAdministracionClientes.Click += new System.EventHandler(this.btnAdministracionClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalir.Font = new System.Drawing.Font("Noto Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(167, 273);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(360, 72);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir del sistema";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreador.Location = new System.Drawing.Point(544, 509);
            this.lblCreador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(137, 14);
            this.lblCreador.TabIndex = 4;
            this.lblCreador.Text = "Creado por Renzo Orpelli";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.BackColor = System.Drawing.Color.PaleGreen;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Noto Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEmpresa.Location = new System.Drawing.Point(143, 29);
            this.lblNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(432, 28);
            this.lblNombreEmpresa.TabIndex = 7;
            this.lblNombreEmpresa.Text = "White Hat Cyber Security. SA";
            // 
            // FormWhiteHatCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(694, 532);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdministracionClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWhiteHatCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWhiteHatCS_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdministracionClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblNombreEmpresa;
    }
}
