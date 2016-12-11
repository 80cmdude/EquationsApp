using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationApp;
using Xamarin.Forms;

namespace EquationApp.Controllers
{
    public static class ModeChange
    {
        public static void ChangeMode()
        {
            if (GlobalVar.quickMode == true)
            {
                GlobalVar.quickMode = false;
            }
            else
            {
                GlobalVar.quickMode = true;
            }
        }
    }
}
