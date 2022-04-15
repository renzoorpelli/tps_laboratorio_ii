using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// Convierte un numero binario a decimal 
        /// </summary>
        /// <param name="numero">recibe numero como string</param>
        /// <returns>retorna numero decimal convertido a string </returns>
        public string BinarioDecimal(string numero)
        {
            char[] charArray = numero.ToCharArray();
            Array.Reverse(charArray); 
            int sumador = 0; 
            string resultado;

            if (!EsBinario(numero))
            {
                resultado =  "Valor inválido";
            }
            else
            {
                for (int i = 0; i < charArray.Length; i++) 
                {
                    if(charArray[i] == '1') 
                    {
                        sumador += (int)Math.Pow(2, i);
                    }
                }
                resultado = sumador.ToString();
                
            }
            return resultado;
        }

        /// <summary>
        /// convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero">recibe un numero decimal del tipo double</param>
        /// <returns>retorna el numero binario en tipo string</returns>
        public string DecimalBinario(double numero)
        {
            string numeroBinario = string.Empty;
            int numeroAbsoluto;
            int calculador;
            numeroAbsoluto = Math.Abs((int)numero);

            if(numeroAbsoluto == 0)
            {
                numeroBinario = "0";
            }
            else
            {
                while (numeroAbsoluto > 0)
                {
                    calculador = numeroAbsoluto % 2;
                    numeroAbsoluto /= 2;
                    numeroBinario = calculador.ToString() + numeroBinario;
                }
            }

            return numeroBinario;
        }

        /// <summary>
        /// recibe un numero decimal en tipo string y lo parsea, y se lo pasa a la funcion encargada de transformalo en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna el numero binario en tipo string en caso de operación exitosa o "valor inválido" si surgió un problema</returns>
        public string DecimalBinario(string numero)
        {
            double binaryDouble;
            if (Double.TryParse(numero, out binaryDouble))
            {
                return DecimalBinario(binaryDouble);
            }
            return "Valor inválido";
        }

        /// <summary>
        /// recibe un binario y se fija que su cadena este contenida por 0 y 1
        /// </summary>
        /// <param name="binario">numero binario en tipo string</param>
        /// <returns>devolvera true si la operación fue exitosa o false si surgió un problema</returns>
        public bool EsBinario (string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// constructor operando setea por default el numero a 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// constructur recibe un numero double y se lo pasa al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// constructor Operando recibe un numero en tipo string, lo valida y se lo pasa a el atributo numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.numero = ValidarOperando(strNumero);
        }

        // sobrecargar operadores aritmeticos
        /// <summary>
        /// sobrecarga el operador - para que este haga una resta de dos numeros
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">segundo numero</param>
        /// <returns>el resultado de la resta</returns>
        public static double operator  -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// sobrecarga el operador * para que este haga una multiplicación de dos numeros
        /// </summary>
        /// <param name="n1">primer numero</param>
        /// <param name="n2">primer nuero</param>
        /// <returns>el resultado de la mutliplicación</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// sobrecarga el operador / para que este haga una división de dos numeros
        /// </summary>
        /// <param name="n1">el primer numero</param>
        /// <param name="n2">el segundo numero</param>
        /// <returns>retorna el resultado de la división</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;

        }
        /// <summary>
        /// sobrecarga el operador + para que este haga una suma de dos numeros
        /// </summary>
        /// <param name="n1">el primer numero</param>
        /// <param name="n2">el segundo numero</param>
        /// <returns>retorna el resultado de la resta</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Propiedad encargada de setear el numero validado 
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero  = ValidarOperando(value);
            }
        }
        /// <summary>
        /// recibe un numero de tipo string lo parsea y lo devuelve en tipo double
        /// </summary>
        /// <param name="strNumero">numero de tipo string</param>
        /// <returns>retorna el numero que recibe en tipo double, si surge un problema retornará 0 como default</returns>
        public double ValidarOperando(string strNumero)
        {
            double toNumber;

            if(Double.TryParse(strNumero, out toNumber))
            {
                return toNumber;
            }
            return 0;
        }

    }
}
