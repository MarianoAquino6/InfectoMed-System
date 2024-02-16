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
    public class GestorMedicos
    {
        private ConsultasMedicos _consultasMedicos = new ConsultasMedicos();

        /// <summary>
        /// Valida la contraseña de registro de un médico.
        /// </summary>
        /// <param name="codigoIngresado">Código de acceso ingresado por el usuario.</param>
        /// <returns>True si el código ingresado es correcto, false si no.</returns>
        public bool ValidarContraseniaRegistro(string codigoIngresado)
        {
            return codigoIngresado == Sistema.CodigoAcceso;
        }

        /// <summary>
        /// Corrobora las credenciales de un médico al intentar iniciar sesión.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de inicio de sesión.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si la credencial es correcta.</returns>
        public RespuestaValidacion CorroborarCredenciales(Dictionary<string, string> camposIngresados)
        {
            Validador validador = new Validador(camposIngresados, ModoValidacion.LOGIN);
            RespuestaValidacion respuesta = validador.ValidarDatos();

            if (respuesta.LogInExitoso)
            {
                Sistema.MedicoLogueado = ObtenerMedicoSegunDNI(camposIngresados["DNI"]);
            }

            return respuesta;
        }

        /// <summary>
        /// Gestiona el registro de un nuevo médico.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de registro.</param>
        /// <returns>Respuesta de validación que indica si los campos son válidos y si se ha registrado correctamente.</returns>
        public RespuestaValidacion GestionarRegistroDeMedico(Dictionary<string, string> camposIngresados)
        {
            Validador validador = new Validador(camposIngresados, ModoValidacion.REGISTROMEDICO);
            RespuestaValidacion respuesta = validador.ValidarDatos();

            if (!respuesta.CamposVacios && respuesta.ListaErrores.Count == 0 && !respuesta.RegistroDuplicado)
            {
                RegistrarMedico(camposIngresados);
            }

            return respuesta;
        }

        /// <summary>
        /// Registra un nuevo médico en la base de datos.
        /// </summary>
        /// <param name="camposIngresados">Diccionario con los campos ingresados en el formulario de registro.</param>
        private void RegistrarMedico(Dictionary<string, string> camposIngresados)
        {
            string contraseniaHasheada = Hash.HashPassword(camposIngresados["contrasenia"]);

            Medico nuevoMedico = new Medico(camposIngresados["DNI"], camposIngresados["nombre"],
                contraseniaHasheada, camposIngresados["matricula"]);

            _consultasMedicos.RegistrarMedico(nuevoMedico);
        }

        /// <summary>
        /// Obtiene un médico según su DNI.
        /// </summary>
        /// <param name="DNI">DNI del médico.</param>
        /// <returns>El médico encontrado o null si no existe.</returns>
        private Medico ObtenerMedicoSegunDNI(string DNI)
        {
            Medico medicoEncontrado = _consultasMedicos.ObtenerMedicoSegunDNI(DNI);
            return medicoEncontrado;
        }
    }
}
