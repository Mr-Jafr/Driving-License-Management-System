using DVLDcontactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDbusinessLayer
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }




        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        public clsPerson(int personID, string nationalNo, string firstName,
            string secondName, string thirdName, string lastName, DateTime dateOfBirth,
            int gender, string address, string phone, string email,
            int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
        }

        public bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPersonDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        public bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

        }

        public static clsPerson Find(int PersonID)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1, Gender = 0;


            if (clsPersonDataAccess.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                           Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static clsPerson Find(string UserName)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1, Gender = 0, PersonID = 0;


            if (clsPersonDataAccess.GetPersonInfoByUsername(UserName, ref PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                           Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }




            return false;
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccess.GetAllPersons();

        }

        
        
        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccess.DeletePerson(PersonID);
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPersonDataAccess.IsPersonExist(PersonID);
        }

        public static bool isPersonExist(string UserName)
        {
            return clsPersonDataAccess.IsPersonExist(UserName);
        }

        public static List<object> GetAllCountries()
        {
            return clsPersonDataAccess.GetAllCountries();
        }

        public static string GetCountry(int CountryID)
        {
            return clsPersonDataAccess.GetCountry(CountryID);
        }

        public static int Login(string UserName, string Password)
        {
            return clsPersonDataAccess.Login(UserName, Password);
        }

        public static bool IsNationalNoExist(string NationalNo)
        {
            return clsPersonDataAccess.IsNationalNoExist(NationalNo);
        }

        public static bool IsEmailExist(string Email)
        {
            return clsPersonDataAccess.IsEmailExist(Email);
        }

        public static bool IsPhoneExist(string Phone)
        {
            return clsPersonDataAccess.IsPhoneExist(Phone);
        }


        public static string ImageSaveAndSendRealPath(string OrginalPath = null)
        {
            if (OrginalPath != null)
            {
                // Get the selected file path
                string sourceFile = OrginalPath;

                // Make sure target folder exists
                string targetFolder = @"C:\DVLD-People-Images";
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                // Build destination path (same filename in C:\Images\)
                string extension = Path.GetExtension(sourceFile);
                string randomFileName = Guid.NewGuid().ToString() + extension;

                string destFile = Path.Combine(targetFolder, randomFileName);

                // Copy the file
                File.Copy(sourceFile, destFile, true); // true = overwrite if exists

                // Show it in PictureBox
                return destFile;
            }
            else
            {
                return "";
            }

        }
    }
}
