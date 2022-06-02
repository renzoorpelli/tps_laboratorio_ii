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

        public override string TipoCliente
        {
            get { return typeof(ClienteParticular).Name; }
        }
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

        protected override string MostrarCliente()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cliente : {this.GetType().Name}");
            datos.AppendLine($"Nombre Cliente : {base.NombreCliente}");
            datos.AppendLine($"Cuil Cliente : {this.CuilPersona}");
            datos.AppendLine($"Domicilio Cliente : {base.DomicilioCliente}");
            return datos.ToString();
        }


        public override string ToString()
        {
          return  $"{ this.GetType().Name}           { base.NombreCliente}                             {this.CategoriaDelCliente}";
        }

        public static bool operator ==(ClienteParticular e1, ClienteParticular e2)
        {
            return e1.CuilPersona == e2.CuilPersona;
        }
        public static bool operator !=(ClienteParticular e1, ClienteParticular e2)
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
