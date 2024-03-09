using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.UserControls
{
    public partial class RemoveBookUserControl : UserControl
    {
        public RemoveBookUserControl()
        {
            InitializeComponent();
        }

        private void RemoveBookUserControl_Load(object sender, EventArgs e)
        {
            executionMessage.Text = "";
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader;
                    SqlCommand tryRemoveBook = sqlConnection.CreateCommand();
                    tryRemoveBook.CommandType = CommandType.StoredProcedure;
                    tryRemoveBook.CommandText = "TryRemoveBook";
                    SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                    {
                        Direction = ParameterDirection.Output
                    };

                    tryRemoveBook.Parameters.Add(new SqlParameter("BookTitle", bookTitleTextbox.Text));
                    tryRemoveBook.Parameters.Add(new SqlParameter("ISBN", isbnTextbox.Text));
                    tryRemoveBook.Parameters.Add(errorMessageParam);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tryRemoveBook);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    sqlConnection.Close();
                    string errorMessage = tryRemoveBook.Parameters[tryRemoveBook.Parameters.Count - 1].Value.ToString();

                    if(errorMessage == string.Empty)
                    {
                        executionMessage.Text = "Success";
                        executionMessage.ForeColor = Color.Green;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                        executionMessage.Text = "Failed";
                        executionMessage.ForeColor = Color.Red;
                    }
                }
            }
        }

        private bool CheckInputs()
        {
            bool isTrue = true;
            if(!Checker.CheckStringValue(bookTitleTextbox, errorProvider1))
            {
                isTrue = false;
            }
            if(!Checker.CheckIntegerValue(isbnTextbox, errorProvider1))
            {
                isTrue = false;
            }
            return isTrue;
        }

        public void ResetControl()
        {
            
        }
    }
}
