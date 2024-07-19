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
using WinFrmContacts;

namespace WinFrmContacts
{
    public partial class ucPrintContactCard : UserControl
    {
        // Constructor: Initializes the Print Contact Card user control.
        public ucPrintContactCard()
        {
            InitializeComponent();
        }

        // Method to clear all fields and combo boxes.
        private void ClearAll()
        {
            cbContactID.Items.Clear();
            cbCountry.Items.Clear();

            // Clear text boxes and reset date picker and combo box selections.
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhone.Text = string.Empty;
            dtpDateOfBirth.Text = string.Empty;
            cbCountry.SelectedIndex = -1;
            tbAddress.Text = string.Empty;
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

        // Method to initialize the Print Contact Card user control.
        public void InitializeUCPrintContactCard()
        {
            this.BringToFront(); // Bring this control to the front.
            ClearAll(); // Clear all fields and combo boxes.
            InitializeIDComboBoxItem(); // Initialize contact ID combo box.
            InitializeCountryComboBoxItems(); // Initialize country combo box.
        }

        // Event handler for when the selected index of the contact ID combo box changes.
        private void cbContactID_SelectedIndexChanged(object sender, EventArgs e)
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

            // Set the image path in the main form to the contact's image path.
            frmMain MainForm = this.ParentForm as frmMain;
            MainForm.ImagePath = Contact.ImagePath;
        }
    }
}
