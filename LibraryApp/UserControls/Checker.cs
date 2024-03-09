using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public static class Checker
    {
        public static bool CheckStringValue(TextBox textBox, ErrorProvider error)
        {
            string inputVal = textBox.Text.ToUpper();
            if(inputVal == string.Empty)
            {
                error.SetError(textBox, "Invalid Input");
                return false;
            }

            foreach (var character in inputVal)
            {
                if (character > 255)
                {
                    error.SetError(textBox, "Invalid Input");
                    return false;
                }
            }
            error.SetError(textBox, string.Empty);
            return true;
        }

        public static bool CheckIntegerValue(TextBox textBox, ErrorProvider error)
        {
            int n = 0;

            if(textBox.Text.Length == 0)
            {
                error.SetError(textBox, "Invalid Input");
                return false;
            }

            if(!int.TryParse(textBox.Text, out n) && n < 0)
            {
                error.SetError(textBox, "Invalid Input");
                return false;
            }
            error.SetError(textBox, string.Empty);
            return true;
        }
    }
}
