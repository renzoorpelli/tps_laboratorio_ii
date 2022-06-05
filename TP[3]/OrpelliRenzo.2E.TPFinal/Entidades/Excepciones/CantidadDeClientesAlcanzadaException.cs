using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CantidadDeClientesAlcanzadaException : Exception
    {
        public CantidadDeClientesAlcanzadaException()
        {
        }
        /// <summary>
        /// crea una excepcion con un mensaje
        /// </summary>
        /// <param name="message">mensaje de la excepcion</param>
        public CantidadDeClientesAlcanzadaException(string message) : base(message)
        {
        }


        /// <summary>
        /// crea una expcecion con un emnsaje y su innerException
        /// </summary>
        /// <param name="message">el mensaje de la excepcion</param>
        /// <param name="innerException">la innerException de la excepcion</param>
        public CantidadDeClientesAlcanzadaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CantidadDeClientesAlcanzadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
