using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ClienteSinServiciosException : Exception
    {
        public ClienteSinServiciosException()
        {
        }

        public ClienteSinServiciosException(string message) : base(message)
        {
        }

        public ClienteSinServiciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClienteSinServiciosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
