using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;
using System.Diagnostics.Eventing.Reader;
using System.Data.SQLite;



namespace Tischprojekt.Data.obj.Userctrl
{
    public partial class AuftragAnnahme : UserControl
    {
        private static readonly object lockObj = new object();
        private static AuftragAnnahme instance;



        public AuftragAnnahme()
        {
            InitializeComponent();
            this.Load += AuftragAnnahme_Load;
        }

        public static AuftragAnnahme GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new AuftragAnnahme();
                    }
                }
            }

            return instance;
        }
        public void FillControls()

        {
            DataTable dt = new DataTable();
            foreach (Control c in panelAuftragAnnehmen.Controls) {
                if (c is ComboBox ) { 
                ComboBox comboBox = (ComboBox)c;   
                        switch (comboBox.Tag)
                        {
                            case "Farbe":
                                dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllFarben);
                                if (dt != null)
                                {
                                comboBox.Items.Clear();
                                foreach (DataRow dr in dt.Rows)
                                    {
                                        comboBox.Items.Add(dr["Farbe_1"].ToString());

                                    }

                                }
                                break;
                            case "Menge":
                                dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllMengen);
                                if (dt != null)
                                {
                                comboBox.Items.Clear();
                                foreach (DataRow dr in dt.Rows)
                                    {
                                        comboBox.Items.Add(dr["Menge_1"].ToString());

                                    }

                                }
                                break;
                            case "Form":
                            dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllFormen);
                            if (dt != null)
                            {
                                comboBox.Items.Clear();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    comboBox.Items.Add(dr["Form_1"].ToString());

                                }

                            }
                            break;

                            default:
                                break;

                        }

                    
                       
                }
            }

        }

        private void CheckInput()
        {
            bool checkText = true;
            if (comboBoxFarbe.SelectedItem == null)
            {
                checkText = false;
            }
            if (comboBoxMenge.SelectedItem == null)
            {
                checkText = false;
            }
            if (comboBoxForm.SelectedItem == null)
            {
                checkText = false;
            }
            if (String.IsNullOrEmpty(textBoxAfutragsEnde.Text))
            {
                checkText = false;
            }
            if (String.IsNullOrEmpty(textBoxAfutragsEnde.Text))
            {
                checkText = false;
            }
            buttonAuftragAnnehmen.Enabled = checkText;

        }
        private void AuftragAnnahme_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuftragAnnehmen_Click(object sender, EventArgs e)
        {

            DateTime anfang = DateTime.Now;             // vollständiges DateTime Objekt
            string abgabeInput = textBoxAfutragsEnde.Text;
            if(TimeSpan.TryParse(abgabeInput, out TimeSpan abgabeZeit))  // Zeit eingabe wird in TimeSpan umgewandelt       // nur Uhrzeit
            {

                DateTime abgabe = anfang.Date + abgabeZeit;         // Datum + Uhrzeit

                // Auftrag erstellen
                try
                {
                    _Auftrag neuerAuftrag = new _Auftrag(Convert.ToInt32(textBoxAuftragsNr.Text), anfang, abgabe, Convert.ToInt32(comboBoxMenge.Text), comboBoxForm.Text, comboBoxFarbe.Text);
                    Console.WriteLine($"Neuer Auftrag erstellt: Nr {neuerAuftrag.Nr}, Abgabe: {neuerAuftrag.Abgabe}");
                    SaveAuftragInDB(neuerAuftrag);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }


                Dashboard.GetInstance().SetDGVAcceptedOrdersDataSource();
                textBoxAfutragsEnde.Text = "";
                textBoxAuftragsNr.Text = "";
                comboBoxFarbe.SelectedIndex = -1;
                comboBoxForm.SelectedIndex = -1;
                comboBoxMenge.SelectedIndex = -1;
            }

            

        }

        private bool SaveAuftragInDB(_Auftrag auftrag)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[]
        {
            new SQLiteParameter("@Nr", auftrag.Nr),
            new SQLiteParameter("@DatumBeginn", auftrag.Beginn.ToString("yyyy-MM-dd HH:mm")), 
            new SQLiteParameter("@DatumAbgabe", auftrag.Abgabe.ToString("yyyy-MM-dd HH:mm")), 
            new SQLiteParameter("@Form", auftrag.Form),
            new SQLiteParameter("@Farbe", auftrag.Farbe),
            new SQLiteParameter("@IstRetoure", auftrag.IstRetoure ? 1 : 0) // Umwandlung von bool in 1 oder 0
        };
            if (ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.InsertIntoAcceptedOrders, parameters) == -1) {
                return false;
            }
            return true;

        }



        // INPUT EVENTS

        private void comboBoxMenge_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void comboBoxFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void comboBoxForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void textBoxAfutragsEnde_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void textBoxAuftragsNr_TextChanged(object sender, EventArgs e)
        {
            CheckInput();
        }
    }
}
