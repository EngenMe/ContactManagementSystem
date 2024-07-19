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
    public partial class ucContactsList : UserControl
    {
        // Constructor: Initializes the Contacts List user control.
        public ucContactsList()
        {
            InitializeComponent();
        }

        // Method to load contact data into the DataGridView.
        private void LoadData()
        {
            // Retrieve all contacts from the business layer as a DataTable.
            DataTable Contacts = clsBusinessLayer.GetAllContacts();

            // Set the DataSource of the DataGridView to the retrieved contacts.
            this.dgvContacts.DataSource = Contacts;
        }

        // Method to initialize the Contacts List user control.
        public void InitializeUCContactsList()
        {
            this.BringToFront(); // Bring this control to the front.
            LoadData(); // Load the contact data into the DataGridView.
        }
    }
}
