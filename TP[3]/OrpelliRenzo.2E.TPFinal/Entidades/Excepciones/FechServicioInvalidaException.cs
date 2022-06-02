using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FechServicioInvalidaException : Exception
    {
        public FechServicioInvalidaException()
        {
        }

        public FechServicioInvalidaException(string message) : base(message)
        {
        }

        public FechServicioInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FechServicioInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
