using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Entidades
{
    public class Paciente
    {
        private string _DNI;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private string _profesion;
        private string _direccion;
        private string _planObraSocial;
        private string _numeroSocio;
        private string _email;

        public Paciente(string DNI, string nombre, DateTime fechaNacimiento, string profesion, string direccion,
            string planObraSocial, string numeroSocio, string email)
        {
            _DNI = DNI;
            _nombre = nombre;
            _fechaNacimiento = fechaNacimiento;
            _profesion = profesion;
            _direccion = direccion;
            _planObraSocial = planObraSocial;
            _numeroSocio = numeroSocio;
            _email = email;
        }

        public string DNI { get { return _DNI; } set { _DNI = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public DateTime FechaNacimiento { get { return _fechaNacimiento; } set { _fechaNacimiento = value; } }
        public string Profesion { get { return _profesion; } set { _profesion = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string PlanObraSocial { get { return _planObraSocial; } set { _planObraSocial = value; } }
        public string NumeroSocio { get { return _numeroSocio; } set { _numeroSocio = value; } }
        public string Email { get { return _email; } set { _email = value; } }
    }
}
