using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFrmContacts
{
    public partial class ucAddContact : UserControl
    {
        // Constructor: Initializes the Add Contact user control.
        public ucAddContact()
        {
            InitializeComponent();
        }

        // Structure to hold the state of the Add Contact button's prerequisites.
        private struct stBTNAddContactState
        {
            public bool FirstNameFilled;
            public bool LastNameFilled;
            public bool EmailFilled;
            public bool EmailValid;
            public bool PhoneFilled;
            public bool PhoneValid;
            public bool CountryChosen;
            public bool AddressFilled;
        }

        // Instance of the structure to manage the button state.
        private stBTNAddContactState BTNAddContactState;

        // Method to reset the contact form fields to their default state.
        private void RefreshAddContact()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhone.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Today;
            cbCountry.SelectedIndex = -1;
            tbAddress.Text = string.Empty;

            epAddContact.Clear(); // Clear all error providers.
        }

        // Method to clear all combo box items and refresh the form.
        private void ClearAll()
        {
            cbContactID.Items.Clear();
            cbCountry.Items.Clear();
            RefreshAddContact();
        }

        // Method to populate the ContactID combo box with IDs from the business layer.
        private void InitializeIDComboBoxItem()
        {
            List<int> ContactIDs = clsBusinessLayer.GetAllContactIDs();

            foreach (int ContactID in ContactIDs)
            {
                this.cbContactID.Items.Add(ContactID);
            }
        }

        // Method to populate the Country combo box with country names from the business layer.
        private void InitializeCountryComboBoxItems()
        {
            List<string> CountryNames = clsBusinessLayer.GetAllCountryNames();

            foreach (string CountryName in CountryNames)
            {
                this.cbCountry.Items.Add(CountryName);
            }
        }

        // Method to initialize the Add Contact user control.
        public void InitializeUCAddContact()
        {
            this.BringToFront();
            ClearAll();
            InitializeIDComboBoxItem();
            InitializeCountryComboBoxItems();
        }

        // Method to check if the FirstName field is filled and update error provider.
        private void CheckIfFirstNameFilled()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                epAddContact.SetError(tbFirstName, "FirstName must be entered!");
                BTNAddContactState.FirstNameFilled = false;
            }
            else
            {
                epAddContact.SetError(tbFirstName, "");
                BTNAddContactState.FirstNameFilled = true;
            }
        }

        // Method to check if the LastName field is filled and update error provider.
        private void CheckIfLastNameFilled()
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                epAddContact.SetError(tbLastName, "LastName must be entered!");
                BTNAddContactState.LastNameFilled = false;
            }
            else
            {
                epAddContact.SetError(tbLastName, "");
                BTNAddContactState.LastNameFilled = true;
            }
        }

        // Method to check if the Email field is filled and update error provider.
        private void CheckIfEmailFilled()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                epAddContact.SetError(tbEmail, "Email must be entered!");
                BTNAddContactState.EmailFilled = false;
            }
            else
            {
                epAddContact.SetError(tbEmail, "");
                BTNAddContactState.EmailFilled = true;
            }
        }

        // Method to check if the Phone field is filled and update error provider.
        private void CheckIfPhoneFilled()
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                epAddContact.SetError(tbPhone, "Phone number must be entered!");
                BTNAddContactState.PhoneFilled = false;
            }
            else
            {
                epAddContact.SetError(tbPhone, "");
                BTNAddContactState.PhoneFilled = true;
            }
        }

        // Method to check if a country is selected from the combo box and update error provider.
        private void CheckIfCountryChosen()
        {
            if (cbCountry.SelectedIndex == -1)
            {
                epAddContact.SetError(cbCountry, "Country must be chosen!");
                BTNAddContactState.CountryChosen = false;
            }
            else
            {
                epAddContact.SetError(cbCountry, "");
                BTNAddContactState.CountryChosen = true;
            }
        }

        // Method to check if the Address field is filled and update error provider.
        private void CheckIfAddressFilled()
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                epAddContact.SetError(tbAddress, "Address must be entered!");
                BTNAddContactState.AddressFilled = false;
            }
            else
            {
                epAddContact.SetError(tbAddress, "");
                BTNAddContactState.AddressFilled = true;
            }
        }

        // Method to validate the Email format using a regular expression.
        private void CheckIfValidEmail()
        {
            if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                epAddContact.SetError(tbEmail, "Invalid Email!, must contain @ and a domain name.");
                BTNAddContactState.EmailValid = false;
            }
            else
            {
                BTNAddContactState.EmailValid = true;
            }
        }

        // Method to validate the Phone format using a regular expression.
        private void CheckIfValidPhone()
        {
            if (!Regex.IsMatch(tbPhone.Text, @"^\+\d+$"))
            {
                epAddContact.SetError(tbPhone, "Invalid Phone!, must contain a country code prefixed with +.");
                BTNAddContactState.PhoneValid = false;
            }
            else
            {
                BTNAddContactState.PhoneValid = true;
            }
        }

        // Method to update the state of the Add Contact button based on the filled fields.
        private void UpdateBTNAddContactState()
        {
            if (BTNAddContactState.FirstNameFilled && BTNAddContactState.LastNameFilled &&
                BTNAddContactState.EmailFilled && BTNAddContactState.EmailValid &&
                BTNAddContactState.PhoneFilled && BTNAddContactState.PhoneValid &&
                BTNAddContactState.CountryChosen && BTNAddContactState.AddressFilled)
            {
                btnAddContact.Enabled = true;
            }
            else
            {
                btnAddContact.Enabled = false;
            }
        }

        // Event handlers for text changed events to validate fields and update button state.
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckIfFirstNameFilled();
            UpdateBTNAddContactState();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            CheckIfLastNameFilled();
            UpdateBTNAddContactState();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            CheckIfEmailFilled();
            CheckIfValidEmail();
            UpdateBTNAddContactState();
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            CheckIfPhoneFilled();
            CheckIfValidPhone();
            UpdateBTNAddContactState();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfCountryChosen();
            UpdateBTNAddContactState();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            CheckIfAddressFilled();
            UpdateBTNAddContactState();
        }

        // Method to get the country ID based on the selected country name.
        private int GetCountryID()
        {
            clsCountry Country = clsBusinessLayer.FindCountry(cbCountry.Text);
            int CountryID = Country.CountryID;

            return CountryID;
        }

        // Method to create a Contact object from the form fields.
        private clsContact GetContactObject()
        {
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            string Email = tbEmail.Text;
            string Phone = tbPhone.Text;
            string Address = tbAddress.Text;
            DateTime DateOfBirth = dtpDateOfBirth.Value;
            int CountryID = GetCountryID();

            frmMain MainForm = this.ParentForm as frmMain;
            string ImagePath = MainForm.ImagePath;

            clsContact Contact = new clsContact(FirstName, LastName, Email, Phone, Address, DateOfBirth,
                CountryID, ImagePath);

            return Contact;
        }

        // Method to check if the contact already exists in the database.
        private bool CheckIfContactExist(clsContact Contact)
        {
            if (clsBusinessLayer.IsContactExist(Contact))
            {
                MessageBox.Show("Contact Already Exists!", "Duplicate Record", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method to save the contact record to the database.
        private void SaveContactRecord(clsContact Contact)
        {
            if (clsBusinessLayer.AddContactRecord(Contact))
            {
                MessageBox.Show("Contact Added Successfully :)", "Add Contact", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed To Add Contact!", "Add Contact", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Event handler for the Add Contact button click.
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            clsContact Contact = GetContactObject();
            if (CheckIfContactExist(Contact))
            {
                SaveContactRecord(Contact);
                RefreshAddContact();
            }
        }
    }
}
