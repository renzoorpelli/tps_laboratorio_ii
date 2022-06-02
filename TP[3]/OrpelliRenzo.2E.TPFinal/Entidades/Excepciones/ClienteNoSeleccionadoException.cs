using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ClienteNoSeleccionadoException : Exception
    {
        public ClienteNoSeleccionadoException()
        {
        }

        public ClienteNoSeleccionadoException(string message) : base(message)
        {
        }

        public ClienteNoSeleccionadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClienteNoSeleccionadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
