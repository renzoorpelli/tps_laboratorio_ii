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
    public partial class FrmAltaCliente : Form
    {
        private AdministracionEmpresa administracion;
        public FrmAltaCliente(AdministracionEmpresa administracion)
        {
            InitializeComponent();
            
            this.administracion = administracion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            string mensajeAlerta = string.Empty;
            try
            {
                if (TextBoxValidos() && NombreValido(this.txtNombre.Text) && CuitOCuilInvalido(this.txtBoxCuilCuit.Text)) // modificado
                {
                    if (this.cmbTipoCliente.SelectedItem.ToString() == "Empresa")
                    {
                        cliente = new ClienteEmpresa((Cliente.categoriaCliente)this.cmbCategoriaCliente.SelectedItem, this.txtNombre.Text, this.txtBoxCuilCuit.Text, this.txtDomicilio.Text);

                    }
                    else
                    {
                        cliente = new ClienteParticular((Cliente.categoriaCliente)this.cmbCategoriaCliente.SelectedItem, this.txtNombre.Text, this.txtBoxCuilCuit.Text, this.txtDomicilio.Text);
                    }
                    if (administracion + cliente)
                    {
                        mensajeAlerta = "Se agregó nuevo cliente exitosamente!";
                    }
                    else
                    {
                        mensajeAlerta = "No se agregó al cliente";
                    }
                    MessageBox.Show(mensajeAlerta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algunos campos estan vacioso los datos son incorrectos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NombreInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CuitOCuilInvalidoException ex)
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
            this.LimpiarFormAltaCliente();
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


        #region validaciones 
        /// <summary>
        /// Verifica que los campos de ingreso de clientes tengan datos ingresados, caso contrario lanzara una excepcion de tipo CamposVaciosException en forma de mensaje
        /// </summary>
        /// <returns>true si los campos estan llenos o una excepcion si los campos estan vacios</returns>
        /// <exception cref="CamposVaciosException"></exception>
        private bool TextBoxValidos()
        {
            if (string.IsNullOrWhiteSpace(this.txtNombre.Text) || string.IsNullOrWhiteSpace(this.txtBoxCuilCuit.Text) || string.IsNullOrWhiteSpace(this.txtDomicilio.Text))
            {
                throw new CamposVaciosException("Algunos campos son invalidos");
            }
            return true;
        }


        private bool NombreValido(string nombre)
        {
            if (int.TryParse(nombre, out int num))
            {
                throw new NombreInvalidoException("El nombre es invalido, revise el campo");
            }
            return true;
        }

        private bool CuitOCuilInvalido(string cuitOcuil)
        {
            if (!int.TryParse(cuitOcuil, out int num))
            {
                throw new CuitOCuilInvalidoException("El Cuit/Cuil es invalido, revise el campo");
            }
            return true;
        }
        #endregion


        private void LimpiarFormAltaCliente()
        {
            this.txtNombre.Text = " ";
            this.txtBoxCuilCuit.Text = " ";
            this.txtDomicilio.Text = " ";
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            this.cmbCategoriaCliente.DataSource = Enum.GetValues(typeof(Cliente.categoriaCliente));
            this.cmbTipoCliente.DataSource = new List<string> { "Cliente Particular", "Empresa" };
        }

        private void FrmAltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
