using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;
namespace Entidades
{
    public class ClienteParticular : Cliente, IFactura
    {
        #region atributos
        private string cuilPersona;
        #endregion

        #region constructores
        public ClienteParticular()
        {

        }
        public ClienteParticular(categoriaCliente categoriaPersona, string nombrePersona, string cuilPersona, string domicilioPersona)
            : base(nombrePersona, domicilioPersona, categoriaPersona)
        {           
            this.cuilPersona = cuilPersona;
        }
        #endregion

        #region propiedades
        /// <summary>
        /// propiedad encargada de obterner el tipo de cliente en string
        /// </summary>
        public override string TipoCliente
        {
            get { return typeof(ClienteParticular).Name; }
        }
        /// <summary>
        /// propiedad encargada de obtener y asignar valor a la propiedad cuilPersona
        /// </summary>
        public string CuilPersona
        {
            get { return this.cuilPersona; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.cuilPersona = value;

                }
            }
        }



        #endregion


        #region metodos
        /// <summary>
        /// metodo encargado de mostrar los datos del cliente en tipo string
        /// </summary>
        /// <returns></returns>
        protected override string MostrarCliente()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cliente : {this.GetType().Name}");
            datos.AppendLine($"Nombre Cliente : {base.NombreCliente}");
            datos.AppendLine($"Cuil Cliente : {this.CuilPersona}");
            datos.AppendLine($"Domicilio Cliente : {base.DomicilioCliente}");
            return datos.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo toString que mostrara algunos datos del cliente, se utilizara para el listbox del formulario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
          return  $"{ this.GetType().Name}           { base.NombreCliente}                             {this.CategoriaDelCliente}";
        }
        /// <summary>
        /// sobrecarga del operador ==  que recibe dos clientes de tipo empresa y compara por el atributo CuilPersona
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>en caso de ser iguales devuelve true, de lo contrario false</returns>
        public static bool operator ==(ClienteParticular e1, ClienteParticular e2)
        {
            return e1.CuilPersona == e2.CuilPersona;
        }
        /// <summary>
        ///sobrecarga del operador != que recibe dos clientes, y compara utilizando la sobrecarga del operador == 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>en caso de ser distintos devuelve true, de lo contrario false</returns>
        public static bool operator !=(ClienteParticular e1, ClienteParticular e2)
        {
            return !(e1 == e2);
        }
        /// <summary>
        /// metodo de la interfaz IFactura encargado de mostrar todos los datos del cliente,
        /// incluyendo los servicios y calculando el total por los servicios, Su funcion es 
        /// tratar de simular una factura
        /// </summary>
        /// <returns>devuelve la factura en tipo string</returns>
        public string EmitirFactura()
        {
            StringBuilder sb = new StringBuilder();
            double totalApagar = 0;
            sb.AppendLine(this.MostrarCliente());
            foreach (Servicio item in ListaServiciosCliente)
            {
                sb.AppendLine($"Serivicios Cliente : {item.ToString()}");
                totalApagar += item.CostoServicio;
            }
            sb.AppendLine($"Total A Pagar ${totalApagar}");
            return sb.ToString();
        }
        #endregion
    }
}
