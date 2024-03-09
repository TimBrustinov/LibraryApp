namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.checkinBookButton = new System.Windows.Forms.Button();
            this.bookDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.selectedTab = new FontAwesome.Sharp.IconButton();
            this.Clients = new FontAwesome.Sharp.IconButton();
            this.Books = new FontAwesome.Sharp.IconButton();
            this.Database = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.flowLayoutPanel1.Controls.Add(this.Clients);
            this.flowLayoutPanel1.Controls.Add(this.bookPanel);
            this.flowLayoutPanel1.Controls.Add(this.Database);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 714);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bookPanel
            // 
            this.bookPanel.Controls.Add(this.updateBookButton);
            this.bookPanel.Controls.Add(this.removeBookButton);
            this.bookPanel.Controls.Add(this.addBookButton);
            this.bookPanel.Controls.Add(this.checkinBookButton);
            this.bookPanel.Controls.Add(this.Books);
            this.bookPanel.Location = new System.Drawing.Point(3, 69);
            this.bookPanel.MaximumSize = new System.Drawing.Size(199, 195);
            this.bookPanel.MinimumSize = new System.Drawing.Size(199, 60);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(199, 194);
            this.bookPanel.TabIndex = 3;
            // 
            // removeBookButton
            // 
            this.removeBookButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeBookButton.FlatAppearance.BorderSize = 0;
            this.removeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeBookButton.Location = new System.Drawing.Point(0, 126);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(199, 33);
            this.removeBookButton.TabIndex = 5;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeBookButton.UseVisualStyleBackColor = false;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addBookButton.Location = new System.Drawing.Point(0, 93);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(199, 33);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Add New Book";
            this.addBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // checkinBookButton
            // 
            this.checkinBookButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.checkinBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkinBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkinBookButton.FlatAppearance.BorderSize = 0;
            this.checkinBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkinBookButton.Location = new System.Drawing.Point(0, 60);
            this.checkinBookButton.Name = "checkinBookButton";
            this.checkinBookButton.Size = new System.Drawing.Size(199, 33);
            this.checkinBookButton.TabIndex = 3;
            this.checkinBookButton.Text = "Check-In/Out Book";
            this.checkinBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBookButton.UseVisualStyleBackColor = false;
            this.checkinBookButton.Click += new System.EventHandler(this.checkinBookButton_Click);
            // 
            // bookDropDownTimer
            // 
            this.bookDropDownTimer.Interval = 15;
            this.bookDropDownTimer.Tick += new System.EventHandler(this.bookDropDownTimer_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel2.Controls.Add(this.selectedTab);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(204, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 63);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // updateBookButton
            // 
            this.updateBookButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateBookButton.FlatAppearance.BorderSize = 0;
            this.updateBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateBookButton.Location = new System.Drawing.Point(0, 159);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(199, 35);
            this.updateBookButton.TabIndex = 6;
            this.updateBookButton.Text = "Update Book";
            this.updateBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBookButton.UseVisualStyleBackColor = false;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // selectedTab
            // 
            this.selectedTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectedTab.FlatAppearance.BorderSize = 0;
            this.selectedTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTab.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectedTab.IconChar = FontAwesome.Sharp.IconChar.None;
            this.selectedTab.IconColor = System.Drawing.Color.Gainsboro;
            this.selectedTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.selectedTab.IconSize = 32;
            this.selectedTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectedTab.Location = new System.Drawing.Point(3, 3);
            this.selectedTab.Name = "selectedTab";
            this.selectedTab.Size = new System.Drawing.Size(162, 60);
            this.selectedTab.TabIndex = 3;
            this.selectedTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectedTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectedTab.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clients.FlatAppearance.BorderSize = 0;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.ForeColor = System.Drawing.Color.Gainsboro;
            this.Clients.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.Clients.IconColor = System.Drawing.Color.Gainsboro;
            this.Clients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clients.IconSize = 32;
            this.Clients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clients.Location = new System.Drawing.Point(3, 3);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(195, 60);
            this.Clients.TabIndex = 3;
            this.Clients.Text = "Clients";
            this.Clients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.Books.Dock = System.Windows.Forms.DockStyle.Top;
            this.Books.FlatAppearance.BorderSize = 0;
            this.Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Books.ForeColor = System.Drawing.Color.Gainsboro;
            this.Books.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Books.IconColor = System.Drawing.Color.Gainsboro;
            this.Books.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Books.IconSize = 32;
            this.Books.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Books.Location = new System.Drawing.Point(0, 0);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(199, 60);
            this.Books.TabIndex = 2;
            this.Books.Text = "Books";
            this.Books.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Books.UseVisualStyleBackColor = false;
            this.Books.Click += new System.EventHandler(this.Books_Click);
            // 
            // Database
            // 
            this.Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.Database.FlatAppearance.BorderSize = 0;
            this.Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Database.ForeColor = System.Drawing.Color.Gainsboro;
            this.Database.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.Database.IconColor = System.Drawing.Color.Gainsboro;
            this.Database.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Database.IconSize = 32;
            this.Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Database.Location = new System.Drawing.Point(3, 269);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(195, 60);
            this.Database.TabIndex = 4;
            this.Database.Text = "Database";
            this.Database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Database.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1104, 714);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bookPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton Books;
        private FontAwesome.Sharp.IconButton Clients;
        private FontAwesome.Sharp.IconButton Database;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button checkinBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Timer bookDropDownTimer;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton selectedTab;
        private System.Windows.Forms.Button updateBookButton;
    }
}

