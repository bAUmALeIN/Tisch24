using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data.obj.dataObj;
using Tischprojekt.Data.obj.Userctrl;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tischprojekt.Data.obj.Controls.Main.Overview;

namespace Tischprojekt.Data.obj.Controls.Main.DashboardControls
{
    public partial class Retoure : UserControl
    {
        private static readonly object lockObj = new object();
        private static Retoure instance;
        private _Auftrag aktullerAuftrag;
        private bool neu = true;
        public Retoure()
        {
            InitializeComponent();
        }


        public static Retoure GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Retoure();
                    }
                }
            }

            return instance;
        }
        public void FillComboBox()
        {
            if (Globals.hasConnection)
            {
                DataTable dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllClosedOrders);
                if (dt != null)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        Console.WriteLine($"Spaltenname: {column.ColumnName}, Typ: {column.DataType}");
                    }
                    comboBoxAuftragsNr.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"Nr: {row["Nr"]}, Auftragsanfang: {row["Auftragsanfang"]}, Auftragsende: {row["Auftragsende"]}, Menge: {row["Menge"]}, Form: {row["Form"]}, Farbe: {row["Farbe"]}");
                        comboBoxAuftragsNr.Items.Add(row["Nr"].ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Keine Daten gefunden.");
                }

            }

        }

        private void comboBoxAuftragsNr_SelectedValueChanged(object sender, EventArgs e)
        {
            if (neu)
            {
                int AUftragNr = Convert.ToInt32(comboBoxAuftragsNr.SelectedItem);
                aktullerAuftrag = _Auftrag.GetAuftragByNr(AUftragNr, false);
                textBoxMenge.Text = aktullerAuftrag.Menge.ToString();
                textBoxFarbe.Text = aktullerAuftrag.Farbe.ToString();
                textBoxFom.Text = aktullerAuftrag.Form.ToString();
                textBoxAuftragsAnfang.Text = aktullerAuftrag.Beginn.ToString();
                textBoxAuftragsEnde.Text = aktullerAuftrag.Abgabe.ToString();
                aktullerAuftrag.Abgeschlossen = true;
                neu = false;
            }
           
        }
        private void buttonAuftragRetoureBuchen_Click(object sender, EventArgs e)
        {
            int sekunden = 0 , menge = 0;
            try
            {
                if(textBoxStrafsekunden.Text != "")
                {
                    sekunden = Convert.ToInt32(textBoxStrafsekunden.Text);

                }
                if(textBoxZusatzMenge.Text != "")
                {
                    menge = Convert.ToInt32(textBoxZusatzMenge.Text);

                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return;
            }

            if (aktullerAuftrag.AuftragSetRetoure(sekunden, menge, richTextBoxBemerkung.Text)) {

                textBoxFom.Text = "";
                textBoxMenge.Text = "";
                textBoxStrafsekunden.Text = "";
                textBoxZusatzMenge.Text = "";
                textBoxFarbe.Text = "";
                textBoxAuftragsEnde.Text = "";
                textBoxAuftragsAnfang.Text = "";
                comboBoxAuftragsNr.SelectedIndex = -1;
                neu = true;
                

            
            }




           // @OrderNr,@Menge,@Farbe,@Form,@AuftragsAnfangOrg,@AuftragsEndeOrg,@Strafsekuden,@Bemerkung,@Zusatzmenge


        }
    }
}
