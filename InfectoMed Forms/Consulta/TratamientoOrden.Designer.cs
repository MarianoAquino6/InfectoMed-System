namespace InfectoMed_Forms
{
    partial class TratamientoOrden
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
            btnAyuda = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblDiagnostico = new Label();
            lblFecha = new Label();
            lblFirma = new Label();
            rtbRecetaOrden = new RichTextBox();
            lblNumSocio = new Label();
            lblObraPlan = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            label8 = new Label();
            rtbAclaraciones = new RichTextBox();
            btnTerminar = new Button();
            groupBox1.SuspendLayout();
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
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.DarkRed;
            btnAyuda.FlatStyle = FlatStyle.Popup;
            btnAyuda.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyuda.ForeColor = SystemColors.Window;
            btnAyuda.Location = new Point(522, 12);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(75, 23);
            btnAyuda.TabIndex = 1;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(325, 26);
            label1.TabIndex = 2;
            label1.Text = "Escriba su RECETA u ORDEN medica:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(lblDiagnostico);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblFirma);
            groupBox1.Controls.Add(rtbRecetaOrden);
            groupBox1.Controls.Add(lblNumSocio);
            groupBox1.Controls.Add(lblObraPlan);
            groupBox1.Controls.Add(lblDNI);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 427);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(228, 390);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(84, 15);
            lblDiagnostico.TabIndex = 7;
            lblDiagnostico.Text = "DIAGNOSTICO";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(16, 388);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "FECHA";
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(451, 377);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(42, 15);
            lblFirma.TabIndex = 5;
            lblFirma.Text = "FIRMA";
            // 
            // rtbRecetaOrden
            // 
            rtbRecetaOrden.BackColor = SystemColors.Window;
            rtbRecetaOrden.BorderStyle = BorderStyle.FixedSingle;
            rtbRecetaOrden.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbRecetaOrden.ForeColor = SystemColors.WindowText;
            rtbRecetaOrden.Location = new Point(16, 162);
            rtbRecetaOrden.MaxLength = 9000;
            rtbRecetaOrden.Name = "rtbRecetaOrden";
            rtbRecetaOrden.Size = new Size(548, 202);
            rtbRecetaOrden.TabIndex = 4;
            rtbRecetaOrden.Text = "";
            rtbRecetaOrden.TextChanged += rtbRecetaOrden_TextChanged;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(16, 127);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(59, 15);
            lblNumSocio.TabIndex = 3;
            lblNumSocio.Text = "N° SOCIO";
            // 
            // lblObraPlan
            // 
            lblObraPlan.AutoSize = true;
            lblObraPlan.Location = new Point(16, 97);
            lblObraPlan.Name = "lblObraPlan";
            lblObraPlan.Size = new Size(124, 15);
            lblObraPlan.TabIndex = 2;
            lblObraPlan.Text = "OBRA SOCIAL Y PLAN";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(16, 66);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(12, 554);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 4;
            label8.Text = "Aclaraciones:";
            // 
            // rtbAclaraciones
            // 
            rtbAclaraciones.BackColor = SystemColors.WindowText;
            rtbAclaraciones.BorderStyle = BorderStyle.FixedSingle;
            rtbAclaraciones.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbAclaraciones.ForeColor = Color.Red;
            rtbAclaraciones.Location = new Point(12, 575);
            rtbAclaraciones.MaxLength = 9000;
            rtbAclaraciones.Name = "rtbAclaraciones";
            rtbAclaraciones.Size = new Size(322, 77);
            rtbAclaraciones.TabIndex = 5;
            rtbAclaraciones.Text = "";
            rtbAclaraciones.TextChanged += rtbAclaraciones_TextChanged;
            // 
            // btnTerminar
            // 
            btnTerminar.BackColor = SystemColors.WindowText;
            btnTerminar.FlatStyle = FlatStyle.Popup;
            btnTerminar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTerminar.ForeColor = SystemColors.Window;
            btnTerminar.Location = new Point(503, 613);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(98, 39);
            btnTerminar.TabIndex = 6;
            btnTerminar.Text = "Terminar";
            btnTerminar.UseVisualStyleBackColor = false;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // TratamientoOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 666);
            Controls.Add(btnTerminar);
            Controls.Add(rtbAclaraciones);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAyuda);
            Controls.Add(btnAtras);
            Name = "TratamientoOrden";
            Text = "Tratamiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Button btnAyuda;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblFirma;
        private RichTextBox rtbRecetaOrden;
        private Label lblNumSocio;
        private Label lblObraPlan;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblFecha;
        private Label label8;
        private RichTextBox rtbAclaraciones;
        private Button btnTerminar;
        private Label lblDiagnostico;
    }
}