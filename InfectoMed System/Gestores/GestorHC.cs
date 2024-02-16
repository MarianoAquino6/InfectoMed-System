using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfectoMed_System.Database;
using InfectoMed_System.Entidades;
using InfectoMed_System.Herramientas;
using InfectoMed_System.Validaciones;

namespace InfectoMed_System.Gestores
{
    public class GestorHC
    {
        private ConsultasHC _consultasHC = new ConsultasHC();

        /// <summary>
        /// Valida los campos ingresados en un formulario de consulta médica.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si hay campos vacíos.</returns>
        public RespuestaValidacion ValidarCampos(Dictionary<string, string> camposIngresados)
        {
            Validador validador = new Validador(camposIngresados, ModoValidacion.REGISTROCONSULTA);
            RespuestaValidacion respuesta = validador.ValidarDatos();

            return respuesta;
        }

        /// <summary>
        /// Gestiona el registro de una nueva consulta médica.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario.</param>
        /// <param name="consulta">Consulta médica a registrar.</param>
        /// <param name="paciente">Paciente al que se le realiza la consulta.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si hay campos vacíos.</returns>
        public RespuestaValidacion GestionarRegistroConsulta(Dictionary<string, string> camposIngresados, ConsultaHC consulta, Paciente paciente)
        {
            RespuestaValidacion respuesta = ValidarCampos(camposIngresados);

            if (!respuesta.CamposVacios)
            {
                _consultasHC.RegistrarConsulta(consulta, paciente);
            }

            return respuesta;
        }

        /// <summary>
        /// Gestiona la edición de una consulta médica existente.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de edición.</param>
        /// <param name="consulta">Consulta médica editada.</param>
        /// <param name="paciente">Paciente al que se le realiza la consulta.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si hay campos vacíos.</returns>
        public RespuestaValidacion GestionarEdicionConsulta(Dictionary<string, string> camposIngresados, ConsultaHC consulta, Paciente paciente)
        {
            RespuestaValidacion respuesta = ValidarCampos(camposIngresados);

            if (!respuesta.CamposVacios)
            {
                _consultasHC.EditarConsulta(consulta, paciente);
            }

            return respuesta;
        }

        /// <summary>
        /// Obtiene todas las consultas médicas asociadas a un paciente según su DNI.
        /// </summary>
        /// <param name="DNI">DNI del paciente.</param>
        /// <returns>Lista de consultas médicas asociadas al paciente.</returns>
        public List<ConsultaHC> ObtenerConsultasSegunDNI(string DNI)
        {
            return _consultasHC.DevolverConsultasSegunDNI(DNI);
        }
    }
}
