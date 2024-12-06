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

namespace Tischprojekt.Data.obj.Userctrl
{

    public partial class Wareneingang : UserControl
    {
        private static readonly object lockObj = new object();
        private static Wareneingang instance;
        public Wareneingang()
        {
            InitializeComponent();
        }

        public static Wareneingang GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Wareneingang();
                    }
                }
            }

            return instance;
        }

        public void FillControls(int mode)

        {
            if (mode == 0)
            {
                DataTable dt = new DataTable();
                foreach (Control c in panelWareneingang.Controls)
                {
                    Console.WriteLine($" Control gefunden: {c.Name}");
                    if (c is ComboBox)
                    {
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
            else
            {
                foreach (Control c in panelWareneingang.Controls)
                {
                    Console.WriteLine($" Control gefunden: {c.Name}");
                    if (c is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)c;
                        comboBox.SelectedIndex = -1;
                    }
                    if (c is TextBox) { 
                        TextBox textBox = (TextBox)c;
                        textBox.Text = "";

                    }
                }
                MessageBox.Show("Warenbuchung ok!");
            }
        }


        private void checkBoxArtikel2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArtikel2.Checked)
            {
                comboBoxArtikel2Farbe.Enabled = true;
                comboBoxArtikel2Menge.Enabled = true;

            }
            else
            {
                comboBoxArtikel2Farbe.Enabled = false;
                comboBoxArtikel2Menge.Enabled = false;
            }
        }

        private void comboBoxArtikel2Farbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxArtikel2Menge_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonBUCHEN_Click(object sender, EventArgs e)
        {
            if (checkBoxArtikel2.Checked)
            {
                // 2 Artikel
                if (comboBoxArtikel2Farbe.Text == "" && comboBoxArtikel2Menge.SelectedItem == null && comboBoxArtikel1Farbe.Text == "" && comboBoxArtikel1Menge.SelectedItem == null)
                {
                    return;

                }
                InsertWareInLager(comboBoxArtikel1Farbe.SelectedItem.ToString(), Convert.ToInt32(comboBoxArtikel1Menge.Text));
                InsertWareInLager(comboBoxArtikel2Farbe.SelectedItem.ToString(), Convert.ToInt32(comboBoxArtikel2Menge.Text));
                FillControls(1);
                Dashboard.GetInstance().UpdateDGVs();
            }
            else
            {
                Console.WriteLine("Wareineingang_ 1 Artikel");
                // 1 Artikel
                if (comboBoxArtikel1Farbe.Text == "" && comboBoxArtikel1Menge.SelectedItem == null)
                {
                    return;

                }
                InsertWareInLager(comboBoxArtikel1Farbe.SelectedItem.ToString(), Convert.ToInt32(comboBoxArtikel1Menge.Text));
                Dashboard.GetInstance().UpdateDGVs();
                FillControls(1);


            }
        }

        private void InsertWareInLager(string farbe, int menge) {

            SQLiteParameter[] parameters = new SQLiteParameter[]
               {

                    new SQLiteParameter("@Farbe", farbe),
                    new SQLiteParameter("@Menge", menge)
               };
            Console.WriteLine($"query Param 1: {comboBoxArtikel1Farbe.Text} | Param 2 {comboBoxArtikel1Menge.Text}");
            if (ConnectionManager.GetInstance().ExecuteNonQuery(SQLquerys.insertIntoLager, parameters) != -1)
            {
                Dashboard.GetInstance().UpdateDGVs();
                //FillControls(1);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
