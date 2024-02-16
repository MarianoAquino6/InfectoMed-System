namespace InfectoMed_Forms
{
    partial class PanelPaciente
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
            lvConsultas = new ListView();
            Fecha = new ColumnHeader();
            MotivoConsulta = new ColumnHeader();
            btnVer = new Button();
            btnNuevaConsulta = new Button();
            btnEditar = new Button();
            lblNombre = new Label();
            lblDNI = new Label();
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
            label1.Font = new Font("Calibri", 15.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(193, 26);
            label1.TabIndex = 1;
            label1.Text = "CONSULTAS PREVIAS";
            // 
            // lvConsultas
            // 
            lvConsultas.BackColor = SystemColors.WindowText;
            lvConsultas.BorderStyle = BorderStyle.FixedSingle;
            lvConsultas.Columns.AddRange(new ColumnHeader[] { Fecha, MotivoConsulta });
            lvConsultas.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvConsultas.ForeColor = Color.Red;
            lvConsultas.FullRowSelect = true;
            lvConsultas.Location = new Point(12, 103);
            lvConsultas.MultiSelect = false;
            lvConsultas.Name = "lvConsultas";
            lvConsultas.Size = new Size(408, 245);
            lvConsultas.TabIndex = 2;
            lvConsultas.UseCompatibleStateImageBehavior = false;
            lvConsultas.View = View.Details;
            lvConsultas.SelectedIndexChanged += lvConsultas_SelectedIndexChanged;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 100;
            // 
            // MotivoConsulta
            // 
            MotivoConsulta.Text = "Motivo de Consulta";
            MotivoConsulta.TextAlign = HorizontalAlignment.Center;
            MotivoConsulta.Width = 300;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.WindowText;
            btnVer.FlatStyle = FlatStyle.Popup;
            btnVer.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.Window;
            btnVer.Location = new Point(12, 373);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(103, 32);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver Consulta";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnNuevaConsulta
            // 
            btnNuevaConsulta.BackColor = SystemColors.WindowText;
            btnNuevaConsulta.FlatStyle = FlatStyle.Popup;
            btnNuevaConsulta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevaConsulta.ForeColor = SystemColors.Window;
            btnNuevaConsulta.Location = new Point(311, 372);
            btnNuevaConsulta.Name = "btnNuevaConsulta";
            btnNuevaConsulta.Size = new Size(112, 35);
            btnNuevaConsulta.TabIndex = 4;
            btnNuevaConsulta.Text = "Nueva Consulta";
            btnNuevaConsulta.UseVisualStyleBackColor = false;
            btnNuevaConsulta.Click += btnNuevaConsulta_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.WindowText;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Window;
            btnEditar.Location = new Point(162, 373);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 32);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Consulta";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.Window;
            lblNombre.Location = new Point(270, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(63, 18);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "NOMBRE";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = SystemColors.Window;
            lblDNI.Location = new Point(270, 33);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(31, 18);
            lblDNI.TabIndex = 7;
            lblDNI.Text = "DNI";
            // 
            // PanelPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 420);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevaConsulta);
            Controls.Add(btnVer);
            Controls.Add(lvConsultas);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Name = "PanelPaciente";
            Text = "PanelPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private Label label1;
        private ListView lvConsultas;
        private Button btnVer;
        private Button btnNuevaConsulta;
        private Button btnEditar;
        private ColumnHeader Fecha;
        private ColumnHeader MotivoConsulta;
        private Label lblNombre;
        private Label lblDNI;
    }
}