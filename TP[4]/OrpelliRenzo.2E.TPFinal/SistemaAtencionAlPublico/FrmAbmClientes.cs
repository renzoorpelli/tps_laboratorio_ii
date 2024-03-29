﻿using System;
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
using Entidades.GestorDeArchivos;
using Entidades.GestorSQL;


namespace SistemaAtencionAlPublico
{
    //delegado encargado de recibir un formulario y referenciar al metodo InicarAltaCliente
    public delegate void AbrirFormulario (Form form);

    //delegado que hace referencia al metodo ActualizarListaClientes
    public delegate void ActualizarListaCliente();
    public partial class FrmAdministracionClientes : Form
    {
        private AdministracionEmpresa administracion;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private bool cargadoDesdeBaseDeDatos;

        //evento asociado a  el metodo ActualizarListaClientes
        public event ActualizarListaCliente ActualizarLista;

        public FrmAdministracionClientes()
        {
            InitializeComponent();
            this.cmbTipoInfeccion.DataSource = Enum.GetValues(typeof(Servicio.tipoVirus));
            this.cmbDificultadVirus.DataSource = Enum.GetValues(typeof(Servicio.dificultadVirus));
            this.administracion = new AdministracionEmpresa(300);
            if (lstClientes.Items.Count == 0)
            {
                this.groupBoxServicios.Enabled = false;
            }
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            ActualizarLista += ActualizarListaClientes;

        }

       

        /// <summary>
        ///  metodo perteneciente al evento Click del btnAltaCliente
        ///  instanciara un nuevo formulario de alta cliente el cual se ejecutara en un hilo secundario y permitira al usuario agregar clientes a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaCliente altaCliente = new FrmAltaCliente(administracion, cancellationToken, cancellationTokenSource, ActualizarLista);
                Task.Run(() => IniciarAltaClientes(altaCliente), cancellationToken);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// metodo encargado mostrar el formulario que se esta ejecutando en un hilo secundario
        /// preguntara si el el manipulador del control del formulario se creo en otro hilo y como la primera vez
        /// dara true invocara el delegado que referencia al metodo con los argumentos para permitir el control
        /// 
        /// </summary>
        /// <param name="altaCliente"></param>
        private void IniciarAltaClientes(Form altaCliente)
        {
            if (this.InvokeRequired)
            {
                AbrirFormulario form = IniciarAltaClientes;
                object[] args = { altaCliente };
                this.BeginInvoke(form, args);
            }
            else
            {
                altaCliente.ShowDialog();
            }

        }


