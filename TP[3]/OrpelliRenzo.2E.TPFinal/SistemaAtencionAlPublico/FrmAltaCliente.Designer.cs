namespace SistemaAtencionAlPublico
{
    partial class FrmAltaCliente
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
            this.gpbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cmbCategoriaCliente = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtBoxCuilCuit = new System.Windows.Forms.TextBox();
            this.lblCuitCuil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatosCliente
            // 
            this.gpbDatosCliente.Controls.Add(this.lblTipoCliente);
            this.gpbDatosCliente.Controls.Add(this.cmbTipoCliente);
            this.gpbDatosCliente.Controls.Add(this.lblDomicilio);
            this.gpbDatosCliente.Controls.Add(this.txtDomicilio);
            this.gpbDatosCliente.Controls.Add(this.cmbCategoriaCliente);
            this.gpbDatosCliente.Controls.Add(this.lblCategoriaCliente);
            this.gpbDatosCliente.Controls.Add(this.txtBoxCuilCuit);
            this.gpbDatosCliente.Controls.Add(this.lblCuitCuil);
            this.gpbDatosCliente.Controls.Add(this.txtNombre);
            this.gpbDatosCliente.Controls.Add(this.lblNombre);
            this.gpbDatosCliente.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbDatosCliente.Location = new System.Drawing.Point(144, 74);
            this.gpbDatosCliente.Name = "gpbDatosCliente";
            this.gpbDatosCliente.Size = new System.Drawing.Size(309, 321);
            this.gpbDatosCliente.TabIndex = 11;
            this.gpbDatosCliente.TabStop = false;
            this.gpbDatosCliente.Text = "Datos Cliente";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoCliente.Location = new System.Drawing.Point(154, 23);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(127, 14);
            this.lblTipoCliente.TabIndex = 13;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Location = new System.Drawing.Point(153, 51);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(121, 25);
            this.cmbTipoCliente.TabIndex = 12;
            this.cmbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCliente_SelectedIndexChanged);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDomicilio.Location = new System.Drawing.Point(144, 128);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(23, 14);
            this.lblDomicilio.TabIndex = 9;
            this.lblDomicilio.Text = "\"\"";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDomicilio.Location = new System.Drawing.Point(153, 160);
            this.txtDomicilio.MaxLength = 20;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(106, 22);
            this.txtDomicilio.TabIndex = 8;
            // 
            // cmbCategoriaCliente
            // 
            this.cmbCategoriaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoriaCliente.FormattingEnabled = true;
            this.cmbCategoriaCliente.Location = new System.Drawing.Point(82, 257);
            this.cmbCategoriaCliente.Name = "cmbCategoriaCliente";
            this.cmbCategoriaCliente.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoriaCliente.TabIndex = 7;
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoriaCliente.Location = new System.Drawing.Point(71, 220);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(143, 14);
            this.lblCategoriaCliente.TabIndex = 6;
            this.lblCategoriaCliente.Text = "Categoria Cliente";
            // 
            // txtBoxCuilCuit
            // 
            this.txtBoxCuilCuit.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCuilCuit.Location = new System.Drawing.Point(17, 160);
            this.txtBoxCuilCuit.MaxLength = 20;
            this.txtBoxCuilCuit.Name = "txtBoxCuilCuit";
            this.txtBoxCuilCuit.Size = new System.Drawing.Size(106, 22);
            this.txtBoxCuilCuit.TabIndex = 5;
            // 
            // lblCuitCuil
            // 
            this.lblCuitCuil.AutoSize = true;
            this.lblCuitCuil.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuitCuil.Location = new System.Drawing.Point(20, 128);
            this.lblCuitCuil.Name = "lblCuitCuil";
            this.lblCuitCuil.Size = new System.Drawing.Size(23, 14);
            this.lblCuitCuil.TabIndex = 4;
            this.lblCuitCuil.Text = "\"\"";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(17, 52);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(17, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "\"\"";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.Plum;
            this.btnAltaCliente.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaCliente.Location = new System.Drawing.Point(144, 401);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(309, 46);
            this.btnAltaCliente.TabIndex = 10;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTitulo.Font = new System.Drawing.Font("Noto Mono", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(197, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 32);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Alta Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(144, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(632, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbDatosCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaCliente";
            this.Text = "FrmAltaCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAltaCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gpbDatosCliente.ResumeLayout(false);
            this.gpbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatosCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.ComboBox cmbCategoriaCliente;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.TextBox txtBoxCuilCuit;
        private System.Windows.Forms.Label lblCuitCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
    }
}