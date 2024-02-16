using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Entidades
{
    public class Medico
    {
        private string _DNI;
        private string _nombre;
        private string _contrasenia;
        private string _matricula;

        public Medico(string DNI, string nombre, string contrasenia, string matricula)
        {
            _DNI = DNI;
            _nombre = nombre;
            _contrasenia = contrasenia;
            _matricula = matricula;
        }

        public string DNI { get { return _DNI; } }
        public string Nombre { get { return _nombre; } }
        public string Contrasenia { get { return _contrasenia; } }
        public string Matricula { get { return _matricula; } }
    }
}
