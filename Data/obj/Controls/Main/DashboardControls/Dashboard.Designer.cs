namespace Tischprojekt.Data.obj.Userctrl
{
    partial class Dashboard
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAktiveAuftraege = new System.Windows.Forms.DataGridView();
            this.buttonBestellen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAngenommeAuftraege = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRetoure = new System.Windows.Forms.Button();
            this.buttonAuftragsAbschluss = new System.Windows.Forms.Button();
            this.buttonAutragsannahme = new System.Windows.Forms.Button();
            this.buttonWareneingang = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewAktiveBestellungen = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewLager = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.labelNoDbConnection = new System.Windows.Forms.Label();
            this.labelDBConnectionOK = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktiveAuftraege)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngenommeAuftraege)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktiveBestellungen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.dataGridViewAktiveAuftraege);
            this.panel6.Location = new System.Drawing.Point(13, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(842, 150);
            this.panel6.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(352, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aktive Aufträge";
            // 
            // dataGridViewAktiveAuftraege
            // 
            this.dataGridViewAktiveAuftraege.AllowUserToAddRows = false;
            this.dataGridViewAktiveAuftraege.AllowUserToDeleteRows = false;
            this.dataGridViewAktiveAuftraege.AllowUserToResizeColumns = false;
            this.dataGridViewAktiveAuftraege.AllowUserToResizeRows = false;
            this.dataGridViewAktiveAuftraege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAktiveAuftraege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAktiveAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktiveAuftraege.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewAktiveAuftraege.Name = "dataGridViewAktiveAuftraege";
            this.dataGridViewAktiveAuftraege.ReadOnly = true;
            this.dataGridViewAktiveAuftraege.Size = new System.Drawing.Size(836, 100);
            this.dataGridViewAktiveAuftraege.TabIndex = 0;
            this.dataGridViewAktiveAuftraege.DataSourceChanged += new System.EventHandler(this.dataGridViewAktiveAuftraege_DataSourceChanged);
            // 
            // buttonBestellen
            // 
            this.buttonBestellen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestellen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestellen.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBestellen.Location = new System.Drawing.Point(1184, 328);
            this.buttonBestellen.Name = "buttonBestellen";
            this.buttonBestellen.Size = new System.Drawing.Size(304, 54);
            this.buttonBestellen.TabIndex = 28;
            this.buttonBestellen.Text = "Bestellen";
            this.buttonBestellen.UseVisualStyleBackColor = true;
            this.buttonBestellen.Click += new System.EventHandler(this.buttonBestellen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewAngenommeAuftraege);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(13, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 270);
            this.panel1.TabIndex = 31;
            // 
            // dataGridViewAngenommeAuftraege
            // 
            this.dataGridViewAngenommeAuftraege.AllowUserToAddRows = false;
            this.dataGridViewAngenommeAuftraege.AllowUserToDeleteRows = false;
            this.dataGridViewAngenommeAuftraege.AllowUserToResizeColumns = false;
            this.dataGridViewAngenommeAuftraege.AllowUserToResizeRows = false;
            this.dataGridViewAngenommeAuftraege.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAngenommeAuftraege.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAngenommeAuftraege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAngenommeAuftraege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAngenommeAuftraege.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAngenommeAuftraege.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewAngenommeAuftraege.Name = "dataGridViewAngenommeAuftraege";
            this.dataGridViewAngenommeAuftraege.ReadOnly = true;
            this.dataGridViewAngenommeAuftraege.Size = new System.Drawing.Size(836, 226);
            this.dataGridViewAngenommeAuftraege.TabIndex = 34;
            this.dataGridViewAngenommeAuftraege.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAngenommeAuftraege_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(672, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Doppelclick Aktiviert Auftrag!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(317, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Angenommene Aufträge";
            // 
            // btnRetoure
            // 
            this.btnRetoure.FlatAppearance.BorderSize = 2;
            this.btnRetoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetoure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetoure.ForeColor = System.Drawing.Color.Brown;
            this.btnRetoure.Location = new System.Drawing.Point(1494, 358);
            this.btnRetoure.Name = "btnRetoure";
            this.btnRetoure.Size = new System.Drawing.Size(199, 54);
            this.btnRetoure.TabIndex = 27;
            this.btnRetoure.Text = "RETOURE";
            this.btnRetoure.UseVisualStyleBackColor = true;
            this.btnRetoure.Click += new System.EventHandler(this.btnRetoure_Click);
            // 
            // buttonAuftragsAbschluss
            // 
            this.buttonAuftragsAbschluss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuftragsAbschluss.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuftragsAbschluss.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAuftragsAbschluss.Location = new System.Drawing.Point(1184, 388);
            this.buttonAuftragsAbschluss.Name = "buttonAuftragsAbschluss";
            this.buttonAuftragsAbschluss.Size = new System.Drawing.Size(304, 54);
            this.buttonAuftragsAbschluss.TabIndex = 30;
            this.buttonAuftragsAbschluss.Text = "Auftragsabschluss";
            this.buttonAuftragsAbschluss.UseVisualStyleBackColor = true;
            this.buttonAuftragsAbschluss.Click += new System.EventHandler(this.buttonAuftragsAbschluss_Click);
            // 
            // buttonAutragsannahme
            // 
            this.buttonAutragsannahme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutragsannahme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutragsannahme.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAutragsannahme.Location = new System.Drawing.Point(875, 328);
            this.buttonAutragsannahme.Name = "buttonAutragsannahme";
            this.buttonAutragsannahme.Size = new System.Drawing.Size(303, 54);
            this.buttonAutragsannahme.TabIndex = 24;
            this.buttonAutragsannahme.Text = "Auftragsannahme";
            this.buttonAutragsannahme.UseVisualStyleBackColor = true;
            this.buttonAutragsannahme.Click += new System.EventHandler(this.buttonAutragsannahme_Click);
            // 
            // buttonWareneingang
            // 
            this.buttonWareneingang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWareneingang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWareneingang.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonWareneingang.Location = new System.Drawing.Point(875, 388);
            this.buttonWareneingang.Name = "buttonWareneingang";
            this.buttonWareneingang.Size = new System.Drawing.Size(303, 54);
            this.buttonWareneingang.TabIndex = 29;
            this.buttonWareneingang.Text = "Wareneingang";
            this.buttonWareneingang.UseVisualStyleBackColor = true;
            this.buttonWareneingang.Click += new System.EventHandler(this.buttonWareneingang_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.DarkGray;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Location = new System.Drawing.Point(13, 475);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1688, 525);
            this.panelContainer.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewAktiveBestellungen);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(1276, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 304);
            this.panel3.TabIndex = 25;
            // 
            // dataGridViewAktiveBestellungen
            // 
            this.dataGridViewAktiveBestellungen.AllowUserToAddRows = false;
            this.dataGridViewAktiveBestellungen.AllowUserToDeleteRows = false;
            this.dataGridViewAktiveBestellungen.AllowUserToResizeColumns = false;
            this.dataGridViewAktiveBestellungen.AllowUserToResizeRows = false;
            this.dataGridViewAktiveBestellungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAktiveBestellungen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAktiveBestellungen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAktiveBestellungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAktiveBestellungen.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAktiveBestellungen.Location = new System.Drawing.Point(-1, 40);
            this.dataGridViewAktiveBestellungen.Name = "dataGridViewAktiveBestellungen";
            this.dataGridViewAktiveBestellungen.ReadOnly = true;
            this.dataGridViewAktiveBestellungen.Size = new System.Drawing.Size(351, 262);
            this.dataGridViewAktiveBestellungen.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(70, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 30);
            this.label15.TabIndex = 9;
            this.label15.Text = "Aktive Bestellungen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewLager);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(875, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 304);
            this.panel2.TabIndex = 23;
            // 
            // dataGridViewLager
            // 
            this.dataGridViewLager.AllowUserToAddRows = false;
            this.dataGridViewLager.AllowUserToDeleteRows = false;
            this.dataGridViewLager.AllowUserToResizeColumns = false;
            this.dataGridViewLager.AllowUserToResizeRows = false;
            this.dataGridViewLager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLager.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewLager.Location = new System.Drawing.Point(2, 40);
            this.dataGridViewLager.Name = "dataGridViewLager";
            this.dataGridViewLager.ReadOnly = true;
            this.dataGridViewLager.Size = new System.Drawing.Size(392, 262);
            this.dataGridViewLager.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(120, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 30);
            this.label12.TabIndex = 9;
            this.label12.Text = "Lagerbestand";
            // 
            // labelNoDbConnection
            // 
            this.labelNoDbConnection.AutoSize = true;
            this.labelNoDbConnection.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDbConnection.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoDbConnection.Location = new System.Drawing.Point(186, 442);
            this.labelNoDbConnection.Name = "labelNoDbConnection";
            this.labelNoDbConnection.Size = new System.Drawing.Size(401, 32);
            this.labelNoDbConnection.TabIndex = 32;
            this.labelNoDbConnection.Text = "KEINE DATENBANK VERBINDUNG";
            this.labelNoDbConnection.Visible = false;
            // 
            // labelDBConnectionOK
            // 
            this.labelDBConnectionOK.AutoSize = true;
            this.labelDBConnectionOK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDBConnectionOK.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelDBConnectionOK.Location = new System.Drawing.Point(10, 442);
            this.labelDBConnectionOK.Name = "labelDBConnectionOK";
            this.labelDBConnectionOK.Size = new System.Drawing.Size(181, 32);
            this.labelDBConnectionOK.TabIndex = 33;
            this.labelDBConnectionOK.Text = "Datenbank ok!";
            this.labelDBConnectionOK.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tischprojekt.Properties.Resources.icons8_aktualisieren_25;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1674, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDBConnectionOK);
            this.Controls.Add(this.labelNoDbConnection);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonBestellen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetoure);
            this.Controls.Add(this.buttonAuftragsAbschluss);
            this.Controls.Add(this.buttonAutragsannahme);
            this.Controls.Add(this.buttonWareneingang);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1722, 1005);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktiveAuftraege)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngenommeAuftraege)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktiveBestellungen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAktiveAuftraege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRetoure;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label labelNoDbConnection;
        public System.Windows.Forms.Label labelDBConnectionOK;
        private System.Windows.Forms.DataGridView dataGridViewAngenommeAuftraege;
        private System.Windows.Forms.DataGridView dataGridViewLager;
        private System.Windows.Forms.DataGridView dataGridViewAktiveBestellungen;
        public System.Windows.Forms.Button buttonBestellen;
        public System.Windows.Forms.Button buttonAuftragsAbschluss;
        public System.Windows.Forms.Button buttonAutragsannahme;
        public System.Windows.Forms.Button buttonWareneingang;
        public System.Windows.Forms.Button button1;
    }
}
