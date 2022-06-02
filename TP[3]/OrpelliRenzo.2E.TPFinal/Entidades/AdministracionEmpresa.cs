﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades
{
    public class AdministracionEmpresa
    {
        private List<Cliente> listaClientes;
        private int cantidadClientesMaxima;


        #region constructor
        public AdministracionEmpresa()
        {

        }
        public AdministracionEmpresa(int cantidadClientesMaxima)
        {
            this.listaClientes = new List<Cliente>();
            this.cantidadClientesMaxima = cantidadClientesMaxima;
        }
        #endregion

        #region propiedades

        public List<Cliente> ListaClientes
        {
            get { return this.listaClientes; }
            set
            {
                if(value is not null)
                {
                    this.listaClientes = value;
                }
            }
        }


        public int CantidadClientesMaxima
        {
            get { return this.cantidadClientesMaxima; }
            set
            {
                this.cantidadClientesMaxima = value; //validar mayor a 0 bla bla
            }
        }
        #endregion

        #region metodos
        /// <summary>
        /// Valida la cantidad de clientes de la lista no sea mayor a la cantidad de clientes permitidos
        /// </summary>
        /// <returns></returns>
        private bool ValidarCantidadClientes()
        {
            if (this.ListaClientes.Count == this.cantidadClientesMaxima)
            {
                throw new CantidadDeClientesAlcanzadaException("Cantidad de clientes máxima alcanzada");
            }
            return true;
        }
        /// <summary>
        /// Verifica que un cliente este en la lista
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator ==(AdministracionEmpresa administracion, Cliente cliente)
        {
            if(administracion is not null && cliente is not null)
            {
                foreach (Cliente c in administracion.listaClientes)
                {
                    if (c == cliente)
                    {
                        return true;
                    }
                }
            } 
            return false;
        }
        /// <summary>
        /// verifica que un cliente no este en la lista
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator !=(AdministracionEmpresa administracion, Cliente cliente)
        {
            return !(administracion == cliente);
        }

        /// <summary>
        /// agrega un cliente a ala lista verificando que este no este y que la cantidad de clientes admitidos lo permita
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool operator +(AdministracionEmpresa administracion, Cliente cliente)
        {
            if (administracion != cliente && administracion.ValidarCantidadClientes())
            {
                //AdministracionEmpresa.AplicarDescuentoCliente(cliente);
                administracion.listaClientes.Add(cliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina un clinete de la lista verificando primero que exista en ella y devolviendo un mensaje con el resultado de la operacion
        /// </summary>
        /// <param name="administracion"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static string operator -(AdministracionEmpresa administracion, Cliente cliente)
        {
            string resultado = "Cliente no encontrado";
            if (administracion == cliente)
            {
                administracion.listaClientes.Remove(cliente);
                resultado = $"Cliente de tipo : {cliente.GetType().Name} con Nombre " + cliente.NombreCliente + " Removido con exito";
            }
            return resultado;

        }

        /// <summary>
        /// Imprime la lista de clientes  NO ESTA EN FUNCIONAMIENTO
        /// </summary>
        /// <returns></returns>
        public string ImprimirListaClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente cliente in this.listaClientes)
            {
                sb.AppendLine("sarasa");
            }
            return sb.ToString();
        }

            #endregion

        }
    }