using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryApp
{
    public partial class RegisterNewClientUserControl : UserControl
    {
        public enum UserData
        {
            FirstName,
            LastName,
            Email,
            PhoneNumber,
            DateOfBirth,
            Address,
            ZipCode,
            State,
        }
        private Dictionary<UserData, TextBox> textBoxes;
        public RegisterNewClientUserControl()
        {

            InitializeComponent();
        }

        private void RegisterNewClientUserControl_Load(object sender, EventArgs e)
        {
            textBoxes = new Dictionary<UserData, TextBox>()
            {
                [UserData.FirstName] = FirstNameInputBox,
                [UserData.LastName] = LastNameInputBox,
                [UserData.Email] = EmailInputBox,
                [UserData.DateOfBirth] = DateOfBirthInputBox,
                [UserData.Address] = AddressInputBox,
                [UserData.ZipCode] = ZipCodeInputBox,
                [UserData.State] = StateInputBox,
                [UserData.PhoneNumber] = PhoneNumberInputBox,
            };
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void SubmitNewClient_Click(object sender, EventArgs e)
        {

            bool isValid = true;
            foreach (var textbox in textBoxes.Values)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    errorProvider1.SetError(textbox, "Invalid Input");
                    isValid = false;
                }
                else
                {
                    errorProvider1.SetError(textbox, string.Empty);
                }
            }

            if (isValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand addClient = sqlConnection.CreateCommand();
                    addClient.CommandType = CommandType.StoredProcedure;
                    addClient.CommandText = "AddClient";
                    foreach (var textbox in textBoxes)
                    {
                        addClient.Parameters.Add(new SqlParameter(textbox.Key.ToString(), textbox.Value.Text));
                    }

                    SqlCommand addMembership = sqlConnection.CreateCommand();
                    addMembership.CommandType = CommandType.StoredProcedure;
                    addMembership.CommandText = "CreateOrRenewMembership";
                    addMembership.Parameters.Add(new SqlParameter("ClientFirstName", textBoxes[UserData.FirstName].Text));
                    addMembership.Parameters.Add(new SqlParameter("ClientLastName", textBoxes[UserData.LastName].Text));
                    try
                    {
                        int rowsAffected = addClient.ExecuteNonQuery();
                        addMembership.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            SuccessLabel.Text = "Client was added";
                            SuccessLabel.ForeColor = Color.Green;
                        }
                        else
                        {
                            SuccessLabel.Text = "Client already exists";
                            SuccessLabel.ForeColor = Color.Red;
                        }
                    }
                    catch
                    {
                        SuccessLabel.Text = "Insert Failed";
                        SuccessLabel.ForeColor = Color.Red;
                    }

                    
                    //Console.WriteLine("Client was added");
                    sqlConnection.Close();
                }
            }

            //const string CONNECTION_STRING = @"Server=sussylaptop\sqlexpress;Database=exampledatabase;User Id=Tim;Password=SussyLaptop123;";

            //SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            //sqlConnection.Open();

            //SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "SELECT * FROM Clients";

            //DataTable dataTable = new DataTable();

            //SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            //adapter.Fill(dataTable);

            //sqlConnection.Close();

            ////dataGridView1.DataSource = dataTable;

            //var value = dataTable.Rows[7]["LastName"];

        }

        private void Return_Click(object sender, EventArgs e)
        {
            clear();
            Hide();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            foreach (var textbox in textBoxes)
            {
                textbox.Value.Text = "";
            }
            errorProvider1.Clear();
        }

        private void PhoneNumberInputBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;
            
            string number = string.Concat(textBox.Text.Where(char.IsDigit));
            
            if (number.Length <= 3)
                textBox.Text = number;
            else if (number.Length <= 6)
                textBox.Text = $"({number.Substring(0, 3)}) {number.Substring(3)}";
            else
                textBox.Text = $"({number.Substring(0, 3)}) {number.Substring(3, 3)}-{number.Substring(6)}";

            textBox.SelectionStart = textBox.Text.Length;
        }

        private void DateOfBirthInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
