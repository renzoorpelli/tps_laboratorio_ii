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

        static ClienteDAO()
        {
            cadenaConexion = "Server=.;Database=CLIENTES_DB;Trusted_Connection=True;";
        }


        /// <summary>
        /// Funcion encargada de Leer la lista de Clientes de la base de datos.
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
                        Cliente.categoriaCliente categoriaCliente = (Cliente.categoriaCliente)reader.GetInt32(3);//obtengo la categoria
                        string nombreCliente = reader.GetString(1);//obtengo el nombre
                        string domicilioCliente = reader.GetString(4);//obtengo domicilio
                        string cuitOCuil = reader.GetString(2);
                        int tipoCliente = reader.GetInt32(0);// obtengo si es de tipo Empresa o Particular
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
                throw new ConexionSQLException("Error al dar de alta un cliente a la base de datos", ex);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

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
                throw new ConexionSQLException("Error al dar de baja un cliente a la base de datos", ex);
            }
        }


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
                throw new ConexionSQLException("Error al modificar un cliente en la base de datos", ex);
            }
        }

    }
}
