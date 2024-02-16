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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfectoMed_Forms
{
    public partial class RegistroPaciente : Form
    {
        private string _DNI;
        private string _nombre;
        private DateTime _nacimiento;
        private string _profesion;
        private string _direccion;
        private string _obraPlan;
        private string _numeroSocio;
        private string _email;

        private GestorPacientes _gestor = new GestorPacientes();
        private Paciente _paciente;
        private ModoRegistroPaciente _modo;
        private string _DNIOriginal;

        /// <summary>
        /// Constructor de la clase RegistroPaciente para modo de registro nuevo.
        /// Configura la apariencia inicial del formulario de registro de paciente.
        /// </summary>
        public RegistroPaciente(ModoRegistroPaciente modo)
        {
            InitializeComponent();
            this.Text = "Registrar Paciente";
            _modo = modo;
        }

        /// <summary>
        /// Constructor de la clase RegistroPaciente para modo de edición.
        /// Configura la apariencia inicial del formulario de registro de paciente con los datos del paciente a editar.
        /// </summary>
        public RegistroPaciente(Paciente paciente, ModoRegistroPaciente modo)
        {
            InitializeComponent();
            this.Text = "Editar Paciente";

            _paciente = paciente;
            _modo = modo;

            CargarDatosPaciente();
        }

        private void CargarDatosPaciente()
        {
            tbDNI.Text = _paciente.DNI;
            _DNI = _paciente.DNI;
            _DNIOriginal = _paciente.DNI;
            tbNombre.Text = _paciente.Nombre;
            _nombre = _paciente.Nombre;
            tbProfesion.Text = _paciente.Profesion;
            _profesion = _paciente.Profesion;
            tbDireccion.Text = _paciente.Direccion;
            _direccion = _paciente.Direccion;
            tbObraPlan.Text = _paciente.PlanObraSocial;
            _obraPlan = _paciente.PlanObraSocial;
            tbNumSocio.Text = _paciente.NumeroSocio;
            _numeroSocio = _paciente.NumeroSocio;
            tbEmail.Text = _paciente.Email;
            _email = _paciente.Email;
            dateTimePicker1.Value = _paciente.FechaNacimiento;
            _nacimiento = _paciente.FechaNacimiento;
        }

        private void RegistroPaciente_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Image image = Image.FromFile(Sistema.FondoDePantalla);
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Icon icon = new Icon(Sistema.Icono);
            this.Icon = icon;
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            _DNI = tbDNI.Text;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbProfesion_TextChanged(object sender, EventArgs e)
        {
            _profesion = tbProfesion.Text;
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            _direccion = tbDireccion.Text;
        }

        private void tbObraPlan_TextChanged(object sender, EventArgs e)
        {
            _obraPlan = tbObraPlan.Text;
        }

        private void tbNumSocio_TextChanged(object sender, EventArgs e)
        {
            _numeroSocio = tbNumSocio.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            _email = tbEmail.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _nacimiento = dateTimePicker1.Value;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Atrás".
        /// Oculta el formulario actual y muestra el formulario del panel médico.
        /// </summary>
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            PanelMedico panelMedico = new PanelMedico();
            panelMedico.Show();
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Continuar".
        /// Valida los campos ingresados y registra o edita al paciente en el sistema según el modo de registro.
        /// </summary>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "DNI", _DNI },
                    { "nombre", _nombre},
                    { "profesion", _profesion},
                    { "direccion", _direccion },
                    { "planObraSocial", _obraPlan },
                    { "numeroSocio", _numeroSocio },
                    { "email", _email }
                };

                RespuestaValidacion respuesta;

                if (_modo == ModoRegistroPaciente.CREAR)
                {
                    respuesta = _gestor.GestionarRegistroPaciente(camposIngresados, _nacimiento);
                }
                else
                {
                    respuesta = _gestor.GestionarEdicionPaciente(camposIngresados, _nacimiento, _DNIOriginal);
                }

                if (respuesta.CamposVacios == true)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }
                else if (respuesta.ListaErrores.Count > 0)
                {
                    throw new Exception(respuesta.MensajeErrores);
                }
                else if (respuesta.RegistroDuplicado && _DNIOriginal != _DNI)
                {
                    throw new Exception("El paciente ya se encuentra registrado");
                }
                else
                {
                    if (_modo == ModoRegistroPaciente.CREAR)
                    {
                        MessageBox.Show("Paciente registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        ConsultaHC nuevaConsulta = new ConsultaHC();
                        Paciente nuevoPaciente = new Paciente(_DNI, _nombre, _nacimiento, _profesion, _direccion, _obraPlan, _numeroSocio, _email);

                        this.Hide();
                        ConsultaParte1 consulta1 = new ConsultaParte1(nuevaConsulta, nuevoPaciente, ModoConsulta.CREAR);
                        consulta1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Paciente editado exitosamente", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.Hide();
                        PanelMedico panelMedico = new PanelMedico();
                        panelMedico.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
