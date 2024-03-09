namespace LibraryApp.UserControls
{
    partial class AddBookControl
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
            this.components = new System.ComponentModel.Container();
            this.lastName = new System.Windows.Forms.Label();
            this.bookTitleTextbox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.publisherTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBN = new System.Windows.Forms.Label();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.submitForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.genreTextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.executionMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lastName.Location = new System.Drawing.Point(3, 37);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(0, 16);
            this.lastName.TabIndex = 15;
            // 
            // bookTitleTextbox
            // 
            this.bookTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextbox.Location = new System.Drawing.Point(79, 43);
            this.bookTitleTextbox.Name = "bookTitleTextbox";
            this.bookTitleTextbox.Size = new System.Drawing.Size(142, 21);
            this.bookTitleTextbox.TabIndex = 12;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(7, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 16);
            this.title.TabIndex = 17;
            this.title.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Publisher";
            // 
            // publisherTextbox
            // 
            this.publisherTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTextbox.Location = new System.Drawing.Point(79, 70);
            this.publisherTextbox.Name = "publisherTextbox";
            this.publisherTextbox.Size = new System.Drawing.Size(142, 21);
            this.publisherTextbox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Publish Date";
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.ForeColor = System.Drawing.Color.Gainsboro;
            this.ISBN.Location = new System.Drawing.Point(8, 127);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(38, 16);
            this.ISBN.TabIndex = 23;
            this.ISBN.Text = "ISBN";
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextbox.Location = new System.Drawing.Point(52, 124);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(170, 21);
            this.isbnTextbox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(7, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Amount";
            // 
            // amountTextbox
            // 
            this.amountTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextbox.Location = new System.Drawing.Point(65, 185);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(31, 21);
            this.amountTextbox.TabIndex = 24;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addAuthorButton.Location = new System.Drawing.Point(10, 224);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(86, 28);
            this.addAuthorButton.TabIndex = 27;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // submitForm
            // 
            this.submitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.submitForm.Location = new System.Drawing.Point(135, 224);
            this.submitForm.Name = "submitForm";
            this.submitForm.Size = new System.Drawing.Size(86, 28);
            this.submitForm.TabIndex = 28;
            this.submitForm.Text = "Submit";
            this.submitForm.UseVisualStyleBackColor = true;
            this.submitForm.Click += new System.EventHandler(this.submitForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Genre";
            // 
            // genreTextbox
            // 
            this.genreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTextbox.Location = new System.Drawing.Point(66, 155);
            this.genreTextbox.Name = "genreTextbox";
            this.genreTextbox.Size = new System.Drawing.Size(83, 21);
            this.genreTextbox.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // executionMessage
            // 
            this.executionMessage.AutoSize = true;
            this.executionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.executionMessage.Location = new System.Drawing.Point(8, 14);
            this.executionMessage.Name = "executionMessage";
            this.executionMessage.Size = new System.Drawing.Size(132, 18);
            this.executionMessage.TabIndex = 33;
            this.executionMessage.Text = "executionMessage";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.executionMessage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreTextbox);
            this.Controls.Add(this.submitForm);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.isbnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publisherTextbox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.bookTitleTextbox);
            this.Name = "AddBookControl";
            this.Size = new System.Drawing.Size(755, 427);
            this.Load += new System.EventHandler(this.AddBookControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox bookTitleTextbox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox publisherTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox isbnTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button submitForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genreTextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label executionMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
