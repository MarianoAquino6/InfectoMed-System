using InfectoMed_System.Database;
using InfectoMed_System.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Gestores
{
    public class GestorAyuda
    {
        private ConsultasAyuda _consultasAyuda = new ConsultasAyuda();

        /// <summary>
        /// Obtiene todas las enfermedades disponibles.
        /// </summary>
        /// <returns>Una lista de enfermedades.</returns>
        public List<Enfermedad> ObtenerTodasLasEnfermedades()
        {
            return _consultasAyuda.ObtenerEnfermedades();
        }

        /// <summary>
        /// Obtiene una lista de fármacos asociados a una enfermedad específica.
        /// </summary>
        /// <param name="enfermedad">La enfermedad para la cual se obtendrán los fármacos.</param>
        /// <returns>Una lista de fármacos asociados a la enfermedad.</returns>
        public List<Farmaco> ObtenerFarmacosSegunEnfermedad(Enfermedad enfermedad)
        {
            return _consultasAyuda.ObtenerListaDeFarmacosSegunEnfermedad(enfermedad);
        }
    }
}
