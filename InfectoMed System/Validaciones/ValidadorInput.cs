using InfectoMed_System.Herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfectoMed_System.Validaciones
{
    internal class ValidadorInput
    {
        private Dictionary<string, string> _camposIngresados;
        private ModoValidacion _modo;

        public ValidadorInput(Dictionary<string, string> camposIngresados, ModoValidacion modo)
        {
            _camposIngresados = camposIngresados;
            _modo = modo;
        }

        /// <summary>
        /// Busca campos vacíos en los campos ingresados.
        /// </summary>
        /// <returns>True si encuentra campos vacíos, false en caso contrario.</returns>
        internal bool BuscarCamposVacios()
        {
            return _camposIngresados.Any(kv => string.IsNullOrWhiteSpace(kv.Value));
        }

        /// <summary>
        /// Valida los campos ingresados según el modo de validación actual (_modo) utilizando expresiones regulares.
        /// </summary>
        /// <returns>Lista de errores de validación.</returns>
        internal List<string> ValidarRegex()
        {
            List<string> listaErrores = new List<string>();

            switch (_modo)
            {
                case ModoValidacion.REGISTROMEDICO:
                    ValidarRegexMedico(listaErrores);
                    break;

                case ModoValidacion.REGISTROEDICIONPACIENTE:
                    ValidarRegexPaciente(listaErrores);
                    break;
            }

            return listaErrores;
        }

        /// <summary>
        /// Valida los campos específicos para un médico según las expresiones regulares definidas.
        /// </summary>
        /// <param name="listaErrores">Lista de errores de validación.</param>
        private void ValidarRegexMedico(List<string> listaErrores)
        {
            foreach (var parClaveValor in _camposIngresados)
            {
                switch (parClaveValor.Key)
                {
                    case "DNI":
                        ValidarCampoRegex(parClaveValor.Value, @"^\d{7,8}$", "DNI", listaErrores);
                        break;

                    case "nombre":
                        ValidarCampoRegex(parClaveValor.Value, @"^[a-zA-Z\s]{5,}$", "Nombre", listaErrores);
                        break;

                    case "contrasenia":
                        if (parClaveValor.Value.Length < 6 || parClaveValor.Value.Length > 20)
                        {
                            listaErrores.Add("Contrasenia");
                        }
                        break;

                    case "matricula":
                        ValidarCampoRegex(parClaveValor.Value, @"^\d{3,10}$", "Matricula", listaErrores);
                        break;
                }
            }
        }

        /// <summary>
        /// Valida los campos específicos para un paciente según las expresiones regulares definidas.
        /// </summary>
        /// <param name="listaErrores">Lista de errores de validación.</param>
        private void ValidarRegexPaciente(List<string> listaErrores)
        {
            foreach (var parClaveValor in _camposIngresados)
            {
                switch (parClaveValor.Key)
                {
                    case "DNI":
                        ValidarCampoRegex(parClaveValor.Value, @"^\d{7,8}$", "DNI", listaErrores);
                        break;

                    case "nombre":
                        ValidarCampoRegex(parClaveValor.Value, @"^[a-zA-Z\s]{5,}$", "Nombre", listaErrores);
                        break;

                    case "profesion":
                    case "direccion":
                    case "planObraSocial":
                        ValidarCampoRegex(parClaveValor.Value, @"^[a-zA-Z0-9\s]+$", parClaveValor.Key, listaErrores);
                        break;

                    case "numeroSocio":
                        ValidarCampoRegex(parClaveValor.Value, @"^\d{1,20}$", "NumeroSocio", listaErrores);
                        break;

                    case "email":
                        ValidarCampoRegex(parClaveValor.Value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", "Email", listaErrores);
                        break;
                }
            }
        }

        /// <summary>
        /// Valida un campo específico utilizando una expresión regular.
        /// </summary>
        /// <param name="valor">Valor del campo a validar.</param>
        /// <param name="patronRegex">Expresión regular a aplicar.</param>
        /// <param name="nombreCampo">Nombre del campo.</param>
        /// <param name="listaErrores">Lista de errores de validación.</param>
        private void ValidarCampoRegex(string valor, string patronRegex, string nombreCampo, List<string> listaErrores)
        {
            if (!Regex.IsMatch(valor, patronRegex))
            {
                listaErrores.Add(nombreCampo);
            }
        }
    }
}
