using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Entidades.Excepciones;
using Entidades.GestorSQL;
namespace SistemaAtencionAlPublico
{
    public partial class FrmAltaCliente : Form
    {
        private AdministracionEmpresa administracion;
        private CancellationToken cancellationToken;
        CancellationTokenSource cancellation;
        Action eventoActualizarLista;
        public FrmAltaCliente(AdministracionEmpresa administracion, CancellationToken cancellationToken, CancellationTokenSource cancellation, Action eventoActualizar)
        {
            InitializeComponent();
            
            this.administracion = administracion;
            this.cancellation = cancellation;
            this.cancellationToken  = cancellationToken;
            this.eventoActualizarLista = eventoActualizar;
        }


        /// <summary>
        /// metodo del evento click de btnAltaCliente encargado de agregar un cliente a la lista, se verificaran que los campos ingresados sean 
        /// validos y de serlo se agregara el cliente a la lista, caso contrario se capturaran las excepciones:
        /// NombreInvalidoException si el nombre ingresado no es valido
        /// CuitOCuilInvalido si el cuit o cuil es invalido
        /// CamposVaciosException si algun campo esta vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            string mensajeAlerta = string.Empty;
            try
            {
                if (TextBoxValidos() && NombreValido(this.txtNombre.Text) && CuitOCuilInvalido(this.txtBoxCuilCuit.Text)) 
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
                        ClienteDAO.Alta(cliente);// añado el cliente a la base de datos
                        if (eventoActualizarLista is not null)
                        {
                            eventoActualizarLista.Invoke();
                        }
                    }
                    else
                    {
                        throw new CuitOCuilInvalidoException("El Cuit/Cuil ingresado ya se encuentra en la lista");
                    }
                    MessageBox.Show(mensajeAlerta, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
            catch (CantidadDeClientesAlcanzadaException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// <summary>
        /// metodo envento SelectedIndexChanged de cmbTipo Cliente el cual mostrara distintos label segun el tipo de cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                throw new CamposVaciosException("Algunos campos son invalidos o estan vacios, reviselos");
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
        /// <summary>
        /// metodo encargado de verificar si el cuit o cuil ingresado es valido
        /// </summary>
        /// <param name="cuitOcuil"></param>
        /// <returns>true si es valido o lanza una excepcion de tipo CuitOCuilInvalidoException en caso de no serlo </returns>
        /// <exception cref="CuitOCuilInvalidoException"></exception>
        private bool CuitOCuilInvalido(string cuitOcuil)
        {
            if (!double.TryParse(cuitOcuil, out double num) && cuitOcuil.Length < 10)
            {
                throw new CuitOCuilInvalidoException("El Cuit/Cuil es invalido, revise el campo (recomendado: 11 digitos y solo numeros)");
            }
            return true;
        }
        #endregion

        /// <summary>
        /// metodo encargado de "vaciar" los textbox utliziado para despues de la carga de un cliente
        /// </summary>
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
                    cancellation.Cancel();
                }
            }
        }
        /// <summary>
        /// metodo evento click btnSalir encargado de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
