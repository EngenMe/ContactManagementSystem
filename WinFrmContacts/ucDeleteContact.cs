using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmContacts
{
    public partial class ucDeleteContact : UserControl
    {
        // Constructor: Initializes the Delete Contact user control.
        public ucDeleteContact()
        {
            InitializeComponent();
        }

        // Method to clear all fields and combo boxes.
        private void ClearAll()
        {
            cbContactID.Items.Clear();
            cbCountry.Items.Clear();
            UnfillFields();
        }

        // Method to initialize the contact ID combo box with items.
        private void InitializeIDComboBoxItem()
        {
            // Retrieve all contact IDs from the business layer.
            List<int> ContactIDs = clsBusinessLayer.GetAllContactIDs();

            // Add each contact ID to the combo box.
            foreach (int ContactID in ContactIDs)
            {
                this.cbContactID.Items.Add(ContactID);
            }
        }

        // Method to initialize the country combo box with items.
        private void InitializeCountryComboBoxItems()
        {
            // Retrieve all country names from the business layer.
            List<string> CountryNames = clsBusinessLayer.GetAllCountryNames();

            // Add each country name to the combo box.
            foreach (string CountryName in CountryNames)
            {
                this.cbCountry.Items.Add(CountryName);
            }
        }

        // Method to initialize the Delete Contact user control.
        public void InitializeUCDeleteContact()
        {
            this.BringToFront(); // Bring this control to the front.
            ClearAll(); // Clear all fields and combo boxes.
            InitializeIDComboBoxItem(); // Initialize contact ID combo box.
            InitializeCountryComboBoxItems(); // Initialize country combo box.
        }

        // Method to fill the contact fields with data based on the selected contact ID.
        private void FillContactFields()
        {
            // Find the contact using the selected contact ID.
            clsContact Contact = clsBusinessLayer.FindContact(Convert.ToInt32(cbContactID.Text));

            // Find the country associated with the contact.
            clsCountry Country = clsBusinessLayer.FindCountry(Contact.CountryID);

            // Fill the text boxes with the contact's details.
            tbFirstName.Text = Contact.FirstName;
            tbLastName.Text = Contact.LastName;
            tbEmail.Text = Contact.Email;
            tbPhone.Text = Contact.Phone;
            dtpDateOfBirth.Value = Contact.DateOfBirth;

            // Select the country in the combo box.
            int counter = 0;
            foreach (var item in cbCountry.Items)
            {
                if (item.ToString() == Country.CountryName)
                {
                    cbCountry.SelectedIndex = counter;
                    break;
                }
                counter++;
            }

            tbAddress.Text = Contact.Address;

            // Set the image path in the main form.
            frmMain MainForm = this.ParentForm as frmMain;
            MainForm.ImagePath = Contact.ImagePath;
        }

        // Event handler for when the selected index of the contact ID combo box changes.
        private void cbContactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillContactFields(); // Fill the contact fields with the selected contact's details.
            btnDeleteContact.Enabled = true; // Enable the Delete Contact button.
        }

        // Method to unfill all fields.
        private void UnfillFields()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhone.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Today;
            cbCountry.SelectedIndex = -1;
            tbAddress.Text = string.Empty;

            // Reset the image path in the main form to the default empty image.
            frmMain MainForm = this.ParentForm as frmMain;
            MainForm.ImagePath = MainForm.EmptyImgLocation;
        }

        // Method to refresh the Delete Contact user control.
        private void RefreshDeleteContact()
        {
            UnfillFields(); // Unfill all fields.
            btnDeleteContact.Enabled = false; // Disable the Delete Contact button.
        }

        // Method to confirm the deletion action.
        private void ConfirmAction()
        {
            // Delete the contact record using the selected contact ID.
            if (clsBusinessLayer.DeleteRecordInContact(Convert.ToInt32(cbContactID.Text)))
            {
                MessageBox.Show("Contact Deleted Successfully :)", "Delete Contact", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Delete Contact", "Delete Contact", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Event handler for the Delete Contact button click.
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            ConfirmAction(); // Confirm the deletion action.
            RefreshDeleteContact(); // Refresh the Delete Contact user control.
        }
    }
}
