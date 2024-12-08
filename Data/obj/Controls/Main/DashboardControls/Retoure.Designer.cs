namespace Tischprojekt.Data.obj.Controls.Main.DashboardControls
{
    partial class Retoure
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAuftragRetoureBuchen = new System.Windows.Forms.Button();
            this.comboBoxAuftragsNr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFarbe = new System.Windows.Forms.TextBox();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.textBoxFom = new System.Windows.Forms.TextBox();
            this.textBoxAuftragsAnfang = new System.Windows.Forms.TextBox();
            this.richTextBoxBemerkung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAuftragsEnde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStrafsekunden = new System.Windows.Forms.TextBox();
            this.labelZusatzMaterialFarbeTEXT = new System.Windows.Forms.Label();
            this.textBoxZusatzMenge = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1722, 37);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(763, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "RETOURE";
            // 
            // buttonAuftragRetoureBuchen
            // 
            this.buttonAuftragRetoureBuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuftragRetoureBuchen.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAuftragRetoureBuchen.Location = new System.Drawing.Point(1321, 389);
            this.buttonAuftragRetoureBuchen.Name = "buttonAuftragRetoureBuchen";
            this.buttonAuftragRetoureBuchen.Size = new System.Drawing.Size(346, 92);
            this.buttonAuftragRetoureBuchen.TabIndex = 14;
            this.buttonAuftragRetoureBuchen.Text = "BUCHEN";
            this.buttonAuftragRetoureBuchen.UseVisualStyleBackColor = true;
            this.buttonAuftragRetoureBuchen.Click += new System.EventHandler(this.buttonAuftragRetoureBuchen_Click);
            // 
            // comboBoxAuftragsNr
            // 
            this.comboBoxAuftragsNr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAuftragsNr.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuftragsNr.FormattingEnabled = true;
            this.comboBoxAuftragsNr.Location = new System.Drawing.Point(296, 54);
            this.comboBoxAuftragsNr.Name = "comboBoxAuftragsNr";
            this.comboBoxAuftragsNr.Size = new System.Drawing.Size(148, 48);
            this.comboBoxAuftragsNr.TabIndex = 18;
            this.comboBoxAuftragsNr.Tag = "AuftragsNr";
            this.comboBoxAuftragsNr.SelectedValueChanged += new System.EventHandler(this.comboBoxAuftragsNr_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Auftrags Nummer:";
            // 
            // textBoxFarbe
            // 
            this.textBoxFarbe.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFarbe.Location = new System.Drawing.Point(138, 131);
            this.textBoxFarbe.Name = "textBoxFarbe";
            this.textBoxFarbe.ReadOnly = true;
            this.textBoxFarbe.Size = new System.Drawing.Size(207, 46);
            this.textBoxFarbe.TabIndex = 24;
            // 
            // textBoxMenge
            // 
            this.textBoxMenge.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenge.Location = new System.Drawing.Point(523, 133);
            this.textBoxMenge.Name = "textBoxMenge";
            this.textBoxMenge.ReadOnly = true;
            this.textBoxMenge.Size = new System.Drawing.Size(207, 46);
            this.textBoxMenge.TabIndex = 25;
            // 
            // textBoxFom
            // 
            this.textBoxFom.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFom.Location = new System.Drawing.Point(889, 133);
            this.textBoxFom.Name = "textBoxFom";
            this.textBoxFom.ReadOnly = true;
            this.textBoxFom.Size = new System.Drawing.Size(207, 46);
            this.textBoxFom.TabIndex = 26;
            // 
            // textBoxAuftragsAnfang
            // 
            this.textBoxAuftragsAnfang.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuftragsAnfang.Location = new System.Drawing.Point(1417, 108);
            this.textBoxAuftragsAnfang.Name = "textBoxAuftragsAnfang";
            this.textBoxAuftragsAnfang.ReadOnly = true;
            this.textBoxAuftragsAnfang.Size = new System.Drawing.Size(250, 46);
            this.textBoxAuftragsAnfang.TabIndex = 27;
            // 
            // richTextBoxBemerkung
            // 
            this.richTextBoxBemerkung.Location = new System.Drawing.Point(45, 389);
            this.richTextBoxBemerkung.Name = "richTextBoxBemerkung";
            this.richTextBoxBemerkung.Size = new System.Drawing.Size(744, 92);
            this.richTextBoxBemerkung.TabIndex = 32;
            this.richTextBoxBemerkung.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 33;
            this.label2.Text = "Farbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 45);
            this.label3.TabIndex = 34;
            this.label3.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 45);
            this.label4.TabIndex = 35;
            this.label4.Text = "Form:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1132, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 45);
            this.label5.TabIndex = 36;
            this.label5.Text = "Auftrags Anfang:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1169, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 45);
            this.label7.TabIndex = 38;
            this.label7.Text = "Auftrags Ende:";
            // 
            // textBoxAuftragsEnde
            // 
            this.textBoxAuftragsEnde.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuftragsEnde.Location = new System.Drawing.Point(1417, 171);
            this.textBoxAuftragsEnde.Name = "textBoxAuftragsEnde";
            this.textBoxAuftragsEnde.ReadOnly = true;
            this.textBoxAuftragsEnde.Size = new System.Drawing.Size(250, 46);
            this.textBoxAuftragsEnde.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1417, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 45);
            this.label8.TabIndex = 40;
            this.label8.Text = "Zusatz Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 45);
            this.label9.TabIndex = 41;
            this.label9.Text = "Bemerkung (Grund):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(866, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 45);
            this.label10.TabIndex = 43;
            this.label10.Text = "Strafsekunden:";
            // 
            // textBoxStrafsekunden
            // 
            this.textBoxStrafsekunden.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStrafsekunden.Location = new System.Drawing.Point(1115, 435);
            this.textBoxStrafsekunden.Name = "textBoxStrafsekunden";
            this.textBoxStrafsekunden.Size = new System.Drawing.Size(121, 46);
            this.textBoxStrafsekunden.TabIndex = 42;
            // 
            // labelZusatzMaterialFarbeTEXT
            // 
            this.labelZusatzMaterialFarbeTEXT.AutoSize = true;
            this.labelZusatzMaterialFarbeTEXT.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZusatzMaterialFarbeTEXT.Location = new System.Drawing.Point(1394, 319);
            this.labelZusatzMaterialFarbeTEXT.Name = "labelZusatzMaterialFarbeTEXT";
            this.labelZusatzMaterialFarbeTEXT.Size = new System.Drawing.Size(147, 45);
            this.labelZusatzMaterialFarbeTEXT.TabIndex = 44;
            this.labelZusatzMaterialFarbeTEXT.Text = "*FARBE*";
            // 
            // textBoxZusatzMenge
            // 
            this.textBoxZusatzMenge.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZusatzMenge.Location = new System.Drawing.Point(1565, 320);
            this.textBoxZusatzMenge.Name = "textBoxZusatzMenge";
            this.textBoxZusatzMenge.Size = new System.Drawing.Size(102, 46);
            this.textBoxZusatzMenge.TabIndex = 45;
            // 
            // Retoure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxZusatzMenge);
            this.Controls.Add(this.labelZusatzMaterialFarbeTEXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxStrafsekunden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAuftragsEnde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxBemerkung);
            this.Controls.Add(this.textBoxAuftragsAnfang);
            this.Controls.Add(this.textBoxFom);
            this.Controls.Add(this.textBoxMenge);
            this.Controls.Add(this.textBoxFarbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuftragsNr);
            this.Controls.Add(this.buttonAuftragRetoureBuchen);
            this.Controls.Add(this.panel1);
            this.Name = "Retoure";
            this.Size = new System.Drawing.Size(1688, 525);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAuftragRetoureBuchen;
        private System.Windows.Forms.ComboBox comboBoxAuftragsNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFarbe;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.TextBox textBoxFom;
        private System.Windows.Forms.TextBox textBoxAuftragsAnfang;
        private System.Windows.Forms.RichTextBox richTextBoxBemerkung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAuftragsEnde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStrafsekunden;
        private System.Windows.Forms.Label labelZusatzMaterialFarbeTEXT;
        private System.Windows.Forms.TextBox textBoxZusatzMenge;
    }
}
