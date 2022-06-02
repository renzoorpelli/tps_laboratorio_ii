using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servicio
    {
        public enum tipoVirus { Malware, Ramsomware, Troyano, Adware, Gusano }
        public enum dificultadVirus { Facil, Medio, Dificil}

        public double costoServicio;
        public dificultadVirus dificultadServicio;
        public tipoVirus tipoInfeccion;
        private DateTime fechaAnalisis;

        #region constructor
        public Servicio()
        {

        }
        public Servicio(double costoServicio, dificultadVirus dificultadServicio, tipoVirus tipoInfeccion, DateTime fechaAnalisis)
        {
            this.costoServicio = costoServicio;
            this.dificultadServicio = dificultadServicio;
            this.tipoInfeccion = tipoInfeccion;
            this.fechaAnalisis = fechaAnalisis;
        }
        #endregion

        #region propiedades


        public tipoVirus TipoInfeccion
        {
            get { return this.tipoInfeccion; }
        }

        public dificultadVirus DificultadServicio
        { 
            get { return this.dificultadServicio; } 
        }

       public double CostoServicio
        {
            get { return this.costoServicio; }
            set 
            {
                if(value > 0)
                {
                    costoServicio = value; 
                }
            }  
        }

        public DateTime FechaAnalisis
        {
            get
            {
                return this.fechaAnalisis;
            }
            set { this.fechaAnalisis = value; }
        }
        #endregion

        #region metodos

        private string MostrarDatosServicio()
        {
            return $"Tipo Virus: {this.TipoInfeccion} -  Dificultad Servicio: {this.DificultadServicio} - Costo Servicio: {this.CostoServicio} - Fecha de Analsis: {this.FechaAnalisis}";
        }

        public override string ToString()
        {
            return this.MostrarDatosServicio();
        }

        public static bool operator ==(Cliente cliente, Servicio servicio)
        {
            return cliente.ListaServiciosCliente.Contains(servicio);
        }

        public static bool operator !=(Cliente cliente, Servicio servicio)
        {
            return !(cliente == servicio);
        }


        /// <summary>
        /// sobrecarga operador + verificar que los parametros no sean nulos y en caso de no serlo agrega un servicio a la lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns></returns>
        public static bool operator +(Cliente cliente, Servicio servicio)
        {
            if (cliente is not null && servicio is not null)
            {
                Servicio.AplicarDescuentoCliente(cliente, servicio);
                cliente.ListaServiciosCliente.Add(servicio);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Si la lista contiene el servicio lo elimina mostrando un mensaje por pantalla
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns></returns>
        public static string operator -(Cliente cliente, Servicio servicio)
        {
            string resultado = "Servicio no encontrado";
            if (cliente == servicio)
            {
                resultado = "Servicio  Removido con exito";
                cliente.ListaServiciosCliente.Remove(servicio);
            }
            return resultado;

        }

        public static void AplicarDescuentoCliente(Cliente cliente, Servicio servicio)
        {
            if (cliente.CategoriaDelCliente == Cliente.categoriaCliente.Premium)
            {
                servicio.CostoServicio = servicio.CostoServicio - (servicio.CostoServicio * 0.1);
            }
            else
            {
                servicio.CostoServicio = servicio.CostoServicio - (servicio.CostoServicio * 0);
            }

        }

        #endregion


    }
}
