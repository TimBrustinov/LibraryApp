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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.registerNewClientUserControl1 = new LibraryApp.RegisterNewClientUserControl();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerNewClientUserControl2 = new LibraryApp.RegisterNewClientUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // registerNewClientUserControl1
            // 
            this.registerNewClientUserControl1.Location = new System.Drawing.Point(0, 0);
            this.registerNewClientUserControl1.Name = "registerNewClientUserControl1";
            this.registerNewClientUserControl1.Size = new System.Drawing.Size(1002, 341);
            this.registerNewClientUserControl1.TabIndex = 2;
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
            this.registerNewClientToolStripMenuItem.Click += new System.EventHandler(this.registerNewClientToolStripMenuItem_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.catalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerNewClientUserControl2
            // 
            this.registerNewClientUserControl2.Location = new System.Drawing.Point(0, 77);
            this.registerNewClientUserControl2.Name = "registerNewClientUserControl2";
            this.registerNewClientUserControl2.Size = new System.Drawing.Size(989, 341);
            this.registerNewClientUserControl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.registerNewClientUserControl2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RegisterNewClientUserControl registerNewClientUserControl1;
        private RegisterNewClientUserControl registerNewClientUserControl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckinBookMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchClientsDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInOutOverviewToolStripMenuItem;
    }
}

