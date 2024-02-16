using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Validaciones
{
    public class RespuestaValidacion
    {
        private bool _vacio;
        private List<string> _listaErrores = new List<string>();
        private string _mensajeErrores = string.Empty;
        private bool _registroDuplicado = false;
        private bool _logInExitoso = false;

        //LOGIN
        public RespuestaValidacion() { }

        /// <summary>
        /// Genera un mensaje de errores a partir de la lista de errores actual y lo asigna a la propiedad _mensajeErrores.
        /// </summary>
        /// <remarks>
        /// El mensaje generado incluye cada error de la lista en una nueva línea, precedido por "Debe corregir: ".
        /// </remarks>
        public void GenerarMensajeDeErrores()
        {
            _mensajeErrores = "Debe corregir: \n";

            foreach (string error in _listaErrores)
            {
                _mensajeErrores += $"{error} \n";
            }
        }

        public bool CamposVacios { get { return _vacio; } set { _vacio = value; } }
        public bool LogInExitoso { get { return _logInExitoso; } set { _logInExitoso = value; } }
        public List<string> ListaErrores { get { return _listaErrores; } set { _listaErrores = value; } }
        public string MensajeErrores { get { return _mensajeErrores; } set { _mensajeErrores = value; } }
        public bool RegistroDuplicado { get { return _registroDuplicado; } set { _registroDuplicado = value; } }
    }
}
