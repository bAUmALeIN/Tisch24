using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void checkBoxArtikel2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArtikel2.Checked)
            {
                panelArtikel2.Enabled = true;

            }
            else
            {
                panelArtikel2.Enabled = false;
            }
        }
    }
}
