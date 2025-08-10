using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6CleanMethod
{
    static class SmartTools
    {
        public static void Clean(Control frm, string Execpt = "") // default parameter
        {
            foreach (Control item in frm.Controls)
            {
                if (item.Name == Execpt)
                {
                    continue;
                }
                if (item is TextBox || item is ComboBox)
                    item.Text = string.Empty;
                if (item is GroupBox)
                { 
                    Clean(item);
                }
            }
        }
    }
}
