using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CantidadDeClientesAlcanzadaException : Exception
    {
        public CantidadDeClientesAlcanzadaException()
        {
        }

        public CantidadDeClientesAlcanzadaException(string message) : base(message)
        {
        }

        public CantidadDeClientesAlcanzadaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CantidadDeClientesAlcanzadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
