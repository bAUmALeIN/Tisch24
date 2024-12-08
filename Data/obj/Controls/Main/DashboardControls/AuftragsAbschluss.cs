using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data.obj.dataObj;
using System.Data.SQLite;
using Tischprojekt.Data;

namespace Tischprojekt.Data.obj.Userctrl
{
    public partial class AuftragsAbschluss : UserControl
    {
        private static readonly object lockObj = new object();
        private static AuftragsAbschluss instance;
        private _Auftrag auftrag;
        public AuftragsAbschluss()
        {
            InitializeComponent();
        }

        public static AuftragsAbschluss GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new AuftragsAbschluss();
                    }
                }
            }

            return instance;
        }

        public void FillComboBoxAuftragsNr(int mode)

        {
            if (mode == 0)
            {
                DataTable dt = new DataTable();
                foreach (Control c in panelAuftragsAbschluss.Controls)
                {
                    Console.WriteLine($" Control gefunden: {c.Name}");
                    if (c is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)c;
                        switch (comboBox.Tag)
                        {
                            case "AuftragsNr":
                                dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAktiveOrdersPOS);
                                if (dt != null)
                                {
                                    comboBox.Items.Clear();
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        comboBox.Items.Add(dr["Nr"].ToString());

                                    }

                                }
                                break;
                            default:
                                break;

                        }
                    }
                }
            }
            else
            {
                foreach (Control c in panelAuftragsAbschluss.Controls)
                {
                    Console.WriteLine($" Control gefunden: {c.Name}");
                    if (c is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)c;
                        comboBox.SelectedIndex = -1;
                    }
                    if (c is TextBox)
                    {
                        TextBox textBox = (TextBox)c;
                        textBox.Text = "";

                    }
                }
                MessageBox.Show("Warenbuchung ok!");
            }
        }

        private void buttonAuftragAbschliessen_Click(object sender, EventArgs e)
        {

            auftrag.AuftragAbschließen();
            Dashboard.GetInstance().UpdateDGVs();
            comboBoxAuftragsNr.SelectedIndex = -1;
            textBoxAbgabe.Text = "";
            textBoxFarbe.Text = "";
            textBoxForm.Text = "";
            textBoxMenge.Text = "";
            FillComboBoxAuftragsNr(0);

        }

        private void comboBoxAuftragsNr_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxAuftragsNr.SelectedIndex == -1) return;
            auftrag = _Auftrag.GetAuftragByNr(Convert.ToInt32(comboBoxAuftragsNr.SelectedItem),true);
            if (auftrag != null) {
                textBoxAbgabe.Text = auftrag.Abgabe.ToString();
                textBoxFarbe.Text = auftrag.Farbe;
                textBoxForm.Text = auftrag.Form;
                textBoxMenge.Text = auftrag.Menge.ToString();

            }
            else
            {

                return;
            }
            buttonAuftragAbschliessen.Enabled = true;






        }
    }
}
