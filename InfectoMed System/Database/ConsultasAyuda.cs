using InfectoMed_System.Entidades;
using Microsoft.Data.SqlClient;
using PdfSharp.Pdf.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Database
{
    internal class ConsultasAyuda : ConexionBD
    {
        /// <summary>
        /// Obtiene una lista de enfermedades desde la base de datos.
        /// </summary>
        /// <returns>Una lista de enfermedades.</returns>
        internal List<Enfermedad> ObtenerEnfermedades()
        {
            string query = "SELECT * FROM Enfermedades";

            Func<SqlDataReader, Enfermedad> mapper = reader =>
            {
                int id = Convert.ToInt32(reader["ID"]);
                string nombre = reader["Nombre"].ToString();
                string esquema = reader["Esquema"].ToString();

                Enfermedad enfermedadReconstruida = new Enfermedad(id, nombre, esquema);

                return enfermedadReconstruida;
            };

            List<Enfermedad> enfermedades = ConsultasGenericasEnBD.CrearInstanciasTotalesDesdeBD(query, mapper);

            return enfermedades;
        }

        /// <summary>
        /// Obtiene una lista de fármacos según una enfermedad especificada.
        /// </summary>
        /// <param name="enfermedad">La enfermedad para la cual se buscan los fármacos.</param>
        /// <returns>Una lista de fármacos.</returns>
        internal List<Farmaco> ObtenerListaDeFarmacosSegunEnfermedad(Enfermedad enfermedad)
        {
            string query = @"
                            SELECT f.ID, f.Nombre, p.Dosis 
                            FROM Farmacos f
                            INNER JOIN Posologia p ON f.ID = p.ID_Farmaco
                            WHERE p.ID_Enfermedad = @idEnfermedad
                        ";

            Func<SqlDataReader, Farmaco> mapper = reader =>
            {
                string nombre = reader["Nombre"].ToString();
                string dosis = reader["Dosis"].ToString();
                int id = Convert.ToInt32(reader["id"]);

                string queryEfectosAdversos = "SELECT EA.Nombre FROM FarmacosEfectosAdversos FEA " +
                "INNER JOIN EfectosAdversos EA ON FEA.ID_EfectoAdverso = EA.ID " +
                "WHERE FEA.ID_Farmaco = @id";

                string queryContraindicaciones = "SELECT C.Nombre FROM FarmacosContraindicaciones FC " +
                "INNER JOIN Contraindicaciones C ON FC.ID_Contraindicacion = C.ID " +
                "WHERE FC.ID_Farmaco = @id";

                List<string> efectosAdversos = ConsultasGenericasEnBD.ObtenerDatosMedianteConexionAlternativa(id, queryEfectosAdversos);
                List<string> contraindicaciones = ConsultasGenericasEnBD.ObtenerDatosMedianteConexionAlternativa(id, queryContraindicaciones);

                Farmaco farmacoReconstruido = new Farmaco(nombre, dosis, efectosAdversos, contraindicaciones);

                return farmacoReconstruido;
            };

            List<Farmaco> listaFarmacos = ConsultasGenericasEnBD.CrearInstanciasFiltradasDesdeBD(query, mapper,
                "@idEnfermedad", enfermedad.Id);

            return listaFarmacos;
        }
    }
}
