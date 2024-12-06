namespace Tischprojekt.Data.obj.Userctrl
{
    partial class Bestellen
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
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxArtikel1Farbe = new System.Windows.Forms.ComboBox();
            this.comboBoxArtikel2Farbe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBUCHEN = new System.Windows.Forms.Button();
            this.textBoxMenge1 = new System.Windows.Forms.TextBox();
            this.textBoxMenge2 = new System.Windows.Forms.TextBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(647, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(412, 65);
            this.label14.TabIndex = 13;
            this.label14.Text = "Warenbestellung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Farbe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Farbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Menge:";
            // 
            // comboBoxArtikel1Farbe
            // 
            this.comboBoxArtikel1Farbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel1Farbe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel1Farbe.FormattingEnabled = true;
            this.comboBoxArtikel1Farbe.Location = new System.Drawing.Point(527, 139);
            this.comboBoxArtikel1Farbe.Name = "comboBoxArtikel1Farbe";
            this.comboBoxArtikel1Farbe.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel1Farbe.TabIndex = 24;
            this.comboBoxArtikel1Farbe.Tag = "Farbe";
            // 
            // comboBoxArtikel2Farbe
            // 
            this.comboBoxArtikel2Farbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArtikel2Farbe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArtikel2Farbe.FormattingEnabled = true;
            this.comboBoxArtikel2Farbe.Location = new System.Drawing.Point(527, 308);
            this.comboBoxArtikel2Farbe.Name = "comboBoxArtikel2Farbe";
            this.comboBoxArtikel2Farbe.Size = new System.Drawing.Size(207, 45);
            this.comboBoxArtikel2Farbe.TabIndex = 25;
            this.comboBoxArtikel2Farbe.Tag = "Farbe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(434, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Artikel 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "Menge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(434, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Artikel 1";
            // 
            // buttonBUCHEN
            // 
            this.buttonBUCHEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBUCHEN.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBUCHEN.Location = new System.Drawing.Point(636, 378);
            this.buttonBUCHEN.Name = "buttonBUCHEN";
            this.buttonBUCHEN.Size = new System.Drawing.Size(390, 112);
            this.buttonBUCHEN.TabIndex = 35;
            this.buttonBUCHEN.Text = "AUSLÖSEN";
            this.buttonBUCHEN.UseVisualStyleBackColor = true;
            this.buttonBUCHEN.Click += new System.EventHandler(this.buttonBUCHEN_Click);
            // 
            // textBoxMenge1
            // 
            this.textBoxMenge1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenge1.Location = new System.Drawing.Point(1023, 141);
            this.textBoxMenge1.Name = "textBoxMenge1";
            this.textBoxMenge1.ReadOnly = true;
            this.textBoxMenge1.Size = new System.Drawing.Size(96, 43);
            this.textBoxMenge1.TabIndex = 36;
            this.textBoxMenge1.Text = "5";
            this.textBoxMenge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMenge2
            // 
            this.textBoxMenge2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenge2.Location = new System.Drawing.Point(1023, 308);
            this.textBoxMenge2.Name = "textBoxMenge2";
            this.textBoxMenge2.ReadOnly = true;
            this.textBoxMenge2.Size = new System.Drawing.Size(96, 43);
            this.textBoxMenge2.TabIndex = 37;
            this.textBoxMenge2.Text = "5";
            this.textBoxMenge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // Bestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMenge2);
            this.Controls.Add(this.textBoxMenge1);
            this.Controls.Add(this.buttonBUCHEN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxArtikel1Farbe);
            this.Controls.Add(this.comboBoxArtikel2Farbe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Name = "Bestellen";
            this.Size = new System.Drawing.Size(1683, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArtikel1Farbe;
        private System.Windows.Forms.ComboBox comboBoxArtikel2Farbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBUCHEN;
        private System.Windows.Forms.TextBox textBoxMenge1;
        private System.Windows.Forms.TextBox textBoxMenge2;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}
