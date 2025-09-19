using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using System.IO;

namespace DVLDcontactsDataAccessLayer
{
    public class clsPersonDataAccess
    {

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref int Gender, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID,
            ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DVLD.dbo.People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    Gender = Convert.ToInt32(reader["Gender"]);
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonInfoByUsername(string UserName, ref int PersonID, ref string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName,
            ref DateTime DateOfBirth, ref int Gender, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID,
            ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT  People.* FROM  Users INNER JOIN   People ON Users.PersonID = People.PersonID where Users.UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];

                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    Gender = Convert.ToInt32(reader["Gender"]);
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int AddNewPerson(string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address,
            string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ContactID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DVLD.dbo.People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender,
                             Address, Phone, Email, NationalityCountryID, ImagePath)
                             VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender,
                             @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ContactID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ContactID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName,
            string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, int Gender, string Address,
            string Phone, string Email, int NationalityCountryID,
            string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  DVLD.dbo.People  
                            set FirstName = @FirstName, 
                                SecondName = @SecondName, 
                                ThirdName = @ThirdName, 
                                LastName = @LastName, 
                                DateOfBirth = @DateOfBirth,
                                Gender = @Gender,
                                Address = @Address, 
                                Phone = @Phone, 
                                Email = @Email, 
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
                clsPersonDataAccess.DeletePersonImgFromMemory(clsPersonDataAccess.GetPersonProfileImgPath(PersonID));
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                clsPersonDataAccess.DeletePersonImgFromMemory(clsPersonDataAccess.GetPersonProfileImgPath(PersonID));
            }
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllPersons()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DVLD.dbo.People.PersonID as 'Person ID', DVLD.dbo.People.NationalNo as 'National No',
                             DVLD.dbo.People.FirstName as 'First Name', 
                             DVLD.dbo.People.SecondName as 'Second Name', DVLD.dbo.People.ThirdName as 'Third Name',
                             DVLD.dbo.People.LastName as 'Last Name',  DVLD.dbo.People.DateOfBirth as 'Date Of Birth',
                             CASE DVLD.dbo.People.Gender  WHEN 0 THEN 'Male'  WHEN 1 THEN 'Female' END AS Gender,
                             DVLD.dbo.People.Address, DVLD.dbo.People.Phone, DVLD.dbo.People.Email,
                             DVLD.dbo.Countries.CountryName as 'Country Name',
                             DVLD.dbo.People.ImagePath FROM DVLD.dbo.People INNER JOIN DVLD.dbo.Countries
                             ON DVLD.dbo.People.NationalityCountryID = DVLD.dbo.Countries.CountryID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT DVLD.dbo.Users.UserID as 'User ID', DVLD.dbo.Users.PersonID as 'Person ID',
                             (DVLD.dbo.People.FirstName + ' ' + DVLD.dbo.People.SecondName + ' ' +
                             DVLD.dbo.People.ThirdName + ' ' + DVLD.dbo.People.LastName) as 'Full Name',
                             DVLD.dbo.Users.UserName, DVLD.dbo.Users.IsActive
                             FROM DVLD.dbo.Users INNER JOIN
                             DVLD.dbo.People ON DVLD.dbo.Users.PersonID = DVLD.dbo.People.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static void DeletePersonImgFromMemory(string ImagePath)
        {
            if (File.Exists(ImagePath))
            {
                File.Delete(ImagePath);
            }
        }

        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete DVLD.dbo.People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

                DeletePersonImgFromMemory(clsPersonDataAccess.GetPersonProfileImgPath(PersonID));
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static string GetPersonProfileImgPath(int PersonID)
        {
            string ImagePath = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select DVLD.dbo.People.ImagePath from DVLD.dbo.People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                {
                    // The record was not found
                    return ImagePath;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ImagePath;
            }
            finally
            {
                connection.Close();
            }

            return ImagePath;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DVLD.dbo.People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int Login(string UserName, string Password)
        {
            int Result = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            // Case 1: username/password found but inactive → return 0
            // Case 2: username/password found and active → return PersonID
            // Case 3: username/password not found at all → return -1
            string query = @"
            SELECT 
                CASE 
                    WHEN EXISTS (SELECT 1 FROM DVLD.dbo.Users WHERE UserName = @UserName AND Password = @Password AND IsActive = 0) 
                        THEN 0
                    WHEN EXISTS (SELECT 1 FROM DVLD.dbo.Users WHERE UserName = @UserName AND Password = @Password AND IsActive = 1) 
                        THEN (SELECT PersonID FROM DVLD.dbo.Users WHERE UserName = @UserName AND Password = @Password AND IsActive = 1)
                    ELSE -1 
                END AS Result;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                object resultObj = command.ExecuteScalar();  // we only need one value

                if (resultObj != null && resultObj != DBNull.Value)
                    Result = Convert.ToInt32(resultObj);


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                Result = -1;
            }
            finally
            {
                connection.Close();
            }

            return Result;
        }

        public static List<object> GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select DVLD.dbo.Countries.CountryName from DVLD.dbo.Countries";

            SqlCommand command = new SqlCommand(query, connection);

            List<object> Result = new List<object>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    Result.Add(reader["CountryName"].ToString());
                }

                if (Result.Count < 1)
                {
                    Result.Add("No countries found.");
                }

                reader.Close();
                return Result;
            }
            catch (Exception ex)
            {
                return Result;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string GetCountry(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select DVLD.dbo.Countries.CountryName from DVLD.dbo.Countries where DVLD.dbo.Countries.CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            string Result = "";

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Result = reader["CountryName"].ToString();
                }
                else
                {
                    Result = "No countries found.";
                }


                reader.Close();
                return Result;
            }
            catch (Exception ex)
            {
                return Result;
            }
            finally
            {
                connection.Close();
            }
        }

        //-------------------------------------------------------------//

        public static bool IsNationalNoExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DVLD.dbo.People WHERE @NationalNo = NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool IsEmailExist(string Email)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DVLD.dbo.People WHERE @Email = Email";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Email", Email);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool IsPhoneExist(string Phone)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM DVLD.dbo.People WHERE @Phone = Phone";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

    }


}
