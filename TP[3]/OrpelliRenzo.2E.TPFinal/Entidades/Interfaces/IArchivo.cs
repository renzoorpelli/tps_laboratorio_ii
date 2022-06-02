using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Guarda un archivo del tipo Objeto Generico en la ruta indicada
        /// </summary>
        /// <param name="ruta">es el directorio del archivo</param>
        /// <param name="nombreArchivo">el nombre del archivo</param>
        /// <param name="contenido">el contenido del objeto generico</param>
        /// <returns>true si la operacion fue realizada con exito</returns>
        string Escribir(string nombreArchivo, T contenido);


        /// <summary>
        /// Lee los datos de un archivo con un objeto del tipo generico
        /// </summary>
        /// <param name="ruta">el directorio del archivo</param>
        /// <returns>retorna el objeto</returns>
        T Leer(string ruta);
    }
}
