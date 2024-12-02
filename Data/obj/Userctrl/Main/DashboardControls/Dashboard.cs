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
        public void SetDGVActiveOrdersDataSource()
        {
            dataGridViewAktiveAuftraege.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAcceptedOrders);

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
            AuftragAnnahme.GetInstance().FillControls();
            
        }

        private void buttonBestellen_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(Bestellen.GetInstance(), panelContainer);
        }

        private void buttonWareneingang_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(Wareneingang.GetInstance(), panelContainer);
        }

        private void buttonAuftragsAbschluss_Click(object sender, EventArgs e)
        {
            MainForm.ShowUserControl(AuftragsAbschluss.GetInstance(), panelContainer);
        }

        private void dataGridViewAktiveAuftraege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Properties.Settings.Default.DBpath))
            {


            }
            else
            {
                dataGridViewAktiveAuftraege.DataSource = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllAcceptedOrders);

            }
        }
    }
}
