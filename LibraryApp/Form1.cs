using LibraryApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private bool isBookPanelCollapsed = true;
        private bool isClientPanelCollapsed = true;
        private bool isDatabasePanelCollapsed = true;


        enum ControlType
        {
            CheckInOutBookControl,
            AddBookControl,
            RemoveBookControl,
            UpdateBookControl,
        }

        private Dictionary<ControlType, Control> ControlTypeToControls = new Dictionary<ControlType, Control>();


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
            bookPanel.Size = bookPanel.MinimumSize;
        }

        private void bookDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isBookPanelCollapsed)
            {
                bookPanel.Height += 10;
                if (bookPanel.Size == bookPanel.MaximumSize)
                {
                    bookDropDownTimer.Stop();
                    isBookPanelCollapsed = false;
                }
            }
            else
            {
                bookPanel.Height -= 10;
                if (bookPanel.Size == bookPanel.MinimumSize)
                {
                    bookDropDownTimer.Stop();
                    isBookPanelCollapsed = true;
                }
            }
        }

        private void Books_Click(object sender, EventArgs e)
        {
            bookDropDownTimer.Start();
        }

        private void checkinBookButton_Click(object sender, EventArgs e)
        {
            clearControls();
            CheckInOutBook checkInOutBook;
            selectedTab.Text = "Check-In/Out Book";
            selectedTab.IconChar = Books.IconChar;
            if (ControlTypeToControls.ContainsKey(ControlType.CheckInOutBookControl))
            {
                checkInOutBook = (CheckInOutBook)ControlTypeToControls[ControlType.CheckInOutBookControl];
                checkInOutBook.ResetControl();
            }
            else
            {
                checkInOutBook = new CheckInOutBook();
                ControlTypeToControls.Add(ControlType.CheckInOutBookControl, checkInOutBook);
                this.Controls.Add(checkInOutBook);
            }

            checkInOutBook.Location = new Point(flowLayoutPanel1.Bounds.Right, flowLayoutPanel2.Bounds.Bottom + 20);

            checkInOutBook.Show();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            clearControls();
            AddBookControl addBookControl;
            selectedTab.Text = "Add Book";
            selectedTab.IconChar = Books.IconChar;
            if (ControlTypeToControls.ContainsKey(ControlType.AddBookControl))
            {
                addBookControl = (AddBookControl)ControlTypeToControls[ControlType.AddBookControl];
                addBookControl.ResetControl();
            }
            else
            {
                addBookControl = new AddBookControl();
                ControlTypeToControls.Add(ControlType.AddBookControl, addBookControl);
                this.Controls.Add(addBookControl);
            }
            addBookControl.Location = new Point(flowLayoutPanel1.Bounds.Right, flowLayoutPanel2.Bounds.Bottom + 20);
            addBookControl.Show();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            clearControls();
            RemoveBookUserControl removeBookControl;
            selectedTab.Text = "Remove Book";
            selectedTab.IconChar = Books.IconChar;
            if (ControlTypeToControls.ContainsKey(ControlType.RemoveBookControl))
            {
                removeBookControl = (RemoveBookUserControl)ControlTypeToControls[ControlType.RemoveBookControl];
                removeBookControl.ResetControl();
            }
            else
            {
                removeBookControl = new RemoveBookUserControl();
                ControlTypeToControls.Add(ControlType.RemoveBookControl, removeBookControl);
                this.Controls.Add(removeBookControl);
            }
            removeBookControl.Location = new Point(flowLayoutPanel1.Bounds.Right, flowLayoutPanel2.Bounds.Bottom + 20);
            removeBookControl.Show();
        }
        private void clearControls()
        {
            foreach (var control in ControlTypeToControls.Values)
            {
                control.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>
            {
            new Book { Title = "1984", ISBN = "9780451524935", Publisher = "Secker & Warburg", PublishDate = new DateTime(1949, 6, 8), Amount = 1, AuthorFirstName = "George", AuthorLastName = "Orwell", GenreName = "Dystopian" },
            new Book { Title = "To Kill a Mockingbird", ISBN = "9780061120084", Publisher = "J. B. Lippincott & Co.", PublishDate = new DateTime(1960, 7, 11), Amount = 1, AuthorFirstName = "Harper", AuthorLastName = "Lee", GenreName = "Southern Gothic" },
            new Book { Title = "The Great Gatsby", ISBN = "9780743273565", Publisher = "Charles Scribner's Sons", PublishDate = new DateTime(1925, 4, 10), Amount = 1, AuthorFirstName = "F. Scott", AuthorLastName = "Fitzgerald", GenreName = "Tragedy" },
            new Book { Title = "Pride and Prejudice", ISBN = "9781503290563", Publisher = "T. Egerton, Whitehall", PublishDate = new DateTime(1813, 1, 28), Amount = 1, AuthorFirstName = "Jane", AuthorLastName = "Austen", GenreName = "Classic Regency Novel" },
            new Book { Title = "The Hobbit", ISBN = "9780547928227", Publisher = "George Allen & Unwin", PublishDate = new DateTime(1937, 9, 21), Amount = 1, AuthorFirstName = "J.R.R.", AuthorLastName = "Tolkien", GenreName = "Fantasy" },
            new Book { Title = "Harry Potter and the Philosopher's Stone", ISBN = "9780747532743", Publisher = "Bloomsbury", PublishDate = new DateTime(1997, 6, 26), Amount = 1, AuthorFirstName = "J.K.", AuthorLastName = "Rowling", GenreName = "Fantasy" },
            new Book { Title = "The Catcher in the Rye", ISBN = "9780316769488", Publisher = "Little, Brown and Company", PublishDate = new DateTime(1951, 7, 16), Amount = 1, AuthorFirstName = "J.D.", AuthorLastName = "Salinger", GenreName = "Realistic Fiction" },
            new Book { Title = "The Chronicles of Narnia", ISBN = "9780066238500", Publisher = "Geoffrey Bles", PublishDate = new DateTime(1950, 10, 16), Amount = 1, AuthorFirstName = "C.S.", AuthorLastName = "Lewis", GenreName = "Fantasy" },
            new Book { Title = "Moby Dick", ISBN = "9781503280786", Publisher = "Richard Bentley", PublishDate = new DateTime(1851, 10, 18), Amount = 1, AuthorFirstName = "Herman", AuthorLastName = "Melville", GenreName = "Adventure Fiction" },
            new Book { Title = "War and Peace", ISBN = "9780199232765", Publisher = "The Russian Messenger", PublishDate = new DateTime(1869, 1, 1), Amount = 1, AuthorFirstName = "Leo", AuthorLastName = "Tolstoy", GenreName = "Historical Fiction" }
            };

            // Instantiate the BookInserter
            SqlServerInserter bookInserter = new SqlServerInserter();

            // Insert the books into the database
            bookInserter.InsertBooks(books);

            List<Book> moreBooks = new List<Book>
        {
            new Book { Title = "Brave New World", ISBN = "9780060850524", Publisher = "Chatto & Windus", PublishDate = new DateTime(1932, 1, 1), Amount = 1, AuthorFirstName = "Aldous", AuthorLastName = "Huxley", GenreName = "Dystopian" },
            new Book { Title = "The Catcher in the Rye", ISBN = "9780316769488", Publisher = "Little, Brown and Company", PublishDate = new DateTime(1951, 7, 16), Amount = 1, AuthorFirstName = "J.D.", AuthorLastName = "Salinger", GenreName = "Fiction" },
            new Book { Title = "The Great Gatsby", ISBN = "9780743273565", Publisher = "Charles Scribner's Sons", PublishDate = new DateTime(1925, 4, 10), Amount = 1, AuthorFirstName = "F. Scott", AuthorLastName = "Fitzgerald", GenreName = "Fiction" },
            new Book { Title = "Moby-Dick", ISBN = "9781503280786", Publisher = "Richard Bentley", PublishDate = new DateTime(1851, 10, 18), Amount = 1, AuthorFirstName = "Herman", AuthorLastName = "Melville", GenreName = "Adventure" },
            new Book { Title = "War and Peace", ISBN = "9780199232765", Publisher = "The Russian Messenger", PublishDate = new DateTime(1869, 1, 1), Amount = 1, AuthorFirstName = "Leo", AuthorLastName = "Tolstoy", GenreName = "Historical Fiction" },
            new Book { Title = "One Hundred Years of Solitude", ISBN = "9780060883287", Publisher = "Harper & Row", PublishDate = new DateTime(1967, 6, 5), Amount = 1, AuthorFirstName = "Gabriel García", AuthorLastName = "Márquez", GenreName = "Magical Realism" },
            new Book { Title = "The Lord of the Rings", ISBN = "9780544003415", Publisher = "Allen & Unwin", PublishDate = new DateTime(1954, 7, 29), Amount = 1, AuthorFirstName = "J.R.R.", AuthorLastName = "Tolkien", GenreName = "Fantasy" },
            new Book { Title = "The Grapes of Wrath", ISBN = "9780143039433", Publisher = "The Viking Press-James Lloyd", PublishDate = new DateTime(1939, 4, 14), Amount = 1, AuthorFirstName = "John", AuthorLastName = "Steinbeck", GenreName = "Historical Fiction" },
            new Book { Title = "1984", ISBN = "9780451524935", Publisher = "Secker & Warburg", PublishDate = new DateTime(1949, 6, 8), Amount = 1, AuthorFirstName = "George", AuthorLastName = "Orwell", GenreName = "Dystopian" },
            new Book { Title = "The Diary of a Young Girl", ISBN = "9780553296983", Publisher = "Contact Publishing", PublishDate = new DateTime(1947, 6, 25), Amount = 1, AuthorFirstName = "Anne", AuthorLastName = "Frank", GenreName = "Biography" }
        };

            // Assuming BookInserter and its InsertBooks method are defined as previously discussed
            bookInserter.InsertBooks(moreBooks);
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            clearControls();
            UpdateBookControl updateBookControl;
            selectedTab.Text = "Update Book";
            selectedTab.IconChar = Books.IconChar;
            if(ControlTypeToControls.ContainsKey(ControlType.UpdateBookControl))
            {
                updateBookControl = (UpdateBookControl)ControlTypeToControls[ControlType.UpdateBookControl];
            }
            else
            {
                updateBookControl = new UpdateBookControl();
                ControlTypeToControls.Add(ControlType.UpdateBookControl, updateBookControl);
                this.Controls.Add(updateBookControl);
            }
            updateBookControl.Location = new Point(flowLayoutPanel1.Bounds.Right, flowLayoutPanel2.Bounds.Bottom + 20);
            updateBookControl.Show();
        }
    }
}
