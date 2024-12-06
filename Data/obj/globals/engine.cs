using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tischprojekt.Data.obj.Userctrl;

namespace Tischprojekt.Data.obj.dataObj
{
    internal class Engine
    {
        private static readonly object lockObj = new object();
        private static Engine instance;

        public static Engine GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Engine();
                    }
                }
            }

            return instance;
        }





    }
}
