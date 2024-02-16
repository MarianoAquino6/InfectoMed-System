using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Entidades
{
    public class ConsultaHC
    {
        private int _id;
        private DateTime _fecha;

        private string _motivoConsulta;
        private string _enfermedadActual;
        private string _antecedentesPersonales;

        private string _inspeccion;
        private string _signosVitales;
        private string _tegumentario;
        private string _nervioso;
        private string _linfo;
        private string _venoso;
        private string _osteo;
        private string _cabeza;
        private string _cardio;
        private string _respi;
        private string _abdomen;
        private string _otros;

        private string _examenesComplementarios;
        private string _resumenSemiologico;
        private string _diagnosticoPresuntivo;
        private string _diagnosticosDiferenciales;

        private string _tratamientoOrden;
        private string _aclaraciones;

        public ConsultaHC(int id, DateTime fecha, string motivoConsulta, string enfermedadActual, string antecedentesPersonales, string inspeccion,
            string signosVitales, string tegumentario, string nervioso, string linfo, string venoso, string osteo, string cabeza,
            string cardio, string respi, string abdomen, string otros, string examenesComplementarios, string resumenSemiologico,
            string diagnosticoPresuntivo, string diagnosticosDiferenciales, string tratamientoOrden, string aclaraciones)
        {
            _id = id;
            _fecha = fecha;
            _motivoConsulta = motivoConsulta;
            _enfermedadActual = enfermedadActual;
            _antecedentesPersonales = antecedentesPersonales;
            _inspeccion = inspeccion;
            _signosVitales = signosVitales;
            _tegumentario = tegumentario;
            _nervioso = nervioso;
            _linfo = linfo;
            _venoso = venoso;
            _osteo = otros;
            _cabeza = cabeza;
            _cardio = cardio;
            _respi = respi;
            _abdomen = abdomen;
            _otros = otros;
            _examenesComplementarios = examenesComplementarios;
            _resumenSemiologico = resumenSemiologico;
            _diagnosticoPresuntivo = diagnosticoPresuntivo;
            _diagnosticosDiferenciales = diagnosticosDiferenciales;
            _tratamientoOrden = tratamientoOrden;
            _aclaraciones = aclaraciones;
        }

        public ConsultaHC()
        {
            _id = 0;
            _motivoConsulta = string.Empty;
            _enfermedadActual = string.Empty;
            _antecedentesPersonales = string.Empty;
            _examenesComplementarios = string.Empty;
            _resumenSemiologico = string.Empty;
            _diagnosticoPresuntivo = string.Empty;
            _diagnosticosDiferenciales = string.Empty;
            _tratamientoOrden = string.Empty;
            _aclaraciones = string.Empty;

            _inspeccion = "Orientado en tiempo y espacio, eutimico, actitud compuesta, decúbito activo e indiferente, " +
                "habito mediolineo, facies compuesta, con estados de nutricion e hidratación conservados";
            _signosVitales = "Tension Arterial: xxx/xxx mmHg \nSaturación O2: xxx% (Fraccion O2 inspirada 21%) \n" +
                "FC: xxx latidos/min \nFR: xxx ciclos/min \nTemperatura Axilar: xx °C";
            _tegumentario = "Sin datos clinicos de relevancia";
            _nervioso = "No presenta alteración en los pares craneales, reflejos osteotendinosos conservados, pupilas " +
                "reactivas, con reflejos conservados. Sin signos de foco";
            _linfo = "Sin adenopatias. Sin datos clinicos de relevancia";
            _venoso = "Sin presencia de edema. Signo de Godet negativo.";
            _osteo = "Sin datos clinicos de relevancia";
            _cabeza = "Sin datos clinicos de relevancia";
            _cardio = "Primer y segundo ruidos conservados en 4 focos con silencios libres, sin falla de bomba. Pulsos radiales" +
                " y pedios simetricos y conservados.";
            _respi = "Buena entrada de aire en via aerea bilateral, buena mecanica ventilatoria y sin ruidos agregados" +
                "a la auscultación. Murmullo vesicular conservado";
            _abdomen = "Abdomen blando, deprimible, indoloro, sin reacción peritoneal y con ruidos hidroaereos positivos.";
            _otros = "Sin datos clinicos de relevancia";
        }

        public int ID { get { return _id; } }
        public DateTime Fecha { get { return _fecha; } set { _fecha = value; } }
        public string MotivoConsulta { get { return _motivoConsulta; } set { _motivoConsulta = value; } }
        public string EnfermedadActual { get { return _enfermedadActual; } set { _enfermedadActual = value; } }
        public string AntecedentesPersonales { get { return _antecedentesPersonales; } set { _antecedentesPersonales = value; } }
        public string Inspeccion { get { return _inspeccion; } set { _inspeccion = value; } }
        public string SignosVitales { get { return _signosVitales; } set { _signosVitales = value; } }
        public string Tegumentario { get { return _tegumentario; } set { _tegumentario = value; } }
        public string Nervioso { get { return _nervioso; } set { _nervioso = value; } }
        public string Linfo { get { return _linfo; } set { _linfo = value; } }
        public string Venoso { get { return _venoso; } set { _venoso = value; } }
        public string Osteo { get { return _osteo; } set { _osteo = value; } }
        public string Cabeza { get { return _cabeza; } set { _cabeza = value; } }
        public string Cardio { get { return _cardio; } set { _cardio = value; } }
        public string Respi { get { return _respi; } set { _respi = value; } }
        public string Abdomen { get { return _abdomen; } set { _abdomen = value; } }
        public string Otros { get { return _otros; } set { _otros = value; } }
        public string ExamenesComplementarios { get { return _examenesComplementarios; } set { _examenesComplementarios = value; } }
        public string ResumenSemiologico { get { return _resumenSemiologico; } set { _resumenSemiologico = value; } }
        public string DiagnosticoPresuntivo { get { return _diagnosticoPresuntivo; } set { _diagnosticoPresuntivo = value; } }
        public string DiagnosticosDiferenciales { get { return _diagnosticosDiferenciales; } set { _diagnosticosDiferenciales = value; } }
        public string TratamientoOrden { get { return _tratamientoOrden; } set { _tratamientoOrden = value; } }
        public string Aclaraciones { get { return _aclaraciones; } set { _aclaraciones = value; } }
    }
}
