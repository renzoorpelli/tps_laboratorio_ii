using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades.Excepciones;

namespace Entidades
{
    [XmlInclude(typeof(ClienteEmpresa)), XmlInclude(typeof(ClienteParticular))]
    public abstract class Cliente
    {
        public enum categoriaCliente { Premium, Classic }
        private categoriaCliente categoriaDelCliente;
        private string nombreCliente;
        private string domicilioCliente;
        private string cuitOCuil;
        private List<Servicio> listaServiciosCliente;


        #region propiedades

        public string CuitOCuil
        {
            get { return this.cuitOCuil; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.cuitOCuil = value; 
                }
            }
        }
        public abstract string TipoCliente
        {
            get;
        }
        /// <summary>
        /// propiedad encargada de obtener o asginar valor al atributo nombreCliente
        /// </summary>
        public string NombreCliente
        {
            get { return this.nombreCliente; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombreCliente = value;
                }
            }
        }
        /// <summary>
        /// propiedad encargada de obtener o asginar valor al atributo domicilioCliente
        /// </summary>
        public string DomicilioCliente
        {
            get { return this.domicilioCliente; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.domicilioCliente = value;
                }
            }
        }


        /// <summary>
        /// propiedad encargada de obtener o asginar valor al atributo categoriaCliente
        /// </summary>
        public categoriaCliente CategoriaDelCliente
        {
            get { return this.categoriaDelCliente; }
            set { this.categoriaDelCliente = value; }
        }

        /// <summary>
        /// propiedad encargada de obtener la lista de servicios
        /// </summary>
        public List<Servicio> ListaServiciosCliente
        {
            get { return this.listaServiciosCliente; }
        }


        #endregion


        #region constructor

        public Cliente()
        {
            this.listaServiciosCliente = new List<Servicio>();
        }
        public Cliente(string nombreCliente, string domicilioCliente, categoriaCliente categoria, string cuitOCuil) : this()
        {
            this.nombreCliente = nombreCliente;
            this.domicilioCliente = domicilioCliente;
            this.categoriaDelCliente = categoria;
            this.cuitOCuil = cuitOCuil;
        }
        #endregion




        #region metodos
        /// <summary>
        /// sobrecarga al operador, si dos clientes tienen el mismo cuit o cuil
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns>true si son iguales,false de lo contrario</returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.cuitOCuil ==  cliente2.cuitOCuil;
            
        }


        /// <summary>
        /// compara que dos clientes sean distintos
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }
        /// <summary>
        /// metodo encargado de obtener los datos de un cliente en un string
        /// </summary>
        /// <returns></returns>
        protected abstract string MostrarCliente();


        

        #endregion
    }
}
