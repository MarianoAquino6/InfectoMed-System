using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfectoMed_System.Entidades;
using InfectoMed_System.Herramientas;
using Microsoft.Data.SqlClient;

namespace InfectoMed_System.Database
{
    internal class ConsultasMedicos : ConexionBD
    {
        /// <summary>
        /// Corrobora las credenciales de un médico.
        /// </summary>
        /// <param name="camposIngresados">Los campos ingresados (DNI y contraseña).</param>
        /// <returns>True si las credenciales son válidas, False en caso contrario.</returns>
        internal bool CorroborarCredenciales(Dictionary<string, string> camposIngresados)
        {
            string contraseniaHasheada = Hash.HashPassword(camposIngresados["contrasenia"]);

            string query = "SELECT * FROM Medicos WHERE Contraseña = @contrasenia AND DNI = @dni";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", camposIngresados["DNI"]},
                {"@contrasenia", contraseniaHasheada}
            };

            bool resultado = ConsultasGenericasEnBD.BuscarCoincidenciasEnBD(query, parametros);

            return resultado;
        }

        /// <summary>
        /// Busca duplicados de un médico según su DNI.
        /// </summary>
        /// <param name="camposIngresados">Los campos ingresados (DNI).</param>
        /// <returns>True si existe un médico con el mismo DNI, False en caso contrario.</returns>
        internal bool BuscarDuplicados(Dictionary<string, string> camposIngresados)
        {
            string query = "SELECT * FROM Medicos WHERE DNI = @dni";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", camposIngresados["DNI"]},
            };

            bool resultado = ConsultasGenericasEnBD.BuscarCoincidenciasEnBD(query, parametros);

            return resultado;
        }

        /// <summary>
        /// Obtiene un médico según su DNI.
        /// </summary>
        /// <param name="DNI">El DNI del médico.</param>
        /// <returns>El médico obtenido.</returns>
        internal Medico ObtenerMedicoSegunDNI(string DNI)
        {
            string query = "SELECT * FROM Medicos WHERE DNI = @dni";

            Func<SqlDataReader, Medico> mapper = reader =>
            {
                string DNI = reader["DNI"].ToString();
                string nombre = reader["Nombre"].ToString();
                string contrasenia = reader["Contraseña"].ToString();
                string matricula = reader["Matricula"].ToString();
                
                Medico medicoReconstruido = new Medico(DNI, nombre, contrasenia, matricula);

                return medicoReconstruido;
            };

            List<Medico> medicosFiltrados = ConsultasGenericasEnBD.CrearInstanciasFiltradasDesdeBD(query, mapper, "@dni", DNI);

            return medicosFiltrados[0];
        }

        /// <summary>
        /// Registra un nuevo médico en la base de datos.
        /// </summary>
        /// <param name="nuevoMedico">El nuevo médico a registrar.</param>
        internal void RegistrarMedico(Medico nuevoMedico)
        {
            string query = "INSERT INTO Medicos (DNI, Nombre, Contraseña, Matricula) " +
                "VALUES (@DNI, @nombre, @contrasenia, @matricula)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", nuevoMedico.DNI},
                {"@nombre", nuevoMedico.Nombre },
                {"@contrasenia", nuevoMedico.Contrasenia },
                {"@matricula", nuevoMedico.Matricula }
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(query, parametros);
        }
    }
}
