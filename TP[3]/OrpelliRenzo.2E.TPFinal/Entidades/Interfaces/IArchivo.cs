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
        /// <param name="nombreArchivo">el nombre del archivo</param>
        /// <param name="contenido">el contenido del objeto generico</param>
        /// <returns>un string que contiene el resultado de la operacion</returns>
        string Escribir(string nombreArchivo, T contenido);


        
        /// <summary>
        /// valida la extension de un archivo
        /// </summary>
        /// <param name="nombreArchivo">nombre del archivo</param>
        /// <returns>true si es correcta, de lo contrario una excepcion de tipo ArchivoNullException</returns>
        bool ValidarExtension(string nombreArchivo);

    }
}
