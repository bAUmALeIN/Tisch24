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

namespace Tischprojekt.Data.obj.Userctrl
{
    public partial class AuftragsAbschluss : UserControl
    {
        private static readonly object lockObj = new object();
        private static AuftragsAbschluss instance;
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

        public void FillControls(int mode)

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



    }
}
