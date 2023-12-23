namespace LibraryApp
{
    partial class BookCheckInOutControl
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
            this.LastNameInputBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameInputBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BookTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastNameInputBox
            // 
            this.LastNameInputBox.Location = new System.Drawing.Point(413, 38);
            this.LastNameInputBox.Name = "LastNameInputBox";
            this.LastNameInputBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameInputBox.TabIndex = 23;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(327, 40);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 18);
            this.LastName.TabIndex = 22;
            this.LastName.Text = "Last Name";
            // 
            // FirstNameInputBox
            // 
            this.FirstNameInputBox.Location = new System.Drawing.Point(99, 37);
            this.FirstNameInputBox.Name = "FirstNameInputBox";
            this.FirstNameInputBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameInputBox.TabIndex = 21;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(12, 39);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 18);
            this.FirstName.TabIndex = 20;
            this.FirstName.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 25;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.Location = new System.Drawing.Point(12, 80);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(75, 18);
            this.BookTitle.TabIndex = 24;
            this.BookTitle.Text = "Book Title";
            // 
            // BookCheckInOutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.LastNameInputBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameInputBox);
            this.Controls.Add(this.FirstName);
            this.Name = "BookCheckInOutControl";
            this.Size = new System.Drawing.Size(893, 370);
            this.Load += new System.EventHandler(this.BookCheckInOutControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastNameInputBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FirstNameInputBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label BookTitle;
    }
}
