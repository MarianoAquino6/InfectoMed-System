using InfectoMed_System.Database;
using InfectoMed_System.Herramientas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Validaciones
{
    internal class ValidadorBD
    {
        private Dictionary<string, string> _camposIngresados;
        private ModoValidacion _modo;

        public ValidadorBD(Dictionary<string, string> camposIngresados, ModoValidacion modo)
        {
            _camposIngresados = camposIngresados;
            _modo = modo;
        }

        /// <summary>
        /// Busca registros duplicados en la base de datos según el modo de validación actual (_modo).
        /// </summary>
        /// <returns>True si se encontraron registros duplicados, false en caso contrario.</returns>
        /// <remarks>
        /// Para el modo REGISTROMEDICO, utiliza la clase ConsultasMedicos para buscar duplicados en los campos ingresados (_camposIngresados).
        /// Para otros modos, utiliza la clase ConsultasPacientes para buscar duplicados en los campos ingresados (_camposIngresados).
        /// </remarks>
        internal bool BuscarRegistrosDuplicados()
        {
            if (_modo == ModoValidacion.REGISTROMEDICO)
            {
                ConsultasMedicos consultasMedicos = new ConsultasMedicos();
                return consultasMedicos.BuscarDuplicados(_camposIngresados);
            }
            else
            {
                ConsultasPacientes consultasPacientes = new ConsultasPacientes();
                return consultasPacientes.BuscarDuplicados(_camposIngresados);
            }
        }

        /// <summary>
        /// Corrobora las credenciales ingresadas en la base de datos.
        /// </summary>
        /// <returns>True si las credenciales son correctas, false en caso contrario.</returns>
        /// <remarks>
        /// Utiliza la clase ConsultasMedicos para corroborar las credenciales en la base de datos.
        /// </remarks>
        internal bool CorroborarCredenciales()
        {
            ConsultasMedicos consultasMedicos = new ConsultasMedicos();
            return consultasMedicos.CorroborarCredenciales(_camposIngresados);
        }
    }
}
