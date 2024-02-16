using InfectoMed_System.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Database
{
    internal class ConsultasPacientes
    {
        /// <summary>
        /// Busca duplicados de un paciente según su DNI.
        /// </summary>
        /// <param name="camposIngresados">Los campos ingresados (DNI).</param>
        /// <returns>True si existe un paciente con el mismo DNI, False en caso contrario.</returns>
        internal bool BuscarDuplicados(Dictionary<string, string> camposIngresados)
        {
            string query = "SELECT * FROM Pacientes WHERE DNI = @dni";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", camposIngresados["DNI"]},
            };

            bool resultado = ConsultasGenericasEnBD.BuscarCoincidenciasEnBD(query, parametros);

            return resultado;
        }

        /// <summary>
        /// Obtiene la lista de pacientes asignados a un médico.
        /// </summary>
        /// <param name="medico">El médico.</param>
        /// <returns>La lista de pacientes del médico.</returns>
        internal List<Paciente> ObtenerPacientesDelMedico(Medico medico)
        {
            string query = "SELECT * FROM MedicosPacientes M " +
                           "INNER JOIN Pacientes P " +
                           "ON M.DNI_Paciente = P.DNI " +
                           "WHERE M.DNI_Medico = @dni";

            Func<SqlDataReader, Paciente> mapper = reader =>
            {
                string DNI = reader["DNI"].ToString();
                string nombre = reader["Nombre"].ToString();
                DateTime nacimiento = (DateTime)reader["FechaNacimiento"];
                string profesion = reader["Profesion"].ToString();
                string direccion = reader["Direccion"].ToString();
                string planObraSocial = reader["PlanObraSocial"].ToString();
                string numeroSocio = reader["NumeroSocio"].ToString();
                string email = reader["Email"].ToString();

                Paciente pacienteReconstruido = new Paciente(DNI, nombre, nacimiento, profesion, direccion, 
                    planObraSocial, numeroSocio, email);

                return pacienteReconstruido;
            };

            List<Paciente> pacientesFiltrados = ConsultasGenericasEnBD.CrearInstanciasFiltradasDesdeBD(query, mapper, "@dni", medico.DNI);

            return pacientesFiltrados;
        }

        /// <summary>
        /// Registra un nuevo paciente en la base de datos y lo vincula al médico logueado.
        /// </summary>
        /// <param name="nuevoPaciente">El nuevo paciente a registrar.</param>
        internal void RegistrarPaciente(Paciente nuevoPaciente)
        {
            string query = "INSERT INTO Pacientes (DNI, Nombre, FechaNacimiento, Profesion, Direccion, PlanObraSocial, NumeroSocio, Email) " +
                "VALUES (@DNI, @nombre, @fechaNacimiento, @profesion, @direccion, @planObraSocial, @numeroSocio, @email)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", nuevoPaciente.DNI},
                {"@nombre", nuevoPaciente.Nombre },
                {"@fechaNacimiento", nuevoPaciente.FechaNacimiento},
                {"@profesion", nuevoPaciente.Profesion},
                {"@direccion", nuevoPaciente.Direccion},
                {"@planObraSocial", nuevoPaciente.PlanObraSocial},
                {"@numeroSocio", nuevoPaciente.NumeroSocio},
                {"@email", nuevoPaciente.Email}
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(query, parametros);
            VincularMedicoPaciente(nuevoPaciente.DNI);
        }

        /// <summary>
        /// Edita los datos de un paciente y actualiza sus registros en caso de cambio de DNI.
        /// </summary>
        /// <param name="pacienteEditado">Los datos editados del paciente.</param>
        /// <param name="DNIOriginal">El DNI original del paciente.</param>
        internal void EditarPaciente(Paciente pacienteEditado, string DNIOriginal)
        {
            if (DNIOriginal != pacienteEditado.DNI) 
            { 
                ActualizarMedicosPacientes(pacienteEditado, DNIOriginal); 
                ActualizarHistoriaClinica(pacienteEditado, DNIOriginal);
            }

            string query = "UPDATE Pacientes SET DNI = @DNI, Nombre = @nombre, FechaNacimiento = @fechaNacimiento, Profesion = @profesion, " +
                "Direccion = @direccion, PlanObraSocial = @planObraSocial, NumeroSocio = @numeroSocio, Email = @email " +
                "WHERE DNI = @DNIOriginal";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI", pacienteEditado.DNI},
                {"@nombre", pacienteEditado.Nombre },
                {"@fechaNacimiento", pacienteEditado.FechaNacimiento},
                {"@profesion", pacienteEditado.Profesion},
                {"@direccion", pacienteEditado.Direccion},
                {"@planObraSocial", pacienteEditado.PlanObraSocial},
                {"@numeroSocio", pacienteEditado.NumeroSocio},
                {"@email", pacienteEditado.Email},
                {"@DNIOriginal", DNIOriginal}
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(query, parametros);
        }

        /// <summary>
        /// Actualiza los registros de la tabla MedicosPacientes con el nuevo DNI del paciente editado.
        /// </summary>
        /// <param name="pacienteEditado">El paciente con los datos editados.</param>
        /// <param name="DNIOriginal">El DNI original del paciente antes de la edición.</param>
        private void ActualizarMedicosPacientes(Paciente pacienteEditado, string DNIOriginal)
        {
            string queryMedicosPacientes = "UPDATE MedicosPacientes SET DNI_Paciente = @nuevoDNI WHERE DNI_Paciente = @DNIOriginal";

            Dictionary<string, object> parametrosMedicosPacientes = new Dictionary<string, object>
                {
                    {"@nuevoDNI", pacienteEditado.DNI},
                    {"@DNIOriginal", DNIOriginal},
                };

            ConsultasGenericasEnBD.EjecutarNonQuery(queryMedicosPacientes, parametrosMedicosPacientes);
        }

        /// <summary>
        /// Actualiza los registros de la tabla HistoriasClinicas con el nuevo DNI del paciente editado.
        /// </summary>
        /// <param name="pacienteEditado">El paciente con los datos editados.</param>
        /// <param name="DNIOriginal">El DNI original del paciente antes de la edición.</param>
        private void ActualizarHistoriaClinica(Paciente pacienteEditado, string DNIOriginal)
        {
            string queryMedicosPacientes = "UPDATE HistoriasClinicas SET DNI = @nuevoDNI WHERE DNI = @DNIOriginal";

            Dictionary<string, object> parametrosMedicosPacientes = new Dictionary<string, object>
                {
                    {"@nuevoDNI", pacienteEditado.DNI},
                    {"@DNIOriginal", DNIOriginal},
                };

            ConsultasGenericasEnBD.EjecutarNonQuery(queryMedicosPacientes, parametrosMedicosPacientes);
        }

        /// <summary>
        /// Vincula al médico logueado con el paciente recién registrado.
        /// </summary>
        /// <param name="DNIPaciente">El DNI del paciente recién registrado.</param>
        private void VincularMedicoPaciente(string DNIPaciente)
        {
            string query = "INSERT INTO MedicosPacientes (DNI_Medico, DNI_Paciente) " +
                "VALUES (@DNI_Medico, @DNI_Paciente)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@DNI_Medico", Sistema.MedicoLogueado.DNI},
                {"@DNI_Paciente", DNIPaciente}
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(query, parametros);
        }
    }
}
