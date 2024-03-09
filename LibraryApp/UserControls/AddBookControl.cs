using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LibraryApp.UserControls
{
    public partial class AddBookControl : UserControl
    {
        private int maximumAuthors = 4;
        private Point originalAddAuthorControlPosition;
        private Point addAuthorControlPosition;
        private List<AddAuthorHelperControl> authors = new List<AddAuthorHelperControl>();
        private List<TextBox> textBoxes = new List<TextBox>();

        public AddBookControl()
        {
            InitializeComponent();
        }
        private void AddBookControl_Load(object sender, EventArgs e)
        {
            addAuthorControlPosition = new Point(addAuthorButton.Location.X, addAuthorButton.Bounds.Bottom + 20);
            originalAddAuthorControlPosition = addAuthorControlPosition;
            executionMessage.Text = string.Empty;
            textBoxes.Add(bookTitleTextbox);
            textBoxes.Add(publisherTextbox);
            textBoxes.Add(genreTextbox);
            CreateAuthorControl();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            CreateAuthorControl();   
        }
        private void CreateAuthorControl()
        {
            if (authors.Count < maximumAuthors)
            {
                AddAuthorHelperControl addAuthorHelperControl = new AddAuthorHelperControl();
                addAuthorHelperControl.Location = addAuthorControlPosition;
                addAuthorControlPosition.Y = addAuthorHelperControl.Bounds.Bottom;
                Controls.Add(addAuthorHelperControl);
                authors.Add(addAuthorHelperControl);
                addAuthorHelperControl.Show();
            }
        }

        private void submitForm_Click(object sender, EventArgs e)
        {
            bool validInputs = CheckInputs() && CheckAuthors();
            if (validInputs)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand addBook = sqlConnection.CreateCommand();
                    string insertedBookId = "";
                    addBook.CommandType = CommandType.StoredProcedure;
                    addBook.CommandText = "TryAddBook";
                    SqlDataReader sqlDataReader = null;
                    //SqlParameter returnValue = new SqlParameter();
                    //returnValue.Direction = ParameterDirection.ReturnValue;
                    //SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                    //{
                    //    Direction = ParameterDirection.Output
                    //};


                    addBook.Parameters.Add(new SqlParameter("Title", bookTitleTextbox.Text));
                    addBook.Parameters.Add(new SqlParameter("ISBN", isbnTextbox.Text));
                    addBook.Parameters.Add(new SqlParameter("Publisher", publisherTextbox.Text));
                    addBook.Parameters.Add(new SqlParameter("PublishDate", dateTimePicker1.Value));
                    addBook.Parameters.Add(new SqlParameter("Amount", amountTextbox.Text));
                    sqlDataReader = addBook.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader[1].ToString());
                        insertedBookId = sqlDataReader[0].ToString();
                    }
                    sqlDataReader.Close();
                    //string retval = addBook.Parameters[addBook.Parameters.Count - 1].Value.ToString();
                    //Console.WriteLine(addBook.Parameters[addBook.Parameters.Count - 2].Value.ToString());
                    if (insertedBookId != "-1")
                    {
                        LinkAuthors(sqlConnection, insertedBookId);
                        LinkGenre(sqlConnection, insertedBookId);
                        executionMessage.Text = "Success";
                        executionMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        executionMessage.Text = "Failed";
                        executionMessage.ForeColor = System.Drawing.Color.Red;
                    }

                    sqlConnection.Close();
                }
            }
        }

        private void LinkAuthors(SqlConnection sqlConnection, string bookID)
        {
            foreach (var author in authors)
            {
                SqlCommand linkBookToAuthor = sqlConnection.CreateCommand();
                linkBookToAuthor.CommandType = CommandType.StoredProcedure;
                linkBookToAuthor.CommandText = "LinkBookToAuthor";
                SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                {
                    Direction = ParameterDirection.Output
                };

                linkBookToAuthor.Parameters.Add(new SqlParameter("BookID", bookID));
                linkBookToAuthor.Parameters.Add(new SqlParameter("AuthorFirstName", author.AuthorFirstName));
                linkBookToAuthor.Parameters.Add(new SqlParameter("AuthorLastName", author.AuthorLastName));
                linkBookToAuthor.Parameters.Add(errorMessageParam);
                linkBookToAuthor.ExecuteNonQuery();

                Console.WriteLine(linkBookToAuthor.Parameters[linkBookToAuthor.Parameters.Count - 1].Value.ToString());   
            }
        }

        private void LinkGenre(SqlConnection sqlConnection, string bookID)
        {
            SqlCommand linkBookToGenre = sqlConnection.CreateCommand();
            linkBookToGenre.CommandType = CommandType.StoredProcedure;
            linkBookToGenre.CommandText = "LinkBookToGenre";
            SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
            {
                Direction = ParameterDirection.Output
            };

            linkBookToGenre.Parameters.Add(new SqlParameter("BookID", bookID));
            linkBookToGenre.Parameters.Add(new SqlParameter("GenreName", genreTextbox.Text));
            linkBookToGenre.Parameters.Add(errorMessageParam);
            linkBookToGenre.ExecuteNonQuery();
            Console.WriteLine(linkBookToGenre.Parameters[linkBookToGenre.Parameters.Count - 1].Value.ToString());
        }

        private bool CheckAuthors()
        {
            bool isTrue = true;
            foreach (var author in authors)
            {
                if(!author.CheckInputs())
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
        private bool CheckInputs()
        {
            bool isValid = true;
            foreach (var textbox in textBoxes)
            {
                if(!Checker.CheckStringValue(textbox, errorProvider1))
                {
                    isValid = false;
                }
            }

            if (!Checker.CheckIntegerValue(isbnTextbox, errorProvider1) && isbnTextbox.Text.Length < 10)
            {
                isValid = false;
            }
            
            if (!Checker.CheckIntegerValue(amountTextbox, errorProvider1))
            {
                isValid = false;
            }
            return isValid;
        }

        public void ResetControl()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            foreach (var author in authors)
            {
                foreach (var textBox in author.Controls.OfType<TextBox>())
                {
                    textBox.Clear();
                }
                author.AuthorFirstName = string.Empty;
                author.AuthorLastName = string.Empty;
            }
            authors.Clear();
            addAuthorControlPosition = originalAddAuthorControlPosition;
        }
    }

    public class Entry
    {
        public string Title;
        public string ISBN;
        public string Publisher;
        public SqlDateTime PublishDate;
        public int Amount;
        public string AuthorFirstName;
        public string AuthorLastName;
        public string Genre;

    }
}
