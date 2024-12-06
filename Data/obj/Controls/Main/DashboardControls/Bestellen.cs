using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;
using Tischprojekt.Data.obj.globals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tischprojekt.Data.obj.Userctrl
{
    public partial class Bestellen : UserControl
    {
        private static readonly object lockObj = new object();
        private static Bestellen instance;

        public Bestellen()
        {
            InitializeComponent();
        }

        public static Bestellen GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Bestellen();
                    }
                }
            }

            return instance;
        }

        public void FillControls()
        {
            comboBoxArtikel1Farbe.Items.Clear();
            comboBoxArtikel2Farbe.Items.Clear();
            DataTable dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllFarben);
            
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxArtikel1Farbe.Items.Add(dr["Farbe_1"].ToString());
                comboBoxArtikel2Farbe.Items.Add(dr["Farbe_1"].ToString());

            }

        }

        private void buttonBUCHEN_Click(object sender, EventArgs e)
        {

            //prüfe 1 oder 2 Artikel
            if(comboBoxArtikel1Farbe.SelectedItem == null)
            {
                Console.WriteLine("comboBox1 Leer");
                return;
                


            }else if(comboBoxArtikel2Farbe.SelectedItem == null)
            {
                _Bestellung neueBestellung = new _Bestellung();
                object ergebnis = ConnectionManager.GetInstance().ExecuteScalar(SQLquerys.nextFreeNumberFromBestellungen);
                neueBestellung.BestellNr = Convert.ToInt32(ergebnis);
                neueBestellung.AddArtikel("Artikel1", comboBoxArtikel1Farbe.SelectedItem.ToString(), Convert.ToInt32(textBoxMenge1.Text));
                Console.WriteLine(neueBestellung.ToString());
                if (neueBestellung.SaveToDatabase())
                {
                    Dashboard.GetInstance().UpdateDGVs();
                    comboBoxArtikel1Farbe.SelectedIndex = -1;
                }
                else
                {


                }
                

                Console.WriteLine("comboBox2 Leer // 1 Artikel");
                return;
            }


            // 2 Artikel ->
            _Bestellung neueBestellung2 = new _Bestellung();
            object ergebnis2 = ConnectionManager.GetInstance().ExecuteScalar(SQLquerys.nextFreeNumberFromBestellungen);
            neueBestellung2.BestellNr = Convert.ToInt32(ergebnis2);
            neueBestellung2.AddArtikel("Artikel1", comboBoxArtikel1Farbe.SelectedItem.ToString(), Convert.ToInt32(textBoxMenge1.Text));
            neueBestellung2.AddArtikel("Artikel2", comboBoxArtikel2Farbe.SelectedItem.ToString(), Convert.ToInt32(textBoxMenge2.Text));
            Console.WriteLine(neueBestellung2.ToString());
            if (neueBestellung2.SaveToDatabase())
            {
                Dashboard.GetInstance().UpdateDGVs();
                comboBoxArtikel1Farbe.SelectedIndex = -1;
                comboBoxArtikel2Farbe.SelectedIndex = -1;
            }
            else
            {


            }


        }
    }
}
