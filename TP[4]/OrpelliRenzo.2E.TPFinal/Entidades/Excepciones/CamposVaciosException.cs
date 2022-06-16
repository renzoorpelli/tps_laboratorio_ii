using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CamposVaciosException : Exception
    {
        public CamposVaciosException()
        {
        }

        public CamposVaciosException(string message) : base(message)
        {
        }

        public CamposVaciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CamposVaciosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
