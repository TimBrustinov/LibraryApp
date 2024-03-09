namespace LibraryApp.UserControls
{
    partial class RemoveBookUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.bookTitleTextbox = new System.Windows.Forms.TextBox();
            this.executionMessage = new System.Windows.Forms.Label();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ISBN";
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextbox.Location = new System.Drawing.Point(47, 70);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(170, 21);
            this.isbnTextbox.TabIndex = 22;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gainsboro;
            this.title.Location = new System.Drawing.Point(3, 46);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(68, 16);
            this.title.TabIndex = 21;
            this.title.Text = "Book Title";
            // 
            // bookTitleTextbox
            // 
            this.bookTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextbox.Location = new System.Drawing.Point(75, 43);
            this.bookTitleTextbox.Name = "bookTitleTextbox";
            this.bookTitleTextbox.Size = new System.Drawing.Size(142, 21);
            this.bookTitleTextbox.TabIndex = 20;
            // 
            // executionMessage
            // 
            this.executionMessage.AutoSize = true;
            this.executionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.executionMessage.Location = new System.Drawing.Point(3, 12);
            this.executionMessage.Name = "executionMessage";
            this.executionMessage.Size = new System.Drawing.Size(132, 18);
            this.executionMessage.TabIndex = 34;
            this.executionMessage.Text = "executionMessage";
            // 
            // removeBookButton
            // 
            this.removeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeBookButton.Location = new System.Drawing.Point(6, 97);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(118, 28);
            this.removeBookButton.TabIndex = 35;
            this.removeBookButton.Text = "Remove Book";
            this.removeBookButton.UseVisualStyleBackColor = true;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(242, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 370);
            this.dataGridView1.TabIndex = 36;
            // 
            // RemoveBookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.executionMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isbnTextbox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.bookTitleTextbox);
            this.Name = "RemoveBookUserControl";
            this.Size = new System.Drawing.Size(765, 381);
            this.Load += new System.EventHandler(this.RemoveBookUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbnTextbox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox bookTitleTextbox;
        private System.Windows.Forms.Label executionMessage;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
