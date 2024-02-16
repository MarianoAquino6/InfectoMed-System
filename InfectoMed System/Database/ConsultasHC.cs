using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InfectoMed_System.Entidades;
using Microsoft.Data.SqlClient;

namespace InfectoMed_System.Database
{
    internal class ConsultasHC
    {
        /// <summary>
        /// Registra una nueva consulta en la base de datos.
        /// </summary>
        /// <param name="consulta">La consulta a registrar.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        internal void RegistrarConsulta(ConsultaHC consulta, Paciente paciente)
        {
            int idExamenFisico = InsertarExamenFisicoYDevolverID(consulta);
            int idConsulta = InsertarConsultaYDevolverID(consulta, idExamenFisico);
            InsertarHistoriaClinica(paciente, idConsulta);
        }

        /// <summary>
        /// Inserta un examen físico en la base de datos y devuelve su ID.
        /// </summary>
        /// <param name="consulta">La consulta asociada al examen físico.</param>
        /// <returns>El ID del examen físico insertado.</returns>
        private int InsertarExamenFisicoYDevolverID(ConsultaHC consulta)
        {
            string queryExamenesFisicos = "INSERT INTO ExamenesFisicos (Inspeccion, SignosVitales, SistemaTegumentario, SistemaLinfoganglionar," +
                "SistemaVenosoSuperficialProfundo, SistemaOsteoarticulomuscular, CabezaCuello, SistemaCardiovascular, " +
                "SistemaRespiratorio, Abdomen, SistemaNervioso, Otros) VALUES (@inspeccion, @signosVitales, @tegumentario, " +
                "@linfoganglionar, @venoso, @osteo, @cabeza, @cardio, @respi, @abdomen, @nervioso, @otros);" +
                "SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parametrosExamenesFisicos = new Dictionary<string, object>
            {
                {"@inspeccion", consulta.Inspeccion},
                {"@signosVitales", consulta.SignosVitales },
                {"@tegumentario", consulta.Tegumentario },
                {"@linfoganglionar", consulta.Linfo },
                {"@venoso", consulta.Venoso},
                {"@osteo", consulta.Osteo },
                {"@cabeza", consulta.Cabeza },
                {"@cardio", consulta.Cardio },
                {"@respi", consulta.Respi },
                {"@abdomen", consulta.Abdomen },
                {"@nervioso", consulta.Nervioso },
                {"@otros", consulta.Otros }
            };

            return ConsultasGenericasEnBD.InsertarRegistroYDevolverID(queryExamenesFisicos, parametrosExamenesFisicos);
        }

        /// <summary>
        /// Inserta una consulta en la base de datos y devuelve su ID.
        /// </summary>
        /// <param name="consulta">La consulta a insertar.</param>
        /// <param name="idExamenFisico">El ID del examen físico asociado a la consulta.</param>
        /// <returns>El ID de la consulta insertada.</returns>
        private int InsertarConsultaYDevolverID(ConsultaHC consulta, int idExamenFisico)
        {
            string queryConsulta = "INSERT INTO Consultas (Fecha, MotivoConsulta, EnfermedadActualAntecedentes, AntecedentesPersonales, " +
                "ID_ExamenFisico, EstudioComplementario, ResumenSemiologico, DiagnosticoPresuntivo, DiagnosticosDiferenciales, " +
                "TratamientoOrdenMedica, Aclaraciones) VALUES (@fecha, @motivoConsulta, @enfermedadActual, @antecedentesPersonales, " +
                "@id, @estudioComplementario, @resumenSemiologico, @diagnosticoPresuntivo, @diagnosticosDiferenciales, @tratamiento, " +
                "@aclaraciones); SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parametrosConsultas = new Dictionary<string, object>
            {
                {"@fecha", DateTime.Now},
                {"@motivoConsulta", consulta.MotivoConsulta },
                {"@enfermedadActual", consulta.EnfermedadActual },
                {"@antecedentesPersonales", consulta.AntecedentesPersonales },
                {"@id", idExamenFisico},
                {"@estudioComplementario", consulta.ExamenesComplementarios },
                {"@resumenSemiologico", consulta.ResumenSemiologico },
                {"@diagnosticoPresuntivo", consulta.DiagnosticoPresuntivo },
                {"@diagnosticosDiferenciales", consulta.DiagnosticosDiferenciales },
                {"@tratamiento", consulta.TratamientoOrden },
                {"@aclaraciones", consulta.Aclaraciones }
            };

            return ConsultasGenericasEnBD.InsertarRegistroYDevolverID(queryConsulta, parametrosConsultas);
        }

