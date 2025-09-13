using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login_And_Regester.My_Classes
{
    public class InputValditionForLoginAndRegister
    {
        //------------------------------------------------------------------//
        // التحقق من صحة البريد الإلكتروني
        public static bool EmailValditor(string Email)
        {
            return Regex.IsMatch(Email, "^[a-zA-Z][_a-zA-Z0-9]*@(gmail|hotmail|yahoo|)\\.(com|iq|org)$");
        }




        public static bool UsernameValditor(string Username)
        {
            return Regex.IsMatch(Username, "^[a-zA-Z][_a-zA-Z0-9]*$");
        }

        //------------------------------------------------------------------//
        // التحقق من صحة رقم الهاتف
        public static bool PhoneNumberValditor(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, "^(0771|0780|0781|0770)\\d{7}$");
        }

        //------------------------------------------------------------------//
        // التحقق من صحة كلمة المرور
        public static bool PasswordValditor(string Password)
        {
            return Regex.IsMatch(Password, @"^[a-zA-Z0-9@_-]{4,}$");
        }

        public static bool NameValditor(string Name)
        {
            return Regex.IsMatch(Name, @"^[a-zA-Z-]{1,}$");
        }
    }
}
