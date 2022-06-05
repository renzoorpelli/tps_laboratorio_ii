using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.Interfaces;
using Entidades.Excepciones;


namespace Entidades.GestorDeArchivos
{
    public class ArchivoTxt : GestorDeArchivo, IArchivo<string>
    {
        public ArchivoTxt() : base("Facturas Clientes", ETipo.ClienteTXT)
        {
        }

        /// <summary>
        /// Recibe el nombre del archivo y el contenido a escribir del mismo de tipo string y lo guarda en un archivo de tipo txt
        /// </summary>
        /// <param name="nombreArchivo">el nombre del archivo</param>
        /// <param name="contenido">el contenido del archivo en tipo string</param>
        /// <returns>devuelve un mensaje con el resultado de la operacion</returns>
        /// <exception cref="ArchivoNullException"></exception>
        public string Escribir(string nombreArchivo, string contenido)
        {
            string puedoLeer = "Error al escribir el archivo de texto";
            try
            {
                if (ValidarExtension(nombreArchivo))
                {
                    using (StreamWriter streamWriter = new StreamWriter($"{base.rutaBase}\\{nombreArchivo}"))
                    {
                        streamWriter.WriteLine(contenido);
                        puedoLeer = $"Archivo de Text Escrito con exito en {rutaBase}\\{nombreArchivo}";
                    }
                }

            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al escribir archivo de texto", ex);
            }
            return puedoLeer;


        }    

        /// <summary>
        /// valida la extension del archivo
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns>true si la extension del arcivo es .txt de lo contrario lanzara una excepcion de tipo ArchivoNullException </returns>
        /// <exception cref="ArchivoNullException"></exception>
        public bool ValidarExtension(string nombreArchivo)
        {
            if (Path.GetExtension(nombreArchivo) == ".txt")
            {
                return true;
            }
            throw new ArchivoNullException("La extensión del archivo txt es invalida");
        }

    }
}
