using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Excepciones;
using Entidades.GestorSQL;

namespace SistemaAtencionAlPublico
{
    public partial class FrmModificarCliente : Form
    {
        Cliente cliente;
        AdministracionEmpresa administracion;
        public FrmModificarCliente()
        {
            InitializeComponent();
        }


        public FrmModificarCliente(Cliente cliente, AdministracionEmpresa administracion) : this()
        {

            this.cmbCategoriaCliente.DataSource = Enum.GetValues(typeof(Cliente.categoriaCliente));
            this.cmbTipoCliente.DataSource = new List<string> { "Cliente Particular", "Empresa" };
            this.cliente = cliente;
            this.administracion = administracion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxValidos() && NombreValido(txtNombre.Text))
                {
                    this.cliente.NombreCliente = this.txtNombre.Text;
                    cliente.CategoriaDelCliente = (Cliente.categoriaCliente)this.cmbCategoriaCliente.SelectedItem;
                    cliente.DomicilioCliente = this.txtDomicilio.Text;
                    ClienteDAO.Modificar(cliente);
                    
                    this.Close();
                }

            }
            catch(NombreInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cliente.NombreCliente;
            this.cmbCategoriaCliente.SelectedItem = cliente.CategoriaDelCliente;
            this.txtDomicilio.Text = cliente.DomicilioCliente;
            this.txtBoxCuilCuit.Text = cliente.CuitOCuil;
            if (cliente is ClienteEmpresa)
            {
                this.lblNombre.Text = "Razon Social";
                this.lblCuitOCuil.Text = "CUIT Empresa";
                this.lblDomicilio.Text = "Domicilio Legal";
                this.txtBoxCuilCuit.Enabled = false;
                this.cmbTipoCliente.Enabled = false;
            }
            else if (cliente is ClienteParticular)
            {
                this.lblNombre.Text = "Nombre Completo";
                this.lblCuitOCuil.Text = "CUIL Persona";
                this.lblDomicilio.Text = "Domicilio Particular";
                this.txtBoxCuilCuit.Enabled = false;
                this.cmbTipoCliente.Enabled = false;
            }

        }
        #region validaciones
        /// <summary>
        /// valida que los textbox sean validos y en caso de que alguno no lo sea lanza una excepcion del tipo CamposVaciosException
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CamposVaciosException"></exception>
        private bool TextBoxValidos()
        {
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtBoxCuilCuit.Text) || string.IsNullOrWhiteSpace(this.txtDomicilio.Text))
            {
                throw new CamposVaciosException("Algunos campos son invalidos");
            }
            return true;
        }

        /// <summary>
        /// metodo encargado de verificar si el nombre ingresado es valido 
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true si el nombre es valido, excepcion de tipo NombreInvalidoException en caso de no serlo</returns>
        /// <exception cref="NombreInvalidoException"></exception>
        private bool NombreValido(string nombre)
        {
            if (int.TryParse(nombre, out int num) || nombre.Length < 3)
            {
                throw new NombreInvalidoException("El nombre es invalido, revise el campo");
            }
            return true;
        }

        
        #endregion
    }
}
