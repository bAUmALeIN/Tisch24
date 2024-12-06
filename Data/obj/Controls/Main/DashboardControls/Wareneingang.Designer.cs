namespace Tischprojekt.Data.obj.Userctrl
{
    partial class Wareneingang
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
            this.panelWareneingang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxArtikel1Menge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxArtikel2 = new System.Windows.Forms.CheckBox();
            this.comboBoxArtikel1Farbe = new System.Windows.Forms.ComboBox();
            this.comboBoxArtikel2Menge = new System.Windows.Forms.ComboBox();
            this.comboBoxArtikel2Farbe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBUCHEN = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panelWareneingang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWareneingang
            // 
            this.panelWareneingang.Controls.Add(this.label2);
            this.panelWareneingang.Controls.Add(this.label1);
            this.panelWareneingang.Controls.Add(this.comboBoxArtikel1Menge);
            this.panelWareneingang.Controls.Add(this.label3);
            this.panelWareneingang.Controls.Add(this.checkBoxArtikel2);
            this.panelWareneingang.Controls.Add(this.comboBoxArtikel1Farbe);
            this.panelWareneingang.Controls.Add(this.comboBoxArtikel2Menge);
            this.panelWareneingang.Controls.Add(this.comboBoxArtikel2Farbe);
            this.panelWareneingang.Controls.Add(this.label5);
            this.panelWareneingang.Controls.Add(this.label7);
            this.panelWareneingang.Controls.Add(this.label4);
            this.panelWareneingang.Controls.Add(this.buttonBUCHEN);
            this.panelWareneingang.Controls.Add(this.label14);
            this.panelWareneingang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWareneingang.Location = new System.Drawing.Point(0, 0);
            this.panelWareneingang.Name = "panelWareneingang";
            this.panelWareneingang.Size = new System.Drawing.Size(1683, 535);
            this.panelWareneingang.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Farbe:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Farbe:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxArtikel1Menge
            // 
            this.comboBoxArtikel1Menge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel1Menge.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel1Menge.FormattingEnabled = true;
            this.comboBoxArtikel1Menge.Location = new System.Drawing.Point(902, 139);
            this.comboBoxArtikel1Menge.Name = "comboBoxArtikel1Menge";
            this.comboBoxArtikel1Menge.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel1Menge.TabIndex = 19;
            this.comboBoxArtikel1Menge.Tag = "Menge";
            this.comboBoxArtikel1Menge.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Menge:";
            // 
            // checkBoxArtikel2
            // 
            this.checkBoxArtikel2.AutoSize = true;
            this.checkBoxArtikel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArtikel2.Location = new System.Drawing.Point(539, 254);
            this.checkBoxArtikel2.Name = "checkBoxArtikel2";
            this.checkBoxArtikel2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxArtikel2.TabIndex = 23;
            this.checkBoxArtikel2.UseVisualStyleBackColor = true;
            this.checkBoxArtikel2.CheckedChanged += new System.EventHandler(this.checkBoxArtikel2_CheckedChanged);
            // 
            // comboBoxArtikel1Farbe
            // 
            this.comboBoxArtikel1Farbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel1Farbe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel1Farbe.FormattingEnabled = true;
            this.comboBoxArtikel1Farbe.Location = new System.Drawing.Point(527, 139);
            this.comboBoxArtikel1Farbe.Name = "comboBoxArtikel1Farbe";
            this.comboBoxArtikel1Farbe.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel1Farbe.TabIndex = 18;
            this.comboBoxArtikel1Farbe.Tag = "Farbe";
            // 
            // comboBoxArtikel2Menge
            // 
            this.comboBoxArtikel2Menge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel2Menge.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel2Menge.FormattingEnabled = true;
            this.comboBoxArtikel2Menge.Location = new System.Drawing.Point(901, 308);
            this.comboBoxArtikel2Menge.Name = "comboBoxArtikel2Menge";
            this.comboBoxArtikel2Menge.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel2Menge.TabIndex = 19;
            this.comboBoxArtikel2Menge.Tag = "Menge";
            this.comboBoxArtikel2Menge.Text = "5";
            this.comboBoxArtikel2Menge.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtikel2Menge_SelectedIndexChanged);
            // 
            // comboBoxArtikel2Farbe
            // 
            this.comboBoxArtikel2Farbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel2Farbe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel2Farbe.FormattingEnabled = true;
            this.comboBoxArtikel2Farbe.Location = new System.Drawing.Point(527, 308);
            this.comboBoxArtikel2Farbe.Name = "comboBoxArtikel2Farbe";
            this.comboBoxArtikel2Farbe.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel2Farbe.TabIndex = 18;
            this.comboBoxArtikel2Farbe.Tag = "Farbe";
            this.comboBoxArtikel2Farbe.SelectedIndexChanged += new System.EventHandler(this.comboBoxArtikel2Farbe_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(434, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Artikel 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(782, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "Menge:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(434, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Artikel 1";
            // 
            // buttonBUCHEN
            // 
            this.buttonBUCHEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBUCHEN.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBUCHEN.Location = new System.Drawing.Point(636, 378);
            this.buttonBUCHEN.Name = "buttonBUCHEN";
            this.buttonBUCHEN.Size = new System.Drawing.Size(390, 112);
            this.buttonBUCHEN.TabIndex = 13;
            this.buttonBUCHEN.Text = "BUCHEN";
            this.buttonBUCHEN.UseVisualStyleBackColor = true;
            this.buttonBUCHEN.Click += new System.EventHandler(this.buttonBUCHEN_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(647, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(358, 65);
            this.label14.TabIndex = 12;
            this.label14.Text = "Wareneingang";
            // 
            // Wareneingang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWareneingang);
            this.Name = "Wareneingang";
            this.Size = new System.Drawing.Size(1683, 535);
            this.panelWareneingang.ResumeLayout(false);
            this.panelWareneingang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWareneingang;
        private System.Windows.Forms.Button buttonBUCHEN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxArtikel1Menge;
        private System.Windows.Forms.ComboBox comboBoxArtikel1Farbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxArtikel2Menge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArtikel2Farbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxArtikel2;
    }
}
