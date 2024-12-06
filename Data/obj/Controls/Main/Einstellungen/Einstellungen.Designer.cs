namespace Tischprojekt.Data.obj.Userctrl.Main.Einstellungen
{
    partial class Einstellungen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCLSdb = new System.Windows.Forms.Button();
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.buttonSaveAndTest = new System.Windows.Forms.Button();
            this.textBoxDbPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewFarben = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewMengen = new System.Windows.Forms.DataGridView();
            this.dataGridViewFormen = new System.Windows.Forms.DataGridView();
            this.buttonSaveFarben = new System.Windows.Forms.Button();
            this.buttonSaveMengen = new System.Windows.Forms.Button();
            this.buttonSaveFormen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Farben = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mengen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFarben)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMengen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormen)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.Control;
            label6.Location = new System.Drawing.Point(13, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(247, 30);
            label6.TabIndex = 10;
            label6.Text = "SQLite Datenbank Pfad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCLSdb);
            this.panel1.Controls.Add(this.buttonOpenDB);
            this.panel1.Controls.Add(this.buttonSaveAndTest);
            this.panel1.Controls.Add(this.textBoxDbPath);
            this.panel1.Controls.Add(label6);
            this.panel1.Location = new System.Drawing.Point(46, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 146);
            this.panel1.TabIndex = 0;
            // 
            // buttonCLSdb
            // 
            this.buttonCLSdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCLSdb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCLSdb.ForeColor = System.Drawing.Color.Crimson;
            this.buttonCLSdb.Location = new System.Drawing.Point(683, 96);
            this.buttonCLSdb.Name = "buttonCLSdb";
            this.buttonCLSdb.Size = new System.Drawing.Size(144, 39);
            this.buttonCLSdb.TabIndex = 30;
            this.buttonCLSdb.Text = "cls";
            this.buttonCLSdb.UseVisualStyleBackColor = true;
            this.buttonCLSdb.Click += new System.EventHandler(this.buttonCLSdb_Click);
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.FlatAppearance.BorderSize = 0;
            this.buttonOpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenDB.ForeColor = System.Drawing.Color.Transparent;
            this.buttonOpenDB.Image = global::Tischprojekt.Properties.Resources.icons8_ordner_öffnen_39;
            this.buttonOpenDB.Location = new System.Drawing.Point(786, 12);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(41, 39);
            this.buttonOpenDB.TabIndex = 30;
            this.buttonOpenDB.UseVisualStyleBackColor = true;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // buttonSaveAndTest
            // 
            this.buttonSaveAndTest.Enabled = false;
            this.buttonSaveAndTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAndTest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAndTest.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonSaveAndTest.Location = new System.Drawing.Point(345, 96);
            this.buttonSaveAndTest.Name = "buttonSaveAndTest";
            this.buttonSaveAndTest.Size = new System.Drawing.Size(144, 39);
            this.buttonSaveAndTest.TabIndex = 29;
            this.buttonSaveAndTest.Text = "Übernehmen";
            this.buttonSaveAndTest.UseVisualStyleBackColor = true;
            this.buttonSaveAndTest.Click += new System.EventHandler(this.buttonSaveAndTest_Click);
            // 
            // textBoxDbPath
            // 
            this.textBoxDbPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDbPath.Location = new System.Drawing.Point(18, 63);
            this.textBoxDbPath.Name = "textBoxDbPath";
            this.textBoxDbPath.Size = new System.Drawing.Size(809, 27);
            this.textBoxDbPath.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewFarben
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFarben.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFarben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFarben.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Farben});
            this.dataGridViewFarben.Location = new System.Drawing.Point(57, 173);
            this.dataGridViewFarben.Name = "dataGridViewFarben";
            this.dataGridViewFarben.RowHeadersVisible = false;
            this.dataGridViewFarben.Size = new System.Drawing.Size(267, 214);
            this.dataGridViewFarben.TabIndex = 1;
            this.dataGridViewFarben.Tag = "Farben";
            this.dataGridViewFarben.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFarben_CellValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(587, 65);
            this.label14.TabIndex = 13;
            this.label14.Text = "Programm Einstellungen";
            // 
            // dataGridViewMengen
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMengen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMengen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMengen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mengen});
            this.dataGridViewMengen.Location = new System.Drawing.Point(381, 173);
            this.dataGridViewMengen.Name = "dataGridViewMengen";
            this.dataGridViewMengen.RowHeadersVisible = false;
            this.dataGridViewMengen.Size = new System.Drawing.Size(267, 214);
            this.dataGridViewMengen.TabIndex = 14;
            this.dataGridViewMengen.Tag = "Mengen";
            this.dataGridViewMengen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMengen_CellValueChanged);
            // 
            // dataGridViewFormen
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFormen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFormen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Formen});
            this.dataGridViewFormen.Location = new System.Drawing.Point(709, 173);
            this.dataGridViewFormen.Name = "dataGridViewFormen";
            this.dataGridViewFormen.RowHeadersVisible = false;
            this.dataGridViewFormen.Size = new System.Drawing.Size(267, 214);
            this.dataGridViewFormen.TabIndex = 15;
            this.dataGridViewFormen.Tag = "Formen";
            this.dataGridViewFormen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormen_CellValueChanged);
            // 
            // buttonSaveFarben
            // 
            this.buttonSaveFarben.Enabled = false;
            this.buttonSaveFarben.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFarben.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFarben.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonSaveFarben.Location = new System.Drawing.Point(115, 402);
            this.buttonSaveFarben.Name = "buttonSaveFarben";
            this.buttonSaveFarben.Size = new System.Drawing.Size(144, 39);
            this.buttonSaveFarben.TabIndex = 30;
            this.buttonSaveFarben.Text = "Speichern";
            this.buttonSaveFarben.UseVisualStyleBackColor = true;
            this.buttonSaveFarben.Click += new System.EventHandler(this.buttonSaveFarben_Click);
            // 
            // buttonSaveMengen
            // 
            this.buttonSaveMengen.Enabled = false;
            this.buttonSaveMengen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveMengen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveMengen.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonSaveMengen.Location = new System.Drawing.Point(440, 402);
            this.buttonSaveMengen.Name = "buttonSaveMengen";
            this.buttonSaveMengen.Size = new System.Drawing.Size(144, 39);
            this.buttonSaveMengen.TabIndex = 31;
            this.buttonSaveMengen.Text = "Speichern";
            this.buttonSaveMengen.UseVisualStyleBackColor = true;
            this.buttonSaveMengen.Click += new System.EventHandler(this.buttonSaveMengen_Click);
            // 
            // buttonSaveFormen
            // 
            this.buttonSaveFormen.Enabled = false;
            this.buttonSaveFormen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFormen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFormen.ForeColor = System.Drawing.Color.OliveDrab;
            this.buttonSaveFormen.Location = new System.Drawing.Point(775, 402);
            this.buttonSaveFormen.Name = "buttonSaveFormen";
            this.buttonSaveFormen.Size = new System.Drawing.Size(144, 39);
            this.buttonSaveFormen.TabIndex = 32;
            this.buttonSaveFormen.Text = "Speichern";
            this.buttonSaveFormen.UseVisualStyleBackColor = true;
            this.buttonSaveFormen.Click += new System.EventHandler(this.buttonSaveFormen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 65);
            this.label1.TabIndex = 33;
            this.label1.Text = "Datenbank Einstellungen";
            // 
            // Farben
            // 
            this.Farben.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Farben.HeaderText = "Farben";
            this.Farben.Name = "Farben";
            // 
            // Formen
            // 
            this.Formen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formen.HeaderText = "Formen";
            this.Formen.Name = "Formen";
            // 
            // Mengen
            // 
            this.Mengen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mengen.HeaderText = "Mengen";
            this.Mengen.Name = "Mengen";
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveFormen);
            this.Controls.Add(this.buttonSaveMengen);
            this.Controls.Add(this.buttonSaveFarben);
            this.Controls.Add(this.dataGridViewFormen);
            this.Controls.Add(this.dataGridViewMengen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridViewFarben);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Einstellungen";
            this.Size = new System.Drawing.Size(1722, 1041);
            this.Tag = "1";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFarben)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMengen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDbPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonSaveAndTest;
        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.Button buttonCLSdb;
        private System.Windows.Forms.DataGridView dataGridViewFarben;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewMengen;
        private System.Windows.Forms.DataGridView dataGridViewFormen;
        private System.Windows.Forms.Button buttonSaveFarben;
        private System.Windows.Forms.Button buttonSaveMengen;
        private System.Windows.Forms.Button buttonSaveFormen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Farben;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mengen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formen;
    }
}
