using InfectoMed_Forms.Paneles;
using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using InfectoMed_System.Herramientas;
using InfectoMed_System.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfectoMed_Forms
{
    public partial class TratamientoOrden : Form
    {
        private ConsultaHC _nuevaConsulta;
        private Paciente _paciente;
        private GestorHC _gestorHC = new GestorHC();
        private GeneradorPDF _generadorPDF = new GeneradorPDF();
        private ModoConsulta _modo;

        /// <summary>
        /// Constructor de la clase TratamientoOrden.
        /// </summary>
        /// <param name="nuevaConsulta">La nueva consulta médica.</param>
        /// <param name="paciente">El paciente asociado a la consulta.</param>
        /// <param name="modo">El modo de consulta (Admin o Estudiante).</param>
        public TratamientoOrden(ConsultaHC nuevaConsulta, Paciente paciente, ModoConsulta modo)
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
            lblNombre.Text = $"Nombre: {_paciente.Nombre}";
            lblDNI.Text = $"DNI: {_paciente.DNI}";
            lblObraPlan.Text = $"Obra social y Plan: {_paciente.PlanObraSocial}";
            lblNumSocio.Text = $"Numero de Socio: {_paciente.NumeroSocio}";
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFirma.Text = $"{Sistema.MedicoLogueado.Nombre} \nMédico Infectologo \n" +
                $"M.N. {Sistema.MedicoLogueado.Matricula}";
            lblDiagnostico.Text = $"DX: {_nuevaConsulta.DiagnosticoPresuntivo}";

            rtbRecetaOrden.Text = _nuevaConsulta.TratamientoOrden;
            rtbAclaraciones.Text = _nuevaConsulta.Aclaraciones;
        }

        private void rtbRecetaOrden_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.TratamientoOrden = rtbRecetaOrden.Text;
        }

        private void rtbAclaraciones_TextChanged(object sender, EventArgs e)
        {
            _nuevaConsulta.Aclaraciones = rtbAclaraciones.Text;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Atrás.
        /// Oculta la ventana actual y muestra la parte anterior de la consulta.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaParte3 consulta3 = new ConsultaParte3(_nuevaConsulta, _paciente, _modo);
            consulta3.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Terminar.
        /// Registra la consulta médica y, si se confirma, imprime la receta/orden médica.
        /// </summary>
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    {"@tratamientoOrden", _nuevaConsulta.TratamientoOrden},
                    {"@aclaraciones", _nuevaConsulta.Aclaraciones }
                };

                RespuestaValidacion respuesta;

                if (_modo == ModoConsulta.CREAR)
                {
                    respuesta = _gestorHC.GestionarRegistroConsulta(camposIngresados, _nuevaConsulta, _paciente);
                }
                else
                {
                    respuesta = _gestorHC.GestionarEdicionConsulta(camposIngresados, _nuevaConsulta, _paciente);
                }

                if (respuesta.CamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }

                DialogResult result = MessageBox.Show("Consulta registrada exitosamente! \nDesea imprimir la receta/orden medica?", "Registro Exitoso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    string _PDFGenerado = _generadorPDF.GenerarPDFTratamientoOrden(_nuevaConsulta, _paciente, Sistema.MedicoLogueado);

                    PrintPDF(_PDFGenerado);

                    // Eliminar el archivo generado después de imprimir
                    if (File.Exists(_PDFGenerado))
                    {
                        File.Delete(_PDFGenerado);
                    }

                    this.Hide();
                    PanelMedico panelMedico = new PanelMedico();
                    panelMedico.Show();
                }
                else
                {
                    this.Hide();
                    PanelMedico panelMedico = new PanelMedico();
                    panelMedico.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Imprime un archivo PDF.
        /// </summary>
        /// <param name="filePath">La ruta del archivo PDF a imprimir.</param>
        private void PrintPDF(string filePath)
        {
            try
            {
                // Crear un proceso para imprimir el archivo
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = filePath,
                    Verb = "Print",
                    UseShellExecute = true,
                    CreateNoWindow = true
                };

                Process printProcess = Process.Start(psi);

                // Esperar a que termine la impresión
                printProcess.WaitForExit();
            }
            catch (Exception ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
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
