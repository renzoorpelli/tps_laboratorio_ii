using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ServicioNoSeleccionadoException : Exception
    {
        public ServicioNoSeleccionadoException()
        {
        }

        public ServicioNoSeleccionadoException(string message) : base(message)
        {
        }

        public ServicioNoSeleccionadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServicioNoSeleccionadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
