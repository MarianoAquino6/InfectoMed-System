using InfectoMed_System.Database;
using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using InfectoMed_System.Herramientas;
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
    public partial class PanelPaciente : Form
    {
        private Paciente _paciente;
        private List<ConsultaHC> _listaConsultas;
        private GestorHC _gestor = new GestorHC();
        private ConsultaHC _consultaSeleccionada;
        private GeneradorPDF _generadorPDF = new GeneradorPDF();

        /// <summary>
        /// Constructor de la clase PanelPaciente.
        /// Configura la apariencia inicial del formulario, muestra el nombre y DNI del paciente
        /// y carga la lista de consultas asociadas al paciente.
        /// </summary>
        /// <param name="paciente">El paciente para el cual mostrar las consultas.</param>
        public PanelPaciente(Paciente paciente)
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

            _paciente = paciente;
            lblNombre.Text = $"Nombre: {paciente.Nombre}";
            lblDNI.Text = $"DNI: {paciente.DNI}";

            MostrarPacientes();
        }

        /// <summary>
        /// Muestra la lista de consultas asociadas al paciente en el ListView.
        /// </summary>
        private void MostrarPacientes()
        {
            _listaConsultas = _gestor.ObtenerConsultasSegunDNI(_paciente.DNI);

            lvConsultas.Items.Clear();

            if (_listaConsultas.Count > 0)
            {
                foreach (ConsultaHC consulta in _listaConsultas)
                {
                    ListViewItem nuevaFila = new ListViewItem(consulta.Fecha.ToString());
                    nuevaFila.SubItems.Add(consulta.MotivoConsulta);

                    lvConsultas.Items.Add(nuevaFila);
                }
            }
        }

        private void lvConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvConsultas.SelectedItems.Count > 0)
            {
                DateTime fechaSeleccionada = DateTime.Parse(lvConsultas.SelectedItems[0].SubItems[0].Text);
                string motivoSeleccionado = lvConsultas.SelectedItems[0].SubItems[1].Text;

                _consultaSeleccionada = _listaConsultas.Find(consulta => consulta.Fecha == fechaSeleccionada
                && consulta.MotivoConsulta == motivoSeleccionado);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Nueva Consulta".
        /// Oculta el formulario actual y muestra el formulario para crear una nueva consulta.
        /// </summary>
        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            ConsultaHC nuevaConsulta = new ConsultaHC();

            this.Hide();
            ConsultaParte1 consulta1 = new ConsultaParte1(nuevaConsulta, _paciente, ModoConsulta.CREAR);
            consulta1.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Ver".
        /// Abre el archivo PDF generado para visualizar la consulta seleccionada.
        /// </summary>
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (_consultaSeleccionada != null)
            {
                string _PDFGenerado = _generadorPDF.GenerarPDF(_consultaSeleccionada, _paciente, Sistema.MedicoLogueado);

                // Lanzar la aplicación de visor de PDF de forma asíncrona
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = _PDFGenerado,
                    UseShellExecute = true
                };
                Process pdfViewerProcess = new Process { StartInfo = psi };
                pdfViewerProcess.Start();
                pdfViewerProcess.WaitForExit();

                // Eliminar el archivo generado después de cerrar el visor de PDF
                if (File.Exists(_PDFGenerado))
                {
                    try
                    {
                        File.Delete(_PDFGenerado);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al eliminar el archivo PDF: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Editar".
        /// Oculta el formulario actual y muestra el formulario para editar la consulta seleccionada.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_consultaSeleccionada != null)
            {
                this.Hide();
                ConsultaParte1 consulta1 = new ConsultaParte1(_consultaSeleccionada, _paciente, ModoConsulta.EDITAR);
                consulta1.Show();
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Atrás".
        /// Oculta el formulario actual y muestra el panel del médico.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelMedico panelMedico = new PanelMedico();
            panelMedico.Show();
        }
    }
}
