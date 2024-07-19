using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WinFrmContacts
{
    public partial class frmMain : Form
    {
        // Constructor: Initializes the main form.
        public frmMain()
        {
            InitializeComponent();
        }

        // Location of the default empty image.
        public string EmptyImgLocation = @"C:\Users\moham\source\repos\WinFrmContacts\img\EmptyImg.png";

        // Method to update the state of the side panel to match the clicked button's position.
        private void UpdateSidePanelState(object sender)
        {
            // Set the height and top position of the side panel to match the clicked button.
            SidePanel.Height = ((Button)sender).Height;
            SidePanel.Top = ((Button)sender).Top;

            // Make the side panel visible if it is not already.
            if (!SidePanel.Visible)
            {
                SidePanel.Visible = true;
            }
        }

        // Event handler for the "Print Contact Card" button click.
        private void btnPrintContactCard_Click(object sender, EventArgs e)
        {
            // Initialize the Print Contact Card user control.
            ucPrintContactCard1.InitializeUCPrintContactCard();
            UpdateSidePanelState(sender);

            // Set the image location to the empty image and make it visible.
            pbImagePath.ImageLocation = EmptyImgLocation;
            pbImagePath.Visible = true;

            // Hide the update image button.
            btnUpdateImg.Visible = false;
        }

        // Event handler for the "Add Contact" button click.
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            // Enable the update image button.
            btnUpdateImg.Enabled = true;

            // Initialize the Add Contact user control.
            ucAddContact1.InitializeUCAddContact();
            UpdateSidePanelState(sender);

            // Set the image location to the empty image and make it visible.
            pbImagePath.ImageLocation = EmptyImgLocation;
            pbImagePath.Visible = true;

            // Show and update the text of the update image button.
            btnUpdateImg.Visible = true;
            btnUpdateImg.Text = "Add\nImage";
        }

        // Event handler for the "Update Contact" button click.
        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            // Initialize the Update Contact user control.
            ucUpdateContact1.InitializeUCUpdateContact();
            UpdateSidePanelState(sender);

            // Set the image location to the empty image and make it visible.
            pbImagePath.ImageLocation = EmptyImgLocation;
            pbImagePath.Visible = true;

            // Show and update the text of the update image button.
            btnUpdateImg.Visible = true;
            btnUpdateImg.Text = "Update\nImage";
        }

        // Event handler for the "Delete Contact" button click.
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            // Disable the update image button.
            btnUpdateImg.Enabled = false;

            // Initialize the Delete Contact user control.
            ucDeleteContact1.InitializeUCDeleteContact();
            UpdateSidePanelState(sender);

            // Set the image location to the empty image and make it visible.
            pbImagePath.ImageLocation = EmptyImgLocation;
            pbImagePath.Visible = true;

            // Show the update image button without text.
            btnUpdateImg.Visible = true;
            btnUpdateImg.Text = string.Empty;
        }

        // Event handler for the "Contacts List" button click.
        private void btnContactsList_Click(object sender, EventArgs e)
        {
            // Initialize the Contacts List user control.
            ucContactsList1.InitializeUCContactsList();
            UpdateSidePanelState(sender);

            // Set the image location to the empty image and hide it.
            pbImagePath.ImageLocation = EmptyImgLocation;
            pbImagePath.Visible = false;

            // Hide the update image button.
            btnUpdateImg.Visible = false;
        }

        // Event handler for the "Info" button click.
        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Show a message box with project information.
            MessageBox.Show("This Project Made By Mohamed Farouk Hasnaoui - EngenMe\n" +
                "All Right Reserved\n" +
                "Follow Me on Social Media :)", "Informations", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Property to get or set the image path of the picture box.
        public string ImagePath
        {
            get { return pbImagePath.ImageLocation; }
            set { pbImagePath.ImageLocation = value; }
        }

        // Event handler for the "Update Image" button click.
        private void btnUpdateImg_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image file.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                // If the user selects a file and clicks OK.
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path.
                    string filePath = openFileDialog.FileName;

                    // Store the old image path.
                    string OldImagePath = ImagePath;

                    // Update the picture box with the new image.
                    pbImagePath.ImageLocation = filePath;

                    // If the image path has changed, enable the update button in the Update Contact user control.
                    if (OldImagePath != ImagePath)
                    {
                        ucUpdateContact1.EnableUpdateBtn();
                    }
                }
            }
        }
    }
}
