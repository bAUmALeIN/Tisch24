using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data.obj.Userctrl;
using Tischprojekt.Data;
using Tischprojekt.Properties;
using Tischprojekt.Data.obj.Userctrl.Main.Einstellungen;
using Tischprojekt;
using Tischprojekt.Data.obj.dataObj;
using System.Data.Entity.Migrations.Sql;
using System.Runtime.InteropServices;
using System.Net.Configuration;
namespace Tischprojekt
{
    public partial class MainForm : Form
    {
        private static readonly object lockObj = new object();
        private static MainForm instance;


        private Point mouseOffset;
        private bool isMouseDown = false;

        public bool ConnectionState = false;
        ConnectionManager connectionManager;

        public MainForm()
        {
            InitializeComponent();
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            this.StartPosition = FormStartPosition.CenterScreen;
            ShowUserControl(Dashboard.GetInstance(), panelMainContainer);
            if (Properties.Settings.Default.DBpath.Length == 0)
            {
                Dashboard.GetInstance().labelNoDbConnection.Visible = true;

            }
            else
            {
                
                connectionManager = ConnectionManager.GetInstance();
                connectionManager.SetConnectionString(Properties.Settings.Default.DBpath);
                Dashboard.GetInstance().labelDBConnectionOK.Visible = true;
            }
        }


        public static MainForm GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new MainForm();
                    }
                }
            }

            return instance;
        }


        public static void ShowUserControl(UserControl uc,Panel panel)
        {
            if (panel.Controls.Count > 0 && panel.Controls[panel.Controls.Count - 1] == uc) 
            {

                return;
            }
            panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
            uc.BringToFront();


        }

        public static void UpdateSettingsControls()
        {

            Einstellungen settings = Einstellungen.GetInstance();
            if (settings == null)
            {

                return;
            }
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.DBpath))
            {

                return;
            }
            
            settings.ChangeTextBoxDbPath(Properties.Settings.Default.DBpath);
            ConnectionManager cm;
            try
            {
                cm = ConnectionManager.GetInstance();
            }
            catch (Exception ex)
            {

                return;
            }


            foreach (Control ctrl in settings.Controls)
            {
                DataGridView dgv = ctrl as DataGridView;
                if (dgv != null && dgv.Tag?.ToString() == "Farben")
                {
                    try
                    {
                        DataTable dt = cm.ExecuteQuery(SQLquerys.getAllFarben);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dgv.Rows.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                dgv.Rows.Add(row.ItemArray); // ItemArray enthält die Werte der Zeile
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler bei der Abfrage SQLquerys.getAllFarben: {ex.Message}");
                    }
                }
                else if(dgv != null && dgv.Tag?.ToString() == "Mengen")
                {
                    try
                    {
                        DataTable dt = cm.ExecuteQuery(SQLquerys.getAllMengen);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dgv.Rows.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                dgv.Rows.Add(row.ItemArray); 
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler bei der Abfrage SQLquerys.getAllFarben: {ex.Message}");
                    }

                }
                else if( dgv != null && dgv.Tag?.ToString() == "Formen")
                {
                    try
                    {
                        DataTable dt = cm.ExecuteQuery(SQLquerys.getAllFormen);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            dgv.Rows.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                dgv.Rows.Add(row.ItemArray);
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler bei der Abfrage SQLquerys.getAllFarben: {ex.Message}");
                    }


                }
            }

        }





        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(Dashboard.GetInstance(), panelMainContainer);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }






        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(Einstellungen.GetInstance(), panelMainContainer);
            UpdateSettingsControls();
        }
    }
}