        /// <summary>
        /// Inserta una historia clínica en la base de datos.
        /// </summary>
        /// <param name="paciente">El paciente asociado a la historia clínica.</param>
        /// <param name="idConsulta">El ID de la consulta asociada a la historia clínica.</param>
        private void InsertarHistoriaClinica(Paciente paciente, int idConsulta)
        {
            string queryHC = "INSERT INTO HistoriasClinicas (ID_Consulta, DNI) VALUES (@id, @DNI)";

            Dictionary<string, object> parametrosHC = new Dictionary<string, object>
            {
                {"@id", idConsulta},
                {"@DNI", paciente.DNI }
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(queryHC, parametrosHC);
        }

        /// <summary>
        /// Edita una consulta existente en la base de datos.
        /// </summary>
        /// <param name="consulta">La consulta a editar.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        internal void EditarConsulta(ConsultaHC consulta, Paciente paciente)
        {
            string queryString = @"
            UPDATE Consultas
            SET
                Consultas.MotivoConsulta = @motivoConsulta,
                Consultas.EnfermedadActualAntecedentes = @enfermedadActual,
                Consultas.AntecedentesPersonales = @antecedentesPersonales,
                Consultas.EstudioComplementario = @estudioComplementario,
                Consultas.ResumenSemiologico = @resumenSemiologico,
                Consultas.DiagnosticoPresuntivo = @diagnosticoPresuntivo,
                Consultas.DiagnosticosDiferenciales = @diagnosticosDiferenciales,
                Consultas.TratamientoOrdenMedica = @tratamiento,
                Consultas.Aclaraciones = @aclaraciones
            FROM
                Consultas
            INNER JOIN ExamenesFisicos ON Consultas.ID_ExamenFisico = ExamenesFisicos.ID
            WHERE
                Consultas.ID = @id;

            UPDATE ExamenesFisicos
            SET
                ExamenesFisicos.Inspeccion = @inspeccion,
                ExamenesFisicos.SignosVitales = @signosVitales,
                ExamenesFisicos.SistemaTegumentario = @tegumentario,
                ExamenesFisicos.SistemaLinfoganglionar = @linfoganglionar,
                ExamenesFisicos.SistemaVenosoSuperficialProfundo = @venoso,
                ExamenesFisicos.SistemaOsteoarticulomuscular = @osteo,
                ExamenesFisicos.CabezaCuello = @cabeza,
                ExamenesFisicos.SistemaCardiovascular = @cardio,
                ExamenesFisicos.SistemaRespiratorio = @respi,
                ExamenesFisicos.Abdomen = @abdomen,
                ExamenesFisicos.SistemaNervioso = @nervioso,
                ExamenesFisicos.Otros = @otros
            FROM
                ExamenesFisicos
            INNER JOIN Consultas ON ExamenesFisicos.ID = Consultas.ID_ExamenFisico
            WHERE
                Consultas.ID = @id;";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                {"@motivoConsulta", consulta.MotivoConsulta },
                {"@enfermedadActual", consulta.EnfermedadActual },
                {"@antecedentesPersonales", consulta.AntecedentesPersonales },
                {"@estudioComplementario", consulta.ExamenesComplementarios },
                {"@resumenSemiologico", consulta.ResumenSemiologico },
                {"@diagnosticoPresuntivo", consulta.DiagnosticoPresuntivo },
                {"@diagnosticosDiferenciales", consulta.DiagnosticosDiferenciales },
                {"@tratamiento", consulta.TratamientoOrden },
                {"@aclaraciones", consulta.Aclaraciones },
                {"@id", consulta.ID },
                {"@inspeccion", consulta.Inspeccion},
                {"@signosVitales", consulta.SignosVitales },
                {"@tegumentario", consulta.Tegumentario },
                {"@linfoganglionar", consulta.Linfo },
                {"@venoso", consulta.Venoso},
                {"@osteo", consulta.Osteo },
                {"@cabeza", consulta.Cabeza },
                {"@cardio", consulta.Cardio },
                {"@respi", consulta.Respi },
                {"@abdomen", consulta.Abdomen },
                {"@nervioso", consulta.Nervioso },
                {"@otros", consulta.Otros }
            };

            ConsultasGenericasEnBD.EjecutarNonQuery(queryString, parametros);
        }

