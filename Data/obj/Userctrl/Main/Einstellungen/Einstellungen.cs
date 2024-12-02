using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;


namespace Tischprojekt.Data.obj.Userctrl.Main.Einstellungen
{
    public partial class Einstellungen : UserControl
    {
        private static readonly object lockObj = new object();
        private static Einstellungen instance;

        public Einstellungen()
        {
            InitializeComponent();
            
        }



        public static Einstellungen GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Einstellungen();
                    }
                }
            }

            return instance;
        }

        public void ChangeTextBoxDbPath(string dbPath)
        {
            textBoxDbPath.Text = dbPath;        
        }


        private void buttonOpenDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite-Datenbanken (*.sqlite;*.db;*.sqlite3)|*.sqlite;*.db;*.sqlite3|Alle Dateien (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDbPath.Text = openFileDialog.FileName;
                buttonSaveAndTest.Enabled = true;
            }
        }



        private void buttonSaveAndTest_Click(object sender, EventArgs e)
        {
            
            ConnectionManager connectionManager = ConnectionManager.GetInstance();
            connectionManager.SetConnectionString(textBoxDbPath.Text);

            if (connectionManager.TestConnection())
            {
                if (MessageBox.Show("Verbindung zur Datenbank erfolgreich!, wollen Sie die Verbindung Speichern ?","TEST ERFOLGREICH",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Properties.Settings.Default.DBpath = textBoxDbPath.Text;
                    Properties.Settings.Default.Save();
                    Dashboard db = Dashboard.GetInstance();
                    db.SetLabelNoDbConnection(false);
                    db.SetLabelDbConnectionOK(true);
                    MainForm.UpdateSettingsControls();
                    Dashboard.GetInstance().SetDGVAcceptedOrdersDataSource();
                }
            }
            else
            {
                MessageBox.Show("Fehler beim Verbinden mit der Datenbank.");
                Dashboard.GetInstance().SetLabelNoDbConnection(true);
                Dashboard.GetInstance().SetLabelDbConnectionOK(false);
            }
        }

        private void Einstellungen_Load(object sender, EventArgs e)
        {

        }

        private void buttonCLSdb_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBpath = "";
            Properties.Settings.Default.Save();

        }

        private void dataGridViewFarben_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            buttonSaveFarben.Enabled = true;
        }
        private void dataGridViewMengen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            buttonSaveMengen.Enabled = true;
        }
        private void dataGridViewFormen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            buttonSaveFormen.Enabled = true;

        }

        private void buttonSaveFarben_Click(object sender, EventArgs e)
        {
            try
            {

                ConnectionManager cm = ConnectionManager.GetInstance();


                cm.ExecuteNonQuery(SQLquerys.deleteAllFarben);

                foreach (DataGridViewRow row in dataGridViewFarben.Rows)
                {
                    string farbe = row.Cells["Farben"].Value?.ToString();
                    if (!string.IsNullOrEmpty(farbe))
                    {
                        SQLiteParameter[] parameters =
                        {
                    new SQLiteParameter("@FARBE", farbe)
                };

                        cm.ExecuteNonQuery(SQLquerys.insertIntoFarben, parameters);
                    }
                }

                MessageBox.Show("Daten erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveMengen_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionManager cm = ConnectionManager.GetInstance();


                cm.ExecuteNonQuery(SQLquerys.deleteAllMengen);

                foreach (DataGridViewRow row in dataGridViewMengen.Rows)
                {

                    if (int.TryParse(row.Cells["Mengen"].Value?.ToString(), out int menge))
                    {
                        SQLiteParameter[] parameters =
                        {
                    new SQLiteParameter("@MENGEN", menge)
                };
                        cm.ExecuteNonQuery(SQLquerys.insertIntoMengen, parameters);
                    }
                }

                MessageBox.Show("Daten erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFormen_Click(object sender, EventArgs e)
        {
            try
            {

                ConnectionManager cm = ConnectionManager.GetInstance();


                cm.ExecuteNonQuery(SQLquerys.deleteAllFormen);

                foreach (DataGridViewRow row in dataGridViewFormen.Rows)
                {
                    string form = row.Cells["Formen"].Value?.ToString();
                    if (!string.IsNullOrEmpty(form))
                    {
                        SQLiteParameter[] parameters =
                        {
                    new SQLiteParameter("@FORMEN", form)
                };

                        cm.ExecuteNonQuery(SQLquerys.insertIntoFormen, parameters);
                    }
                }

                MessageBox.Show("Daten erfolgreich gespeichert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

