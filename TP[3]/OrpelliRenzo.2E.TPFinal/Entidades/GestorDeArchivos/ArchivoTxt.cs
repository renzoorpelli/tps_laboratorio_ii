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
        /// Recibe el nombre del archivo y el contenido a escribir del mismo de tipo string
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="contenido"></param>
        /// <returns></returns>
        /// <exception cref="ArchivoNullException"></exception>
        public string Escribir(string nombreArchivo, string contenido)
        {
            string puedoLeer = "Error al escribir el archivo de texto";
            try
            {
                if (ValidarExtensionTxt(nombreArchivo))
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
        /// recibe el archivo por parametro de tipo string
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns>devuelve el contenido del archivo, de lo contrario capturara una excepcion de tipo ArchivoNullException </returns>
        /// <exception cref="ArchivoNullException"></exception>
        public string Leer(string nombreArchivo)
        {
            try
            {
                if (ValidarExtensionTxt(nombreArchivo))
                {
                    using (StreamReader streamReader = new StreamReader($"{base.rutaBase}\\{nombreArchivo}"))
                    {
                        return streamReader.ReadToEnd();
                    }
                }

            }
            catch (ArchivoNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al leer el archivo", ex);
            }
            return null;
        }

        /// <summary>
        /// valida la extension del archivo
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns>true si la extension del arcivo es .txt de lo contrario lanzara una excepcion de tipo ArchivoNullException </returns>
        /// <exception cref="ArchivoNullException"></exception>
        public bool ValidarExtensionTxt(string nombreArchivo)
        {
            if (Path.GetExtension(nombreArchivo) == ".txt")
            {
                return true;
            }
            throw new ArchivoNullException("La extensión del archivo txt es invalida");
        }

    }
}
