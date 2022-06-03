namespace SistemaAtencionAlPublico
{
    partial class FrmModificarCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cmbCategoriaCliente = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCliente = new System.Windows.Forms.Label();
            this.txtBoxCuilCuit = new System.Windows.Forms.TextBox();
            this.lblCuitCuil = new System.Windows.Forms.Label();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(100, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(23, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "\"\"";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(100, 52);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 25);
            this.txtNombre.TabIndex = 2;
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
            this.gpbDatosCliente.Location = new System.Drawing.Point(77, 82);
            this.gpbDatosCliente.Name = "gpbDatosCliente";
            this.gpbDatosCliente.Size = new System.Drawing.Size(531, 283);
            this.gpbDatosCliente.TabIndex = 4;
            this.gpbDatosCliente.TabStop = false;
            this.gpbDatosCliente.Text = "Datos Cliente";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoCliente.Location = new System.Drawing.Point(306, 23);
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
            this.cmbTipoCliente.Location = new System.Drawing.Point(306, 52);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(121, 25);
            this.cmbTipoCliente.TabIndex = 12;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDomicilio.Location = new System.Drawing.Point(306, 117);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(23, 14);
            this.lblDomicilio.TabIndex = 9;
            this.lblDomicilio.Text = "\"\"";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDomicilio.Location = new System.Drawing.Point(306, 149);
            this.txtDomicilio.MaxLength = 20;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(121, 22);
            this.txtDomicilio.TabIndex = 8;
            // 
            // cmbCategoriaCliente
            // 
            this.cmbCategoriaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoriaCliente.FormattingEnabled = true;
            this.cmbCategoriaCliente.Location = new System.Drawing.Point(186, 235);
            this.cmbCategoriaCliente.Name = "cmbCategoriaCliente";
            this.cmbCategoriaCliente.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoriaCliente.TabIndex = 7;
            // 
            // lblCategoriaCliente
            // 
            this.lblCategoriaCliente.AutoSize = true;
            this.lblCategoriaCliente.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoriaCliente.Location = new System.Drawing.Point(186, 198);
            this.lblCategoriaCliente.Name = "lblCategoriaCliente";
            this.lblCategoriaCliente.Size = new System.Drawing.Size(143, 14);
            this.lblCategoriaCliente.TabIndex = 6;
            this.lblCategoriaCliente.Text = "Categoria Cliente";
            // 
            // txtBoxCuilCuit
            // 
            this.txtBoxCuilCuit.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCuilCuit.Location = new System.Drawing.Point(97, 149);
            this.txtBoxCuilCuit.MaxLength = 20;
            this.txtBoxCuilCuit.Name = "txtBoxCuilCuit";
            this.txtBoxCuilCuit.Size = new System.Drawing.Size(106, 22);
            this.txtBoxCuilCuit.TabIndex = 5;
            // 
            // lblCuitCuil
            // 
            this.lblCuitCuil.AutoSize = true;
            this.lblCuitCuil.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuitCuil.Location = new System.Drawing.Point(100, 117);
            this.lblCuitCuil.Name = "lblCuitCuil";
            this.lblCuitCuil.Size = new System.Drawing.Size(23, 14);
            this.lblCuitCuil.TabIndex = 4;
            this.lblCuitCuil.Text = "\"\"";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarCliente.Location = new System.Drawing.Point(77, 399);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(254, 83);
            this.btnGuardarCliente.TabIndex = 5;
            this.btnGuardarCliente.Text = "Guardar Cambios";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Plum;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(354, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(254, 83);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Noto Mono", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(232, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "MODIFICAR DATOS";
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(707, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.gpbDatosCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.FrmModificarCliente_Load);
            this.gpbDatosCliente.ResumeLayout(false);
            this.gpbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbDatosCliente;
        private System.Windows.Forms.TextBox txtBoxCuilCuit;
        private System.Windows.Forms.Label lblCuitCuil;
        private System.Windows.Forms.ComboBox cmbCategoriaCliente;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
    }
}