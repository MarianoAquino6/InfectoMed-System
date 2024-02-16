namespace InfectoMed_Forms
{
    partial class ConsultaParte1
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
            lblNombrePaciente = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            tbMotivoConsulta = new TextBox();
            rtbEnfermedadActual = new RichTextBox();
            rtbAntecedentesPersonales = new RichTextBox();
            btnContinuar = new Button();
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
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.BackColor = Color.Transparent;
            lblNombrePaciente.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombrePaciente.ForeColor = SystemColors.Window;
            lblNombrePaciente.Location = new Point(12, 61);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(153, 26);
            lblNombrePaciente.TabIndex = 2;
            lblNombrePaciente.Text = "CONSULTA INFO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(108, 18);
            label4.TabIndex = 4;
            label4.Text = "Motivo Consulta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 157);
            label1.Name = "label1";
            label1.Size = new Size(225, 18);
            label1.TabIndex = 5;
            label1.Text = "Enfermedad Actual / Antecedentes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(12, 383);
            label5.Name = "label5";
            label5.Size = new Size(166, 18);
            label5.TabIndex = 6;
            label5.Text = "Antecedentes Personales";
            // 
            // tbMotivoConsulta
            // 
            tbMotivoConsulta.BackColor = SystemColors.WindowText;
            tbMotivoConsulta.BorderStyle = BorderStyle.FixedSingle;
            tbMotivoConsulta.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbMotivoConsulta.ForeColor = Color.Red;
            tbMotivoConsulta.Location = new Point(12, 119);
            tbMotivoConsulta.MaxLength = 300;
            tbMotivoConsulta.Name = "tbMotivoConsulta";
            tbMotivoConsulta.Size = new Size(335, 25);
            tbMotivoConsulta.TabIndex = 16;
            tbMotivoConsulta.TextChanged += tbMotivoConsulta_TextChanged;
            // 
            // rtbEnfermedadActual
            // 
            rtbEnfermedadActual.BackColor = SystemColors.WindowText;
            rtbEnfermedadActual.BorderStyle = BorderStyle.FixedSingle;
            rtbEnfermedadActual.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbEnfermedadActual.ForeColor = Color.Red;
            rtbEnfermedadActual.Location = new Point(12, 178);
            rtbEnfermedadActual.MaxLength = 200000;
            rtbEnfermedadActual.Name = "rtbEnfermedadActual";
            rtbEnfermedadActual.Size = new Size(482, 184);
            rtbEnfermedadActual.TabIndex = 17;
            rtbEnfermedadActual.Text = "";
            rtbEnfermedadActual.TextChanged += rtbEnfermedadActual_TextChanged;
            // 
            // rtbAntecedentesPersonales
            // 
            rtbAntecedentesPersonales.BackColor = SystemColors.WindowText;
            rtbAntecedentesPersonales.BorderStyle = BorderStyle.FixedSingle;
            rtbAntecedentesPersonales.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbAntecedentesPersonales.ForeColor = Color.Red;
            rtbAntecedentesPersonales.Location = new Point(12, 404);
            rtbAntecedentesPersonales.MaxLength = 200000;
            rtbAntecedentesPersonales.Name = "rtbAntecedentesPersonales";
            rtbAntecedentesPersonales.Size = new Size(482, 175);
            rtbAntecedentesPersonales.TabIndex = 18;
            rtbAntecedentesPersonales.Text = "";
            rtbAntecedentesPersonales.TextChanged += rtbAntecedentesPersonales_TextChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(401, 603);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(93, 39);
            btnContinuar.TabIndex = 19;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.DarkRed;
            btnAyuda.FlatStyle = FlatStyle.Popup;
            btnAyuda.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyuda.ForeColor = SystemColors.Window;
            btnAyuda.Location = new Point(419, 12);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(75, 23);
            btnAyuda.TabIndex = 20;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // ConsultaParte1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 659);
            Controls.Add(btnAyuda);
            Controls.Add(btnContinuar);
            Controls.Add(rtbAntecedentesPersonales);
            Controls.Add(rtbEnfermedadActual);
            Controls.Add(tbMotivoConsulta);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblNombrePaciente);
            Controls.Add(btnAtras);
            Name = "ConsultaParte1";
            Text = "Consulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label lblNombrePaciente;
        private Label label4;
        private Label label1;
        private Label label5;
        private TextBox tbMotivoConsulta;
        private RichTextBox rtbEnfermedadActual;
        private RichTextBox rtbAntecedentesPersonales;
        private Button btnContinuar;
        private Button btnAyuda;
    }
}