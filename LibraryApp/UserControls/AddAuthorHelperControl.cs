using LibraryApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddAuthorHelperControl : UserControl
    {
        public string AuthorFirstName = string.Empty;
        public string AuthorLastName = string.Empty;
        public AddAuthorHelperControl()
        {
            InitializeComponent();
        }

        public void setAuthorName(string authorFirstName, string authorLastName)
        {
            authorFirstNameTextbox.Text = authorFirstName;
            authorLastNameTextbox.Text = authorLastName;
        }
        private void authorFirstNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AuthorFirstName = authorFirstNameTextbox.Text;
        }

        private void authorLastNameTextbox_TextChanged(object sender, EventArgs e)
        {
            AuthorLastName = authorLastNameTextbox.Text;
        }

        public bool CheckInputs()
        {
            bool isTrue = true;
            if(!Checker.CheckStringValue(authorFirstNameTextbox, errorProvider1))
            {
                isTrue = false;
            }

            if (!Checker.CheckStringValue(authorLastNameTextbox, errorProvider1))
            {
                isTrue = false;
            }
            return isTrue;
        }

        private void AddAuthorHelperControl_Load(object sender, EventArgs e)
        {

        }
    }
}
