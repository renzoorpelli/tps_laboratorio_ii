using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ConexionSQLException : Exception
    {
        public ConexionSQLException()
        {
        }

        public ConexionSQLException(string message) : base(message)
        {
        }

        public ConexionSQLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConexionSQLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
