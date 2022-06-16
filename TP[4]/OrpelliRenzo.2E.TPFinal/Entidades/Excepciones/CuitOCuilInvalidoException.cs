using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CuitOCuilInvalidoException : Exception
    {
        public CuitOCuilInvalidoException()
        {
        }

        public CuitOCuilInvalidoException(string message) : base(message)
        {
        }

        public CuitOCuilInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CuitOCuilInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