        /// <summary>
        /// Devuelve una lista de consultas asociadas a un paciente según su DNI.
        /// </summary>
        /// <param name="DNI">El DNI del paciente.</param>
        /// <returns>Una lista de consultas asociadas al paciente.</returns>
        internal List<ConsultaHC> DevolverConsultasSegunDNI(string DNI)
        {
            string query = "SELECT * FROM HistoriasClinicas HC " +
                "INNER JOIN Consultas C ON HC.ID_Consulta = C.ID " +
                "INNER JOIN ExamenesFisicos E ON C.ID_ExamenFisico = E.ID " +
                "WHERE HC.DNI = @dni";

            Func<SqlDataReader, ConsultaHC> mapper = reader =>
            {
                int id = Convert.ToInt32(reader["ID"]);
                DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                string motivoConsulta = reader["MotivoConsulta"].ToString();
                string enfermedadActual = reader["EnfermedadActualAntecedentes"].ToString();
                string antecedentesPersonales = reader["AntecedentesPersonales"].ToString();
                string examenesComplementarios = reader["EstudioComplementario"].ToString();
                string resumenSemiologico = reader["ResumenSemiologico"].ToString();
                string diagnosticoPresuntivo = reader["DiagnosticoPresuntivo"].ToString();
                string diagnosticosDiferenciales = reader["DiagnosticosDiferenciales"].ToString();
                string tratamientoOrden = reader["TratamientoOrdenMedica"].ToString();
                string aclaraciones = reader["Aclaraciones"].ToString();

                string inspeccion = reader["Inspeccion"].ToString();
                string signosVitales = reader["SignosVitales"].ToString();
                string tegumentario = reader["SistemaTegumentario"].ToString();
                string nervioso = reader["SistemaNervioso"].ToString();
                string linfo = reader["SistemaLinfoganglionar"].ToString();
                string venoso = reader["SistemaVenosoSuperficialProfundo"].ToString();
                string osteo = reader["SistemaOsteoarticulomuscular"].ToString();
                string cabeza = reader["CabezaCuello"].ToString();
                string cardio = reader["SistemaCardiovascular"].ToString();
                string respi = reader["SistemaRespiratorio"].ToString();
                string abdomen = reader["Abdomen"].ToString();
                string otros = reader["Otros"].ToString();

                ConsultaHC consultaReconstruida = new ConsultaHC(id, fecha, motivoConsulta, enfermedadActual, antecedentesPersonales, inspeccion,
                    signosVitales, tegumentario, nervioso, linfo, venoso, osteo, cabeza, cardio, respi, abdomen, otros, examenesComplementarios,
                    resumenSemiologico, diagnosticoPresuntivo, diagnosticosDiferenciales, tratamientoOrden, aclaraciones);

                return consultaReconstruida;
            };

            List<ConsultaHC> listaConsultasHC = ConsultasGenericasEnBD.CrearInstanciasFiltradasDesdeBD(query, mapper, "@dni", DNI);

            return listaConsultasHC;
        }
    }
}
