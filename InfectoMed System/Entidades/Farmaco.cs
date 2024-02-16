using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Entidades
{
    public class Farmaco
    {
        private string _nombre;
        private string _dosis;
        private List<string> _efectosAdversos;
        private List<string> _contraindicaciones;

        public Farmaco(string nombre, string dosis, List<string> efectosAdversos, List<string> contraindicaciones) 
        {
            _nombre = nombre;
            _dosis = dosis;
            _efectosAdversos = efectosAdversos;
            _contraindicaciones = contraindicaciones;
        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Dosis { get { return _dosis; } set { _dosis = value; } }
        public List<string> EfectosAdversos { get { return _efectosAdversos; } set { _efectosAdversos = value; } }
        public List<string> Contraindicaciones { get { return _contraindicaciones; } set { _contraindicaciones = value; } }
    }
}
