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

        private void FrmAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipoCliente.SelectedItem.ToString() == "Empresa")
            {
                this.lblNombre.Text = "Razon Social";
                this.lblCuitCuil.Text = "CUIT Empresa";
                this.lblDomicilio.Text = "Domicilio Legal";
            }
            else
            {
                this.lblNombre.Text = "Nombre Completo";
                this.lblCuitCuil.Text = "CUIL Persona";
                this.lblDomicilio.Text = "Domicilio Particular";
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxValidos())
                {
                    this.cliente.NombreCliente = this.txtNombre.Text;
                    cliente.CategoriaDelCliente = (Cliente.categoriaCliente)this.cmbCategoriaCliente.SelectedItem;
                    cliente.DomicilioCliente = this.txtDomicilio.Text;
                    if (cliente is ClienteEmpresa)
                    {
                        ((ClienteEmpresa)cliente).CuitEmpresa = this.txtBoxCuilCuit.Text;


                    }
                    else if (cliente is ClienteParticular)
                    {

                        ((ClienteParticular)cliente).CuilPersona = this.txtBoxCuilCuit.Text;
                    }
                    this.Close();
                }

            }catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cliente.NombreCliente;
            this.cmbCategoriaCliente.SelectedItem = cliente.CategoriaDelCliente;
            this.txtDomicilio.Text = cliente.DomicilioCliente;
            if (cliente is ClienteEmpresa)
            {
                this.txtBoxCuilCuit.Text = ((ClienteEmpresa)cliente).CuitEmpresa;
                this.cmbTipoCliente.Enabled = false;
            }
            else if (cliente is ClienteParticular)
            {               
                this.txtBoxCuilCuit.Text = ((ClienteParticular)cliente).CuilPersona;
                this.cmbTipoCliente.Enabled = false;
            }

        }

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
    }
}
