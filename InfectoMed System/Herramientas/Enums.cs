using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Herramientas
{
    public enum ModoConsulta
    {
        CREAR,
        EDITAR
    }

    public enum ModoRegistroPaciente
    {
        CREAR,
        EDITAR
    }

    public enum ModoValidacion
    {
        LOGIN,
        REGISTROMEDICO,
        REGISTROEDICIONPACIENTE,
        REGISTROCONSULTA
    }
}
