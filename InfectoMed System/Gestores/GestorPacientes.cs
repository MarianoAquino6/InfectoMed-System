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
    public class GestorPacientes
    {
        private ConsultasPacientes _consultasPacientes = new ConsultasPacientes();

        /// <summary>
        /// Gestiona el registro de un nuevo paciente.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de registro.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del paciente.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si se ha registrado correctamente.</returns>
        public RespuestaValidacion GestionarRegistroPaciente(Dictionary<string, string> camposIngresados, DateTime fechaNacimiento)
        {
            Validador validador = new Validador(camposIngresados, ModoValidacion.REGISTROEDICIONPACIENTE);
            RespuestaValidacion respuesta = validador.ValidarDatos();

            if (!respuesta.CamposVacios && respuesta.ListaErrores.Count == 0 && !respuesta.RegistroDuplicado)
            {
                RegistrarPaciente(camposIngresados, fechaNacimiento);
            }

            return respuesta;
        }

        /// <summary>
        /// Gestiona la edición de un paciente existente.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de edición.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del paciente.</param>
        /// <param name="DNIOriginal">DNI original del paciente antes de la edición.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si se ha editado correctamente.</returns>
        public RespuestaValidacion GestionarEdicionPaciente(Dictionary<string, string> camposIngresados, DateTime fechaNacimiento, string DNIOriginal)
        {
            Validador validador = new Validador(camposIngresados, ModoValidacion.REGISTROEDICIONPACIENTE);
            RespuestaValidacion respuesta = validador.ValidarDatos();

            bool noHayCamposVacios = !respuesta.CamposVacios;
            bool noHayErrores = respuesta.ListaErrores.Count == 0;
            bool esRegistroDuplicado = respuesta.RegistroDuplicado;
            bool huboCambioDeDNI = camposIngresados["DNI"] != DNIOriginal;

            if (noHayCamposVacios && noHayErrores && ((esRegistroDuplicado && !huboCambioDeDNI) || (!esRegistroDuplicado && huboCambioDeDNI)))
            {
                EditarPaciente(camposIngresados, fechaNacimiento, DNIOriginal);
            }

            return respuesta;
        }

        /// <summary>
        /// Registra un nuevo paciente en la base de datos.
        /// </summary>
        /// <param name="camposIngresados">Diccionario que contiene los campos del paciente a registrar.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del paciente.</param>
        private void RegistrarPaciente(Dictionary<string, string> camposIngresados, DateTime fechaNacimiento)
        {
            Paciente nuevoPaciente = new Paciente(camposIngresados["DNI"], camposIngresados["nombre"],
                fechaNacimiento, camposIngresados["profesion"], camposIngresados["direccion"],
                camposIngresados["planObraSocial"], camposIngresados["numeroSocio"], camposIngresados["email"]);

            _consultasPacientes.RegistrarPaciente(nuevoPaciente);
        }

        /// <summary>
        /// Edita los datos de un paciente existente en la base de datos.
        /// </summary>
        /// <param name="camposIngresados">Diccionario que contiene los campos del paciente editado.</param>
        /// <param name="fechaNacimiento">Nueva fecha de nacimiento del paciente.</param>
        /// <param name="DNIOriginal">DNI original del paciente antes de la edición.</param>
        private void EditarPaciente(Dictionary<string, string> camposIngresados, DateTime fechaNacimiento, string DNIOriginal)
        {
            Paciente pacienteEditado = new Paciente(camposIngresados["DNI"], camposIngresados["nombre"],
                fechaNacimiento, camposIngresados["profesion"], camposIngresados["direccion"],
                camposIngresados["planObraSocial"], camposIngresados["numeroSocio"], camposIngresados["email"]);

            _consultasPacientes.EditarPaciente(pacienteEditado, DNIOriginal);
        }

        /// <summary>
        /// Filtra la lista de pacientes según el médico logueado.
        /// </summary>
        /// <param name="medico">Médico logueado.</param>
        /// <returns>Lista de pacientes asignados al médico.</returns>
        public List<Paciente> FiltrarPacientesSegunMedico(Medico medico)
        {
            List<Paciente> listaPacientes = _consultasPacientes.ObtenerPacientesDelMedico(medico);
            return listaPacientes;
        }
    }
}
