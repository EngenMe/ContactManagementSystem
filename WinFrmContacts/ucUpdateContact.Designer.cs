namespace WinFrmContacts
{
    partial class ucUpdateContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUpdateContact));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbContactID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.epUpdateContact = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epUpdateContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ContactID";
            // 
            // cbContactID
            // 
            this.cbContactID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactID.FormattingEnabled = true;
            this.cbContactID.Location = new System.Drawing.Point(227, 83);
            this.cbContactID.Name = "cbContactID";
            this.cbContactID.Size = new System.Drawing.Size(93, 32);
            this.cbContactID.TabIndex = 1;
            this.cbContactID.SelectedIndexChanged += new System.EventHandler(this.cbContactID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "LastName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "DateOfBirth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(565, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Address";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Location = new System.Drawing.Point(227, 132);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(308, 32);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Location = new System.Drawing.Point(227, 181);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(308, 32);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(227, 230);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(308, 32);
            this.tbEmail.TabIndex = 4;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Enabled = false;
            this.tbPhone.Location = new System.Drawing.Point(227, 279);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(308, 32);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Enabled = false;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(227, 377);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(235, 32);
            this.cbCountry.TabIndex = 7;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(227, 328);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(347, 32);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.Enabled = false;
            this.tbAddress.Location = new System.Drawing.Point(569, 132);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(327, 166);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(704, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 96);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // epUpdateContact
            // 
            this.epUpdateContact.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epUpdateContact.ContainerControl = this;
            // 
            // ucUpdateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbContactID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucUpdateContact";
            this.Size = new System.Drawing.Size(927, 505);
            ((System.ComponentModel.ISupportInitialize)(this.epUpdateContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbContactID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider epUpdateContact;
    }
}
