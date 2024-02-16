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
    public partial class ConsultaParte2 : Form
    {
        private ConsultaHC _nuevaConsulta;
        private Paciente _paciente;
        private GestorHC _gestorHC = new GestorHC();
        private ModoConsulta _modo;

        /// <summary>
        /// Constructor de la clase ConsultaParte2.
        /// </summary>
        /// <param name="nuevaConsulta">La nueva consulta médica.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        /// <param name="modo">El modo de consulta (Admin o Estudiante).</param>
        public ConsultaParte2(ConsultaHC nuevaConsulta, Paciente paciente, ModoConsulta modo)
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
            rtbInspeccion.Text = _nuevaConsulta.Inspeccion;
            rtbSignosVitales.Text = _nuevaConsulta.SignosVitales;
            rtbTegumentario.Text = _nuevaConsulta.Tegumentario;
            rtbNervioso.Text = _nuevaConsulta.Nervioso;
            rtbLinfo.Text = _nuevaConsulta.Linfo;
            rtbVenoso.Text = _nuevaConsulta.Venoso;
            rtbOsteo.Text = _nuevaConsulta.Osteo;
            rtbCabeza.Text = _nuevaConsulta.Cabeza;
            rtbCardio.Text = _nuevaConsulta.Cardio;
            rtbRespi.Text = _nuevaConsulta.Respi;
            rtbAbdomen.Text = _nuevaConsulta.Abdomen;
            rtbOtros.Text = _nuevaConsulta.Otros;
        }

        private void rtbInspeccion_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Inspeccion = rtbInspeccion.Text;
        }

        private void rtbSignosVitales_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.SignosVitales = rtbSignosVitales.Text;
        }

        private void rtbTegumentario_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Tegumentario = rtbTegumentario.Text;
        }

        private void rtbNervioso_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Nervioso = rtbNervioso.Text;
        }

        private void rtbLinfo_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Linfo = rtbLinfo.Text;
        }

        private void rtbVenoso_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Venoso = rtbVenoso.Text;
        }

        private void rtbOsteo_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Osteo = rtbOsteo.Text;
        }

        private void rtbCabeza_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Cabeza = rtbCabeza.Text;
        }

        private void rtbCardio_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Cardio = rtbCardio.Text;
        }

        private void rtbRespi_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Respi = rtbRespi.Text;
        }

        private void rtbAbdomen_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Abdomen = rtbAbdomen.Text;
        }

        private void rtbOtros_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Otros = rtbOtros.Text;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Atrás.
        /// Oculta la ventana actual y muestra la parte anterior de la consulta.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaParte1 consulta1 = new ConsultaParte1(_nuevaConsulta, _paciente, _modo);
            consulta1.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Continuar.
        /// Valida los campos de la nueva consulta médica y muestra la siguiente parte de la consulta.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    {"@inspeccion", _nuevaConsulta.Inspeccion},
                    {"@signosVitales", _nuevaConsulta.SignosVitales },
                    {"@tegumentario", _nuevaConsulta.Tegumentario },
                    {"@linfoganglionar", _nuevaConsulta.Linfo },
                    {"@venoso", _nuevaConsulta.Venoso},
                    {"@osteo", _nuevaConsulta.Osteo },
                    {"@cabeza", _nuevaConsulta.Cabeza },
                    {"@cardio", _nuevaConsulta.Cardio },
                    {"@respi", _nuevaConsulta.Respi },
                    {"@abdomen", _nuevaConsulta.Abdomen },
                    {"@nervioso", _nuevaConsulta.Nervioso },
                    {"@otros", _nuevaConsulta.Otros }
                };

                RespuestaValidacion respuesta = _gestorHC.ValidarCampos(camposIngresados);

                if (respuesta.CamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                this.Hide();
                ConsultaParte3 consulta3 = new ConsultaParte3(_nuevaConsulta, _paciente, _modo);
                consulta3.Show();
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
