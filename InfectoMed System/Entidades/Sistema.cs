using InfectoMed_System.Database;

namespace InfectoMed_System.Entidades
{
    public static class Sistema
    {
        private static string _codigoAcceso = "ts5bf4";
        private static Medico _medicoLogueado;
        private static string _fondoDePantalla = "BG.png";
        private static string _icono = "ICON.ico";

        internal static string CodigoAcceso { get { return _codigoAcceso; } }
        public static Medico MedicoLogueado { get { return _medicoLogueado; } set { _medicoLogueado = value; } }
        public static string FondoDePantalla { get { return _fondoDePantalla; } }
        public static string Icono { get { return _icono; } }
    }
}