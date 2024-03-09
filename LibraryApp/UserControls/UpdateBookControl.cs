using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class UpdateBookControl : UserControl
    {
        private List<AddAuthorHelperControl> authorHelperControls = new List<AddAuthorHelperControl>();
        private int visibleAuthors = 0;
        public UpdateBookControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBookControl_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            executionMessage.Text = string.Empty;
            authorHelperControls.Add(addAuthorHelperControl1);
            authorHelperControls.Add(addAuthorHelperControl2);
            authorHelperControls.Add(addAuthorHelperControl3);
            authorHelperControls.Add(addAuthorHelperControl4);
            hideAuthors();
        }

        private void findBookButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlDataReader sqlDataReader = null;
                SqlCommand getBookData = sqlConnection.CreateCommand();
                getBookData.CommandType = CommandType.StoredProcedure;
                getBookData.CommandText = "GetBookData";

                getBookData.Parameters.Add(new SqlParameter("BookTitle", bookTitleTextbox.Text));
                sqlDataReader = getBookData.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    panel2.Visible = true;
                    hideAuthors();
                    while (sqlDataReader.Read())
                    {
                        dateTimePicker1.Value = parseDate(sqlDataReader[0].ToString());
                        isbnTextbox.Text = sqlDataReader[1].ToString();
                        amountTextbox.Text = sqlDataReader[2].ToString();
                        publisherTextbox.Text = sqlDataReader[3].ToString();
                        genreTextbox.Text = sqlDataReader[4].ToString();
                    }
                    sqlDataReader.NextResult();

                    while(sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader[0].ToString() + " " + sqlDataReader[1].ToString());
                        authorHelperControls[visibleAuthors].setAuthorName(sqlDataReader[0].ToString(), sqlDataReader[1].ToString());
                        authorHelperControls[visibleAuthors].Visible = true;
                        visibleAuthors++;
                        Console.WriteLine(visibleAuthors);
                    }

                    executionMessage.Text = "Success";
                    executionMessage.ForeColor = Color.Green;
                }
                else
                {
                    panel2.Visible = false;
                    hideAuthors();
                    executionMessage.Text = "Book Not Found";
                    executionMessage.ForeColor = Color.Red;
                }

                sqlConnection.Close();
            }
        }

        private void hideAuthors()
        {
            foreach (var control in authorHelperControls)
            {
                control.Visible = false;
            }
            visibleAuthors = 0;
        }

        private DateTime parseDate(string date)
        {
            string newDate = date.Split(' ')[0];
            int[] nums = newDate.Split('/').Select(s => int.Parse(s)).ToArray();
            return new DateTime(nums[2], nums[0], nums[1]);
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            
            authorHelperControls[visibleAuthors].Visible = true;
            visibleAuthors++;
            if (visibleAuthors > 3)
            {
                visibleAuthors = 3;
            }
            Console.WriteLine(visibleAuthors);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeAuthorButton1_Click(object sender, EventArgs e)
        {
            
            authorHelperControls[visibleAuthors].Visible = false;
            visibleAuthors--;
            if (visibleAuthors < 1)
            {
                visibleAuthors = 1;
            }
            Console.WriteLine(visibleAuthors);
        }
    }
}
