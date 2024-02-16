namespace InfectoMed_Forms
{
    partial class ConsultaParte3
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
            label1 = new Label();
            label2 = new Label();
            rtbResumen = new RichTextBox();
            label3 = new Label();
            tbDiagnosticoPresuntivo = new TextBox();
            label4 = new Label();
            rtbDxDiferenciales = new RichTextBox();
            btnContinuar = new Button();
            btnAyuda = new Button();
            rtbComplementarios = new RichTextBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(189, 18);
            label1.TabIndex = 1;
            label1.Text = "Examenes Complementarios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(12, 243);
            label2.Name = "label2";
            label2.Size = new Size(149, 18);
            label2.TabIndex = 2;
            label2.Text = "Resumen Semiologico:";
            // 
            // rtbResumen
            // 
            rtbResumen.BackColor = SystemColors.WindowText;
            rtbResumen.BorderStyle = BorderStyle.FixedSingle;
            rtbResumen.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbResumen.ForeColor = Color.Red;
            rtbResumen.Location = new Point(12, 264);
            rtbResumen.MaxLength = 9000;
            rtbResumen.Name = "rtbResumen";
            rtbResumen.Size = new Size(339, 125);
            rtbResumen.TabIndex = 3;
            rtbResumen.Text = "";
            rtbResumen.TextChanged += rtbResumen_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(12, 402);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 4;
            label3.Text = "Diagnostico Presuntivo:";
            // 
            // tbDiagnosticoPresuntivo
            // 
            tbDiagnosticoPresuntivo.BackColor = SystemColors.WindowText;
            tbDiagnosticoPresuntivo.BorderStyle = BorderStyle.FixedSingle;
            tbDiagnosticoPresuntivo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiagnosticoPresuntivo.ForeColor = Color.Red;
            tbDiagnosticoPresuntivo.Location = new Point(12, 423);
            tbDiagnosticoPresuntivo.MaxLength = 200;
            tbDiagnosticoPresuntivo.Name = "tbDiagnosticoPresuntivo";
            tbDiagnosticoPresuntivo.Size = new Size(339, 25);
            tbDiagnosticoPresuntivo.TabIndex = 5;
            tbDiagnosticoPresuntivo.TextChanged += tbDiagnosticoPresuntivo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(12, 457);
            label4.Name = "label4";
            label4.Size = new Size(174, 18);
            label4.TabIndex = 6;
            label4.Text = "Diagnosticos Diferenciales:";
            // 
            // rtbDxDiferenciales
            // 
            rtbDxDiferenciales.BackColor = SystemColors.WindowText;
            rtbDxDiferenciales.BorderStyle = BorderStyle.FixedSingle;
            rtbDxDiferenciales.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDxDiferenciales.ForeColor = Color.Red;
            rtbDxDiferenciales.Location = new Point(12, 478);
            rtbDxDiferenciales.MaxLength = 9000;
            rtbDxDiferenciales.Name = "rtbDxDiferenciales";
            rtbDxDiferenciales.Size = new Size(339, 109);
            rtbDxDiferenciales.TabIndex = 7;
            rtbDxDiferenciales.Text = "";
            rtbDxDiferenciales.TextChanged += rtbDxDiferenciales_TextChanged;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.WindowText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Location = new Point(253, 612);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(98, 36);
            btnContinuar.TabIndex = 9;
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
            btnAyuda.Location = new Point(276, 12);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(75, 23);
            btnAyuda.TabIndex = 10;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // rtbComplementarios
            // 
            rtbComplementarios.BackColor = SystemColors.WindowText;
            rtbComplementarios.BorderStyle = BorderStyle.FixedSingle;
            rtbComplementarios.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbComplementarios.ForeColor = Color.Red;
            rtbComplementarios.Location = new Point(12, 99);
            rtbComplementarios.MaxLength = 9000;
            rtbComplementarios.Name = "rtbComplementarios";
            rtbComplementarios.Size = new Size(339, 125);
            rtbComplementarios.TabIndex = 11;
            rtbComplementarios.Text = "";
            rtbComplementarios.TextChanged += rtbComplementarios_TextChanged;
            // 
            // ConsultaParte3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 660);
            Controls.Add(rtbComplementarios);
            Controls.Add(btnAyuda);
            Controls.Add(btnContinuar);
            Controls.Add(rtbDxDiferenciales);
            Controls.Add(label4);
            Controls.Add(tbDiagnosticoPresuntivo);
            Controls.Add(label3);
            Controls.Add(rtbResumen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "ConsultaParte3";
            Text = "ConsultaParte3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private Label label2;
        private RichTextBox rtbResumen;
        private Label label3;
        private TextBox tbDiagnosticoPresuntivo;
        private Label label4;
        private RichTextBox rtbDxDiferenciales;
        private Button btnContinuar;
        private Button btnAyuda;
        private RichTextBox rtbComplementarios;
    }
}