using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ErrorAltaSQLException : Exception
    {
        public ErrorAltaSQLException()
        {
        }

        public ErrorAltaSQLException(string message) : base(message)
        {
        }

        public ErrorAltaSQLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorAltaSQLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
