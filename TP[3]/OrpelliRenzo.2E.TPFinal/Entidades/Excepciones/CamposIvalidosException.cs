using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CamposIvalidosException : Exception
    {
        public CamposIvalidosException()
        {
        }

        public CamposIvalidosException(string message) : base(message)
        {
        }

        public CamposIvalidosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CamposIvalidosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
