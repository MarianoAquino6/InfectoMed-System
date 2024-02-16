using InfectoMed_Forms.Paneles;
using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using InfectoMed_System.Herramientas;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InfectoMed_Forms
{
    public partial class PanelMedico : Form
    {
        private Paciente _pacienteSeleccionado;
        private GestorPacientes _gestor = new GestorPacientes();
        private List<Paciente> _listaPacientes;

        /// <summary>
        /// Constructor de la clase PanelMedico.
        /// Configura la apariencia inicial del formulario, muestra un mensaje de bienvenida al médico logueado
        /// y carga la lista de pacientes asignados al médico.
        /// </summary>
        public PanelMedico()
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

            lblBienvenida.Text = $"Bienvenido Dr. {Sistema.MedicoLogueado.Nombre}!";
            _listaPacientes = _gestor.FiltrarPacientesSegunMedico(Sistema.MedicoLogueado);

            MostrarPacientes(string.Empty);
        }

        /// <summary>
        /// Muestra la lista de pacientes en el ListView, filtrando por el DNI ingresado si se proporciona.
        /// </summary>
        /// <param name="DNI">El DNI por el cual filtrar la lista de pacientes.</param>
        private void MostrarPacientes(string DNI)
        {
            lvPacientes.Items.Clear();

            if (_listaPacientes.Count > 0)
            {
                List<Paciente> pacientesFiltradosPorDNI = _listaPacientes
                    .Where(p => p.DNI.StartsWith(DNI, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                foreach (Paciente paciente in pacientesFiltradosPorDNI)
                {
                    ListViewItem nuevaFila = new ListViewItem(paciente.DNI);
                    nuevaFila.SubItems.Add(paciente.Nombre);
                    nuevaFila.SubItems.Add(paciente.Email);

                    lvPacientes.Items.Add(nuevaFila);
                }
            }
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            string dniIngresado = tbDNI.Text.Trim();
            MostrarPacientes(dniIngresado);
        }

        private void lvPacientes_ItemSelectionChanged(object sender, EventArgs e)
        {
            if (lvPacientes.SelectedItems.Count > 0)
            {
                _pacienteSeleccionado = _listaPacientes.Find(p => p.DNI == lvPacientes.SelectedItems[0].SubItems[0].Text);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Atrás".
        /// Oculta el formulario actual y muestra el formulario de inicio de sesión.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Nuevo Paciente".
        /// Oculta el formulario actual y muestra el formulario de registro de un nuevo paciente en modo creación.
        /// </summary>
        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroPaciente registroPaciente = new RegistroPaciente(ModoRegistroPaciente.CREAR);
            registroPaciente.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Continuar".
        /// Si se ha seleccionado un paciente, oculta el formulario actual y muestra el panel del paciente seleccionado.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (_pacienteSeleccionado != null)
            {
                this.Hide();
                PanelPaciente panelPaciente = new PanelPaciente(_pacienteSeleccionado);
                panelPaciente.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Editar Paciente".
        /// Si se ha seleccionado un paciente, oculta el formulario actual y muestra el formulario de edición del paciente seleccionado.
        /// </summary>
        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (_pacienteSeleccionado != null)
            {
                this.Hide();
                RegistroPaciente panelPaciente = new RegistroPaciente(_pacienteSeleccionado, ModoRegistroPaciente.EDITAR);
                panelPaciente.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Ayuda".
        /// Muestra el formulario de ayuda.
        /// </summary>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            PanelAyuda panelAyuda = new PanelAyuda();
            panelAyuda.ShowDialog();
        }
    }
}
