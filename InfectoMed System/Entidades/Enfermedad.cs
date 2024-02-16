using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Entidades
{
    public class Enfermedad
    {
        private int _id;
        private string _nombre;
        private string _esquema;

        public Enfermedad(int id, string nombre, string esquema)
        { 
            _id = id;
            _nombre = nombre;
            _esquema = esquema;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Esquema { get { return _esquema; } set { _esquema = value; } }
    }
}
