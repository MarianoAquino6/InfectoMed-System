using InfectoMed_System.Herramientas;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Database
{
    internal class ConsultasGenericasEnBD : ConexionBD
    {
        /// <summary>
        /// Busca coincidencias en la base de datos.
        /// </summary>
        /// <param name="query">La consulta SQL.</param>
        /// <param name="parametros">Los parámetros de la consulta.</param>
        /// <returns>True si se encontraron coincidencias, False de lo contrario.</returns>
        internal static bool BuscarCoincidenciasEnBD(string query, Dictionary<string, object> parametros)
        {
            bool resultado = false;

            try
            {
                connection.Open();

                command.CommandText = query;

                foreach (var parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                using (var reader = command.ExecuteReader())
                {
                    // Verificar si hay al menos una fila en el resultado
                    if (reader.HasRows)
                    {
                        resultado = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Crea instancias totales de una entidad a partir de los datos en la base de datos.
        /// </summary>
        /// <typeparam name="T">El tipo de entidad.</typeparam>
        /// <param name="query">La consulta SQL.</param>
        /// <param name="mapper">El mapeador que convierte los datos en la entidad.</param>
        /// <returns>Una lista de instancias de la entidad.</returns>
        internal static List<T> CrearInstanciasTotalesDesdeBD<T>(string query, Func<SqlDataReader, T> mapper)
        {
            List<T> listaReconstruida = new List<T>();

            try
            {
                connection.Open();
                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entidad = mapper(reader);
                        listaReconstruida.Add(entidad);
                    }
                }
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return listaReconstruida;
        }

        /// <summary>
        /// Crea instancias filtradas de una entidad a partir de los datos en la base de datos.
        /// </summary>
        /// <typeparam name="T">El tipo de entidad.</typeparam>
        /// <param name="query">La consulta SQL.</param>
        /// <param name="mapper">El mapeador que convierte los datos en la entidad.</param>
        /// <param name="parametro">El nombre del parámetro de filtro.</param>
        /// <param name="filtro">El valor del filtro.</param>
        /// <returns>Una lista de instancias de la entidad.</returns>
        internal static List<T> CrearInstanciasFiltradasDesdeBD<T>(string query, Func<SqlDataReader, T> mapper, string parametro, object filtro)
        {
            List<T> listaReconstruida = new List<T>();

            try
            {
                connection.Open();
                command.CommandText = query;
                command.Parameters.AddWithValue(parametro, filtro);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T entidad = mapper(reader);
                        listaReconstruida.Add(entidad);
                    }
                }
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return listaReconstruida;
        }

        /// <summary>
        /// Ejecuta una consulta que no devuelve resultados (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">La consulta SQL.</param>
        /// <param name="parametros">Los parámetros de la consulta.</param>
        internal static void EjecutarNonQuery(string query, Dictionary<string, object> parametros)
        {
            try
            {
                connection.Open();

                command.CommandText = query;

                foreach (var parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }

        /// <summary>
        /// Inserta un registro en la base de datos y devuelve su ID.
        /// </summary>
        /// <param name="query">La consulta SQL.</param>
        /// <param name="parametros">Los parámetros de la consulta.</param>
        /// <returns>El ID del registro insertado.</returns>
        internal static int InsertarRegistroYDevolverID(string query, Dictionary<string, object> parametros)
        {
            int idInsertado = 0;

            try
            {
                connection.Open();

                command.CommandText = query;

                foreach (var parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                idInsertado = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return idInsertado;
        }

        /// <summary>
        /// Obtiene datos de la base de datos mediante una conexión alternativa.
        /// </summary>
        /// <param name="id">El ID de referencia.</param>
        /// <param name="query">La consulta SQL.</param>
        /// <returns>Una lista de datos obtenidos.</returns>
        internal static List<string> ObtenerDatosMedianteConexionAlternativa(int id, string query)
        {
            List<string> listaADevolver = new List<string>();

            using (var connectionAlternativa = new SqlConnection(@"Server = .; Database = TestMEDICO; Trusted_Connection = True; Encrypt=False; TrustServerCertificate=True;"))
            {
                using (var commandAlternativo = new SqlCommand(query, connectionAlternativa))
                {
                    commandAlternativo.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connectionAlternativa.Open();

                        using (var readerAlternativo = commandAlternativo.ExecuteReader())
                        {
                            while (readerAlternativo.Read())
                            {
                                string nombre = readerAlternativo["Nombre"].ToString();
                                listaADevolver.Add(nombre);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        RegistroExcepciones.RegistrarExcepcion(ex);
                        throw new Exception("Error de conexión a la base de datos: " + ex.Message);
                    }
                }
            }

            return listaADevolver;
        }
    }
}
