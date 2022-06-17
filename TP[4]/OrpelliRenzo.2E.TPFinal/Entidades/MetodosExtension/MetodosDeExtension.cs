using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosExtension
{
    public static class MetodosDeExtension
    {
        public static double  CalcularPorcentaje(this double precio, double porcentaje)
        {
            return precio * porcentaje / 100;
        }

    }
}
