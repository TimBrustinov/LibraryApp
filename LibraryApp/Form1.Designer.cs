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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckinBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchClientsDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInOutOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckinBookPanel = new System.Windows.Forms.Panel();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.CheckinBookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.catalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckinBookMenuItem,
            this.checkoutBookToolStripMenuItem,
            this.addNewBookToolStripMenuItem,
            this.removToolStripMenuItem,
            this.updateBookToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Books";
            // 
            // CheckinBookMenuItem
            // 
            this.CheckinBookMenuItem.Name = "CheckinBookMenuItem";
            this.CheckinBookMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CheckinBookMenuItem.Text = "Checkin Book";
            this.CheckinBookMenuItem.Click += new System.EventHandler(this.CheckinBookMenuItem_Click);
            // 
            // checkoutBookToolStripMenuItem
            // 
            this.checkoutBookToolStripMenuItem.Name = "checkoutBookToolStripMenuItem";
            this.checkoutBookToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.checkoutBookToolStripMenuItem.Text = "Checkout Book";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            // 
            // removToolStripMenuItem
            // 
            this.removToolStripMenuItem.Name = "removToolStripMenuItem";
            this.removToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removToolStripMenuItem.Text = "Remove Book";
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bookToolStripMenuItem.Text = "Book Availability";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewClientToolStripMenuItem,
            this.editClientInformationToolStripMenuItem,
            this.deleteClientProfileToolStripMenuItem,
            this.clientHistoryToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // registerNewClientToolStripMenuItem
            // 
            this.registerNewClientToolStripMenuItem.Name = "registerNewClientToolStripMenuItem";
            this.registerNewClientToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registerNewClientToolStripMenuItem.Text = "Register New Client";
            // 
            // editClientInformationToolStripMenuItem
            // 
            this.editClientInformationToolStripMenuItem.Name = "editClientInformationToolStripMenuItem";
            this.editClientInformationToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editClientInformationToolStripMenuItem.Text = "Edit Client Information";
            // 
            // deleteClientProfileToolStripMenuItem
            // 
            this.deleteClientProfileToolStripMenuItem.Name = "deleteClientProfileToolStripMenuItem";
            this.deleteClientProfileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteClientProfileToolStripMenuItem.Text = "Delete Client Profile";
            // 
            // clientHistoryToolStripMenuItem
            // 
            this.clientHistoryToolStripMenuItem.Name = "clientHistoryToolStripMenuItem";
            this.clientHistoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clientHistoryToolStripMenuItem.Text = "Client History";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchClientsDatabaseToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.catalogToolStripMenuItem.Text = "Catalog";
            // 
            // searchClientsDatabaseToolStripMenuItem
            // 
            this.searchClientsDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem1,
            this.booksToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.checkInOutOverviewToolStripMenuItem});
            this.searchClientsDatabaseToolStripMenuItem.Name = "searchClientsDatabaseToolStripMenuItem";
            this.searchClientsDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.searchClientsDatabaseToolStripMenuItem.Text = "Search Database";
            // 
            // clientsToolStripMenuItem1
            // 
            this.clientsToolStripMenuItem1.Name = "clientsToolStripMenuItem1";
            this.clientsToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.clientsToolStripMenuItem1.Text = "Clients";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // checkInOutOverviewToolStripMenuItem
            // 
            this.checkInOutOverviewToolStripMenuItem.Name = "checkInOutOverviewToolStripMenuItem";
            this.checkInOutOverviewToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.checkInOutOverviewToolStripMenuItem.Text = "Check-In/Out Overview";
            // 
            // CheckinBookPanel
            // 
            this.CheckinBookPanel.Controls.Add(this.textBox3);
            this.CheckinBookPanel.Controls.Add(this.EmailAddress);
            this.CheckinBookPanel.Controls.Add(this.textBox2);
            this.CheckinBookPanel.Controls.Add(this.LastName);
            this.CheckinBookPanel.Controls.Add(this.textBox1);
            this.CheckinBookPanel.Controls.Add(this.FirstName);
            this.CheckinBookPanel.Location = new System.Drawing.Point(0, 27);
            this.CheckinBookPanel.Name = "CheckinBookPanel";
            this.CheckinBookPanel.Size = new System.Drawing.Size(1002, 522);
            this.CheckinBookPanel.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(12, 56);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 18);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(335, 53);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 18);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddress.Location = new System.Drawing.Point(12, 91);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(103, 18);
            this.EmailAddress.TabIndex = 4;
            this.EmailAddress.Text = "Email Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 551);
            this.Controls.Add(this.CheckinBookPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CheckinBookPanel.ResumeLayout(false);
            this.CheckinBookPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckinBookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientsDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInOutOverviewToolStripMenuItem;
        private System.Windows.Forms.Panel CheckinBookPanel;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.TextBox textBox2;
    }
}

