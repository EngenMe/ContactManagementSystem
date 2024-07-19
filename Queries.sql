-- SQL Queries for Contact Management System

-- Create Contacts Table
CREATE TABLE Contacts (
    ContactID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Phone NVARCHAR(15),
    Address NVARCHAR(255),
    DateOfBirth DATE,
    CountryID INT,
    ImagePath NVARCHAR(255)
);

-- Create Countries Table
CREATE TABLE Countries (
    CountryID INT PRIMARY KEY IDENTITY,
    CountryName NVARCHAR(100),
    Code NVARCHAR(10),
    PhoneCode NVARCHAR(10)
);

-- Insert Sample Data into Contacts Table
INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
VALUES ('John', 'Doe', 'john.doe@example.com', '123-456-7890', '123 Elm St', '1980-01-01', 1, 'path/to/image.jpg');

-- Insert Sample Data into Countries Table
INSERT INTO Countries (CountryName, Code, PhoneCode)
VALUES ('United States', 'US', '+1');

-- Select All Contacts
SELECT * FROM Contacts;

-- Update Contact Information
UPDATE Contacts
SET Email = 'new.email@example.com'
WHERE ContactID = 1;

-- Delete a Contact
DELETE FROM Contacts
WHERE ContactID = 1;

-- Select All Countries
SELECT * FROM Countries;
