using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data;
using Tischprojekt.Data.obj.dataObj;

namespace Tischprojekt.Data.obj.Controls.Main.Overview
{
    public partial class Orders : UserControl
    {
        private static readonly object lockObj = new object();
        private static Orders instance;
        public Orders()
        {
            InitializeComponent();
        }

        public static Orders GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Orders();
                    }
                }
            }

            return instance;
        }

        public void FillDGV()
        {
            if (Globals.hasConnection) {
                DataTable dt = ConnectionManager.GetInstance().ExecuteQuery(SQLquerys.getAllOrders);
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine($"Spaltenname: {column.ColumnName}, Typ: {column.DataType}");
                }
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"Nr: {row["Nr"]}, Auftragsanfang: {row["Auftragsanfang"]}, Auftragsende: {row["Auftragsende"]}");
                    }
                    dataGridViewAllOrders.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Keine Daten gefunden.");
                }

            }
           
        }
    }
}
