namespace SistemaAtencionAlPublico
{
    partial class FrmAdministracionClientes
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblListadoEmpleados = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
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
            this.lblFechaAnalisis = new System.Windows.Forms.Label();
            this.dateFechaAnalisis = new System.Windows.Forms.DateTimePicker();
            this.lblTpClienteMenu = new System.Windows.Forms.Label();
            this.lblNmeClienteMenu = new System.Windows.Forms.Label();
            this.lblCatClienteMenu = new System.Windows.Forms.Label();
            this.groupBoxServicios = new System.Windows.Forms.GroupBox();
            this.lblCostoServicio = new System.Windows.Forms.Label();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.lblDificultadVirus = new System.Windows.Forms.Label();
            this.cmbDificultadVirus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoInfeccion = new System.Windows.Forms.ComboBox();
            this.buttonMostrarServicios = new System.Windows.Forms.Button();
            this.btnAltaServicios = new System.Windows.Forms.Button();
            this.groupBoxAdministrarDatos = new System.Windows.Forms.GroupBox();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.btnGuardarClientes = new System.Windows.Forms.Button();
            this.gpbDatosCliente.SuspendLayout();
            this.groupBoxServicios.SuspendLayout();
            this.groupBoxAdministrarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(23, 112);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(718, 499);
            this.lstClientes.TabIndex = 0;
            // 
            // lblListadoEmpleados
            // 
            this.lblListadoEmpleados.AutoSize = true;
            this.lblListadoEmpleados.BackColor = System.Drawing.Color.Plum;
            this.lblListadoEmpleados.Font = new System.Drawing.Font("Noto Mono", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoEmpleados.Location = new System.Drawing.Point(160, 37);
            this.lblListadoEmpleados.Name = "lblListadoEmpleados";
            this.lblListadoEmpleados.Size = new System.Drawing.Size(270, 32);
            this.lblListadoEmpleados.TabIndex = 1;
            this.lblListadoEmpleados.Text = "Listado Clientes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTitulo.Font = new System.Drawing.Font("Noto Mono", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(923, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(382, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Administración Clientes";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.Location = new System.Drawing.Point(779, 557);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(309, 58);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(779, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.Plum;
            this.btnModificarCliente.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarCliente.Location = new System.Drawing.Point(779, 493);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(309, 58);
            this.btnModificarCliente.TabIndex = 5;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAltaCliente.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaCliente.Location = new System.Drawing.Point(779, 429);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(309, 58);
            this.btnAltaCliente.TabIndex = 7;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
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
            this.gpbDatosCliente.Location = new System.Drawing.Point(779, 85);
            this.gpbDatosCliente.Name = "gpbDatosCliente";
            this.gpbDatosCliente.Size = new System.Drawing.Size(309, 321);
            this.gpbDatosCliente.TabIndex = 8;
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
            // lblFechaAnalisis
            // 
            this.lblFechaAnalisis.AutoSize = true;
            this.lblFechaAnalisis.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaAnalisis.Location = new System.Drawing.Point(94, 247);
            this.lblFechaAnalisis.Name = "lblFechaAnalisis";
            this.lblFechaAnalisis.Size = new System.Drawing.Size(143, 14);
            this.lblFechaAnalisis.TabIndex = 11;
            this.lblFechaAnalisis.Text = "Fecha de Analisis";
            // 
            // dateFechaAnalisis
            // 
            this.dateFechaAnalisis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaAnalisis.Location = new System.Drawing.Point(78, 284);
            this.dateFechaAnalisis.Name = "dateFechaAnalisis";
            this.dateFechaAnalisis.Size = new System.Drawing.Size(173, 25);
            this.dateFechaAnalisis.TabIndex = 10;
            // 
            // lblTpClienteMenu
            // 
            this.lblTpClienteMenu.AutoSize = true;
            this.lblTpClienteMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTpClienteMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTpClienteMenu.Location = new System.Drawing.Point(33, 89);
            this.lblTpClienteMenu.Name = "lblTpClienteMenu";
            this.lblTpClienteMenu.Size = new System.Drawing.Size(89, 20);
            this.lblTpClienteMenu.TabIndex = 9;
            this.lblTpClienteMenu.Text = "Tipo Cliente";
            // 
            // lblNmeClienteMenu
            // 
            this.lblNmeClienteMenu.AutoSize = true;
            this.lblNmeClienteMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.lblNmeClienteMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNmeClienteMenu.Location = new System.Drawing.Point(169, 89);
            this.lblNmeClienteMenu.Name = "lblNmeClienteMenu";
            this.lblNmeClienteMenu.Size = new System.Drawing.Size(114, 20);
            this.lblNmeClienteMenu.TabIndex = 10;
            this.lblNmeClienteMenu.Text = "Nombre Cliente";
            // 
            // lblCatClienteMenu
            // 
            this.lblCatClienteMenu.AutoSize = true;
            this.lblCatClienteMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCatClienteMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatClienteMenu.Location = new System.Drawing.Point(352, 89);
            this.lblCatClienteMenu.Name = "lblCatClienteMenu";
            this.lblCatClienteMenu.Size = new System.Drawing.Size(124, 20);
            this.lblCatClienteMenu.TabIndex = 12;
            this.lblCatClienteMenu.Text = "Categoria Cliente";
            // 
            // groupBoxServicios
            // 
            this.groupBoxServicios.Controls.Add(this.lblCostoServicio);
            this.groupBoxServicios.Controls.Add(this.txtCostoServicio);
            this.groupBoxServicios.Controls.Add(this.lblFechaAnalisis);
            this.groupBoxServicios.Controls.Add(this.dateFechaAnalisis);
            this.groupBoxServicios.Controls.Add(this.lblDificultadVirus);
            this.groupBoxServicios.Controls.Add(this.cmbDificultadVirus);
            this.groupBoxServicios.Controls.Add(this.label1);
            this.groupBoxServicios.Controls.Add(this.cmbTipoInfeccion);
            this.groupBoxServicios.Controls.Add(this.buttonMostrarServicios);
            this.groupBoxServicios.Controls.Add(this.btnAltaServicios);
            this.groupBoxServicios.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxServicios.Location = new System.Drawing.Point(1106, 85);
            this.groupBoxServicios.Name = "groupBoxServicios";
            this.groupBoxServicios.Size = new System.Drawing.Size(315, 402);
            this.groupBoxServicios.TabIndex = 15;
            this.groupBoxServicios.TabStop = false;
            this.groupBoxServicios.Text = "Servicios Cliente";
            // 
            // lblCostoServicio
            // 
            this.lblCostoServicio.AutoSize = true;
            this.lblCostoServicio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCostoServicio.Location = new System.Drawing.Point(102, 168);
            this.lblCostoServicio.Name = "lblCostoServicio";
            this.lblCostoServicio.Size = new System.Drawing.Size(119, 14);
            this.lblCostoServicio.TabIndex = 23;
            this.lblCostoServicio.Text = "Costo Servicio";
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCostoServicio.Location = new System.Drawing.Point(78, 201);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(173, 22);
            this.txtCostoServicio.TabIndex = 22;
            // 
            // lblDificultadVirus
            // 
            this.lblDificultadVirus.AutoSize = true;
            this.lblDificultadVirus.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDificultadVirus.Location = new System.Drawing.Point(102, 96);
            this.lblDificultadVirus.Name = "lblDificultadVirus";
            this.lblDificultadVirus.Size = new System.Drawing.Size(135, 14);
            this.lblDificultadVirus.TabIndex = 21;
            this.lblDificultadVirus.Text = "Dificultad Virus";
            // 
            // cmbDificultadVirus
            // 
            this.cmbDificultadVirus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificultadVirus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDificultadVirus.FormattingEnabled = true;
            this.cmbDificultadVirus.Location = new System.Drawing.Point(78, 122);
            this.cmbDificultadVirus.Name = "cmbDificultadVirus";
            this.cmbDificultadVirus.Size = new System.Drawing.Size(173, 25);
            this.cmbDificultadVirus.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de Virus";
            // 
            // cmbTipoInfeccion
            // 
            this.cmbTipoInfeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInfeccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoInfeccion.FormattingEnabled = true;
            this.cmbTipoInfeccion.Location = new System.Drawing.Point(78, 52);
            this.cmbTipoInfeccion.Name = "cmbTipoInfeccion";
            this.cmbTipoInfeccion.Size = new System.Drawing.Size(173, 25);
            this.cmbTipoInfeccion.TabIndex = 18;
            // 
            // buttonMostrarServicios
            // 
            this.buttonMostrarServicios.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonMostrarServicios.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarServicios.Location = new System.Drawing.Point(172, 344);
            this.buttonMostrarServicios.Name = "buttonMostrarServicios";
            this.buttonMostrarServicios.Size = new System.Drawing.Size(115, 44);
            this.buttonMostrarServicios.TabIndex = 17;
            this.buttonMostrarServicios.Text = "Mostrar Servicios";
            this.buttonMostrarServicios.UseVisualStyleBackColor = false;
            this.buttonMostrarServicios.Click += new System.EventHandler(this.buttonMostrarServicios_Click);
            // 
            // btnAltaServicios
            // 
            this.btnAltaServicios.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAltaServicios.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaServicios.Location = new System.Drawing.Point(21, 344);
            this.btnAltaServicios.Name = "btnAltaServicios";
            this.btnAltaServicios.Size = new System.Drawing.Size(115, 44);
            this.btnAltaServicios.TabIndex = 16;
            this.btnAltaServicios.Text = "Alta Servicios";
            this.btnAltaServicios.UseVisualStyleBackColor = false;
            this.btnAltaServicios.Click += new System.EventHandler(this.btnAltaServicios_Click);
            // 
            // groupBoxAdministrarDatos
            // 
            this.groupBoxAdministrarDatos.Controls.Add(this.btnCargarClientes);
            this.groupBoxAdministrarDatos.Controls.Add(this.btnGuardarClientes);
            this.groupBoxAdministrarDatos.Font = new System.Drawing.Font("Noto Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAdministrarDatos.Location = new System.Drawing.Point(1106, 511);
            this.groupBoxAdministrarDatos.Name = "groupBoxAdministrarDatos";
            this.groupBoxAdministrarDatos.Size = new System.Drawing.Size(315, 187);
            this.groupBoxAdministrarDatos.TabIndex = 16;
            this.groupBoxAdministrarDatos.TabStop = false;
            this.groupBoxAdministrarDatos.Text = "Datos";
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.BackColor = System.Drawing.Color.Plum;
            this.btnCargarClientes.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarClientes.Location = new System.Drawing.Point(172, 46);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(115, 70);
            this.btnCargarClientes.TabIndex = 18;
            this.btnCargarClientes.Text = "Cargar Clientes";
            this.btnCargarClientes.UseVisualStyleBackColor = false;
            this.btnCargarClientes.Click += new System.EventHandler(this.btnCargarClientes_Click);
            // 
            // btnGuardarClientes
            // 
            this.btnGuardarClientes.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGuardarClientes.Font = new System.Drawing.Font("Noto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarClientes.Location = new System.Drawing.Point(21, 46);
            this.btnGuardarClientes.Name = "btnGuardarClientes";
            this.btnGuardarClientes.Size = new System.Drawing.Size(115, 70);
            this.btnGuardarClientes.TabIndex = 17;
            this.btnGuardarClientes.Text = "Guardar Clientes";
            this.btnGuardarClientes.UseVisualStyleBackColor = false;
            this.btnGuardarClientes.Click += new System.EventHandler(this.btnGuardarClientes_Click);
            // 
            // FrmAdministracionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1479, 722);
            this.Controls.Add(this.groupBoxAdministrarDatos);
            this.Controls.Add(this.groupBoxServicios);
            this.Controls.Add(this.lblCatClienteMenu);
            this.Controls.Add(this.lblNmeClienteMenu);
            this.Controls.Add(this.lblTpClienteMenu);
            this.Controls.Add(this.gpbDatosCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblListadoEmpleados);
            this.Controls.Add(this.lstClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdministracionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdministracionClientes_FormClosing);
            this.gpbDatosCliente.ResumeLayout(false);
            this.gpbDatosCliente.PerformLayout();
            this.groupBoxServicios.ResumeLayout(false);
            this.groupBoxServicios.PerformLayout();
            this.groupBoxAdministrarDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblListadoEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.GroupBox gpbDatosCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label lblFechaAnalisis;
        private System.Windows.Forms.DateTimePicker dateFechaAnalisis;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.ComboBox cmbCategoriaCliente;
        private System.Windows.Forms.Label lblCategoriaCliente;
        private System.Windows.Forms.TextBox txtBoxCuilCuit;
        private System.Windows.Forms.Label lblCuitCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTpClienteMenu;
        private System.Windows.Forms.Label lblNmeClienteMenu;
        private System.Windows.Forms.Label lblCatClienteMenu;
        private System.Windows.Forms.GroupBox groupBoxServicios;
        private System.Windows.Forms.Button buttonMostrarServicios;
        private System.Windows.Forms.Button btnAltaServicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoInfeccion;
        private System.Windows.Forms.Label lblCostoServicio;
        private System.Windows.Forms.TextBox txtCostoServicio;
        private System.Windows.Forms.Label lblDificultadVirus;
        private System.Windows.Forms.ComboBox cmbDificultadVirus;
        private System.Windows.Forms.GroupBox groupBoxAdministrarDatos;
        private System.Windows.Forms.Button btnCargarClientes;
        private System.Windows.Forms.Button btnGuardarClientes;
    }
}