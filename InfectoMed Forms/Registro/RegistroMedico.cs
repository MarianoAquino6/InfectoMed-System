using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
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
    public partial class RegistroMedico : Form
    {
        private string _DNI;
        private string _nombre;
        private string _contrasenia;
        private string _matricula;
        GestorMedicos gestor = new GestorMedicos();

        /// <summary>
        /// Constructor de la clase RegistroMedico.
        /// Configura la apariencia inicial del formulario de registro de médico.
        /// </summary>
        public RegistroMedico()
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
        }

        private void tbDNI_TextChanged(object sender, EventArgs e)
        {
            _DNI = tbDNI.Text;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            _nombre = tbNombre.Text;
        }

        private void tbContrasenia_TextChanged(object sender, EventArgs e)
        {
            _contrasenia = tbContrasenia.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _matricula = textBox1.Text;
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
        /// Evento que se dispara al hacer clic en el botón "Registrarse".
        /// Valida los campos ingresados y registra al médico en el sistema si los datos son válidos.
        /// </summary>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "DNI", _DNI },
                    { "nombre", _nombre},
                    { "contrasenia", _contrasenia},
                    { "matricula", _matricula }
                };

                RespuestaValidacion respuesta = gestor.GestionarRegistroDeMedico(camposIngresados);

                if (respuesta.CamposVacios == true)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }
                else if (respuesta.ListaErrores.Count > 0)
                {
                    throw new Exception(respuesta.MensajeErrores);
                }
                else if (respuesta.RegistroDuplicado)
                {
                    throw new Exception("El usuario ya se encuentra registrado");
                }
                else
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Hide();
                    InicioSesion inicioSesion = new InicioSesion();
                    inicioSesion.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
