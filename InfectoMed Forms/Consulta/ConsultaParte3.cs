using InfectoMed_Forms.Paneles;
using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using InfectoMed_System.Herramientas;
using InfectoMed_System.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfectoMed_Forms
{
    public partial class ConsultaParte3 : Form
    {
        private ConsultaHC _nuevaConsulta;
        private Paciente _paciente;
        private GestorHC _gestorHC = new GestorHC();
        private ModoConsulta _modo;

        /// <summary>
        /// Constructor de la clase ConsultaParte3.
        /// </summary>
        /// <param name="nuevaConsulta">La nueva consulta médica.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        /// <param name="modo">El modo de consulta (Admin o Estudiante).</param>
        public ConsultaParte3(ConsultaHC nuevaConsulta, Paciente paciente, ModoConsulta modo)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Image image = Image.FromFile(Sistema.FondoDePantalla);
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Icon icon = new Icon(Sistema.Icono);
            this.Icon = icon;

            _nuevaConsulta = nuevaConsulta;
            _paciente = paciente;
            _modo = modo;

            ConfigurarTextosPredeterminados();
        }

        /// <summary>
        /// Configura los textos predeterminados en los controles de la ventana.
        /// </summary>
        private void ConfigurarTextosPredeterminados()
        {
            rtbComplementarios.Text = _nuevaConsulta.ExamenesComplementarios;
            rtbResumen.Text = _nuevaConsulta.ResumenSemiologico;
            tbDiagnosticoPresuntivo.Text = _nuevaConsulta.DiagnosticoPresuntivo;
            rtbDxDiferenciales.Text = _nuevaConsulta.DiagnosticosDiferenciales;
        }

        private void rtbComplementarios_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.ExamenesComplementarios = rtbComplementarios.Text;
        }

        private void rtbResumen_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.ResumenSemiologico = rtbResumen.Text;
        }

        private void tbDiagnosticoPresuntivo_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.DiagnosticoPresuntivo = tbDiagnosticoPresuntivo.Text;
        }

        private void rtbDxDiferenciales_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.DiagnosticosDiferenciales = rtbDxDiferenciales.Text;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Atrás.
        /// Oculta la ventana actual y muestra la parte anterior de la consulta.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaParte2 consulta2 = new ConsultaParte2(_nuevaConsulta, _paciente, _modo);
            consulta2.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Atrás.
        /// Oculta la ventana actual y muestra la parte anterior de la consulta.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    {"@complementarios", _nuevaConsulta.ExamenesComplementarios},
                    {"@resumen", _nuevaConsulta.ResumenSemiologico },
                    {"@diagnostico", _nuevaConsulta.DiagnosticoPresuntivo },
                    {"@diferenciales", _nuevaConsulta.DiagnosticosDiferenciales }
                };

                RespuestaValidacion respuesta = _gestorHC.ValidarCampos(camposIngresados);

                if (respuesta.CamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                this.Hide();
                TratamientoOrden tratamientoOrden = new TratamientoOrden(_nuevaConsulta, _paciente, _modo);
                tratamientoOrden.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Ayuda.
        /// Muestra un panel de ayuda.
        /// </summary>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            PanelAyuda panelAyuda = new PanelAyuda();
            panelAyuda.ShowDialog();
        }
    }
}
