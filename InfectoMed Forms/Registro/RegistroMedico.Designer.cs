namespace InfectoMed_Forms
{
    partial class RegistroMedico
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
            lblIngrese = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblContrasenia = new Label();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            tbContrasenia = new TextBox();
            btnRegistrarse = new Button();
            lblMatricula = new Label();
            textBox1 = new TextBox();
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
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.BackColor = Color.Transparent;
            lblIngrese.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIngrese.ForeColor = SystemColors.Window;
            lblIngrese.Location = new Point(12, 58);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(254, 26);
            lblIngrese.TabIndex = 1;
            lblIngrese.Text = "Ingrese los siguientes datos:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = SystemColors.Window;
            lblDNI.Location = new Point(12, 98);
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
            lblNombre.Location = new Point(12, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(129, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre y Apellido:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.BackColor = Color.Transparent;
            lblContrasenia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.ForeColor = SystemColors.Window;
            lblContrasenia.Location = new Point(12, 212);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(82, 18);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña:";
            // 
            // tbDNI
            // 
            tbDNI.BackColor = SystemColors.WindowText;
            tbDNI.BorderStyle = BorderStyle.FixedSingle;
            tbDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDNI.ForeColor = Color.Red;
            tbDNI.Location = new Point(12, 119);
            tbDNI.MaxLength = 8;
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(170, 25);
            tbDNI.TabIndex = 6;
            tbDNI.TextChanged += tbDNI_TextChanged;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.WindowText;
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.ForeColor = Color.Red;
            tbNombre.Location = new Point(12, 177);
            tbNombre.MaxLength = 80;
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(170, 25);
            tbNombre.TabIndex = 7;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // tbContrasenia
            // 
            tbContrasenia.BackColor = SystemColors.WindowText;
            tbContrasenia.BorderStyle = BorderStyle.FixedSingle;
            tbContrasenia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbContrasenia.ForeColor = Color.Red;
            tbContrasenia.Location = new Point(12, 233);
            tbContrasenia.MaxLength = 20;
            tbContrasenia.Name = "tbContrasenia";
            tbContrasenia.Size = new Size(170, 25);
            tbContrasenia.TabIndex = 8;
            tbContrasenia.TextChanged += tbContrasenia_TextChanged;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = SystemColors.WindowText;
            btnRegistrarse.FlatStyle = FlatStyle.Popup;
            btnRegistrarse.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = SystemColors.Window;
            btnRegistrarse.Location = new Point(247, 323);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(97, 33);
            btnRegistrarse.TabIndex = 9;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.BackColor = Color.Transparent;
            lblMatricula.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.ForeColor = SystemColors.Window;
            lblMatricula.Location = new Point(12, 272);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(70, 18);
            lblMatricula.TabIndex = 10;
            lblMatricula.Text = "Matricula:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.WindowText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(12, 293);
            textBox1.MaxLength = 7;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 25);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RegistroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 368);
            Controls.Add(textBox1);
            Controls.Add(lblMatricula);
            Controls.Add(btnRegistrarse);
            Controls.Add(tbContrasenia);
            Controls.Add(tbNombre);
            Controls.Add(tbDNI);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblIngrese);
            Controls.Add(btnAtras);
            Name = "RegistroMedico";
            Text = "Registrar Medico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblIngrese;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblContrasenia;
        private TextBox tbDNI;
        private TextBox tbNombre;
        private TextBox tbContrasenia;
        private Button btnRegistrarse;
        private Label lblMatricula;
        private TextBox textBox1;
    }
}