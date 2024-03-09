namespace LibraryApp
{
    partial class AddAuthorHelperControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.authorLastNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(243, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Last Name";
            // 
            // authorLastNameTextbox
            // 
            this.authorLastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLastNameTextbox.Location = new System.Drawing.Point(321, 6);
            this.authorLastNameTextbox.Name = "authorLastNameTextbox";
            this.authorLastNameTextbox.Size = new System.Drawing.Size(126, 21);
            this.authorLastNameTextbox.TabIndex = 34;
            this.authorLastNameTextbox.TextChanged += new System.EventHandler(this.authorLastNameTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "First Name";
            // 
            // authorFirstNameTextbox
            // 
            this.authorFirstNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorFirstNameTextbox.Location = new System.Drawing.Point(78, 6);
            this.authorFirstNameTextbox.Name = "authorFirstNameTextbox";
            this.authorFirstNameTextbox.Size = new System.Drawing.Size(126, 21);
            this.authorFirstNameTextbox.TabIndex = 32;
            this.authorFirstNameTextbox.TextChanged += new System.EventHandler(this.authorFirstNameTextbox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddAuthorHelperControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(20)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authorLastNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.authorFirstNameTextbox);
            this.Name = "AddAuthorHelperControl";
            this.Size = new System.Drawing.Size(489, 35);
            this.Load += new System.EventHandler(this.AddAuthorHelperControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authorLastNameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorFirstNameTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
