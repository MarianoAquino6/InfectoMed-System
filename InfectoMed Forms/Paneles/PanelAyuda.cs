using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfectoMed_Forms.Paneles
{
    public partial class PanelAyuda : Form
    {
        private GestorAyuda _gestorAyuda = new GestorAyuda();
        private Enfermedad _enfermedadSeleccionada;
        private List<Enfermedad> _listaEnfermedades;
        private List<Farmaco> _listaFarmacos;
        private Farmaco _farmacoSeleccionado;

        /// <summary>
        /// Constructor de la clase PanelAyuda.
        /// Configura la apariencia inicial del formulario y carga la lista de enfermedades.
        /// </summary>
        public PanelAyuda()
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

            lblEsquema.Text = "Seleccione una enfermedad";
            lblPosologiaInfo.Text = "Seleccione un farmaco";

            _listaEnfermedades = _gestorAyuda.ObtenerTodasLasEnfermedades();
            MostrarComboBoxEnfermedades();
        }

        /// <summary>
        /// Muestra las enfermedades disponibles en el ComboBox de enfermedades.
        /// </summary>
        public void MostrarComboBoxEnfermedades()
        {
            cbEnfermedad.Items.Clear();

            foreach (Enfermedad enfermedad in _listaEnfermedades)
            {
                cbEnfermedad.Items.Add(enfermedad.Nombre);
            }
        }

        /// <summary>
        /// Muestra los fármacos disponibles en el ComboBox de fármacos.
        /// </summary>
        public void MostrarComboBoxFarmacos()
        {
            cbFarmacosDisponibles.Items.Clear();

            foreach (Farmaco farmaco in _listaFarmacos)
            {
                cbFarmacosDisponibles.Items.Add(farmaco.Nombre);
            }
        }

        /// <summary>
        /// Muestra los efectos adversos del fármaco seleccionado en la lista de efectos adversos.
        /// </summary>
        private void MostrarEfectosAdversos()
        {
            lvEfectosAdversos.Items.Clear();

            if (_farmacoSeleccionado.EfectosAdversos.Count > 0)
            {
                foreach (string efectoAdverso in _farmacoSeleccionado.EfectosAdversos)
                {
                    ListViewItem nuevaFila = new ListViewItem(efectoAdverso);

                    lvEfectosAdversos.Items.Add(nuevaFila);
                }
            }
        }

        /// <summary>
        /// Muestra las contraindicaciones del fármaco seleccionado en la lista de contraindicaciones.
        /// </summary>
        private void MostrarContraindicaciones()
        {
            lvContraindicaciones.Items.Clear();

            if (_farmacoSeleccionado.Contraindicaciones.Count > 0)
            {
                foreach (string contraindicacion in _farmacoSeleccionado.Contraindicaciones)
                {
                    ListViewItem nuevaFila = new ListViewItem(contraindicacion);

                    lvContraindicaciones.Items.Add(nuevaFila);
                }
            }
        }

        /// <summary>
        /// Reinicia los valores mostrados en el formulario.
        /// </summary>
        private void ReiniciarValores()
        {
            lblPosologiaInfo.Text = "Seleccione un farmaco";
            lvEfectosAdversos.Items.Clear();
            lvContraindicaciones.Items.Clear();
            cbFarmacosDisponibles.Text = string.Empty;
        }

        /// <summary>
        /// Evento que se dispara al seleccionar una enfermedad en el ComboBox de enfermedades.
        /// Carga los fármacos disponibles para la enfermedad seleccionada.
        /// </summary>
        private void cbEnfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnfermedad.SelectedItem != null)
            {
                string nombreSeleccionado = cbEnfermedad.SelectedItem.ToString();
                _enfermedadSeleccionada = _listaEnfermedades.Find(enfermedad => enfermedad.Nombre == nombreSeleccionado);
                lblEsquema.Text = _enfermedadSeleccionada.Esquema;
                _listaFarmacos = _gestorAyuda.ObtenerFarmacosSegunEnfermedad(_enfermedadSeleccionada);
                MostrarComboBoxFarmacos();
                ReiniciarValores();
            }
        }

        /// <summary>
        /// Evento que se dispara al seleccionar un fármaco en el ComboBox de fármacos.
        /// Muestra la información del fármaco seleccionado.
        /// </summary>
        private void cbFarmacosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFarmacosDisponibles.SelectedItem != null)
            {
                string nombreSeleccionado = cbFarmacosDisponibles.SelectedItem.ToString();
                _farmacoSeleccionado = _listaFarmacos.Find(farmaco => farmaco.Nombre == nombreSeleccionado);
                lblPosologiaInfo.Text = _farmacoSeleccionado.Dosis;
                MostrarEfectosAdversos();
                MostrarContraindicaciones();
            }
        }
    }
}
