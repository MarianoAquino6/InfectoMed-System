namespace InfectoMed_Forms
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInicio = new Label();
            lblDNI = new Label();
            lblContrasenia = new Label();
            tbDNI = new TextBox();
            tbContrasenia = new TextBox();
            btnRegistro = new Button();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInicio.ForeColor = SystemColors.Window;
            lblInicio.Location = new Point(343, 60);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(149, 26);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "INICIAR SESION";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = SystemColors.Window;
            lblDNI.Location = new Point(346, 93);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 18);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = SystemColors.Window;
            lblContrasenia.Location = new Point(346, 148);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(82, 18);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contraseña:";
            // 
            // tbDNI
            // 
            tbDNI.BackColor = SystemColors.WindowText;
            tbDNI.BorderStyle = BorderStyle.FixedSingle;
            tbDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDNI.ForeColor = Color.Red;
            tbDNI.Location = new Point(346, 114);
            tbDNI.MaxLength = 8;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(146, 25);
            tbDNI.TabIndex = 3;
            tbDNI.TextChanged += tbDNI_TextChanged;
            // 
            // tbContrasenia
            // 
            tbContrasenia.BackColor = SystemColors.WindowText;
            tbContrasenia.BorderStyle = BorderStyle.FixedSingle;
            tbContrasenia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbContrasenia.ForeColor = Color.Red;
            tbContrasenia.Location = new Point(346, 169);
            tbContrasenia.MaxLength = 20;
            tbContrasenia.Name = "tbContrasenia";
            tbContrasenia.PasswordChar = '*';
            tbContrasenia.Size = new Size(146, 25);
            tbContrasenia.TabIndex = 4;
            tbContrasenia.UseSystemPasswordChar = true;
            tbContrasenia.TextChanged += tbContrasenia_TextChanged;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = SystemColors.WindowText;
            btnRegistro.FlatStyle = FlatStyle.Popup;
            btnRegistro.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.ForeColor = SystemColors.Window;
            btnRegistro.Location = new Point(309, 219);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(92, 23);
            btnRegistro.TabIndex = 5;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.WindowText;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.Window;
            btnIngresar.Location = new Point(452, 219);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(92, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.LOGO2;
            pictureBox1.Location = new Point(17, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 297);
            Controls.Add(pictureBox1);
            Controls.Add(btnIngresar);
            Controls.Add(btnRegistro);
            Controls.Add(tbContrasenia);
            Controls.Add(tbDNI);
            Controls.Add(lblContrasenia);
            Controls.Add(lblDNI);
            Controls.Add(lblInicio);
            Name = "InicioSesion";
            RightToLeftLayout = true;
            Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
        private Label lblDNI;
        private Label lblContrasenia;
        private TextBox tbDNI;
        private TextBox tbContrasenia;
        private Button btnRegistro;
        private Button btnIngresar;
        private PictureBox pictureBox1;
    }
}