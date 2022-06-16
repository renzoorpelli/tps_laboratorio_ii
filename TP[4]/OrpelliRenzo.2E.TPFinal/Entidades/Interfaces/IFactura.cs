using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface  IFactura
    {
        /// <summary>
        /// metodo emitir factura que devolvera los datos del cliente, con sus servicios y el total por ellos  
        /// </summary>
        /// <returns>retornara la informacion en un string</returns>
        string EmitirFactura();
    }
}
