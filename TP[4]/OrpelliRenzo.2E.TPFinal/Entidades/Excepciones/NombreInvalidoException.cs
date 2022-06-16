using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException()
        {
        }

        public NombreInvalidoException(string message) : base(message)
        {
        }

        public NombreInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NombreInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
