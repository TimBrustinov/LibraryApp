namespace LibraryApp.UserControls
{
    partial class UpdateBookControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.bookTitleTextbox = new System.Windows.Forms.TextBox();
            this.findBookPanel = new System.Windows.Forms.Panel();
            this.findBookButton = new System.Windows.Forms.Button();
            this.executionMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.removeAuthorButton1 = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.Label();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.genreTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.addAuthorHelperControl4 = new LibraryApp.AddAuthorHelperControl();
            this.addAuthorHelperControl3 = new LibraryApp.AddAuthorHelperControl();
            this.addAuthorHelperControl2 = new LibraryApp.AddAuthorHelperControl();
            this.addAuthorHelperControl1 = new LibraryApp.AddAuthorHelperControl();
            this.button1 = new System.Windows.Forms.Button();
            this.findBookPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(3, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 16);
            this.title.TabIndex = 19;
            this.title.Text = "Book Title";
            // 
            // bookTitleTextbox
            // 
            this.bookTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextbox.Location = new System.Drawing.Point(75, 41);
            this.bookTitleTextbox.Name = "bookTitleTextbox";
            this.bookTitleTextbox.Size = new System.Drawing.Size(142, 21);
            this.bookTitleTextbox.TabIndex = 18;
            // 
            // findBookPanel
            // 
            this.findBookPanel.Controls.Add(this.findBookButton);
            this.findBookPanel.Controls.Add(this.executionMessage);
            this.findBookPanel.Controls.Add(this.title);
            this.findBookPanel.Controls.Add(this.bookTitleTextbox);
            this.findBookPanel.Location = new System.Drawing.Point(3, 3);
            this.findBookPanel.Name = "findBookPanel";
            this.findBookPanel.Size = new System.Drawing.Size(290, 111);
            this.findBookPanel.TabIndex = 20;
            // 
            // findBookButton
            // 
            this.findBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.findBookButton.Location = new System.Drawing.Point(6, 68);
            this.findBookButton.Name = "findBookButton";
            this.findBookButton.Size = new System.Drawing.Size(86, 28);
            this.findBookButton.TabIndex = 35;
            this.findBookButton.Text = "Find Book";
            this.findBookButton.UseVisualStyleBackColor = true;
            this.findBookButton.Click += new System.EventHandler(this.findBookButton_Click);
            // 
            // executionMessage
            // 
            this.executionMessage.AutoSize = true;
            this.executionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.executionMessage.Location = new System.Drawing.Point(3, 10);
            this.executionMessage.Name = "executionMessage";
            this.executionMessage.Size = new System.Drawing.Size(132, 18);
            this.executionMessage.TabIndex = 34;
            this.executionMessage.Text = "executionMessage";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.addAuthorButton);
            this.panel2.Controls.Add(this.addAuthorHelperControl4);
            this.panel2.Controls.Add(this.addAuthorHelperControl3);
            this.panel2.Controls.Add(this.addAuthorHelperControl2);
            this.panel2.Controls.Add(this.removeAuthorButton1);
            this.panel2.Controls.Add(this.addAuthorHelperControl1);
            this.panel2.Controls.Add(this.ISBN);
            this.panel2.Controls.Add(this.isbnTextbox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.genreTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.amountTextbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.publisherTextbox);
            this.panel2.Location = new System.Drawing.Point(3, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 494);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addAuthorButton.Location = new System.Drawing.Point(254, 5);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(89, 26);
            this.addAuthorButton.TabIndex = 56;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // removeAuthorButton1
            // 
            this.removeAuthorButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAuthorButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAuthorButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeAuthorButton1.Location = new System.Drawing.Point(362, 5);
            this.removeAuthorButton1.Name = "removeAuthorButton1";
            this.removeAuthorButton1.Size = new System.Drawing.Size(119, 26);
            this.removeAuthorButton1.TabIndex = 49;
            this.removeAuthorButton1.Text = "Remove Author";
            this.removeAuthorButton1.UseVisualStyleBackColor = true;
            this.removeAuthorButton1.Click += new System.EventHandler(this.removeAuthorButton1_Click);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.ForeColor = System.Drawing.Color.Gainsboro;
            this.ISBN.Location = new System.Drawing.Point(3, 37);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(38, 16);
            this.ISBN.TabIndex = 45;
            this.ISBN.Text = "ISBN";
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextbox.Location = new System.Drawing.Point(47, 34);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(170, 21);
            this.isbnTextbox.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Genre";
            // 
            // genreTextbox
            // 
            this.genreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTextbox.Location = new System.Drawing.Point(63, 87);
            this.genreTextbox.Name = "genreTextbox";
            this.genreTextbox.Size = new System.Drawing.Size(83, 21);
            this.genreTextbox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(4, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Amount";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextbox.Location = new System.Drawing.Point(62, 117);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(31, 21);
            this.amountTextbox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Publish Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Publisher";
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextbox.Location = new System.Drawing.Point(75, 7);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(142, 21);
            this.publisherTextbox.TabIndex = 34;
            // 
            // addAuthorHelperControl4
            // 
            this.addAuthorHelperControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.addAuthorHelperControl4.Location = new System.Drawing.Point(250, 160);
            this.addAuthorHelperControl4.Name = "addAuthorHelperControl4";
            this.addAuthorHelperControl4.Size = new System.Drawing.Size(489, 35);
            this.addAuthorHelperControl4.TabIndex = 54;
            // 
            // addAuthorHelperControl3
            // 
            this.addAuthorHelperControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.addAuthorHelperControl3.Location = new System.Drawing.Point(250, 119);
            this.addAuthorHelperControl3.Name = "addAuthorHelperControl3";
            this.addAuthorHelperControl3.Size = new System.Drawing.Size(489, 35);
            this.addAuthorHelperControl3.TabIndex = 52;
            // 
            // addAuthorHelperControl2
            // 
            this.addAuthorHelperControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.addAuthorHelperControl2.Location = new System.Drawing.Point(250, 78);
            this.addAuthorHelperControl2.Name = "addAuthorHelperControl2";
            this.addAuthorHelperControl2.Size = new System.Drawing.Size(489, 35);
            this.addAuthorHelperControl2.TabIndex = 50;
            // 
            // addAuthorHelperControl1
            // 
            this.addAuthorHelperControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.addAuthorHelperControl1.Location = new System.Drawing.Point(250, 37);
            this.addAuthorHelperControl1.Name = "addAuthorHelperControl1";
            this.addAuthorHelperControl1.Size = new System.Drawing.Size(489, 35);
            this.addAuthorHelperControl1.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(2, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 48);
            this.button1.TabIndex = 57;
            this.button1.Text = "Edit Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.findBookPanel);
            this.Name = "UpdateBookControl";
            this.Size = new System.Drawing.Size(976, 643);
            this.Load += new System.EventHandler(this.UpdateBookControl_Load);
            this.findBookPanel.ResumeLayout(false);
            this.findBookPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox bookTitleTextbox;
        private System.Windows.Forms.Panel findBookPanel;
        private System.Windows.Forms.Label executionMessage;
        private System.Windows.Forms.Button findBookButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genreTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publisherTextbox;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox isbnTextbox;
        private AddAuthorHelperControl addAuthorHelperControl1;
        private AddAuthorHelperControl addAuthorHelperControl4;
        private AddAuthorHelperControl addAuthorHelperControl3;
        private AddAuthorHelperControl addAuthorHelperControl2;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button removeAuthorButton1;
        private System.Windows.Forms.Button button1;
    }
}
