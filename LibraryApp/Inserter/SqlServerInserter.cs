using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class SqlServerInserter
{
    public void InsertBooks(List<Book> books)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
        using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        {
            sqlConnection.Open();

            foreach (var book in books)
            {
                string insertedBookId = "";
                using (SqlCommand addBook = sqlConnection.CreateCommand())
                {
                    addBook.CommandType = CommandType.StoredProcedure;
                    addBook.CommandText = "TryAddBook";

                    // Add parameters from book object
                    addBook.Parameters.Add(new SqlParameter("Title", book.Title));
                    addBook.Parameters.Add(new SqlParameter("ISBN", book.ISBN));
                    addBook.Parameters.Add(new SqlParameter("Publisher", book.Publisher));
                    addBook.Parameters.Add(new SqlParameter("PublishDate", book.PublishDate));
                    addBook.Parameters.Add(new SqlParameter("Amount", book.Amount));

                    using (SqlDataReader sqlDataReader = addBook.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            insertedBookId = sqlDataReader[0].ToString();
                        }
                    }
                }

                // Check the result and proceed with linking authors if successful
                if (!string.IsNullOrEmpty(insertedBookId) && insertedBookId != "-1")
                {
                    // Insert the author and link to the book
                    using (SqlCommand linkBookToAuthor = sqlConnection.CreateCommand())
                    {
                        linkBookToAuthor.CommandType = CommandType.StoredProcedure;
                        linkBookToAuthor.CommandText = "LinkBookToAuthor";
                        SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                        {
                            Direction = ParameterDirection.Output
                        };

                        linkBookToAuthor.Parameters.Add(new SqlParameter("BookID", insertedBookId));
                        linkBookToAuthor.Parameters.Add(new SqlParameter("AuthorFirstName", book.AuthorFirstName));
                        linkBookToAuthor.Parameters.Add(new SqlParameter("AuthorLastName", book.AuthorLastName));
                        linkBookToAuthor.Parameters.Add(errorMessageParam);
                        linkBookToAuthor.ExecuteNonQuery();

                        var errorMessage = errorMessageParam.Value.ToString();
                        if (!string.IsNullOrEmpty(errorMessage))
                        {
                            Console.WriteLine($"Error linking author to book ({book.AuthorFirstName} {book.AuthorLastName} and {book.Title}): {errorMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"Author linked successfully to book ID ({book.AuthorFirstName} {book.AuthorLastName} and {book.Title}): " + insertedBookId);
                        }
                    }

                    using (SqlCommand linkBookToGenre = sqlConnection.CreateCommand())
                    {
                        linkBookToGenre.CommandType = CommandType.StoredProcedure;
                        linkBookToGenre.CommandText = "LinkBookToGenre";
                        SqlParameter errorMessageParam = new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 4000)
                        {
                            Direction = ParameterDirection.Output
                        };

                        linkBookToGenre.Parameters.Add(new SqlParameter("BookID", insertedBookId));
                        linkBookToGenre.Parameters.Add(new SqlParameter("GenreName", book.GenreName));
                        linkBookToGenre.Parameters.Add(errorMessageParam);
                        linkBookToGenre.ExecuteNonQuery();

                        var errorMessage = errorMessageParam.Value.ToString();
                        if (!string.IsNullOrEmpty(errorMessage))
                        {
                            Console.WriteLine($"Error linking genre to book ({book.GenreName} and {book.Title}): {errorMessage}");
                        }
                        else
                        {
                            Console.WriteLine($"Genre linked successfully to book ID ({book.GenreName} and {book.Title}): " + insertedBookId);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failed to insert book: " + book.Title);
                }
            }
            sqlConnection.Close();
        }
    }
}
