using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ErrorModificarSQLException : Exception
    {
        public ErrorModificarSQLException()
        {
        }

        public ErrorModificarSQLException(string message) : base(message)
        {
        }

        public ErrorModificarSQLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorModificarSQLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
