using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MetodosExtension;
namespace Entidades
{
    public class Servicio
    {
        public enum tipoVirus { Malware, Ramsomware, Troyano, Adware, Gusano }
        public enum dificultadVirus { Facil, Medio, Dificil}

        private double costoServicio;
        private dificultadVirus dificultadServicio;
        private tipoVirus tipoInfeccion;
        private DateTime fechaAnalisis;
        private string cuilOCuitCliente;

        #region constructor
        public Servicio()
        {

        }
        public Servicio(double costoServicio, dificultadVirus dificultadServicio, tipoVirus tipoInfeccion, DateTime fechaAnalisis, string cuilOCuitCliente)
        {
            this.costoServicio = costoServicio;
            this.dificultadServicio = dificultadServicio;
            this.tipoInfeccion = tipoInfeccion;
            this.fechaAnalisis = fechaAnalisis;
            this.cuilOCuitCliente = cuilOCuitCliente;
        }
        #endregion

        #region propiedades

        /// <summary>
        /// propiedad encargada de retornar el tipo de infeccion del enumerado
        /// </summary>
        public tipoVirus TipoInfeccion
        {
            get { return this.tipoInfeccion; }
        }
        /// <summary>
        /// propiedad encargada de retornar el tipo de dificultad del enumerado
        /// </summary>
        public dificultadVirus DificultadServicio
        { 
            get { return this.dificultadServicio; } 
        }
        /// <summary>
        /// propiedad encargada de obtener y asignar un valor al servicio siempre que este sea un numero positivo
        /// </summary>
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
        /// <summary>
        /// propiedad encargada de obtener y asignar una fecha de analisis del tipo Datetime
        /// </summary>
        public DateTime FechaAnalisis
        {
            get
            {
                return this.fechaAnalisis;
            }
            set { this.fechaAnalisis = value; }
        }

        /// <summary>
        /// propiedad encargada de obtener  cuit del cliente del que se tiene los servicios
        /// </summary>
        public string CuilOCuitCliente
        {
            get { return this.cuilOCuitCliente; }
            set 
            { 
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.cuilOCuitCliente = value; 
                }
            }
        }
        #endregion

        #region metodos
        /// <summary>
        /// metodo encargado de retornar todos los datos del servicio
        /// </summary>
        /// <returns></returns>
        private string MostrarDatosServicio()
        {
            return $"Tipo Virus: {this.TipoInfeccion} -  Dificultad Servicio: {this.DificultadServicio} - Costo Servicio: {this.CostoServicio} - Fecha de Analisis: {this.FechaAnalisis}";
        }
        /// <summary>
        /// sobrecarga del metodo toString que llamara al metodo privado MostrarDatosServicio para que el listbox lo muestre de dicha manera
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatosServicio();
        }
        /// <summary>
        /// sobrecarga del operador == encargada de fijarse si un cliente ya posee el mismo servicio en la lista de servicios
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns>devuelve true en caso de tenerlo, false de lo contrario</returns>
        public static bool operator ==(Cliente cliente, Servicio servicio)
        {
            return cliente.ListaServiciosCliente.Contains(servicio);
        }
        /// <summary>
        /// sobrecarga del operador != que tomara como referencia la sobrecarga del operador == negada
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns>retornara true si son distintos, false de lo contrario</returns>
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
        /// <summary>
        /// metodo encargado de aplicar un descuento a un cliente sobre un servicio solo si el cliente es de tipo categoria premium
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        public static void AplicarDescuentoCliente(Cliente cliente, Servicio servicio)
        {
            if (cliente.CategoriaDelCliente == Cliente.categoriaCliente.Premium)
            {
                servicio.CostoServicio = servicio.CostoServicio - (servicio.CostoServicio.CalcularPorcentaje(10));
            }
            else
            {
                servicio.CostoServicio = servicio.CostoServicio - (servicio.CostoServicio * 0);
            }

        }

        #endregion


    }
}
