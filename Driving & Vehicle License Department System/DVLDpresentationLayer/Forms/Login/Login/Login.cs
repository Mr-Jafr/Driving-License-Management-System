using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDbusinessLayer;
using DVLDpresentationLayer;
using DVLDpresentationLayer.Forms;
using Login_And_Regester.My_Classes;

namespace Login_And_Regester
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoadLoginCredentials();
        }

        private void GoToMainForm()
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private bool CheckEmailAndPasswordEmpty()
        {
            short ErrorCounter = 0;

            if (txtBoxUsername.Text.Length == 0)
            {
                lblEmailRequired.Visible = true;
                ErrorCounter++;
            }
            else
            {
                lblEmailRequired.Visible = false;
            }

            if (txtBoxPassword.Text.Length == 0)
            {
                lblPasswordRequired.Visible = true;
                ErrorCounter++;
            }
            else
            {
                lblPasswordRequired.Visible = false;
            }

            return ErrorCounter == 0 ? true : false;
        }

        private void SaveLoginCredentials()
        {
            string filePath = "RememberMeFile.txt";

            // ===== Writing to a file using StreamWriter =====
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(txtBoxUsername.Text);
                writer.WriteLine(txtBoxPassword.Text);
            } // writer is closed automatically here

        }

        private void LoadLoginCredentials()
        {
            List<string> AccountInfo = new List<string> { };

            string line = "";

            // ===== Reading from a file using StreamReader =====
            using (StreamReader reader = new StreamReader(@"RememberMeFile.txt"))
            {
                bool IsInfoFound = false;
                while ((line = reader.ReadLine()) != null)
                {
                    AccountInfo.Add(line);
                    cbRememberMe.Checked = true;
                    IsInfoFound = true;
                }

                if (IsInfoFound)
                {
                    txtBoxUsername.Text = AccountInfo[0];
                    txtBoxPassword.Text = AccountInfo[1];
                }
            }
            // reader is closed automatically here
        }

        private void ClearLoginCredentials()
        {
            string filePath = "RememberMeFile.txt";

            // ===== Writing to a file using StreamWriter =====
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write("");
            } // writer is closed automatically here
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckEmailAndPasswordEmpty())
            {


                if (InputValditionForLoginAndRegister.UsernameValditor(txtBoxUsername.Text) &&
                    InputValditionForLoginAndRegister.PasswordValditor(txtBoxPassword.Text))
                {
                    int LoginResult = clsPerson.Login(txtBoxUsername.Text, txtBoxPassword.Text);

                    if (LoginResult > 0)
                    {
                        clsCurrentPerson.CurrentPerson = clsPerson.Find(txtBoxUsername.Text);

                        if (cbRememberMe.Checked)
                        {
                            SaveLoginCredentials();
                        }
                        else
                        {
                            ClearLoginCredentials();
                        }

                        GoToMainForm();
                    }
                    else if (LoginResult == 0)
                    {
                        MessageBox.Show("This Account is InActive :(", "InActive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password :(", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        //------------------------------------------------------------------//
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.PasswordValditor(txtBoxPassword.Text))
            {
                txtBoxPassword.ForeColor = Color.Black;
                toolTipForPasswordAndEmail.SetToolTip(txtBoxPassword, ""); // Clear tooltip
            }
            else
            {
                txtBoxPassword.ForeColor = Color.Red;
                toolTipForPasswordAndEmail.SetToolTip(txtBoxPassword, "Invalid Characters @_@");
            }
        }

        private void cbRevelPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRevelPassword.Checked)
            {
                txtBoxPassword.PasswordChar = '\0'; // عرض كلمة المرور
            }
            else
            {
                txtBoxPassword.PasswordChar = '*'; // إخفاء كلمة المرور
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.UsernameValditor(txtBoxUsername.Text))
            {
                txtBoxUsername.ForeColor = Color.Black;
                toolTipForPasswordAndEmail.SetToolTip(txtBoxUsername, ""); // Clear tooltip
            }
            else
            {
                txtBoxUsername.ForeColor = Color.Red;
                toolTipForPasswordAndEmail.SetToolTip(txtBoxUsername, "Invalid Password @_@");
            }
        }
    }
}
