namespace InfectoMed_Forms
{
    partial class RegistroPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAtras = new Button();
            lblInfo = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblNacimiento = new Label();
            lblProfesion = new Label();
            lblEmail = new Label();
            lblDireccion = new Label();
            lblObraSocial = new Label();
            lblSocio = new Label();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            tbProfesion = new TextBox();
            tbDireccion = new TextBox();
            tbObraPlan = new TextBox();
            tbNumSocio = new TextBox();
            tbEmail = new TextBox();
            btnContinuar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkRed;
            btnAtras.FlatStyle = FlatStyle.Popup;
            btnAtras.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ForeColor = SystemColors.Window;
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Window;
            lblInfo.Location = new Point(12, 63);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(331, 26);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Ingrese los datos del nuevo paciente:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = SystemColors.Window;
            lblDNI.Location = new Point(12, 112);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 18);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(12, 184);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(129, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre y Apellido:";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.BackColor = Color.Transparent;
            lblNacimiento.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNacimiento.ForeColor = SystemColors.Window;
            lblNacimiento.Location = new Point(12, 250);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(142, 18);
            lblNacimiento.TabIndex = 4;
            lblNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblProfesion
            // 
            lblProfesion.AutoSize = true;
            lblProfesion.BackColor = Color.Transparent;
            lblProfesion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesion.ForeColor = SystemColors.Window;
            lblProfesion.Location = new Point(12, 311);
            lblProfesion.Name = "lblProfesion";
            lblProfesion.Size = new Size(72, 18);
            lblProfesion.TabIndex = 5;
            lblProfesion.Text = "Profesion:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.Window;
            lblEmail.Location = new Point(259, 311);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-Mail:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.Window;
            lblDireccion.Location = new Point(259, 112);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(70, 18);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion:";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.BackColor = Color.Transparent;
            lblObraSocial.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblObraSocial.ForeColor = SystemColors.Window;
            lblObraSocial.Location = new Point(259, 184);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(121, 18);
            lblObraSocial.TabIndex = 8;
            lblObraSocial.Text = "Obra Social y Plan:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.BackColor = Color.Transparent;
            lblSocio.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSocio.ForeColor = SystemColors.Window;
            lblSocio.Location = new Point(259, 253);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(118, 18);
            lblSocio.TabIndex = 9;
            lblSocio.Text = "Numero de Socio:";
            // 
            // tbDNI
            // 
            tbDNI.BackColor = SystemColors.WindowText;
            tbDNI.BorderStyle = BorderStyle.FixedSingle;
            tbDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDNI.ForeColor = Color.Red;
            tbDNI.Location = new Point(12, 133);
            tbDNI.MaxLength = 8;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(177, 25);
            tbDNI.TabIndex = 10;
            tbDNI.TextChanged += tbDNI_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.WindowText;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.Red;
            tbNombre.Location = new Point(12, 205);
            tbNombre.MaxLength = 80;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(177, 25);
            tbNombre.TabIndex = 11;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbProfesion
            // 
            tbProfesion.BackColor = SystemColors.WindowText;
            tbProfesion.BorderStyle = BorderStyle.FixedSingle;
            tbProfesion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbProfesion.ForeColor = Color.Red;
            tbProfesion.Location = new Point(12, 332);
            tbProfesion.MaxLength = 50;
            tbProfesion.Name = "tbProfesion";
            tbProfesion.Size = new Size(177, 25);
            tbProfesion.TabIndex = 13;
            tbProfesion.TextChanged += tbProfesion_TextChanged;
            // 
            // tbDireccion
            // 
            tbDireccion.BackColor = SystemColors.WindowText;
            tbDireccion.BorderStyle = BorderStyle.FixedSingle;
            tbDireccion.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDireccion.ForeColor = Color.Red;
            tbDireccion.Location = new Point(259, 133);
            tbDireccion.MaxLength = 50;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(165, 25);
            tbDireccion.TabIndex = 14;
            tbDireccion.TextChanged += tbDireccion_TextChanged;
            // 
            // tbObraPlan
            // 
            tbObraPlan.BackColor = SystemColors.WindowText;
            tbObraPlan.BorderStyle = BorderStyle.FixedSingle;
            tbObraPlan.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbObraPlan.ForeColor = Color.Red;
            tbObraPlan.Location = new Point(259, 205);
            tbObraPlan.MaxLength = 50;
            tbObraPlan.Name = "tbObraPlan";
            tbObraPlan.Size = new Size(165, 25);
            tbObraPlan.TabIndex = 15;
            tbObraPlan.TextChanged += tbObraPlan_TextChanged;
            // 
            // tbNumSocio
            // 
            tbNumSocio.BackColor = SystemColors.WindowText;
            tbNumSocio.BorderStyle = BorderStyle.FixedSingle;
            tbNumSocio.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNumSocio.ForeColor = Color.Red;
            tbNumSocio.Location = new Point(259, 274);
            tbNumSocio.MaxLength = 50;
            tbNumSocio.Name = "tbNumSocio";
            tbNumSocio.Size = new Size(165, 25);
            tbNumSocio.TabIndex = 16;
            tbNumSocio.TextChanged += tbNumSocio_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.WindowText;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.Red;
            tbEmail.Location = new Point(259, 332);
            tbEmail.MaxLength = 50;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(165, 25);
            tbEmail.TabIndex = 17;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(336, 385);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(88, 40);
            btnContinuar.TabIndex = 18;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.Red;
            dateTimePicker1.CalendarMonthBackground = SystemColors.WindowText;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.WindowText;
            dateTimePicker1.CalendarTitleForeColor = Color.Red;
            dateTimePicker1.CalendarTrailingForeColor = Color.Red;
            dateTimePicker1.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(12, 271);
            dateTimePicker1.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1880, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 25);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.Value = new DateTime(1950, 1, 30, 14, 42, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 437);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnContinuar);
            Controls.Add(tbEmail);
            Controls.Add(tbNumSocio);
            Controls.Add(tbObraPlan);
            Controls.Add(tbDireccion);
            Controls.Add(tbProfesion);
            Controls.Add(tbNombre);
            Controls.Add(tbDNI);
            Controls.Add(lblSocio);
            Controls.Add(lblObraSocial);
            Controls.Add(lblDireccion);
            Controls.Add(lblEmail);
            Controls.Add(lblProfesion);
            Controls.Add(lblNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblInfo);
            Controls.Add(btnAtras);
            Name = "RegistroPaciente";
            Text = "RegistroPaciente";
            Load += RegistroPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblInfo;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblNacimiento;
        private Label lblProfesion;
        private Label lblEmail;
        private Label lblDireccion;
        private Label lblObraSocial;
        private Label lblSocio;
        private TextBox tbDNI;
        private TextBox tbNombre;
        private TextBox tbProfesion;
        private TextBox tbDireccion;
        private TextBox tbObraPlan;
        private TextBox tbNumSocio;
        private TextBox tbEmail;
        private Button btnContinuar;
        private DateTimePicker dateTimePicker1;
    }
}