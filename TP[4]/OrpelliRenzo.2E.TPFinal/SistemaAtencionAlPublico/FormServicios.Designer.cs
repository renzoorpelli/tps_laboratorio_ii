namespace SistemaAtencionAlPublico
{
    partial class FormServicios
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
            this.lstbServicios = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbServicios
            // 
            this.lstbServicios.FormattingEnabled = true;
            this.lstbServicios.ItemHeight = 15;
            this.lstbServicios.Location = new System.Drawing.Point(26, 21);
            this.lstbServicios.Name = "lstbServicios";
            this.lstbServicios.Size = new System.Drawing.Size(737, 349);
            this.lstbServicios.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSalir.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(551, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(212, 46);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.BackColor = System.Drawing.Color.Plum;
            this.btnEmitirFactura.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmitirFactura.Location = new System.Drawing.Point(26, 390);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(212, 46);
            this.btnEmitirFactura.TabIndex = 10;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = false;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmitirFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstbServicios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbServicios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEmitirFactura;
    }
}