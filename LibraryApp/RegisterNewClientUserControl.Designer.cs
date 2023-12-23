namespace LibraryApp
{
    partial class RegisterNewClientUserControl
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
            this.PhoneNumberInputBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.EmailInputBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.StateInputBox = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.ZipCodeInputBox = new System.Windows.Forms.TextBox();
            this.ZIPcode = new System.Windows.Forms.Label();
            this.DateOfBirthInputBox = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.AddressInputBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.LastNameInputBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstNameInputBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SubmitNewClient = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneNumberInputBox
            // 
            this.PhoneNumberInputBox.Location = new System.Drawing.Point(417, 134);
            this.PhoneNumberInputBox.Name = "PhoneNumberInputBox";
            this.PhoneNumberInputBox.Size = new System.Drawing.Size(200, 20);
            this.PhoneNumberInputBox.TabIndex = 31;
            this.PhoneNumberInputBox.TextChanged += new System.EventHandler(this.PhoneNumberInputBox_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(303, 136);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(108, 18);
            this.PhoneNumber.TabIndex = 30;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // EmailInputBox
            // 
            this.EmailInputBox.Location = new System.Drawing.Point(58, 134);
            this.EmailInputBox.Name = "EmailInputBox";
            this.EmailInputBox.Size = new System.Drawing.Size(200, 20);
            this.EmailInputBox.TabIndex = 29;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(7, 136);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(45, 18);
            this.Email.TabIndex = 28;
            this.Email.Text = "Email";
            // 
            // StateInputBox
            // 
            this.StateInputBox.Location = new System.Drawing.Point(581, 97);
            this.StateInputBox.Name = "StateInputBox";
            this.StateInputBox.Size = new System.Drawing.Size(138, 20);
            this.StateInputBox.TabIndex = 27;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.Location = new System.Drawing.Point(533, 99);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(42, 18);
            this.State.TabIndex = 26;
            this.State.Text = "State";
            // 
            // ZipCodeInputBox
            // 
            this.ZipCodeInputBox.Location = new System.Drawing.Point(392, 97);
            this.ZipCodeInputBox.Name = "ZipCodeInputBox";
            this.ZipCodeInputBox.Size = new System.Drawing.Size(103, 20);
            this.ZipCodeInputBox.TabIndex = 25;
            // 
            // ZIPcode
            // 
            this.ZIPcode.AutoSize = true;
            this.ZIPcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZIPcode.Location = new System.Drawing.Point(319, 99);
            this.ZIPcode.Name = "ZIPcode";
            this.ZIPcode.Size = new System.Drawing.Size(67, 18);
            this.ZIPcode.TabIndex = 24;
            this.ZIPcode.Text = "ZIP code";
            // 
            // DateOfBirthInputBox
            // 
            this.DateOfBirthInputBox.Location = new System.Drawing.Point(831, 58);
            this.DateOfBirthInputBox.Name = "DateOfBirthInputBox";
            this.DateOfBirthInputBox.Size = new System.Drawing.Size(103, 20);
            this.DateOfBirthInputBox.TabIndex = 23;
            this.DateOfBirthInputBox.TextChanged += new System.EventHandler(this.DateOfBirthInputBox_TextChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(643, 59);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(182, 18);
            this.DateOfBirth.TabIndex = 22;
            this.DateOfBirth.Text = "Date of Birth (mm/dd/yyyy)";
            // 
            // AddressInputBox
            // 
            this.AddressInputBox.Location = new System.Drawing.Point(75, 97);
            this.AddressInputBox.Name = "AddressInputBox";
            this.AddressInputBox.Size = new System.Drawing.Size(200, 20);
            this.AddressInputBox.TabIndex = 21;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(7, 99);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(62, 18);
            this.Address.TabIndex = 20;
            this.Address.Text = "Address";
            // 
            // LastNameInputBox
            // 
            this.LastNameInputBox.Location = new System.Drawing.Point(408, 57);
            this.LastNameInputBox.Name = "LastNameInputBox";
            this.LastNameInputBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameInputBox.TabIndex = 19;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(322, 59);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 18);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            // 
            // FirstNameInputBox
            // 
            this.FirstNameInputBox.Location = new System.Drawing.Point(94, 56);
            this.FirstNameInputBox.Name = "FirstNameInputBox";
            this.FirstNameInputBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameInputBox.TabIndex = 17;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(7, 58);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 18);
            this.FirstName.TabIndex = 16;
            this.FirstName.Text = "First Name";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // SubmitNewClient
            // 
            this.SubmitNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitNewClient.Location = new System.Drawing.Point(10, 219);
            this.SubmitNewClient.Name = "SubmitNewClient";
            this.SubmitNewClient.Size = new System.Drawing.Size(150, 43);
            this.SubmitNewClient.TabIndex = 32;
            this.SubmitNewClient.Text = "Add Client";
            this.SubmitNewClient.UseVisualStyleBackColor = true;
            this.SubmitNewClient.Click += new System.EventHandler(this.SubmitNewClient_Click);
            // 
            // Return
            // 
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(860, 3);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(74, 26);
            this.Return.TabIndex = 33;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.Black;
            this.SuccessLabel.Location = new System.Drawing.Point(7, 187);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 20);
            this.SuccessLabel.TabIndex = 35;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFormButton.Location = new System.Drawing.Point(166, 219);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(150, 43);
            this.ClearFormButton.TabIndex = 36;
            this.ClearFormButton.Text = "Clear";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // RegisterNewClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.SubmitNewClient);
            this.Controls.Add(this.PhoneNumberInputBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.EmailInputBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.StateInputBox);
            this.Controls.Add(this.State);
            this.Controls.Add(this.ZipCodeInputBox);
            this.Controls.Add(this.ZIPcode);
            this.Controls.Add(this.DateOfBirthInputBox);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.AddressInputBox);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastNameInputBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameInputBox);
            this.Controls.Add(this.FirstName);
            this.Name = "RegisterNewClientUserControl";
            this.Size = new System.Drawing.Size(989, 341);
            this.Load += new System.EventHandler(this.RegisterNewClientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneNumberInputBox;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.TextBox EmailInputBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox StateInputBox;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.TextBox ZipCodeInputBox;
        private System.Windows.Forms.Label ZIPcode;
        private System.Windows.Forms.TextBox DateOfBirthInputBox;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.TextBox AddressInputBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox LastNameInputBox;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox FirstNameInputBox;
        private System.Windows.Forms.Label FirstName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SubmitNewClient;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Button ClearFormButton;
    }
}
