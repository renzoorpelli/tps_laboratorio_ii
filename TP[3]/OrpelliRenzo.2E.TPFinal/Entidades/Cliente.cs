using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(ClienteEmpresa)), XmlInclude(typeof(ClienteParticular))]
    public abstract class Cliente
    {
        public enum categoriaCliente { Premium, Classic }
        private categoriaCliente categoriaDelCliente;
        private string nombreCliente;
        private string domicilioCliente;
        private List<Servicio> listaServiciosCliente;


        #region propiedades

        public abstract string TipoCliente
        {
            get;
        }
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

        

        public categoriaCliente CategoriaDelCliente
        {
            get { return this.categoriaDelCliente; }
            set { this.categoriaDelCliente = value; }
        }


        public List<Servicio> ListaServiciosCliente
        {
            get { return this.listaServiciosCliente;}
        }


        #endregion


        #region constructor

        public Cliente()
        {
            this.listaServiciosCliente = new List<Servicio>();
        }
        public Cliente(string nombreCliente, string domicilioCliente, categoriaCliente categoria):this()
        {
            this.nombreCliente = nombreCliente;
            this.domicilioCliente = domicilioCliente;
            this.categoriaDelCliente = categoria;
        }
        #endregion




        #region metodos
        /// <summary>
        /// sobrecarga al operador, si dos clientes tienen el mismo nombre y domicilio son iguales
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns>true si son iguales,false de lo contrario</returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.NombreCliente == cliente2.NombreCliente && cliente1.DomicilioCliente == cliente2.DomicilioCliente;
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
        protected abstract string MostrarCliente();

        


        #endregion
    }
}
