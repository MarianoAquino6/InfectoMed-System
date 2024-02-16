namespace InfectoMed_Forms.Paneles
{
    partial class PanelAyuda
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
            lblEnfermedad = new Label();
            cbEnfermedad = new ComboBox();
            lblEsquemaRecomendado = new Label();
            cbFarmacosDisponibles = new ComboBox();
            lblFarmacosDisponibles = new Label();
            lvEfectosAdversos = new ListView();
            EfectosAdversos = new ColumnHeader();
            lvContraindicaciones = new ListView();
            Contraindicaciones = new ColumnHeader();
            lblPosologia = new Label();
            lblEsquema = new Label();
            lblPosologiaInfo = new Label();
            SuspendLayout();
            // 
            // lblEnfermedad
            // 
            lblEnfermedad.AutoSize = true;
            lblEnfermedad.BackColor = Color.Transparent;
            lblEnfermedad.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnfermedad.ForeColor = SystemColors.Window;
            lblEnfermedad.Location = new Point(12, 29);
            lblEnfermedad.Name = "lblEnfermedad";
            lblEnfermedad.Size = new Size(88, 18);
            lblEnfermedad.TabIndex = 0;
            lblEnfermedad.Text = "Enfermedad:";
            // 
            // cbEnfermedad
            // 
            cbEnfermedad.BackColor = SystemColors.WindowText;
            cbEnfermedad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnfermedad.FlatStyle = FlatStyle.Popup;
            cbEnfermedad.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbEnfermedad.ForeColor = Color.Red;
            cbEnfermedad.FormattingEnabled = true;
            cbEnfermedad.Location = new Point(12, 50);
            cbEnfermedad.Name = "cbEnfermedad";
            cbEnfermedad.Size = new Size(316, 25);
            cbEnfermedad.TabIndex = 1;
            cbEnfermedad.SelectedIndexChanged += cbEnfermedad_SelectedIndexChanged;
            // 
            // lblEsquemaRecomendado
            // 
            lblEsquemaRecomendado.AutoSize = true;
            lblEsquemaRecomendado.BackColor = Color.Transparent;
            lblEsquemaRecomendado.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsquemaRecomendado.ForeColor = SystemColors.Window;
            lblEsquemaRecomendado.Location = new Point(12, 102);
            lblEsquemaRecomendado.Name = "lblEsquemaRecomendado";
            lblEsquemaRecomendado.Size = new Size(160, 18);
            lblEsquemaRecomendado.TabIndex = 2;
            lblEsquemaRecomendado.Text = "Esquema Recomendado:";
            // 
            // cbFarmacosDisponibles
            // 
            cbFarmacosDisponibles.BackColor = SystemColors.WindowText;
            cbFarmacosDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFarmacosDisponibles.FlatStyle = FlatStyle.Popup;
            cbFarmacosDisponibles.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFarmacosDisponibles.ForeColor = Color.Red;
            cbFarmacosDisponibles.FormattingEnabled = true;
            cbFarmacosDisponibles.Location = new Point(12, 192);
            cbFarmacosDisponibles.Name = "cbFarmacosDisponibles";
            cbFarmacosDisponibles.Size = new Size(214, 25);
            cbFarmacosDisponibles.TabIndex = 3;
            cbFarmacosDisponibles.SelectedIndexChanged += cbFarmacosDisponibles_SelectedIndexChanged;
            // 
            // lblFarmacosDisponibles
            // 
            lblFarmacosDisponibles.AutoSize = true;
            lblFarmacosDisponibles.BackColor = Color.Transparent;
            lblFarmacosDisponibles.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFarmacosDisponibles.ForeColor = SystemColors.Window;
            lblFarmacosDisponibles.Location = new Point(12, 171);
            lblFarmacosDisponibles.Name = "lblFarmacosDisponibles";
            lblFarmacosDisponibles.Size = new Size(146, 18);
            lblFarmacosDisponibles.TabIndex = 5;
            lblFarmacosDisponibles.Text = "Farmacos Disponibles:";
            // 
            // lvEfectosAdversos
            // 
            lvEfectosAdversos.BackColor = SystemColors.WindowText;
            lvEfectosAdversos.BorderStyle = BorderStyle.FixedSingle;
            lvEfectosAdversos.Columns.AddRange(new ColumnHeader[] { EfectosAdversos });
            lvEfectosAdversos.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvEfectosAdversos.ForeColor = Color.Red;
            lvEfectosAdversos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvEfectosAdversos.HideSelection = true;
            lvEfectosAdversos.Location = new Point(12, 234);
            lvEfectosAdversos.MultiSelect = false;
            lvEfectosAdversos.Name = "lvEfectosAdversos";
            lvEfectosAdversos.Size = new Size(214, 206);
            lvEfectosAdversos.TabIndex = 6;
            lvEfectosAdversos.UseCompatibleStateImageBehavior = false;
            lvEfectosAdversos.View = View.Details;
            // 
            // EfectosAdversos
            // 
            EfectosAdversos.Text = "Efectos Adversos";
            EfectosAdversos.Width = 210;
            // 
            // lvContraindicaciones
            // 
            lvContraindicaciones.BackColor = SystemColors.WindowText;
            lvContraindicaciones.BorderStyle = BorderStyle.FixedSingle;
            lvContraindicaciones.Columns.AddRange(new ColumnHeader[] { Contraindicaciones });
            lvContraindicaciones.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lvContraindicaciones.ForeColor = Color.Red;
            lvContraindicaciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvContraindicaciones.HideSelection = true;
            lvContraindicaciones.Location = new Point(247, 234);
            lvContraindicaciones.MultiSelect = false;
            lvContraindicaciones.Name = "lvContraindicaciones";
            lvContraindicaciones.Size = new Size(262, 206);
            lvContraindicaciones.TabIndex = 7;
            lvContraindicaciones.UseCompatibleStateImageBehavior = false;
            lvContraindicaciones.View = View.Details;
            // 
            // Contraindicaciones
            // 
            Contraindicaciones.Text = "Contraindicaciones";
            Contraindicaciones.Width = 260;
            // 
            // lblPosologia
            // 
            lblPosologia.AutoSize = true;
            lblPosologia.BackColor = Color.Transparent;
            lblPosologia.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosologia.ForeColor = SystemColors.Window;
            lblPosologia.Location = new Point(12, 466);
            lblPosologia.Name = "lblPosologia";
            lblPosologia.Size = new Size(72, 18);
            lblPosologia.TabIndex = 8;
            lblPosologia.Text = "Posologia:";
            // 
            // lblEsquema
            // 
            lblEsquema.AutoSize = true;
            lblEsquema.BackColor = Color.Transparent;
            lblEsquema.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsquema.ForeColor = SystemColors.Window;
            lblEsquema.Location = new Point(12, 127);
            lblEsquema.Name = "lblEsquema";
            lblEsquema.Size = new Size(69, 18);
            lblEsquema.TabIndex = 4;
            lblEsquema.Text = "ESQUEMA";
            // 
            // lblPosologiaInfo
            // 
            lblPosologiaInfo.AutoSize = true;
            lblPosologiaInfo.BackColor = Color.Transparent;
            lblPosologiaInfo.Font = new Font("Calibri", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosologiaInfo.ForeColor = SystemColors.Window;
            lblPosologiaInfo.Location = new Point(90, 466);
            lblPosologiaInfo.Name = "lblPosologiaInfo";
            lblPosologiaInfo.Size = new Size(81, 18);
            lblPosologiaInfo.TabIndex = 9;
            lblPosologiaInfo.Text = "POSOLOGIA";
            // 
            // PanelAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 506);
            Controls.Add(lblPosologiaInfo);
            Controls.Add(lblPosologia);
            Controls.Add(lvContraindicaciones);
            Controls.Add(lvEfectosAdversos);
            Controls.Add(lblFarmacosDisponibles);
            Controls.Add(lblEsquema);
            Controls.Add(cbFarmacosDisponibles);
            Controls.Add(lblEsquemaRecomendado);
            Controls.Add(cbEnfermedad);
            Controls.Add(lblEnfermedad);
            Name = "PanelAyuda";
            Text = "PanelAyuda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnfermedad;
        private ComboBox cbEnfermedad;
        private Label lblEsquemaRecomendado;
        private ComboBox cbFarmacosDisponibles;
        private Label lblFarmacosDisponibles;
        private ListView lvEfectosAdversos;
        private ListView lvContraindicaciones;
        private Label lblPosologia;
        private Label lblEsquema;
        private Label lblPosologiaInfo;
        private ColumnHeader EfectosAdversos;
        private ColumnHeader Contraindicaciones;
    }
}