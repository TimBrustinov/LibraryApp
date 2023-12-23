using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
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
            registerNewClientUserControl2.Hide();
        }

        private void registerNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerNewClientUserControl2.Show();
        }
    }
}
