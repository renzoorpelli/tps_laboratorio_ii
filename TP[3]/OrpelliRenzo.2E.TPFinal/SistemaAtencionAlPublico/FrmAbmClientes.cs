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
using Entidades.GestorDeArchivos;
namespace SistemaAtencionAlPublico
{
    public partial class FrmAdministracionClientes : Form
    {
        private AdministracionEmpresa administracion;


        public FrmAdministracionClientes()
        {
            InitializeComponent();
            this.cmbCategoriaCliente.DataSource = Enum.GetValues(typeof(Cliente.categoriaCliente));
            this.cmbTipoCliente.DataSource = new List<string> { "Cliente Particular", "Empresa" };
            this.cmbTipoInfeccion.DataSource = Enum.GetValues(typeof(Servicio.tipoVirus));
            this.cmbDificultadVirus.DataSource = Enum.GetValues(typeof(Servicio.dificultadVirus));
            this.administracion = new AdministracionEmpresa(50);//50 CLIENTES MAXIMO
            if (lstClientes.Items.Count == 0)
            {
                this.groupBoxServicios.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdministracionClientes_FormClosing(object sender, FormClosingEventArgs e)
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

            this.ActualizarListaClientes();
            this.LimpiarFormAltaCliente();
        }

        private void ActualizarListaClientes()
        {
            this.lstClientes.DataSource = null;
            this.lstClientes.DataSource = administracion.ListaClientes;
            if (lstClientes.Items.Count > 0)
            {
                this.groupBoxServicios.Enabled = true;
            }

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayClientes())
                {
                    Cliente? clienteSeleccionado = this.lstClientes.SelectedItem as Cliente;
                    if (clienteSeleccionado is not null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro que quiere eliminar el cliente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            MessageBox.Show(this.administracion - clienteSeleccionado, "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.ActualizarListaClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayClientes())
                {
                    FrmModificarCliente modificarCliente;
                    Cliente? clienteSeleccionado = this.lstClientes.SelectedItem as Cliente;
                    if (clienteSeleccionado is not null)
                    {
                        modificarCliente = new FrmModificarCliente(clienteSeleccionado, administracion);
                        modificarCliente.ShowDialog();
                    }

                }
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.ActualizarListaClientes();
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
        /// <summary>
        /// controla que el valor del servicio ingresado sea de tipo numerico
        /// </summary>
        /// <param name="importe">el importe ingresado del textbox</param>
        /// <param name="importeDouble">la variable donde se guardara el importe para pasarlo al objeto de tipo servicio</param>
        /// <returns>true si pudo o una excepcion de tipo campoInvalido</returns>
        /// <exception cref="CamposIvalidosException"></exception>
        private bool CostoServicioValido(string importe, out double importeDouble)
        {
            if (!double.TryParse(importe, out importeDouble))
            {
                throw new CamposIvalidosException("El Costo de servicio es inválido, revisar campo");
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

        private bool ValidarFecha(DateTime fechaServicio)
        {
            if (fechaServicio > DateTime.Now)
            {
                throw new FechServicioInvalidaException("La fecha ingresada es invalida, revise el campo");
            }
            return true;
        }


        private bool HayClientes()
        {
            if (this.lstClientes.Items.Count == 0 || this.lstClientes.SelectedIndex == -1)
            {
                throw new ClienteNoSeleccionadoException("No has seleccionado ningun cliente");
            }

            return true;
        }

        #endregion

        private void btnAltaServicios_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayClientes())
                {
                    Cliente? clienteSeleccionado = this.lstClientes.SelectedItem as Cliente;
                    double costoServicio;
                    Servicio servicio;
                    if (clienteSeleccionado is not null)
                    {
                        if (CostoServicioValido(this.txtCostoServicio.Text, out costoServicio) && ValidarFecha(this.dateFechaAnalisis.Value))
                        {
                            servicio = new Servicio(costoServicio, (Servicio.dificultadVirus)this.cmbDificultadVirus.SelectedItem, (Servicio.tipoVirus)this.cmbTipoInfeccion.SelectedItem, this.dateFechaAnalisis.Value);
                            if (clienteSeleccionado + servicio)
                            {
                                MessageBox.Show("Servicio Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CamposIvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FechServicioInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void LimpiarFormAltaCliente()
        {
            this.txtNombre.Text = " ";
            this.txtBoxCuilCuit.Text = " ";
            this.txtDomicilio.Text = " ";
        }


        private void buttonMostrarServicios_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayClientes())
                {
                    Cliente? clienteSeleccionado = this.lstClientes.SelectedItem as Cliente;
                    if (clienteSeleccionado is not null)
                    {
                        FormServicios frmServicios = new FormServicios(clienteSeleccionado, clienteSeleccionado.ListaServiciosCliente, administracion);
                        frmServicios.ShowDialog();
                    }
                }
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnGuardarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if(HayClientes())
                {
                    Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>(GestorDeArchivo.ETipo.ClienteXML);
                    string mensaje = serializador.Escribir("listaClientes.xml", administracion.ListaClientes);
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArchivoNullException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>(GestorDeArchivo.ETipo.ClienteXML);
                this.administracion.ListaClientes = serializador.Leer("listaClientes.xml");
                this.ActualizarListaClientes();
                MessageBox.Show("Lista cargada Exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArchivoNullException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
