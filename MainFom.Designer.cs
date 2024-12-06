using Tischprojekt.Data.obj.Userctrl;

namespace Tischprojekt
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelProgBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panelProgBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 2;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Location = new System.Drawing.Point(11, 969);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(162, 42);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "Einstellungen";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.buttonDashboard);
            this.panel4.Controls.Add(this.buttonSettings);
            this.panel4.Location = new System.Drawing.Point(1722, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 1018);
            this.panel4.TabIndex = 22;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 2;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Location = new System.Drawing.Point(11, 15);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(162, 42);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "DASHBOARD";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Location = new System.Drawing.Point(0, 23);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1722, 1011);
            this.panelMainContainer.TabIndex = 23;
            this.panelMainContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panelMainContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panelMainContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // panelProgBar
            // 
            this.panelProgBar.BackColor = System.Drawing.Color.Silver;
            this.panelProgBar.Controls.Add(this.buttonMinimize);
            this.panelProgBar.Controls.Add(this.buttonClose);
            this.panelProgBar.Controls.Add(this.label7);
            this.panelProgBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgBar.Location = new System.Drawing.Point(0, 0);
            this.panelProgBar.Name = "panelProgBar";
            this.panelProgBar.Size = new System.Drawing.Size(1900, 24);
            this.panelProgBar.TabIndex = 0;
            this.panelProgBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panelProgBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panelProgBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Image = global::Tischprojekt.Properties.Resources.icons8_fenster_verkleinern_20;
            this.buttonMinimize.Location = new System.Drawing.Point(1855, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 10;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::Tischprojekt.Properties.Resources.icons8_löschen_20;
            this.buttonClose.Location = new System.Drawing.Point(1881, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(826, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tisch24.de";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1900, 1035);
            this.Controls.Add(this.panelProgBar);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Bestellung ";
            this.panel4.ResumeLayout(false);
            this.panelProgBar.ResumeLayout(false);
            this.panelProgBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelProgBar;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label7;
    }
}

