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
        #endregion

        #region constructores
        public ClienteParticular()
        {

        }
        public ClienteParticular(categoriaCliente categoriaPersona, string nombrePersona, string cuitOcuil, string domicilioPersona)
            : base(nombrePersona, domicilioPersona, categoriaPersona, cuitOcuil)
        {           
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
        


        #endregion


        #region metodos
        /// <summary>
        /// metodo encargado de mostrar los datos del cliente en tipo string
        /// </summary>
        /// <returns></returns>
        protected override string MostrarCliente()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cliente :        {this.GetType().Name}");
            datos.AppendLine($"Nombre Cliente : {base.NombreCliente}");
            datos.AppendLine($"CUIL Persona :   {this.CuitOCuil}");
            datos.AppendLine($"Domicilio Cliente : {base.DomicilioCliente}");
            return datos.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo toString que mostrara algunos datos del cliente, se utilizara para el listbox del formulario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
          return  $"{this.GetType().Name}           { base.NombreCliente}                             {this.CategoriaDelCliente}";
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
