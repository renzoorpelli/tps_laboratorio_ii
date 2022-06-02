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
using Entidades.GestorDeArchivos;
using Entidades.Excepciones;
namespace SistemaAtencionAlPublico
{
    public partial class FormServicios : Form
    {
        Cliente cliente;
        List<Servicio> listaServicios;
        AdministracionEmpresa administracion;
        public FormServicios(Cliente cliente, List<Servicio> listaServicios, AdministracionEmpresa administracion)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.listaServicios = listaServicios;
            this.administracion = administracion;
        }

        /// <summary>
        /// metodo encargado de actualizar los elementos de el listbox 
        /// </summary>
        private void ActualizarLista()
        {
            this.lstbServicios.DataSource = null;
            this.lstbServicios.DataSource = listaServicios;
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }
        /// <summary>
        /// Metodo encargado de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo encargado de eliminar un servico de la lista, verificara si la lista tiene servicios y en caso de tenerlos eliminara
        /// el servicio seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayServicios())
                {
                    Servicio? servicioSeleccionado = this.lstbServicios.SelectedItem as Servicio;
                    if (servicioSeleccionado is not null)
                    {
                        DialogResult resultado = MessageBox.Show("¿Está seguro que quiere eliminar el servicio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            MessageBox.Show(this.cliente - servicioSeleccionado, "Servicio Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        this.ActualizarLista();
                    }
                }
            }
            catch (ServicioNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Metodo encargada de emitir la factura del cliente seleccionado, se verificara que haya servicios en la lista y creara un archivo de tipo
        /// txt con todos los datos del cliente y su total por los servicios. 
        /// En caso de que el cliente no tengar servicios capturara una excepcion  de tipo ServicioNoSeleccionadoException.
        /// En caso de no poder escribir el archivo txt capturara una excepcion de tipo ArchivoNullException.
        /// Por cualquier otro caso capturara la excepcion de tipo Exception. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if(HayServicios())
                {
                    ArchivoTxt factura = new ArchivoTxt();
                    if (this.cliente is ClienteEmpresa)
                    {
                        MessageBox.Show(factura.Escribir($"{this.cliente.NombreCliente}.txt", ((ClienteEmpresa)cliente).EmitirFactura()), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(factura.Escribir($"{this.cliente.NombreCliente}.txt", ((ClienteParticular)cliente).EmitirFactura()), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 

            }catch (ServicioNoSeleccionadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(ArchivoNullException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo encargada de fijarse si los elementos de la listbox son iguales a 0 (es decir, no hay elementos cargados) o si el indice seleccionado de la listbox es -1 (ningun elemento seleccionado)
        /// </summary>
        /// <returns>true si las condiciones no se cumplen o una excepcion de tipo ServicioNoSeleccionadoException en caso de que la condicion se cumpla</returns>
        /// <exception cref="ServicioNoSeleccionadoException"></exception>
        private bool HayServicios()
        {
            if (this.lstbServicios.Items.Count == 0 || this.lstbServicios.SelectedIndex == -1)
            {
                throw new ServicioNoSeleccionadoException("No has seleccionado ningun servicio");
            }

            return true;
        }
    }
}
