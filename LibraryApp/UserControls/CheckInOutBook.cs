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
    public partial class CheckInOutBook : UserControl
    {
        public CheckInOutBook()
        {
            InitializeComponent();
        }

        private void submitFormButton_Click(object sender, EventArgs e)
        {
            bool validInputs = CheckInputs();

            if (validInputs)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
                if (comboBox1.Text == "Check-In")
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();

                        SqlCommand checkinBook = sqlConnection.CreateCommand();
                        checkinBook.CommandType = CommandType.StoredProcedure;
                        checkinBook.CommandText = "CheckinBook";
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                        {
                            Direction = ParameterDirection.Output
                        };


                        checkinBook.Parameters.Add(new SqlParameter("ClientFirstName", firstNameTextbox.Text));
                        checkinBook.Parameters.Add(new SqlParameter("ClientLastName", lastNameTextbox.Text));
                        checkinBook.Parameters.Add(new SqlParameter("BookTitle", bookTitleTextbox.Text));
                        checkinBook.Parameters.Add(errorMessageParam);
                        checkinBook.Parameters.Add(returnValue);
                        checkinBook.ExecuteNonQuery();
                        
                        string retval = checkinBook.Parameters[checkinBook.Parameters.Count - 1].Value.ToString();
                        Console.WriteLine(checkinBook.Parameters[checkinBook.Parameters.Count - 2].Value.ToString());
                        if(retval == "0")
                        {
                            executionMessage.Text = "Failed";
                            executionMessage.ForeColor = Color.Red;
                        }
                        else
                        {
                            CreateDataTable(sqlConnection);
                            executionMessage.Text = "Success";
                            executionMessage.ForeColor = Color.Green;
                        }
                        sqlConnection.Close();
                    }
                }
                else if (comboBox1.Text == "Check-Out")
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();

                        SqlCommand checkoutBook = sqlConnection.CreateCommand();
                        checkoutBook.CommandType = CommandType.StoredProcedure;
                        checkoutBook.CommandText = "CheckoutBook";
                        SqlParameter returnValue = new SqlParameter();
                        SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                        {
                            Direction = ParameterDirection.Output
                        };

                        returnValue.Direction = ParameterDirection.ReturnValue;

                        checkoutBook.Parameters.Add(new SqlParameter("ClientFirstName", firstNameTextbox.Text));
                        checkoutBook.Parameters.Add(new SqlParameter("ClientLastName", lastNameTextbox.Text));
                        checkoutBook.Parameters.Add(new SqlParameter("BookTitle", bookTitleTextbox.Text));
                        checkoutBook.Parameters.Add(errorMessageParam);
                        checkoutBook.Parameters.Add(returnValue);
                        checkoutBook.ExecuteNonQuery();

                        string retval = checkoutBook.Parameters[checkoutBook.Parameters.Count - 1].Value.ToString();
                        Console.WriteLine(checkoutBook.Parameters[checkoutBook.Parameters.Count - 2].Value.ToString());
                        if(retval == "0")
                        {
                            executionMessage.Text = "Failed";
                            executionMessage.ForeColor = Color.Red;
                        }
                        else
                        {
                            CreateDataTable(sqlConnection);
                            executionMessage.Text = "Success";
                            executionMessage.ForeColor = Color.Green;
                        }

                        sqlConnection.Close();
                    }
                }
            }
        }

        private void CreateDataTable(SqlConnection sqlConnection)
        {
            SqlCommand selectAllBooks = new SqlCommand($"Select FirstName, LastName, Email, TotalCheckouts From Clients where FirstName = @placeHolderFirstName and LastName = @placeHolderLastName", sqlConnection);
            selectAllBooks.Parameters.AddWithValue("@placeHolderFirstName", firstNameTextbox.Text);
            selectAllBooks.Parameters.AddWithValue("@placeHolderLastName", lastNameTextbox.Text);
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectAllBooks))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        public void ResetControl()
        {
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
            comboBox1.SelectedItem = null;
            errorProvider1.Clear();
        }
        private bool CheckInputs()
        {
            bool isValid = true;
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                if (!Checker.CheckStringValue(textbox, errorProvider1))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private void CheckInOutBook_Load(object sender, EventArgs e)
        {
            executionMessage.Text = string.Empty;
        }
    }
}
