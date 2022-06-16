using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entidades.Interfaces;
using Entidades.Excepciones;

namespace Entidades.GestorDeArchivos
{
    public class Serializador<T> : GestorDeArchivo, IArchivo<T> where T : class, new()
    {
        public Serializador(ETipo tipo) : base("Archivos Cliente", tipo)
        {

        }
        /// <summary>
        /// metodo encargado de serializar la lista de clientes, recibe el nombre archivo y contenido de tipo generico
        /// lo serializara y guardara en la ruta especificada en la clase GestorDeArchivo
        /// </summary>
        /// <param name="nombreArchivo">string con el nombre del archivo</param>
        /// <param name="elemento"></param>
        /// <returns>un string con la ruta del archivo guardado o de caso contrario lanzara excepciones del tipo ArchivoNullException</returns>
        /// <exception cref="ArchivoNullException"></exception>
        public string Escribir(string nombreArchivo, T elemento)
        {
            string resultado = "Error al Guardar";

            try
            {
                if (tipo == ETipo.ClienteXML)
                {
                    if (ValidarExtension(nombreArchivo))
                    {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{rutaBase}\\{nombreArchivo}", Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            serializer.Serialize(xmlTextWriter, elemento);
                            resultado = $"Archivo Guardado Existosamente en {this.rutaBase}{nombreArchivo}";
                        }
                    }

                }
            }
            catch (ArchivoNullException ex)
            {
                resultado = ex.Message;
            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al escribir el archivo xml", ex);
            }
            return resultado;
        }
        /// <summary>
        /// metodo encargado de leer un archivo de tipo xml, deserializandolo y devolviendolo el objeto T 
        /// </summary>
        /// <param name="nombreArchivo">string con el nombre del archivo</param>
        /// <returns>returna el objeto deserializado, caso contrario lanzara excepcioones del tipo ArchivoNullException</returns>
        /// <exception cref="ArchivoNullException"></exception>
        public T Leer(string nombreArchivo)
        {
            try
            {
                if (tipo == ETipo.ClienteXML)
                {
                    if (ValidarExtension(nombreArchivo) && ExisteArchivo($"{rutaBase}\\{nombreArchivo}"))
                    {
                        using (XmlTextReader xmlTextReader = new XmlTextReader($"{rutaBase}\\{nombreArchivo}"))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(T));
                            return serializer.Deserialize(xmlTextReader) as T;
                        }
                    }
                }
            }
            catch (ArchivoNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al leer el archivo xml", ex);
            }
            return null;
        }

        #region Validaciones
        /// <summary>
        /// metodo encargado de validar la extension de un archivo xml
        /// </summary>
        /// <param name="nombreArchivo">string con el nombre del archivo</param>
        /// <returns>devolvera true si la extension fue xml de lo contrario lanzara un excelcion del tipo ArchivoNullException</returns>
        /// <exception cref="ArchivoNullException"></exception>
        public bool ValidarExtension(string nombreArchivo)
        {
            if (Path.GetExtension(nombreArchivo) != ".xml")
            {
                throw new ArchivoNullException("La extensión del archivo xml es invalida");
            }
            return true;
        }
        /// <summary>
        /// valida que el archivo que se le quiera pasar al metodo leer exista
        /// </summary>
        /// <param name="nombreArchivo">el nombre del archivo</param>
        /// <returns>true si existe, caso contrario una excepcion de tipo ArchivoNullException</returns>
        /// <exception cref="ArchivoNullException"></exception>
        private bool ExisteArchivo(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo))
            {
                return true;
            }
            throw new ArchivoNullException("El archivo no existe, presione 'Guardar Clientes'");
        }
        #endregion
    }
}
