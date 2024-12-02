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
    }
}
