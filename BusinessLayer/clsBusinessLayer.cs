using System;
using System.Collections.Generic;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    // Represents a contact entity with properties for storing contact information.
    public class clsContact
    {
        private int _ContactID; // Unique identifier for the contact.
        private string _FirstName; // First name of the contact.
        private string _LastName; // Last name of the contact.
        private string _Email; // Email address of the contact.
        private string _Phone; // Phone number of the contact.
        private string _Address; // Address of the contact.
        private DateTime _DateOfBirth; // Date of birth of the contact.
        private int _CountryID; // ID of the country associated with the contact.
        private string _ImagePath; // Path to the contact's image.

        // Properties to access and modify the private fields.
        public int ContactID
        {
            get { return _ContactID; }
            set { _ContactID = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }
        public int CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        // Constructors for creating a clsContact object with various combinations of parameters.
        public clsContact(int ContactID, string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            _ContactID = ContactID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
            _Address = Address;
            _DateOfBirth = DateOfBirth;
            _CountryID = CountryID;
            _ImagePath = ImagePath;
        }
        public clsContact(int ContactID, string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID)
        {
            _ContactID = ContactID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
            _Address = Address;
            _DateOfBirth = DateOfBirth;
            _CountryID = CountryID;
        }
        public clsContact(string FirstName, string LastName, string Email, string Phone, string Address,
            DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            _ContactID = 0; // Default ContactID for a new contact.
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
            _Address = Address;
            _DateOfBirth = DateOfBirth;
            _CountryID = CountryID;
            _ImagePath = ImagePath;
        }
        public clsContact(string FirstName, string LastName, string Email, string Phone, string Address,
            DateTime DateOfBirth, int CountryID)
        {
            _ContactID = 0; // Default ContactID for a new contact.
            _FirstName = FirstName;
            _LastName = LastName;
            _Email = Email;
            _Phone = Phone;
            _Address = Address;
            _DateOfBirth = DateOfBirth;
            _CountryID = CountryID;
            _ImagePath = string.Empty; // Default empty image path.
        }
        public clsContact(int ContactID)
        {
            _ContactID = ContactID;
            _FirstName = string.Empty;
            _LastName = string.Empty;
            _Email = string.Empty;
            _Phone = string.Empty;
            _Address = string.Empty;
            _DateOfBirth = DateTime.MinValue;
            _CountryID = 0;
            _ImagePath = string.Empty;
        }
        public clsContact()
        {
            _ContactID = 0;
            _FirstName = string.Empty;
            _LastName = string.Empty;
            _Email = string.Empty;
            _Phone = string.Empty;
            _Address = string.Empty;
            _DateOfBirth = DateTime.MinValue;
            _CountryID = 0;
            _ImagePath = string.Empty;
        }

        // Method to check if the contact is empty (not present in the database).
        public bool IsEmptyContact()
        {
            return !clsBusinessLayer.IsContactExist(this.ContactID);
        }

        // Method to check if the contact exists in the database.
        public bool IsContactExist()
        {
            return clsContactDB.IsContactExist(this.ContactID);
        }
    }

    // Represents a country entity with properties for storing country information.
    public class clsCountry
    {
        private int _CountryID; // Unique identifier for the country.
        private string _CountryName; // Name of the country.
        private string _Code; // Code of the country (e.g., ISO code).
        private string _PhoneCode; // Phone code of the country.

        // Properties to access and modify the private fields.
        public int CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }
        public string CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string PhoneCode
        {
            get { return _PhoneCode; }
            set { _PhoneCode = value; }
        }

        // Constructors for creating a clsCountry object with various combinations of parameters.
        public clsCountry(int CountryID, string CountryName, string Code, string PhoneCode)
        {
            _CountryID = CountryID;
            _CountryName = CountryName;
            _Code = Code;
            _PhoneCode = PhoneCode;
        }
        public clsCountry(string CountryName, string Code, string PhoneCode)
        {
            _CountryName = CountryName;
            _Code = Code;
            _PhoneCode = PhoneCode;
        }
        public clsCountry(int CountryID)
        {
            _CountryID = CountryID;
        }
        public clsCountry(string CountryName)
        {
            _CountryName = CountryName;
        }

        // Method to check if the country is empty (not present in the database).
        public bool IsEmptyCountry()
        {
            return !clsBusinessLayer.IsCountryExist(this.CountryID);
        }

        // Method to check if the country exists in the database.
        public bool IsCountryExist()
        {
            return clsCountryDB.IsCountryExist(this.CountryID);
        }
    }

    // Contains business logic for handling contact and country entities.
    public class clsBusinessLayer
    {
        // Converts a stContact structure to a clsContact object.
        private static clsContact _ConvertStructToCls(int ContactID, stContact stContact)
        {
            clsContact Contact = new clsContact(ContactID);

            Contact.FirstName = stContact.FirstName;
            Contact.LastName = stContact.LastName;
            Contact.Email = stContact.Email;
            Contact.Phone = stContact.Phone;
            Contact.Address = stContact.Address;
            Contact.DateOfBirth = stContact.DateOfBirth;
            Contact.CountryID = stContact.CountryID;
            Contact.ImagePath = stContact.ImagePath;

            return Contact;
        }

        // Converts a stCountry structure to a clsCountry object.
        private static clsCountry _ConvertStructToCls(int CountryID, stCountry stCountry)
        {
            clsCountry Country = new clsCountry(CountryID);

            Country.CountryName = stCountry.CountryName;
            Country.Code = stCountry.Code;
            Country.PhoneCode = stCountry.PhoneCode;

            return Country;
        }

        // Converts a stCountry structure to a clsCountry object using country name.
        private static clsCountry _ConvertStructToCls(string CountryName, stCountry stCountry)
        {
            clsCountry Country = new clsCountry(CountryName);

            Country.CountryID = stCountry.CountryID;
            Country.Code = stCountry.Code;
            Country.PhoneCode = stCountry.PhoneCode;

            return Country;
        }

        // Converts a clsContact object to a stContact structure.
        private static stContact _ConvertClsToStruct(clsContact Contact)
        {
            stContact stContact = new stContact();

            stContact.ContactID = Contact.ContactID;
            stContact.FirstName = Contact.FirstName;
            stContact.LastName = Contact.LastName;
            stContact.Email = Contact.Email;
            stContact.Phone = Contact.Phone;
            stContact.Address = Contact.Address;
            stContact.DateOfBirth = Contact.DateOfBirth;
            stContact.CountryID = Contact.CountryID;
            stContact.ImagePath = Contact.ImagePath;

            return stContact;
        }

        // Converts a clsCountry object to a stCountry structure.
        private static stCountry _ConvertClsToStruct(clsCountry Country)
        {
            stCountry stCountry = new stCountry();

            stCountry.CountryID = Country.CountryID;
            stCountry.CountryName = Country.CountryName;
            stCountry.Code = Country.Code;
            stCountry.PhoneCode = Country.PhoneCode;

            return stCountry;
        }

        // Finds a contact by ID and returns a clsContact object.
        public static clsContact FindContact(int ContactID)
        {
            stContact stContact = clsContactDB.GetLineRecord(ContactID);
            clsContact Contact = _ConvertStructToCls(ContactID, stContact);

            return Contact;
        }

        // Finds a country by ID and returns a clsCountry object.
        public static clsCountry FindCountry(int CountryID)
        {
            stCountry stCountry = clsCountryDB.GetLineRecord(CountryID);
            clsCountry Country = _ConvertStructToCls(CountryID, stCountry);

            return Country;
        }

        // Finds a country by name and returns a clsCountry object.
        public static clsCountry FindCountry(string CountryName)
        {
            stCountry stCountry = clsCountryDB.GetLineRecord(CountryName);
            clsCountry Country = _ConvertStructToCls(CountryName, stCountry);

            return Country;
        }

        // Adds a new contact record to the database.
        public static bool AddContactRecord(clsContact NewContact)
        {
            return clsContactDB.AddRecordToContactDB(_ConvertClsToStruct(NewContact));
        }

        // Adds a new country record to the database.
        public static bool AddCountryRecord(clsCountry NewCountry)
        {
            return clsCountryDB.AddRecordToCountryDB(_ConvertClsToStruct(NewCountry));
        }

        // Updates an existing contact record in the database.
        public static bool UpdateContactRecord(int ContactID, clsContact NewContact)
        {
            return clsContactDB.UpdateRecordInContactDB(ContactID, _ConvertClsToStruct(NewContact));
        }

        // Updates an existing country record in the database.
        public static bool UpdateCountryRecord(int CountryID, clsCountry NewCountry)
        {
            return clsCountryDB.UpdateRecordInCountryDB(CountryID, _ConvertClsToStruct(NewCountry));
        }

        // Deletes a contact record from the database by ID.
        public static bool DeleteRecordInContact(int ContactID)
        {
            return clsContactDB.DeleteRecordInContactDB(ContactID);
        }

        // Deletes a country record from the database by ID.
        public static bool DeleteRecordInCountry(int CountryID)
        {
            return clsCountryDB.DeleteRecordInCountryDB(CountryID);
        }

        // Retrieves a list of all contact IDs from the database.
        public static List<int> GetAllContactIDs()
        {
            return clsContactDB.GetAllContactIDs();
        }

        // Retrieves a list of all country IDs from the database.
        public static List<int> GetAllCountryIDs()
        {
            return clsCountryDB.GetAllCountryIDs();
        }

        // Retrieves a list of all country names from the database.
        public static List<string> GetAllCountryNames()
        {
            return clsCountryDB.GetAllCountryNames();
        }

        // Retrieves a DataTable with all contacts from the database.
        public static DataTable GetAllContacts()
        {
            return clsContactDB.GetAllContactsFromContactsDB();
        }

        // Retrieves a DataTable with all countries from the database.
        public static DataTable GetAllCountries()
        {
            return clsCountryDB.GetAllCountriesFromCountriesDB();
        }

        // Checks if a contact exists in the database by ID.
        public static bool IsContactExist(int ContactID)
        {
            return clsContactDB.IsContactExist(ContactID);
        }

        // Checks if a contact exists in the database by contact object.
        public static bool IsContactExist(clsContact Contact)
        {
            stContact stContact = _ConvertClsToStruct(Contact);

            return clsContactDB.IsContactExist(stContact);
        }

        // Checks if a country exists in the database by ID.
        public static bool IsCountryExist(int CountryID)
        {
            return clsCountryDB.IsCountryExist(CountryID);
        }
    }
}
