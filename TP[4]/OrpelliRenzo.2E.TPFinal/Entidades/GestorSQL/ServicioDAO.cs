﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Entidades.Excepciones;

namespace Entidades.GestorSQL
{
    public class ServicioDAO
    {
        private static string cadenaConexion;
        
        /// <summary>
        /// constructor estatico encargado de instanciar la cadena de conexion a la base de datos
        /// </summary>
        static ServicioDAO()
        {
            cadenaConexion = "Server=.;Database=CLIENTES_DB;Trusted_Connection=True;";
        }

        /// <summary>
        /// metodo encargado de traeer la lista de servicios que tiene un cliente
        /// </summary>
        /// <param name="cliente">el cliente del cual se quiere extraer la lista de servicios</param>
        /// <returns>retorna la lista de servicios de ese cliente, sino lanzara una excepcion del tipo ConexionSQLException</returns>
        /// <exception cref="ConexionSQLException">r</exception>
        public static List<Servicio> LeerServicios(Cliente cliente)
        {
            List<Servicio> listaServicios = new List<Servicio>();
            try
            {
                string queryClientes = $"Select servicios.costo_servicio, servicios.dificultad_servicio, servicios.tipo_infeccion, servicios.fecha_analisis from clientes join servicios on clientes.cuit_cuil = servicios.idCuitOCuil_cliente where clientes.cuit_cuil = '{cliente.CuitOCuil}'";
                using (SqlConnection connection = new SqlConnection(ServicioDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(queryClientes, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        double costoServicio = reader.GetInt32(0);
                        Servicio.dificultadVirus dificultadServicio = (Servicio.dificultadVirus)reader.GetInt32(1);
                        Servicio.tipoVirus tipoInfeccion = (Servicio.tipoVirus)reader.GetInt32(2);
                        DateTime fechaAnalisis = reader.GetDateTime(3);
                        Servicio servicio = new Servicio(costoServicio, dificultadServicio, tipoInfeccion, fechaAnalisis, cliente.CuitOCuil);
                        listaServicios.Add(servicio);

                    }
                }
            }
            catch (Exception ex)
            {
                throw new ConexionSQLException("Error al leer datos de servicio desde la base de datos, se intentara desde el archivo", ex);
            }
            return listaServicios;
        }

        /// <summary>
        /// metodo encargado de eliminar un servicio del cliente seleccionado, caso contrario lanzara una excepcion de tipo 
        /// ErrorBorrarSQLException
        /// </summary>
        /// <param name="cliente">el cliente el cual se le usara el cuit/cuil como identificador para borrarlo</param>
        public static void Borrar(Cliente cliente)
        {
            try
            {
                string query = "DELETE FROM servicios WHERE idCuitOCuil_cliente=@idCuitOCuil";
                using (SqlConnection connection = new SqlConnection(ServicioDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("idCuitOCuil", cliente.CuitOCuil);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new ErrorBorrarSQLException("Error al tratar de borrar un registro de la base de datos", ex);
            }
        }

        /// <summary>
        /// metodo encargado de agregar un servicio a la base de datos, caso contrario lanzara una exepcion de tipo
        /// ErrorAltaSQLException
        /// </summary>
        /// <param name="servicio">el servicio que dara de alta a la base de datos</param>
        /// <exception cref="ConexionSQLException"></exception>
        public static void Alta(Servicio servicio)
        {
            string query = "INSERT INTO servicios(costo_servicio, dificultad_servicio, tipo_infeccion, fecha_analisis, idCuitOCuil_cliente) values(@costoServicio,@dificultadServicio, @tipoInfeccion,@fechaAnalisis,@idCuitOCuil)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ServicioDAO.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
               
                cmd.Parameters.AddWithValue("costoServicio", servicio.CostoServicio);
                cmd.Parameters.AddWithValue("dificultadServicio", (int)servicio.DificultadServicio);
                cmd.Parameters.AddWithValue("tipoInfeccion", (int)servicio.TipoInfeccion);
                cmd.Parameters.AddWithValue("fechaAnalisis", servicio.FechaAnalisis);
                cmd.Parameters.AddWithValue("idCuitOCuil", servicio.CuilOCuitCliente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ErrorAltaSQLException("Error al dar de alta un servicio a la base de datos", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
