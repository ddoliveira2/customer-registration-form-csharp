using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.Utils
{
    public static class Utils
    {
        public static void AdjustMainScreen(this Form form)
        {
            form.Top = 0;
            form.Left = 0;
            form.Width = Screen.PrimaryScreen.Bounds.Width - 2;
            form.Height = Screen.PrimaryScreen.Bounds.Height - 45;
        }
    }
}
