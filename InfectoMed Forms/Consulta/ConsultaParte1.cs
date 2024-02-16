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
    public partial class ConsultaParte1 : Form
    {
        private ConsultaHC _consulta;
        private Paciente _paciente;
        private GestorHC _gestorHC = new GestorHC();
        private ModoConsulta _modo;

        /// <summary>
        /// Constructor de la clase ConsultaParte1.
        /// </summary>
        /// <param name="consulta">La consulta médica.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        /// <param name="modo">El modo de consulta (Admin o Estudiante).</param>
        public ConsultaParte1(ConsultaHC consulta, Paciente paciente, ModoConsulta modo)
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

            _consulta = consulta;
            _paciente = paciente;
            _modo = modo;

            ConfigurarTextosPredeterminados();
        }

        /// <summary>
        /// Configura los textos predeterminados en los controles de la ventana.
        /// </summary>
        private void ConfigurarTextosPredeterminados()
        {
            int diferenciaEnAnios = DateTime.Now.Year - _paciente.FechaNacimiento.Year;
            lblNombrePaciente.Text = $"CONSULTA MEDICA: {_paciente.Nombre} - {diferenciaEnAnios} años";
            tbMotivoConsulta.Text = _consulta.MotivoConsulta;
            rtbEnfermedadActual.Text = _consulta.EnfermedadActual;
            rtbAntecedentesPersonales.Text = _consulta.AntecedentesPersonales;
        }


        private void tbMotivoConsulta_TextChanged(object sender, EventArgs e)
        {
            _consulta.MotivoConsulta = tbMotivoConsulta.Text;
        }

        private void rtbEnfermedadActual_TextChanged(object sender, EventArgs e)
        {
            _consulta.EnfermedadActual = rtbEnfermedadActual.Text;
        }

        private void rtbAntecedentesPersonales_TextChanged(object sender, EventArgs e)
        {
            _consulta.AntecedentesPersonales = rtbAntecedentesPersonales.Text;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Continuar.
        /// Valida los campos de la consulta médica y muestra la siguiente parte de la consulta.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "motivo", _consulta.MotivoConsulta },
                    { "enfermedadActual", _consulta.EnfermedadActual},
                    { "antecedenesPersonales", _consulta.AntecedentesPersonales},
                };

                RespuestaValidacion respuesta = _gestorHC.ValidarCampos(camposIngresados);

                if (respuesta.CamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                this.Hide();
                ConsultaParte2 consulta2 = new ConsultaParte2(_consulta, _paciente, _modo);
                consulta2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Atrás.
        /// Oculta la ventana actual y muestra el panel del paciente.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelPaciente panelPaciente = new PanelPaciente(_paciente);
            panelPaciente.Show();
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
