using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// se encarga de realizar la operación con los parámetros que recibe
        /// </summary>
        /// <param name="n1">número de tipo Operando</param>
        /// <param name="n2">número de tipo Operando</param>
        /// <param name="operador">el operador aritmético en tipo Char</param>
        /// <returns>retorna el resultado de la operación</returns>
        public static double Operar(Operando n1, Operando n2, char operador)
        {
            double operacion;
            switch (ValidarOperador(operador))
            {
                case '+':
                    operacion = n1 + n2;
                    break;
                case '*':
                    operacion = n1 * n2;
                    break;
                case '/':
                    operacion = n1 / n2;
                    break;
                case '-':
                    operacion = n1 - n2;
                    break;
                default:
                    operacion = n1 + n2;
                break;
            }
            return operacion;
        }

        /// <summary>
        /// valida que el operador que recibe sea válido
        /// </summary>
        /// <param name="operador">el operador aritmético en tipo Char</param>
        /// <returns>retorna el operador aritmético y si este no existe retorna "+" por defecto</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '/' || operador == '*' || operador == '-')
            {
                return operador;
            }
            return '+';
        }
    }
}
