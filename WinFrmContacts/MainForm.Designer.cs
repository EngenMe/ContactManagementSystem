namespace WinFrmContacts
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnContactsList = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnPrintContactCard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucIntroScreen1 = new WinFrmContacts.ucIntroScreen();
            this.ucContactsList1 = new WinFrmContacts.ucContactsList();
            this.ucDeleteContact1 = new WinFrmContacts.ucDeleteContact();
            this.ucUpdateContact1 = new WinFrmContacts.ucUpdateContact();
            this.ucAddContact1 = new WinFrmContacts.ucAddContact();
            this.ucPrintContactCard1 = new WinFrmContacts.ucPrintContactCard();
            this.pbImagePath = new System.Windows.Forms.PictureBox();
            this.btnUpdateImg = new System.Windows.Forms.Button();
            this.ofdImagePath = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePath)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(201, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnContactsList);
            this.panel2.Controls.Add(this.btnDeleteContact);
            this.panel2.Controls.Add(this.btnUpdateContact);
            this.panel2.Controls.Add(this.btnAddContact);
            this.panel2.Controls.Add(this.btnPrintContactCard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 796);
            this.panel2.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SidePanel.Location = new System.Drawing.Point(0, 90);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(22, 96);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.Location = new System.Drawing.Point(3, 745);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 48);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnContactsList
            // 
            this.btnContactsList.BackColor = System.Drawing.Color.Transparent;
            this.btnContactsList.FlatAppearance.BorderSize = 0;
            this.btnContactsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactsList.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactsList.Image = ((System.Drawing.Image)(resources.GetObject("btnContactsList.Image")));
            this.btnContactsList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContactsList.Location = new System.Drawing.Point(28, 498);
            this.btnContactsList.Name = "btnContactsList";
            this.btnContactsList.Size = new System.Drawing.Size(170, 96);
            this.btnContactsList.TabIndex = 5;
            this.btnContactsList.Text = "Contacts\r\nList";
            this.btnContactsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactsList.UseVisualStyleBackColor = false;
            this.btnContactsList.Click += new System.EventHandler(this.btnContactsList_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.FlatAppearance.BorderSize = 0;
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteContact.Image")));
            this.btnDeleteContact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteContact.Location = new System.Drawing.Point(28, 396);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(170, 96);
            this.btnDeleteContact.TabIndex = 4;
            this.btnDeleteContact.Text = "Delete\r\nContact";
            this.btnDeleteContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateContact.FlatAppearance.BorderSize = 0;
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContact.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateContact.Image")));
            this.btnUpdateContact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateContact.Location = new System.Drawing.Point(28, 294);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(170, 96);
            this.btnUpdateContact.TabIndex = 3;
            this.btnUpdateContact.Text = "Update\r\nContact";
            this.btnUpdateContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateContact.UseVisualStyleBackColor = false;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.FlatAppearance.BorderSize = 0;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContact.Image")));
            this.btnAddContact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddContact.Location = new System.Drawing.Point(28, 192);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(170, 96);
            this.btnAddContact.TabIndex = 2;
            this.btnAddContact.Text = "Add\r\nContact";
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnPrintContactCard
            // 
            this.btnPrintContactCard.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintContactCard.FlatAppearance.BorderSize = 0;
            this.btnPrintContactCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintContactCard.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintContactCard.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintContactCard.Image")));
            this.btnPrintContactCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintContactCard.Location = new System.Drawing.Point(28, 90);
            this.btnPrintContactCard.Name = "btnPrintContactCard";
            this.btnPrintContactCard.Size = new System.Drawing.Size(170, 96);
            this.btnPrintContactCard.TabIndex = 1;
            this.btnPrintContactCard.Text = "Contact\r\nCard";
            this.btnPrintContactCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintContactCard.UseVisualStyleBackColor = false;
            this.btnPrintContactCard.Click += new System.EventHandler(this.btnPrintContactCard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(274, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 233);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "EngenMe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts\r\nProject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.ucIntroScreen1);
            this.panel5.Controls.Add(this.ucContactsList1);
            this.panel5.Controls.Add(this.ucDeleteContact1);
            this.panel5.Controls.Add(this.ucUpdateContact1);
            this.panel5.Controls.Add(this.ucAddContact1);
            this.panel5.Controls.Add(this.ucPrintContactCard1);
            this.panel5.Location = new System.Drawing.Point(274, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(927, 505);
            this.panel5.TabIndex = 0;
            // 
            // ucIntroScreen1
            // 
            this.ucIntroScreen1.BackColor = System.Drawing.Color.LightBlue;
            this.ucIntroScreen1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucIntroScreen1.Location = new System.Drawing.Point(0, 1);
            this.ucIntroScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.ucIntroScreen1.Name = "ucIntroScreen1";
            this.ucIntroScreen1.Size = new System.Drawing.Size(927, 505);
            this.ucIntroScreen1.TabIndex = 0;
            // 
            // ucContactsList1
            // 
            this.ucContactsList1.BackColor = System.Drawing.Color.LightBlue;
            this.ucContactsList1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucContactsList1.Location = new System.Drawing.Point(0, 1);
            this.ucContactsList1.Margin = new System.Windows.Forms.Padding(4);
            this.ucContactsList1.Name = "ucContactsList1";
            this.ucContactsList1.Size = new System.Drawing.Size(927, 505);
            this.ucContactsList1.TabIndex = 4;
            this.ucContactsList1.TabStop = false;
            // 
            // ucDeleteContact1
            // 
            this.ucDeleteContact1.BackColor = System.Drawing.Color.LightBlue;
            this.ucDeleteContact1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDeleteContact1.Location = new System.Drawing.Point(0, 0);
            this.ucDeleteContact1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDeleteContact1.Name = "ucDeleteContact1";
            this.ucDeleteContact1.Size = new System.Drawing.Size(927, 505);
            this.ucDeleteContact1.TabIndex = 4;
            this.ucDeleteContact1.TabStop = false;
            // 
            // ucUpdateContact1
            // 
            this.ucUpdateContact1.BackColor = System.Drawing.Color.LightBlue;
            this.ucUpdateContact1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUpdateContact1.Location = new System.Drawing.Point(0, -1);
            this.ucUpdateContact1.Margin = new System.Windows.Forms.Padding(4);
            this.ucUpdateContact1.Name = "ucUpdateContact1";
            this.ucUpdateContact1.Size = new System.Drawing.Size(927, 505);
            this.ucUpdateContact1.TabIndex = 4;
            this.ucUpdateContact1.TabStop = false;
            // 
            // ucAddContact1
            // 
            this.ucAddContact1.BackColor = System.Drawing.Color.LightBlue;
            this.ucAddContact1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddContact1.Location = new System.Drawing.Point(0, -1);
            this.ucAddContact1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddContact1.Name = "ucAddContact1";
            this.ucAddContact1.Size = new System.Drawing.Size(927, 505);
            this.ucAddContact1.TabIndex = 4;
            this.ucAddContact1.TabStop = false;
            // 
            // ucPrintContactCard1
            // 
            this.ucPrintContactCard1.BackColor = System.Drawing.Color.LightBlue;
            this.ucPrintContactCard1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPrintContactCard1.Location = new System.Drawing.Point(0, 0);
            this.ucPrintContactCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPrintContactCard1.Name = "ucPrintContactCard1";
            this.ucPrintContactCard1.Size = new System.Drawing.Size(927, 505);
            this.ucPrintContactCard1.TabIndex = 0;
            this.ucPrintContactCard1.TabStop = false;
            // 
            // pbImagePath
            // 
            this.pbImagePath.Image = ((System.Drawing.Image)(resources.GetObject("pbImagePath.Image")));
            this.pbImagePath.InitialImage = null;
            this.pbImagePath.Location = new System.Drawing.Point(1002, 60);
            this.pbImagePath.Name = "pbImagePath";
            this.pbImagePath.Size = new System.Drawing.Size(156, 194);
            this.pbImagePath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagePath.TabIndex = 1;
            this.pbImagePath.TabStop = false;
            this.pbImagePath.Visible = false;
            // 
            // btnUpdateImg
            // 
            this.btnUpdateImg.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateImg.FlatAppearance.BorderSize = 0;
            this.btnUpdateImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateImg.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateImg.Image")));
            this.btnUpdateImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateImg.Location = new System.Drawing.Point(808, 121);
            this.btnUpdateImg.Name = "btnUpdateImg";
            this.btnUpdateImg.Size = new System.Drawing.Size(170, 96);
            this.btnUpdateImg.TabIndex = 2;
            this.btnUpdateImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateImg.UseVisualStyleBackColor = false;
            this.btnUpdateImg.Visible = false;
            this.btnUpdateImg.Click += new System.EventHandler(this.btnUpdateImg_Click);
            // 
            // ofdImagePath
            // 
            this.ofdImagePath.FileName = "ImagePath";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 796);
            this.Controls.Add(this.pbImagePath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnUpdateImg);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnPrintContactCard;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnContactsList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panel5;
        private ucPrintContactCard ucPrintContactCard1;
        private ucAddContact ucAddContact1;
        private ucUpdateContact ucUpdateContact1;
        private ucDeleteContact ucDeleteContact1;
        private ucContactsList ucContactsList1;
        private ucIntroScreen ucIntroScreen1;
        private System.Windows.Forms.PictureBox pbImagePath;
        private System.Windows.Forms.Button btnUpdateImg;
        private System.Windows.Forms.OpenFileDialog ofdImagePath;
    }
}

