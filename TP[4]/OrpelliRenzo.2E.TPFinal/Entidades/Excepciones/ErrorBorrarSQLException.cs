using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ErrorBorrarSQLException : Exception
    {
        public ErrorBorrarSQLException()
        {
        }

        public ErrorBorrarSQLException(string message) : base(message)
        {
        }

        public ErrorBorrarSQLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErrorBorrarSQLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
