using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.GestorDeArchivos
{
    public abstract class GestorDeArchivo
    {
        protected string rutaBase;
        protected ETipo tipo;
        protected string nombreCarpeta;
        public enum ETipo { ClienteTXT, ClienteXML };

        protected GestorDeArchivo(string nombreCarpeta, ETipo tipo)
        {
            DirectoryInfo path = Directory.CreateDirectory($"{Environment.CurrentDirectory}\\{nombreCarpeta}\\{tipo}\\");
            rutaBase = path.FullName;
            this.tipo = tipo;
            this.nombreCarpeta = nombreCarpeta;
        }
    }
}
