using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Publisher { get; set; }
    public DateTime PublishDate { get; set; }
    public int Amount { get; set; }
    public string AuthorFirstName { get; set; } // Added
    public string AuthorLastName { get; set; } // Added
    public string GenreName { get; set; } // Added
}
