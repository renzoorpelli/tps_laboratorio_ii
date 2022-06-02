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
    public  class Serializador<T> : GestorDeArchivo,  IArchivo<T> where T: class, new()
    {
        public Serializador(ETipo tipo) : base("Archivos Cliente", tipo)
        {

        }

        public string Escribir(string nombreArchivo,T elemento)
        {
            string resultado = "Error al Guardar";

            try
            {
                if (tipo == ETipo.ClienteXML)
                {
                    if (ValidarExtensionXml(nombreArchivo))
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
            }catch(ArchivoNullException ex)
            {
                resultado = ex.Message;
            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al escribir el archivo xml", ex);
            }
            return resultado;
        }

        public T Leer(string nombreArchivo)
        {
            try
            {
                if(tipo == ETipo.ClienteXML)
                {
                    if (ValidarExtensionXml(nombreArchivo))
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
                throw ex;// REVISAR
            }
            catch (Exception ex)
            {
                throw new ArchivoNullException("Error al leer el archivo xml", ex);
            }
            return null;
        }

        #region Validaciones

        public bool ValidarExtensionXml(string nombreArchivo)
        {
            if(Path.GetExtension(nombreArchivo) != ".xml")
            {
                throw new ArchivoNullException("La extensión del archivo xml es invalida");
            }
            return true;
        }

        #endregion
    }
}
