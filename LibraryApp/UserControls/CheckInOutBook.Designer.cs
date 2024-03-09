namespace LibraryApp.UserControls
{
    partial class CheckInOutBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.Label();
            this.bookTitleTextbox = new System.Windows.Forms.TextBox();
            this.submitFormButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.executionMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.Location = new System.Drawing.Point(81, 35);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(170, 21);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.firstName.Location = new System.Drawing.Point(3, 36);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(72, 16);
            this.firstName.TabIndex = 3;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lastName.Location = new System.Drawing.Point(3, 62);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(72, 16);
            this.lastName.TabIndex = 5;
            this.lastName.Text = "Last Name";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.Location = new System.Drawing.Point(81, 61);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(170, 21);
            this.lastNameTextbox.TabIndex = 4;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.bookTitle.Location = new System.Drawing.Point(3, 88);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(68, 16);
            this.bookTitle.TabIndex = 7;
            this.bookTitle.Text = "Book Title";
            // 
            // bookTitleTextbox
            // 
            this.bookTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextbox.Location = new System.Drawing.Point(81, 87);
            this.bookTitleTextbox.Name = "bookTitleTextbox";
            this.bookTitleTextbox.Size = new System.Drawing.Size(170, 21);
            this.bookTitleTextbox.TabIndex = 6;
            // 
            // submitFormButton
            // 
            this.submitFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFormButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.submitFormButton.Location = new System.Drawing.Point(6, 141);
            this.submitFormButton.Name = "submitFormButton";
            this.submitFormButton.Size = new System.Drawing.Size(69, 27);
            this.submitFormButton.TabIndex = 10;
            this.submitFormButton.Text = "Submit";
            this.submitFormButton.UseVisualStyleBackColor = true;
            this.submitFormButton.Click += new System.EventHandler(this.submitFormButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Check-In",
            "Check-Out"});
            this.comboBox1.Location = new System.Drawing.Point(6, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // executionMessage
            // 
            this.executionMessage.AutoSize = true;
            this.executionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.executionMessage.Location = new System.Drawing.Point(3, 10);
            this.executionMessage.Name = "executionMessage";
            this.executionMessage.Size = new System.Drawing.Size(132, 18);
            this.executionMessage.TabIndex = 12;
            this.executionMessage.Text = "executionMessage";
            // 
            // CheckInOutBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.executionMessage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.submitFormButton);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.bookTitleTextbox);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckInOutBook";
            this.Size = new System.Drawing.Size(721, 433);
            this.Load += new System.EventHandler(this.CheckInOutBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.TextBox bookTitleTextbox;
        private System.Windows.Forms.Button submitFormButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label executionMessage;
    }
}
