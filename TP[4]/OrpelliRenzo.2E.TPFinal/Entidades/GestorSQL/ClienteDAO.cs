using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using Entidades;
using Entidades.Interfaces;
using Entidades.Excepciones;


namespace Entidades.GestorSQL
{
    public static class ClienteDAO
    {
        private static string cadenaConexion;


        /// <summary>
        /// constructor estatico encargado de instanciar la cadena de conexion a la base de datos
        /// </summary>
        static ClienteDAO()
        {
            cadenaConexion = "Server=.;Database=CLIENTES_DB;Trusted_Connection=True;";
        }


        /// <summary>
        /// metodo encargada de Leer la lista de Clientes de la base de datos.
        /// </summary>
        /// <returns>retornara una lista de clientes, caso contrario lanzara una excepcion de tipo ConexionSQLException </returns>
        /// <exception cref="ConexionSQLException"></exception>
        public static List<Cliente> LeerDatos()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                string queryClientes = "SELECT * FROM clientes";
                using(SqlConnection connection = new SqlConnection(ClienteDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(queryClientes, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Cliente.categoriaCliente categoriaCliente = (Cliente.categoriaCliente)reader.GetInt32(3);
                        string nombreCliente = reader.GetString(1);
                        string domicilioCliente = reader.GetString(4);
                        string cuitOCuil = reader.GetString(2);
                        int tipoCliente = reader.GetInt32(0);
                        if(tipoCliente == 1)
                        {
                            Cliente cliente = new ClienteEmpresa(categoriaCliente, nombreCliente, cuitOCuil, domicilioCliente);
                            listaClientes.Add(cliente);
                        }
                        else
                        {
                            Cliente cliente = new ClienteParticular(categoriaCliente, nombreCliente, cuitOCuil, domicilioCliente);
                            listaClientes.Add(cliente);
                        }
                    }
                }
            }catch (Exception ex)
            {
                throw new ConexionSQLException("Error al leer datos desde la base de datos", ex);
            }
            return listaClientes;
        }

        /// <summary>
        /// metodo encargado de dar de agregar un cliente a la base de datos
        /// </summary>
        /// <param name="cliente">el cliente que se quiere agregar</param>
        /// <exception cref="ErrorAltaSQLException"></exception>
        public static void Alta(Cliente cliente)
        {
            string query = "INSERT INTO clientes(tipo_cliente, nombre_completo, cuit_cuil, categoria_cliente, domicilio_cliente) values(@tipoCliente,@nombreCompleto, @cuitOCuil,@categoriaCliente,@domicilioCliente)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ClienteDAO.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (cliente is ClienteEmpresa)
                {
                    cmd.Parameters.AddWithValue("tipoCliente", 1);

                }
                else
                {
                    cmd.Parameters.AddWithValue("tipoCliente", 0);
                }
                cmd.Parameters.AddWithValue("nombreCompleto", cliente.NombreCliente);
                cmd.Parameters.AddWithValue("cuitOCuil", cliente.CuitOCuil);
                cmd.Parameters.AddWithValue("categoriaCliente", (int)cliente.CategoriaDelCliente);
                cmd.Parameters.AddWithValue("domicilioCliente", cliente.DomicilioCliente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ErrorAltaSQLException("Error al dar de alta un cliente a la base de datos", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// metodo encargado de borrar un cliente de la base de datos
        /// </summary>
        /// <param name="cuitOCuil">el identificador de cliente para la query</param>
        /// <exception cref="ErrorBorrarSQLException"></exception>
        public static void Borrar(string cuitOCuil)
        {
            try
            {
                string query = "DELETE FROM clientes WHERE cuit_cuil=@cuitOCuil";
                using (SqlConnection connection = new SqlConnection(ClienteDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("cuitOCuil", cuitOCuil);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new ErrorBorrarSQLException("Error al dar de baja un cliente a la base de datos", ex);
            }
        }

        /// <summary>
        /// metodo encargado de modificar algunos datos del cliente de la base de datos, caso contrario
        /// lanzara una excepcion de tipo ErrorModificarSQLException
        /// </summary>
        /// <param name="cliente">recibe el cliente a modificar</param>
        /// <exception cref="ErrorModificarSQLException"></exception>
        public static void Modificar(Cliente cliente)
        {
            try
            {
                string query = "update clientes set nombre_completo=@nombreCliente, domicilio_cliente=@domicilioCliente, categoria_cliente=@categoriaCliente where clientes.cuit_cuil = @idCuitOcuil";
                using (SqlConnection connection = new SqlConnection(ClienteDAO.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("idCuitOcuil", cliente.CuitOCuil);
                    cmd.Parameters.AddWithValue("nombreCliente", cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("domicilioCliente", cliente.DomicilioCliente);
                    cmd.Parameters.AddWithValue("categoriaCliente", cliente.CategoriaDelCliente);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                throw new ErrorModificarSQLException("Error al modificar un cliente en la base de datos", ex);
            }
        }

    }
}
