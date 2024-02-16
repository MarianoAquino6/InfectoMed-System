namespace InfectoMed_Forms
{
    partial class PanelMedico
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
            lblBienvenida = new Label();
            lblBuscar = new Label();
            tbDNI = new TextBox();
            lvPacientes = new ListView();
            DNI = new ColumnHeader();
            Nombre = new ColumnHeader();
            Email = new ColumnHeader();
            btnNuevoPaciente = new Button();
            btnContinuar = new Button();
            btnEditarPaciente = new Button();
            btnAyuda = new Button();
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
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBienvenida.ForeColor = SystemColors.Window;
            lblBienvenida.Location = new Point(12, 79);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(200, 26);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido NOMBRE!";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = SystemColors.Window;
            lblBuscar.Location = new Point(12, 127);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(175, 18);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar paciente segun DNI:";
            // 
            // tbDNI
            // 
            tbDNI.BackColor = SystemColors.WindowText;
            tbDNI.BorderStyle = BorderStyle.FixedSingle;
            tbDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDNI.ForeColor = Color.Red;
            tbDNI.Location = new Point(193, 125);
            tbDNI.MaxLength = 8;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(161, 25);
            tbDNI.TabIndex = 3;
            tbDNI.TextChanged += tbDNI_TextChanged;
            // 
            // lvPacientes
            // 
            lvPacientes.BackColor = SystemColors.WindowText;
            lvPacientes.BorderStyle = BorderStyle.FixedSingle;
            lvPacientes.Columns.AddRange(new ColumnHeader[] { DNI, Nombre, Email });
            lvPacientes.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvPacientes.ForeColor = Color.Red;
            lvPacientes.FullRowSelect = true;
            lvPacientes.Location = new Point(12, 170);
            lvPacientes.MultiSelect = false;
            lvPacientes.Name = "lvPacientes";
            lvPacientes.Size = new Size(464, 257);
            lvPacientes.TabIndex = 4;
            lvPacientes.UseCompatibleStateImageBehavior = false;
            lvPacientes.View = View.Details;
            lvPacientes.ItemSelectionChanged += lvPacientes_ItemSelectionChanged;
            // 
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 120;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.TextAlign = HorizontalAlignment.Center;
            Nombre.Width = 160;
            // 
            // Email
            // 
            Email.Text = "E-Mail";
            Email.TextAlign = HorizontalAlignment.Center;
            Email.Width = 180;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.BackColor = SystemColors.WindowText;
            btnNuevoPaciente.FlatStyle = FlatStyle.Popup;
            btnNuevoPaciente.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoPaciente.ForeColor = SystemColors.Window;
            btnNuevoPaciente.Location = new Point(12, 460);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(106, 38);
            btnNuevoPaciente.TabIndex = 5;
            btnNuevoPaciente.Text = "Ingresar Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(370, 460);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(106, 38);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.BackColor = SystemColors.WindowText;
            btnEditarPaciente.FlatStyle = FlatStyle.Popup;
            btnEditarPaciente.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPaciente.ForeColor = SystemColors.Window;
            btnEditarPaciente.Location = new Point(194, 460);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Size = new Size(97, 38);
            btnEditarPaciente.TabIndex = 7;
            btnEditarPaciente.Text = "Editar Paciente";
            btnEditarPaciente.UseVisualStyleBackColor = false;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.DarkRed;
            btnAyuda.FlatStyle = FlatStyle.Popup;
            btnAyuda.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyuda.ForeColor = SystemColors.Window;
            btnAyuda.Location = new Point(403, 12);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(75, 23);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // PanelMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 521);
            Controls.Add(btnAyuda);
            Controls.Add(btnEditarPaciente);
            Controls.Add(btnContinuar);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(lvPacientes);
            Controls.Add(tbDNI);
            Controls.Add(lblBuscar);
            Controls.Add(lblBienvenida);
            Controls.Add(btnAtras);
            Name = "PanelMedico";
            Text = "Panel Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblBienvenida;
        private Label lblBuscar;
        private TextBox tbDNI;
        private ListView lvPacientes;
        private Button btnNuevoPaciente;
        private Button btnContinuar;
        private ColumnHeader DNI;
        private ColumnHeader Nombre;
        private ColumnHeader Email;
        private Button btnEditarPaciente;
        private Button btnAyuda;
    }
}