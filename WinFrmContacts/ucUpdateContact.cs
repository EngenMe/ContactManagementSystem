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
    public partial class ucUpdateContact : UserControl
    {
        // Constructor: Initializes the Update Contact user control.
        public ucUpdateContact()
        {
            InitializeComponent();
        }

        // Instance of clsContact to hold contact information.
        clsContact Contact = new clsContact();

        // Structure to hold the state of the update contact button.
        private struct stBTNUpdateContactState
        {
            public bool FirstNameFilled;
            public bool LastNameFilled;
            public bool EmailFilled;
            public bool EmailValid;
            public bool PhoneFilled;
            public bool PhoneValid;
            public bool CountryChosen;
            public bool AddressFilled;
            public bool IsContactObjectChanged;
        }
        private stBTNUpdateContactState BTNUpdateContactState;

        // Method to clear all fields and reset the form.
        private void ClearAll()
        {
            cbContactID.Items.Clear();
            cbCountry.Items.Clear();
            epUpdateContact.Clear();

            // Unsubscribe and reset text boxes to avoid event firing during reset.
            this.tbFirstName.TextChanged -= this.tbFirstName_TextChanged;
            tbFirstName.Text = string.Empty;
            this.tbFirstName.TextChanged += this.tbFirstName_TextChanged;

            this.tbLastName.TextChanged -= this.tbLastName_TextChanged;
            tbLastName.Text = string.Empty;
            this.tbLastName.TextChanged += this.tbLastName_TextChanged;

            this.tbEmail.TextChanged -= this.tbEmail_TextChanged;
            tbEmail.Text = string.Empty;
            this.tbEmail.TextChanged += this.tbEmail_TextChanged;

            this.tbPhone.TextChanged -= this.tbPhone_TextChanged;
            tbPhone.Text = string.Empty;
            this.tbPhone.TextChanged += this.tbPhone_TextChanged;

            dtpDateOfBirth.Text = string.Empty;

            this.cbCountry.TextChanged -= this.cbCountry_SelectedIndexChanged;
            cbCountry.SelectedIndex = -1;
            this.cbCountry.TextChanged += this.cbCountry_SelectedIndexChanged;

            this.tbAddress.TextChanged -= this.tbAddress_TextChanged;
            tbAddress.Text = string.Empty;
            this.tbAddress.TextChanged += this.tbAddress_TextChanged;
        }

        // Method to initialize the contact ID combo box with all contact IDs.
        private void InitializeContactIDComboBoxItems()
        {
            List<int> ContactIDs = clsBusinessLayer.GetAllContactIDs();

            foreach (int ContactID in ContactIDs)
            {
                this.cbContactID.Items.Add(ContactID);
            }
        }

        // Method to initialize the country combo box with all country names.
        private void InitializeCountryIDComboBoxItems()
        {
            List<string> CountryNames = clsBusinessLayer.GetAllCountryNames();

            foreach (string CountryName in CountryNames)
            {
                this.cbCountry.Items.Add(CountryName);
            }
        }

        // Method to initialize the Update Contact user control.
        public void InitializeUCUpdateContact()
        {
            this.BringToFront(); // Bring this control to the front.
            ClearAll(); // Clear all fields and reset the form.
            InitializeContactIDComboBoxItems(); // Populate the contact ID combo box.
            InitializeCountryIDComboBoxItems(); // Populate the country combo box.
        }

        // Method to fill the Contact object with details of the selected contact.
        private void FillContactObj()
        {
            Contact = clsBusinessLayer.FindContact(Convert.ToInt32(cbContactID.Text));
        }

        // Method to fill country information in the combo box.
        private void FillCountryInfo()
        {
            int CountryID = Contact.CountryID;
            clsCountry Country = clsBusinessLayer.FindCountry(CountryID);
            string CountryName = Country.CountryName;

            int Counter = 0;
            foreach (string CountryNameItem in cbCountry.Items)
            {
                if (CountryNameItem == CountryName)
                {
                    cbCountry.SelectedIndex = Counter;
                    break;
                }
                else
                {
                    Counter++;
                }
            }
        }

        // Method to fill contact information fields with the contact details.
        private void FillContactInfoFields()
        {
            tbFirstName.Text = Contact.FirstName;
            tbLastName.Text = Contact.LastName;
            tbEmail.Text = Contact.Email;
            tbPhone.Text = Contact.Phone;
            dtpDateOfBirth.Value = Contact.DateOfBirth;
            FillCountryInfo(); // Fill country information.
            tbAddress.Text = Contact.Address;
            //Change ImagePath
            frmMain MainForm = this.ParentForm as frmMain;
            MainForm.ImagePath = Contact.ImagePath;
        }

        // Method to enable editing of contact information fields.
        private void EnableEditingInfos()
        {
            tbFirstName.Enabled = true;
            tbLastName.Enabled = true;
            tbEmail.Enabled = true;
            tbPhone.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            cbCountry.Enabled = true;
            tbAddress.Enabled = true;
        }

        // Event handler for when the selected index of the contact ID combo box changes.
        private void cbContactID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillContactObj(); // Load contact data based on selected ID.
            FillContactInfoFields(); // Populate fields with contact information.
            EnableEditingInfos(); // Enable fields for editing.
        }

        // Method to check if the selected country matches the contact's country.
        private bool IsCountryMatched()
        {
            clsCountry Country = clsBusinessLayer.FindCountry(Contact.CountryID);
            string CountryNameFromContactObj = Country.CountryName;
            string CountryNameFromCB = cbCountry.Text;

            return CountryNameFromContactObj == CountryNameFromCB;
        }

        // Method to check if the contact object matches the information fields.
        private bool ContactObjMatchInfoFields()
        {
            bool ContactIDMatched = Contact.ContactID == Convert.ToInt32(cbContactID.Text);
            bool FirstNameMatched = Contact.FirstName == tbFirstName.Text;
            bool LastNameMatched = Contact.LastName == tbLastName.Text;
            bool EmailMatched = Contact.Email == tbEmail.Text;
            bool PhoneMatched = Contact.Phone == tbPhone.Text;
            bool DateOfBirthMatched =
                Contact.DateOfBirth.ToString("dd/MM/yyyy") == dtpDateOfBirth.Value.ToString("dd/MM/yyyy");
            bool CountryMatched = IsCountryMatched();
            bool AddressMatched = Contact.Address == tbAddress.Text;

            return ContactIDMatched && FirstNameMatched && LastNameMatched && EmailMatched && PhoneMatched &&
                DateOfBirthMatched && CountryMatched && AddressMatched;
        }

        // Method to check if the image path has changed.
        private bool IsImagePathChanged()
        {
            frmMain MainForm = this.ParentForm as frmMain;
            string ImagePath = MainForm.ImagePath;

            return ImagePath != Contact.ImagePath;
        }

        // Method to validate if the first name is filled.
        private void CheckIfFirstNameFilled()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                epUpdateContact.SetError(tbFirstName, "First name must be entered!");
                BTNUpdateContactState.FirstNameFilled = false;
            }
            else
            {
                epUpdateContact.SetError(tbFirstName, "");
                BTNUpdateContactState.FirstNameFilled = true;
            }
        }

        // Method to validate if the last name is filled.
        private void CheckIfLastNameFilled()
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                epUpdateContact.SetError(tbLastName, "Last name must be entered!");
                BTNUpdateContactState.LastNameFilled = false;
            }
            else
            {
                epUpdateContact.SetError(tbLastName, "");
                BTNUpdateContactState.LastNameFilled = true;
            }
        }

        // Method to validate if the email is filled.
        private void CheckIfEmailFilled()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                epUpdateContact.SetError(tbEmail, "Email must be entered!");
                BTNUpdateContactState.EmailFilled = false;
            }
            else
            {
                epUpdateContact.SetError(tbEmail, "");
                BTNUpdateContactState.EmailFilled = true;
            }
        }

        // Method to validate if the phone number is filled.
        private void CheckIfPhoneFilled()
        {
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                epUpdateContact.SetError(tbPhone, "Phone number must be entered!");
                BTNUpdateContactState.PhoneFilled = false;
            }
            else
            {
                epUpdateContact.SetError(tbPhone, "");
                BTNUpdateContactState.PhoneFilled = true;
            }
        }

        // Method to validate if a country is chosen.
        private void CheckIfCountryChosen()
        {
            if (cbCountry.SelectedIndex == -1)
            {
                epUpdateContact.SetError(cbCountry, "Country must be chosen!");
                BTNUpdateContactState.CountryChosen = false;
            }
            else
            {
                epUpdateContact.SetError(cbCountry, "");
                BTNUpdateContactState.CountryChosen = true;
            }
        }

        // Method to validate if the address is filled.
        private void CheckIfAddressFilled()
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                epUpdateContact.SetError(tbAddress, "Address must be entered!");
                BTNUpdateContactState.AddressFilled = false;
            }
            else
            {
                epUpdateContact.SetError(tbAddress, "");
                BTNUpdateContactState.AddressFilled = true;
            }
        }

        // Method to validate the email format.
        private void CheckIfValidEmail()
        {
            if (!Regex.IsMatch(tbEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                epUpdateContact.SetError(tbEmail, "Invalid Email! Must contain @ and domain.");
                BTNUpdateContactState.EmailValid = false;
            }
            else
            {
                BTNUpdateContactState.EmailValid = true;
            }
        }

        // Method to validate the phone number format.
        private void CheckIfValidPhone()
        {
            if (!Regex.IsMatch(tbPhone.Text, @"^\+\d+$"))
            {
                epUpdateContact.SetError(tbPhone, "Invalid Phone! Must start with + followed by country code.");
                BTNUpdateContactState.PhoneValid = false;
            }
            else
            {
                BTNUpdateContactState.PhoneValid = true;
            }
        }

        // Method to check if the contact object has changed compared to the information fields.
        private void CheckIfContactObjectChanged()
        {
            if (ContactObjMatchInfoFields())
            {
                BTNUpdateContactState.IsContactObjectChanged = false;
            }
            else
            {
                BTNUpdateContactState.IsContactObjectChanged = true;
            }
        }

        // Method to update the state of the Update button based on validation results.
        private void UpdateBTNUpdateContactState()
        {
            if ((BTNUpdateContactState.FirstNameFilled && BTNUpdateContactState.LastNameFilled &&
                BTNUpdateContactState.EmailFilled && BTNUpdateContactState.EmailValid &&
                BTNUpdateContactState.PhoneFilled && BTNUpdateContactState.PhoneValid &&
                BTNUpdateContactState.CountryChosen && BTNUpdateContactState.AddressFilled &&
                BTNUpdateContactState.IsContactObjectChanged) ||
                IsImagePathChanged())
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        // Event handler for changes in the first name text box.
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckIfFirstNameFilled();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();
        }

        // Event handler for changes in the last name text box.
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            CheckIfLastNameFilled();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();
        }

        // Event handler for changes in the email text box.
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            CheckIfEmailFilled();
            CheckIfValidEmail();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();
        }

        // Event handler for changes in the phone number text box.
        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            CheckIfPhoneFilled();
            CheckIfValidPhone();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();
        }

        // Event handler for changes in the country combo box.
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfCountryChosen();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();

            // Update image path in the main form.
            frmMain MainForm = this.ParentForm as frmMain;
            MainForm.ImagePath = Contact.ImagePath;
        }

        // Event handler for changes in the address text box.
        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            CheckIfAddressFilled();
            CheckIfContactObjectChanged();
            UpdateBTNUpdateContactState();
        }

        // Method to update the country ID in the contact object.
        private void UpdateCountryID()
        {
            clsCountry Country = clsBusinessLayer.FindCountry(cbCountry.Text);
            Contact.CountryID = Country.CountryID;
        }

        // Method to update the contact object with current field values.
        private void UpdateContactObject()
        {
            Contact.ContactID = Convert.ToInt32(cbContactID.Text);
            Contact.FirstName = tbFirstName.Text;
            Contact.LastName = tbLastName.Text;
            Contact.Email = tbEmail.Text;
            Contact.Phone = tbPhone.Text;
            Contact.DateOfBirth = dtpDateOfBirth.Value;
            UpdateCountryID(); // Update country ID based on selection.
            Contact.Address = tbAddress.Text;

            // Update image path from the main form.
            frmMain MainForm = this.ParentForm as frmMain;
            Contact.ImagePath = MainForm.ImagePath;
        }

        // Method to confirm and execute the contact update action.
        private void ConfirmAction()
        {
            if (!clsBusinessLayer.IsContactExist(Contact))
            {
                clsBusinessLayer.UpdateContactRecord(Contact.ContactID, Contact);
                MessageBox.Show("Contact Updated Successfully :)", "Update", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to Update Contact!", "Update", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Method to reset the button state after update action.
        private void ResetBTNUpdateContactState()
        {
            BTNUpdateContactState.IsContactObjectChanged = false;
            btnUpdate.Enabled = false;
        }

        // Event handler for the Update button click.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateContactObject(); // Update contact object with current data.
            ConfirmAction(); // Confirm and execute update action.
            ResetBTNUpdateContactState(); // Reset button state.
        }

        // Method to enable the Update button (used externally).
        public void EnableUpdateBtn()
        {
            btnUpdate.Enabled = true;
        }
    }
}
