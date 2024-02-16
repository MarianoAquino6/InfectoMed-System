using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using InfectoMed_System.Database;
using InfectoMed_System.Entidades;
using InfectoMed_System.Herramientas;

namespace InfectoMed_System.Validaciones
{
    internal class Validador
    {
        private ValidadorInput _validadorInput;
        private ValidadorBD _validadorBD;
        private RespuestaValidacion _respuesta;
        private ModoValidacion _modo;

        public Validador(Dictionary<string, string> camposIngresados, ModoValidacion modo)
        {
            _respuesta = new RespuestaValidacion();
            _modo = modo;

            _validadorInput = new ValidadorInput(camposIngresados, modo);
            _validadorBD = new ValidadorBD(camposIngresados, modo);
        }

        /// <summary>
        /// Valida los datos según el modo de validación actual (_modo) y devuelve una respuesta de validación.
        /// </summary>
        /// <returns>Respuesta de validación que indica si los datos son válidos y contiene información adicional según el modo de validación.</returns>
        /// <remarks>
        /// Para el modo LOGIN, busca campos vacíos y, si no los encuentra, intenta corroborar las credenciales en la base de datos.
        /// Para los modos REGISTROMEDICO y REGISTROEDICIONPACIENTE, busca campos vacíos y, si no los encuentra, valida los campos con expresiones regulares, busca registros duplicados en la base de datos y genera un mensaje de errores si los hubiera.
        /// Para el modo REGISTROCONSULTA, busca campos vacíos.
        /// </remarks>
        internal RespuestaValidacion ValidarDatos()
        {
            switch (_modo)
            {
                case ModoValidacion.LOGIN:
                    _respuesta.CamposVacios = _validadorInput.BuscarCamposVacios();
                    if (!_respuesta.CamposVacios) { _respuesta.LogInExitoso = _validadorBD.CorroborarCredenciales(); }

                    break;
                case ModoValidacion.REGISTROMEDICO:
                case ModoValidacion.REGISTROEDICIONPACIENTE:
                    _respuesta.CamposVacios = _validadorInput.BuscarCamposVacios();

                    if (!_respuesta.CamposVacios)
                    {
                        _respuesta.ListaErrores = _validadorInput.ValidarRegex();
                        _respuesta.RegistroDuplicado = _validadorBD.BuscarRegistrosDuplicados();

                        if (_respuesta.ListaErrores.Count > 0)
                        {
                            _respuesta.GenerarMensajeDeErrores();
                        }
                    }

                    break;
                case ModoValidacion.REGISTROCONSULTA:
                    _respuesta.CamposVacios = _validadorInput.BuscarCamposVacios();

                    break;
            }

            return _respuesta;
        }
    }
}
