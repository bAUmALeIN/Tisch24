using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data.obj.dataObj;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;

namespace Tischprojekt.Data.obj.Userctrl
{
    public partial class Dashboard : UserControl
    {


        private static readonly object lockObj = new object();
        private static Dashboard instance;

        public Dashboard()
        {
            InitializeComponent();
        }


        public void UpdateDGVs()
        {
            dataGridViewAktiveBestellungen.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAktiveBestellungenPOS);
            dataGridViewAktiveAuftraege.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAktiveOrdersPOS);
            dataGridViewLager.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllLagerPOS);
            dataGridViewAngenommeAuftraege.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAcceptedOrders);
        }

        public void SetLabelNoDbConnection(bool wert)
        {
            labelNoDbConnection.Visible = wert;
        }
        public void SetLabelDbConnectionOK(bool wert)
        {
            labelDBConnectionOK.Visible = wert;
        }

        public static Dashboard GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Dashboard();
                    }
                }
            }

            return instance;
        }




        private void buttonAutragsannahme_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(AuftragAnnahme.GetInstance(), panelContainer);
            if (Globals.hasConnection)
            {
                AuftragAnnahme.GetInstance().FillControls();

            }


        }

        private void buttonBestellen_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(Bestellen.GetInstance(), panelContainer);
            if (Globals.hasConnection)
            {
                Bestellen.GetInstance().FillControls();

            }
        }

        private void buttonWareneingang_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(Wareneingang.GetInstance(), panelContainer);
            if (Globals.hasConnection)
            {
                Wareneingang.GetInstance().FillControls(0);

            }

        }

        private void buttonAuftragsAbschluss_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(AuftragsAbschluss.GetInstance(), panelContainer);
            if (Globals.hasConnection)
            {
                AuftragsAbschluss.GetInstance().FillComboBoxAuftragsNr(0);

            }

        }

        private void dataGridViewAktiveAuftraege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.DBpath))
            {


            }
            else
            {
                dataGridViewAngenommeAuftraege.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAcceptedOrders);

            }
        }
        /*   
     
        */
        private void dataGridViewAngenommeAuftraege_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (!Globals.hasConnection)
            {
                MessageBox.Show("Keine Verbindung zur Datenbank!");
                return;
            }

            Console.WriteLine("CELL DOUBLECLICK HAS CONNECTION");

            
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            
            DataGridViewRow row = dataGridViewAngenommeAuftraege.Rows[e.RowIndex];
            int nr = Convert.ToInt32(row.Cells[0].Value);
            string beginn = Convert.ToString(row.Cells[1].Value);
            string ende = Convert.ToString(row.Cells[2].Value);
            string form = Convert.ToString(row.Cells[3].Value);
            string farbe = Convert.ToString(row.Cells[4].Value);
            bool istRetoure = Convert.ToBoolean(row.Cells[5].Value);
            int menge = Convert.ToInt32(row.Cells[6].Value);

            // SQL-Parameter
            SQLiteParameter[] parametersCheckStock = {
        new SQLiteParameter("@Farbe", farbe),
        new SQLiteParameter("@Menge", menge)
            };

            
            DataTable result = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.SelectLagerMengeWhereNrAndFarbe, parametersCheckStock);

            // Wenn kein Lager gefunden wurde
            if (result == null || result.Rows.Count == 0)
            {
                MessageBox.Show($"Kein Lagerbestand für die Farbe '{farbe}' gefunden!");
                return;
            }

            // Bestand prüfen 
            int lagerMenge = Convert.ToInt32(result.Rows[0]["Menge"]);
            if (lagerMenge < menge)
            {
                MessageBox.Show($"Nicht genügend Bestand für die Farbe '{farbe}'. Verfügbar: {lagerMenge}, benötigt: {menge}");
                return;
            }

            // SQL-Parameter
            SQLiteParameter[] parametersActiveOrders = {
                new SQLiteParameter("@Nr", nr),
                new SQLiteParameter("@DatumBeginn", beginn),
                new SQLiteParameter("@DatumAbgabe", ende),
                new SQLiteParameter("@Form", form),
                new SQLiteParameter("@Farbe", farbe),
                new SQLiteParameter("@IstRetoure", istRetoure ? 1 : 0),
                new SQLiteParameter("@Menge", menge)
            };

            SQLiteParameter[] parametersDeleteAcceptedOrders = {
                 new SQLiteParameter("@Nr", nr)
            };

            SQLiteParameter[] parametersUpdateStock = {
                new SQLiteParameter("@Farbe", farbe),
                new SQLiteParameter("@Menge", menge)
            };

            // Auftrag in aktive Bestellungen verschieben
            if (ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.insertIntoActiveOrders, parametersActiveOrders) != -1)
            {
                // Akzeptierte Bestellung löschen
                if (ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.deleteFromAcceptedOrders, parametersDeleteAcceptedOrders) != -1)
                {
                    // Lagerbestand aktualisieren
                    ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.UpdateLagerbestand, parametersUpdateStock);

                    
                    ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.deleteFromLagerWhereMenge0);

                    
                    Dashboard.GetInstance().UpdateDGVs();


                    MessageBox.Show("Auftrag erfolgreich übertragen!");
                }
                else
                {
                    MessageBox.Show("Fehler beim Löschen des akzeptierten Auftrags!");
                }
            }
            else
            {
                MessageBox.Show("Fehler beim Übertragen des Auftrags in aktive Bestellungen!");
            }
        }

    }
}
