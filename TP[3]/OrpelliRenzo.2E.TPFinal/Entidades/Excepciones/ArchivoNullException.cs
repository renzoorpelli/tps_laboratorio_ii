using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ArchivoNullException : Exception
    {
        public ArchivoNullException()
        {
        }

        public ArchivoNullException(string message) : base(message)
        {
        }

        public ArchivoNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArchivoNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
