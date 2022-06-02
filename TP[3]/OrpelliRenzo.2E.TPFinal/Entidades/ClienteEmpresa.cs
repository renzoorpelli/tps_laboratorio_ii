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

        public override string TipoCliente
        {
            get { return typeof(ClienteEmpresa).Name; }
        }
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

        protected override string MostrarCliente()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cliente : {this.GetType().Name} ");
            datos.AppendLine($"Razon Social : {base.NombreCliente} ");
            datos.AppendLine($"Cuit Cliente : {this.CuitEmpresa} ");
            datos.AppendLine($"Domicilio Cliente : {this.DomicilioCliente} ");  
            return datos.ToString();

        }

        public override string ToString()
        {
            return $"{ this.GetType().Name}           { base.NombreCliente}                        {this.CategoriaDelCliente}";   
        }

        public static bool operator == (ClienteEmpresa e1, ClienteEmpresa e2)
        {
            return e1.CuitEmpresa == e2.CuitEmpresa;
        }
        public static bool operator !=(ClienteEmpresa e1, ClienteEmpresa e2)
        {
            return !(e1 == e2);
        }

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
