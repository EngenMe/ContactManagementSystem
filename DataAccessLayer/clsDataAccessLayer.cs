using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    // Contains connection string details for accessing the database.
    public class clsServerInfo
    {
        // Connection string for connecting to the SQL Server database.
        public static string ConnectionString = "Server=.;Database=DB_Contacts;User Id=sa; Password=sa123456;";
    }

    // Represents the structure of a contact record in the database.
    public struct stContact
    {
        public int ContactID;       // Unique identifier for the contact.
        public string FirstName;    // First name of the contact.
        public string LastName;     // Last name of the contact.
        public string Email;        // Email address of the contact.
        public string Phone;        // Phone number of the contact.
        public string Address;      // Address of the contact.
        public DateTime DateOfBirth; // Date of birth of the contact.
        public int CountryID;       // Foreign key to the country record associated with the contact.
        public string ImagePath;    // File path for the contact's image.
    }

    // Represents the structure of a country record in the database.
    public struct stCountry
    {
        public int CountryID;       // Unique identifier for the country.
        public string CountryName;  // Name of the country.
        public string Code;         // Country code.
        public string PhoneCode;    // Country phone code.
    }

    // Data access class for handling operations related to contact records.
    public class clsContactDB
    {
        // Retrieves a contact record by its unique identifier.
        public static stContact GetLineRecord(int ContactID)
        {
            stContact Contact = new stContact();
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE ContactID = @ContactID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // Populate the contact structure with values from the database record.
                    Contact.ContactID = Convert.ToInt32(Reader["ContactID"]);
                    Contact.FirstName = Convert.ToString(Reader["FirstName"]);
                    Contact.LastName = Convert.ToString(Reader["LastName"]);
                    Contact.Email = Convert.ToString(Reader["Email"]);
                    Contact.Phone = Convert.ToString(Reader["Phone"]);
                    Contact.Address = Convert.ToString(Reader["Address"]);
                    Contact.DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Contact.CountryID = Convert.ToInt32(Reader["CountryID"]);
                    Contact.ImagePath = Convert.ToString(Reader["ImagePath"]);

                    Reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return Contact;
        }

        // Adds a new contact record to the database.
        public static bool AddRecordToContactDB(stContact NewContact)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, DateOfBirth,
                                                   CountryID, ImagePath)
                             VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @CountryID,
                                     @ImagePath);";
            SqlCommand Command = new SqlCommand(Query, Connection);

            // Set parameters for the SQL query.
            Command.Parameters.AddWithValue("@FirstName", NewContact.FirstName);
            Command.Parameters.AddWithValue("@LastName", NewContact.LastName);
            Command.Parameters.AddWithValue("@Email", NewContact.Email);
            Command.Parameters.AddWithValue("@Phone", NewContact.Phone);
            Command.Parameters.AddWithValue("@Address", NewContact.Address);
            Command.Parameters.AddWithValue("@DateOfBirth", NewContact.DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", NewContact.CountryID);
            Command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(NewContact.ImagePath) ? (object)System.DBNull.Value : NewContact.ImagePath);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Updates an existing contact record in the database.
        public static bool UpdateRecordInContactDB(int ContactID, stContact NewContact)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"UPDATE Contacts SET
                                 FirstName = @FirstName,
                                 LastName = @LastName,
                                 Email = @Email,
                                 Phone = @Phone,
                                 Address = @Address,
                                 DateOfBirth = @DateOfBirth,
                                 CountryID = @CountryID,
                                 ImagePath = @ImagePath
                             WHERE ContactID = @ContactID;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            // Set parameters for the SQL query.
            Command.Parameters.AddWithValue("@FirstName", NewContact.FirstName);
            Command.Parameters.AddWithValue("@LastName", NewContact.LastName);
            Command.Parameters.AddWithValue("@Email", NewContact.Email);
            Command.Parameters.AddWithValue("@Phone", NewContact.Phone);
            Command.Parameters.AddWithValue("@Address", NewContact.Address);
            Command.Parameters.AddWithValue("@DateOfBirth", NewContact.DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", NewContact.CountryID);
            Command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(NewContact.ImagePath) ? (object)System.DBNull.Value : NewContact.ImagePath);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Deletes a contact record from the database.
        public static bool DeleteRecordInContactDB(int ContactID)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"DELETE FROM Contacts WHERE ContactID = @ContactID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Retrieves a list of all contact IDs from the database.
        public static List<int> GetAllContactIDs()
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT ContactID FROM Contacts;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            List<int> ContactIDs = new List<int>();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    ContactIDs.Add(Convert.ToInt32(Reader["ContactID"]));
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return ContactIDs;
        }

        // Retrieves a DataTable containing all contact records from the database.
        public static DataTable GetAllContactsFromContactsDB()
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT * FROM Contacts;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable Data = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                Data.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return Data;
        }

        // Checks if a contact exists in the database by ID.
        public static bool IsContactExist(int ContactID)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT FOUND = 1 FROM Contacts WHERE ContactID = @ContactID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        // Checks if a contact exists in the database by its details.
        public static bool IsContactExist(stContact Contact)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"SELECT FOUND = 1 FROM Contacts 
                              WHERE 
                              (
                               FirstName = @FirstName AND
                               LastName = @LastName AND
                               Email = @Email AND
                               Phone = @Phone AND
                               Address = @Address AND
                               FORMAT(DateOfBirth, 'dd/MM/yyyy') = FORMAT(@DateOfBirth, 'dd/MM/yyyy') AND
                               CountryID = @CountryID AND
                               ImagePath = @ImagePath
                              );";
            SqlCommand Command = new SqlCommand(Query, Connection);

            // Set parameters for the SQL query.
            Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            Command.Parameters.AddWithValue("@LastName", Contact.LastName);
            Command.Parameters.AddWithValue("@Email", Contact.Email);
            Command.Parameters.AddWithValue("@Phone", Contact.Phone);
            Command.Parameters.AddWithValue("@Address", Contact.Address);
            Command.Parameters.AddWithValue("@DateOfBirth", Contact.DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);
            Command.Parameters.AddWithValue("@ImagePath", Contact.ImagePath);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }
    }

    // Data access class for handling operations related to country records.
    public class clsCountryDB
    {
        // Retrieves a country record by its unique identifier.
        public static stCountry GetLineRecord(int CountryID)
        {
            stCountry Country = new stCountry();
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT * FROM Countries WHERE CountryID = @CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // Populate the country structure with values from the database record.
                    Country.CountryID = Convert.ToInt32(Reader["CountryID"]);
                    Country.CountryName = Convert.ToString(Reader["CountryName"]);
                    Country.Code = Convert.ToString(Reader["Code"]);
                    Country.PhoneCode = Convert.ToString(Reader["PhoneCode"]);

                    Reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return Country;
        }

        // Overloaded method to retrieve a country record by country name.
        public static stCountry GetLineRecord(string CountryName)
        {
            stCountry Country = new stCountry();
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    // Populate the country structure with values from the database record.
                    Country.CountryID = Convert.ToInt32(Reader["CountryID"]);
                    Country.CountryName = Convert.ToString(Reader["CountryName"]);
                    Country.Code = Convert.ToString(Reader["Code"]);
                    Country.PhoneCode = Convert.ToString(Reader["PhoneCode"]);

                    Reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return Country;
        }

        // Adds a new country record to the database.
        public static bool AddRecordToCountryDB(stCountry NewCountry)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"INSERT INTO Countries (CountryName, Code, PhoneCode)
                             VALUES (@CountryName, @Code, @PhoneCode);";
            SqlCommand Command = new SqlCommand(Query, Connection);

            // Set parameters for the SQL query.
            Command.Parameters.AddWithValue("@CountryName", NewCountry.CountryName);
            Command.Parameters.AddWithValue("@Code", NewCountry.Code);
            Command.Parameters.AddWithValue("@PhoneCode", NewCountry.PhoneCode);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Updates an existing country record in the database.
        public static bool UpdateRecordInCountryDB(int CountryID, stCountry NewCountry)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"UPDATE Countries 
                             SET CountryName = @CountryName,
                                 Code = @Code,
                                 PhoneCode = @PhoneCode
                             WHERE CountryID = @CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            // Set parameters for the SQL query.
            Command.Parameters.AddWithValue("@CountryName", NewCountry.CountryName);
            Command.Parameters.AddWithValue("@Code", NewCountry.Code);
            Command.Parameters.AddWithValue("@PhoneCode", NewCountry.PhoneCode);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Deletes a country record from the database.
        public static bool DeleteRecordInCountryDB(int CountryID)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = @"DELETE FROM Countries WHERE CountryID = @CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            int NumRowsAffected = 0;
            try
            {
                Connection.Open();
                NumRowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return NumRowsAffected > 0;
        }

        // Retrieves a list of all country IDs from the database.
        public static List<int> GetAllCountryIDs()
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT CountryID FROM Countries;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            List<int> CountryIDs = new List<int>();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    CountryIDs.Add(Convert.ToInt32(Reader["CountryID"]));
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return CountryIDs;
        }

        // Retrieves a list of all country names from the database.
        public static List<string> GetAllCountryNames()
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT CountryName FROM Countries;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            List<string> CountryNames = new List<string>();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    CountryNames.Add(Convert.ToString(Reader["CountryName"]));
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return CountryNames;
        }

        // Retrieves a DataTable containing all country records from the database.
        public static DataTable GetAllCountriesFromCountriesDB()
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT * FROM Countries;";
            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable Data = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    Data.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return Data;
        }

        // Checks if a country exists in the database by its ID.
        public static bool IsCountryExist(int CountryID)
        {
            SqlConnection Connection = new SqlConnection(clsServerInfo.ConnectionString);
            string Query = "SELECT FOUND = 1 FROM Countries WHERE CountryID = @CountryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }
    }

    // Empty class for additional data access methods.
    public class clsDataAccessLayer
    {
    }
}
