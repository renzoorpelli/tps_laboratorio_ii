using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MetodosExtension
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// metodo encargado de calcular un procentaje sobre un tipo de dato double
        /// </summary>
        /// <param name="precio">la instancia de la variable que lo llama</param>
        /// <param name="porcentaje">es el porcentaje sobre el cual se quiere hacer el calculo</param>
        /// <returns>retorna el porcentaje</returns>
        public static double  CalcularPorcentaje(this double precio, double porcentaje)
        {
            return precio * porcentaje / 100;
        }
    }
}
