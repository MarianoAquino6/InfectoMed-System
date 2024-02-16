using InfectoMed_Forms.Paneles;
using InfectoMed_System.Entidades;
using InfectoMed_System.Gestores;
using InfectoMed_System.Validaciones;

namespace InfectoMed_Forms
{
    public partial class InicioSesion : Form
    {
        private string _DNI;
        private string _contrasenia;
        private GestorMedicos _gestor = new GestorMedicos();

        /// <summary>
        /// Constructor de la clase InicioSesion.
        /// </summary>
        public InicioSesion()
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

        private void tbContrasenia_TextChanged(object sender, EventArgs e)
        {
            _contrasenia = tbContrasenia.Text;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón Ingresar.
        /// Verifica las credenciales ingresadas y muestra la ventana principal si son correctas.
        /// </summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> camposIngresados = new Dictionary<string, string>()
                {
                    { "DNI", _DNI },
                    { "contrasenia", _contrasenia}
                };

                RespuestaValidacion resultadoLogIn = _gestor.CorroborarCredenciales(camposIngresados);

                if (resultadoLogIn.CamposVacios)
                {
                    throw new Exception("Asegúrese de completar los campos solicitados");
                }
                else if (!resultadoLogIn.LogInExitoso)
                {
                    throw new Exception("Credenciales de inicio incorrectas");
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
        /// Evento que se dispara al hacer clic en el botón Registro.
        /// Verifica un código de acceso para permitir el registro de un nuevo médico.
        /// </summary>
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string codigoIngresado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña:", "Verificar Contraseña", "");

            if (_gestor.ValidarContraseniaRegistro(codigoIngresado))
            {
                this.Hide();
                RegistroMedico registroMedico = new RegistroMedico();
                registroMedico.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}