        /// <summary>
        /// Metodo encargado de actualizar la lista de clientes y habilitar la carga de servicios si la lista 
        /// cuenta con clientes cargados, utilizara un delegfado del tipo Comparison para ordenar la lista por orden alfabetico de los nombres
        /// </summary>
        private void ActualizarListaClientes()
        {
            try
            {
                Comparison<Cliente> comparador = (Cliente c1, Cliente c2) => c1.NombreCliente.CompareTo(c2.NombreCliente);
                this.administracion.ListaClientes.Sort(comparador);
                this.lstClientes.DataSource = null;
                this.lstClientes.DataSource = administracion.ListaClientes;
                if (lstClientes.Items.Count > 0)
                {
                    this.groupBoxServicios.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //}
        /// <summary>
        /// metodo del evento click de btnEliminarCliente se encargar de eliminar un cliente de la lista verificando
        /// que la lista tenga clientes y que uno este seleccioado. En caso de ser un cliente de la base de datos eliminara sus servicios y el cliente.
        /// Si surge algun error capturara una excepcion de
        /// tipo ClienteNoSeleccionadoException
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            if(cargadoDesdeBaseDeDatos == true)
                            {
                                ServicioDAO.Borrar(clienteSeleccionado);
                                ClienteDAO.Borrar(clienteSeleccionado.CuitOCuil);
                            }
                           
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

        /// <summary>
        /// metodo del evento click del boton btnModificarCliente, se encargar de llevar todos los datos 
        /// del cliente seleccionado al nuevo formulario y renovara estos datos del cliente en la lista del 
        /// frmAbmCliente, tambien verificara que la lista tenga clientes y que uno sea seleccionado. Se le pasara como 
        /// argumento al form si el cliente es cargado desde la base de datos  o es cargado desde un archivo
        /// si surge algun error capturara una excepcion de tipo ClienteNoSeleccionadoException
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        modificarCliente = new FrmModificarCliente(clienteSeleccionado, administracion, cargadoDesdeBaseDeDatos);
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
        /// <summary>
        /// metodo encargado de validar que la fecha del servicio no sea mayor a la actual, si es mayor lanzara una
        /// exccepcion del tipo FechaServicioInvalidaException de lo contrario retornara true
        /// </summary>
        /// <param name="fechaServicio"></param>
        /// <returns></returns>
        /// <exception cref="FechServicioInvalidaException"></exception>
        private bool ValidarFecha(DateTime fechaServicio)
        {
            if (fechaServicio > DateTime.Now)
            {
                throw new FechServicioInvalidaException("La fecha ingresada es invalida, revise el campo");
            }
            return true;
        }

        /// <summary>
        /// metodo encargado de verificar si hay clientes en la lista (listbox) o si hay un cliente seleccionado.
        /// </summary>
        /// <returns>lanzara una excepcion de tipo ClienteNoSeleccionadoException si cumple las dos condiciones o true de lo contrario</returns>
        /// <exception cref="ClienteNoSeleccionadoException"></exception>
        private bool HayClientes()
        {
            if (this.lstClientes.Items.Count == 0 || this.lstClientes.SelectedIndex == -1)
            {
                throw new ClienteNoSeleccionadoException("No has seleccionado ningun cliente");
            }

            return true;
        }

        #endregion
        /// <summary>
        /// metodo del evento click de btnAltaServicio encargado de dar de alta a un cliente seleccionado, verificara si hay clientes o si se selecciona alguno 
        /// o de caso contrario capturar las siguientes excepciones:
        /// ClienteNoSeleccionadoException si ningun cliente es seleccionado o no hay clientes
        /// CamposIvalidosException si alguno de los campos es invalido
        /// FechServicioInvalidaException si la fecha de servicio es mayor a la actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            servicio = new Servicio(costoServicio, (Servicio.dificultadVirus)this.cmbDificultadVirus.SelectedItem, (Servicio.tipoVirus)this.cmbTipoInfeccion.SelectedItem, this.dateFechaAnalisis.Value, clienteSeleccionado.CuitOCuil);
                            if (clienteSeleccionado + servicio)
                            {
                                MessageBox.Show("Servicio Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if(cargadoDesdeBaseDeDatos == true)//todo analizar si se puede mejorar
                                {
                                    ServicioDAO.Alta(servicio);
                                }
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

        /// <summary>
        /// metodo del evento click del boton btnMostrarServicios encargado de mostrar los ervicios del cliente seleccionado, verificara si hay clientes
        /// en la lista o si hay un cliente seleccionado. De caso contario, capturara una excepcion de tipo ClienteNoSeleccionadoException
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMostrarServicios_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayClientes())
                {
                    Cliente? clienteSeleccionado = this.lstClientes.SelectedItem as Cliente;
                    if (clienteSeleccionado is not null)
                    {
                        FormServicios frmServicios = new FormServicios(clienteSeleccionado, clienteSeleccionado.ListaServiciosCliente, administracion, cargadoDesdeBaseDeDatos);
                        frmServicios.ShowDialog();
                    }
                }
            }
            catch (ClienteNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// metodo del evento click del  boton btnGuardarClientes encargado de serializar la lista de clientes con sus respectivos servicios en caso de tenerlos
        /// verificara que haya clientes en la lista, podra capturar las sigueintes excepciones: 
        /// ClienteNoSeleccionadoException si no hay clientes en la lista
        /// ArchivoNullException si surge algun problema al serializar
        /// si todo es correcto mostrara un mensaje por pantalla mostrando la ruta de guardado del archivo xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarClientes_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>(GestorDeArchivo.ETipo.ClienteXML);
            try
            {
                if (HayClientes())
                {
                    if(cargadoDesdeBaseDeDatos == false)
                    {
                        
                        mensaje = serializador.Escribir("listaClientes.xml", administracion.ListaClientes);
                    }
                    else
                    {
                        foreach(Cliente cliente in administracion.ListaClientes)
                        {
                            cliente.ListaServiciosCliente = ServicioDAO.LeerServicios(cliente);
                        }
                        mensaje = serializador.Escribir("listaClientes.xml", administracion.ListaClientes);
                    }
                   
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// metodo del evento click del boton btnCargarClientes encargado de cargar la lista de clientes del archivo xml, si el archivo es null
        /// capturara una excepcion de tipo ArchivoNullException y mostrara el error por pantalla, caso contrario mostrar un mensaje de 
        /// operacion exitosa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                this.cargadoDesdeBaseDeDatos = false;
                ProgressBarForm form = new ProgressBarForm();
                form.ShowDialog();
                Serializador<List<Cliente>> serializador = new Serializador<List<Cliente>>(GestorDeArchivo.ETipo.ClienteXML);
                this.administracion.ListaClientes.Clear();
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
        /// <summary>
        /// metodo del evento click del btnSalir encargado de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO borraste la lista actual
        private void btnCargarDesdeSQL_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.cargadoDesdeBaseDeDatos = true;
                ProgressBarForm form = new ProgressBarForm();
                form.ShowDialog();
                this.administracion.ListaClientes.Clear();
                this.administracion.ListaClientes = ClienteDAO.LeerDatos();            
                this.ActualizarListaClientes();
                MessageBox.Show("Lista cargada desde base de datos exitosamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }


        /// <summary>
        /// evento de cierre de formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}
