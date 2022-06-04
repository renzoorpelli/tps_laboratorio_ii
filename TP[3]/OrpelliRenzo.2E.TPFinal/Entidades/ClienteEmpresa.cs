using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Interfaces;
namespace Entidades
{
    public class ClienteEmpresa : Cliente , IFactura
    {
        #region atributos
        private string cuitEmpresa;

        #endregion


        #region constructores

        public ClienteEmpresa()
        {

        }
        public ClienteEmpresa(categoriaCliente categoriaEmpresa, string razonSocial,  string cuitEmpresa, string domicilioLegalEmpresa) 
            :base(razonSocial, domicilioLegalEmpresa, categoriaEmpresa)
        {   
            this.cuitEmpresa = cuitEmpresa;
        }
        #endregion


        #region propiedades
        

        /// <summary>
        /// propiedad encargada de obtener el tipo de cliente en string
        /// </summary>
        public override string TipoCliente
        {
            get { return typeof(ClienteEmpresa).Name; }
        }
        /// <summary>
        /// propiedad encargada de obtener o asignar valor a la propiedad cuitEmpresa
        /// </summary>
        public string CuitEmpresa
        {
            get { return this.cuitEmpresa; }
            set 
            { 
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.cuitEmpresa = value; 
                }
            }
        }

        #endregion


        #region metodos
        /// <summary>
        /// metodo encargado de mostrar los datos del cliente en string
        /// </summary>
        /// <returns></returns>
        protected override string MostrarCliente()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cliente :      {this.GetType().Name}");
            datos.AppendLine($"Razon Social : {base.NombreCliente}");
            datos.AppendLine($"Cuit Cliente : {this.CuitEmpresa}");
            datos.AppendLine($"Domicilio Cliente : {this.DomicilioCliente}");  
            return datos.ToString();

        }
        /// <summary>
        /// sobrecarga del metodo toString que mostrara algunos datos del cliente, se utilizara para el listbox del formulario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.GetType().Name}           { base.NombreCliente}                        {this.CategoriaDelCliente}";   
        }
        /// <summary>
        /// sobrecarga del operador ==  que recibe dos clientes de tipo empresa y compara por el atributo CuitEmpresa
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>en caso de ser iguales devuelve true, de lo contrario false</returns>
        public static bool operator == (ClienteEmpresa e1, ClienteEmpresa e2)
        {
            return e1.CuitEmpresa == e2.CuitEmpresa;
        }
        /// <summary>
        /// metodo que recibe dos clientes, y compara utilizando la sobrecarga del operador == 
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>en caso de ser distintos devuelve true, de lo contrario false</returns>
        public static bool operator !=(ClienteEmpresa e1, ClienteEmpresa e2)
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
