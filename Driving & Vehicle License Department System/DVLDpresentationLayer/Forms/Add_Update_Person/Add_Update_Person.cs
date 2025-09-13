using DVLDbusinessLayer;
using Login_And_Regester.My_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDbusinessLayer.clsPerson;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDpresentationLayer
{
    public partial class Add_Update_Person : Form
    {
        private Mode AddOrUpdateMode;
        private bool _HasDataChanged;

        // Declare a delegate
        public delegate void HasDataChangedBackEventHandler(object sender, bool _HasDataChanged);

        // Declare an event using the delegate
        public event HasDataChangedBackEventHandler DataBackHasDataChanged;

        clsPerson person = new clsPerson();

        public Add_Update_Person(int PersonID)
        {
            InitializeComponent();


            FillCountrys();

            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);   // youngest allowed
            dateTimePickerDateOfBirth.MinDate = DateTime.Now.AddYears(-100); // oldest allowed

            radioBtnGenderMale.Checked = true;

            if (PersonID == -1)
            {
                AddOrUpdateMode = (Mode.Add);
            }
            else
            {
                AddOrUpdateMode = (Mode.Update);
                person = clsPerson.Find(PersonID);
                LoadPersonCardInfo();
            }

            FormArrange();
        }

        void FillCountrys()
        {
            comboBoxCountry.Items.AddRange(clsPerson.GetAllCountries().ToArray());
            comboBoxCountry.SelectedIndex = 0;
        }

        public void LoadPersonCardInfo()
        {
            textBoxFirstName.Text = person.FirstName;
            textBoxSecondName.Text = person.SecondName;
            textBoxThirdName.Text = person.ThirdName;
            textBoxLastName.Text = person.LastName;

            textBoxNationalNo.Text = person.NationalNo.ToString();

            textBoxEmail.Text = person.Email;

            textBoxAdress.Text = person.Address;

            textBoxPhone.Text = person.Phone;

            if (person.Gender == 0)
            {
                radioBtnGenderMale.Checked = true;
            }
            else
            {
                radioBtnGenderFemale.Checked = true;
            }

            comboBoxCountry.SelectedIndex = person.NationalityCountryID - 1;

            if (person.ImagePath != "")
            {
                pictureBoxPersonProfile.ImageLocation = person.ImagePath;
                RemoveImageBtnVisiblty(true);
            }
            else
            {
                RemoveImageBtnVisiblty(false);
            }

            dateTimePickerDateOfBirth.Value = person.DateOfBirth;
        }


        //------------------------------------------------//

        public enum Mode
        {
            Update = 1,
            Add = 2
        }


        public void FormArrange()
        {
            if (AddOrUpdateMode == Mode.Update)
            {
                labelTitle.Text = "Update Person";
                buttonSave_Add.Text = "Save";
            }
            else if (AddOrUpdateMode == Mode.Add)
            {
                labelTitle.Text = "Add New Person";
                buttonSave_Add.Text = "Add";
            }

        }

        public int GetGender()
        {
            if (radioBtnGenderFemale.Checked)
            {
                return 1;
            }

            return 0;

        }

        public void ProfilepictureChangeByGender(object sender, EventArgs e)
        {
            if (pictureBoxPersonProfile.Image == null || pictureBoxPersonProfile.ImageLocation == null)
            {
                if (radioBtnGenderFemale.Checked)
                {
                    pictureBoxPersonProfile.Image = Properties.Resources.ProfilePic_person_Female_72x721; // your female image
                }
                else
                {
                    pictureBoxPersonProfile.Image = Properties.Resources.ProfilePic_person_Male_72x721; // your male image
                }
            }
        }

        public int GetCuntryNumber()
        {
            return comboBoxCountry.SelectedIndex + 1;
        }

        private bool AddPerson()
        {
            person = new clsPerson(-1, textBoxNationalNo.Text, textBoxFirstName.Text, textBoxSecondName.Text,
               textBoxThirdName.Text, textBoxLastName.Text, dateTimePickerDateOfBirth.Value, GetGender(), textBoxAdress.Text,
               textBoxPhone.Text, textBoxEmail.Text, GetCuntryNumber(),
               clsPerson.ImageSaveAndSendRealPath(openFileDialogSetImage.FileName));

            person.Mode = enMode.AddNew;
            return person.Save();
        }

        private bool UpdatePerson()
        {

            person = new clsPerson(person.PersonID, textBoxNationalNo.Text, textBoxFirstName.Text, textBoxSecondName.Text,
               textBoxThirdName.Text, textBoxLastName.Text, dateTimePickerDateOfBirth.Value, GetGender(), textBoxAdress.Text,
               textBoxPhone.Text, textBoxEmail.Text, GetCuntryNumber(),
               clsPerson.ImageSaveAndSendRealPath(pictureBoxPersonProfile.ImageLocation));

            person.Mode = enMode.Update;
            return person.Save();
        }

        private void CloseForm()
        {
            this.Close();
        }



        //--------------------------------------------------------------//
        public bool FirstNameCheck = false, SecondNameCheck = false, ThirdNameCheck = false, LastNameCheck = false, EmailCheck = false, PhoneNumberCheck = false, NationalNoCheck = false, SomethingChanged = false;


        private bool CheckAll()
        {
            return (FirstNameCheck && SecondNameCheck && ThirdNameCheck && LastNameCheck && EmailCheck && PhoneNumberCheck && NationalNoCheck && SomethingChanged);
        }

        private void RemoveImageBtnVisiblty(bool Visible)
        {
            linkLabelRemoveImage.Visible = Visible;

        }


        private bool EditModeIsSomethingChanged()
        {
            int SelectedGender = 0;

            if (radioBtnGenderMale.Checked == true)
            {
                SelectedGender = 0;
            }
            else
            {
                SelectedGender = 1;
            }

            string ImagePath = "";

            if (person.ImagePath == "")
            {
                ImagePath = null;
            }

            if (textBoxFirstName.Text == person.FirstName &&
            textBoxSecondName.Text == person.SecondName &&
            textBoxThirdName.Text == person.ThirdName &&
            textBoxLastName.Text == person.LastName &&
            textBoxNationalNo.Text == person.NationalNo.ToString() &&
            textBoxEmail.Text == person.Email &&
            textBoxAdress.Text == person.Address &&
            textBoxPhone.Text == person.Phone &&
            (person.NationalityCountryID - 1) == (comboBoxCountry.SelectedIndex) &&
            pictureBoxPersonProfile.ImageLocation == ImagePath &&
            SelectedGender == person.Gender
            )
            {
                return false;
            }
            return true;
        }

        //--------------------------------------------------------------------------------------//

        private void buttonSave_Add_Click(object sender, EventArgs e)
        {
            if (CheckAll())
            {
                if (AddOrUpdateMode == Mode.Add)
                {
                    if (AddPerson())
                    {
                        _HasDataChanged = true;
                        MessageBox.Show("The Person Has Been Added ^_^");
                        DataBackHasDataChanged?.Invoke(this, _HasDataChanged);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error :(");
                    }

                }
                else
                {

                    if (EditModeIsSomethingChanged())
                    {
                        if (UpdatePerson())
                        {
                            _HasDataChanged = true;
                            MessageBox.Show("The Person Has Been Updated ^_^");
                            DataBackHasDataChanged?.Invoke(this, _HasDataChanged);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error :(");
                        }

                    }
                    else
                    {
                        MessageBox.Show("U did not change anything @_@");
                        this.Close();
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (openFileDialogSetImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonProfile.Image = System.Drawing.Image.FromFile(openFileDialogSetImage.FileName);
                pictureBoxPersonProfile.ImageLocation = openFileDialogSetImage.FileName;
                SomethingChanged = true;
                RemoveImageBtnVisiblty(true);
            }

        }

        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GetGender() == 1)
            {
                pictureBoxPersonProfile.Image = Properties.Resources.ProfilePic_person_Female_72x721;
            }
            else
            {
                pictureBoxPersonProfile.Image = Properties.Resources.ProfilePic_person_Male_72x721;
            }

            pictureBoxPersonProfile.ImageLocation = null;

            SomethingChanged = true;

            RemoveImageBtnVisiblty(false);
        }


        //
        private void pictureBoxPersonProfile_LocationChanged(object sender, EventArgs e)
        {
            if (AddOrUpdateMode == Mode.Update)
            {
                SomethingChanged = true;
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddOrUpdateMode == Mode.Update)
            {
                SomethingChanged = true;
            }
        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (AddOrUpdateMode == Mode.Update)
            {
                SomethingChanged = true;
            }
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (AddOrUpdateMode == Mode.Update)
            {
                SomethingChanged = true;
            }
        }

        //--------------------------------------------------------------------------------------//

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.PhoneNumberValditor(textBoxPhone.Text))
            {
                if (textBoxPhone.Text == person.Phone)
                {
                    PhoneNumberCheck = true;
                    errorProvider.SetError(textBoxPhone, "");
                }
                else if (!clsPerson.IsPhoneExist(textBoxPhone.Text))
                {
                    PhoneNumberCheck = true;
                    errorProvider.SetError(textBoxPhone, "");
                }
                else
                {
                    PhoneNumberCheck = false;
                    errorProvider.SetError(textBoxPhone, "Phone Number is Already Used in another Account");
                }
            }
            else
            {
                PhoneNumberCheck = false;
                errorProvider.SetError(textBoxPhone, "Phone Number is Invald or Empty");
            }
        }

        private void textBoxNationalNo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNationalNo.Text))
            {
                if (textBoxNationalNo.Text == person.NationalNo)
                {
                    NationalNoCheck = true;
                    errorProvider.SetError(textBoxNationalNo, "");
                }
                else if (!clsPerson.IsNationalNoExist(textBoxNationalNo.Text))
                {
                    NationalNoCheck = true;
                    errorProvider.SetError(textBoxNationalNo, "");
                }
                else
                {
                    NationalNoCheck = false;
                    errorProvider.SetError(textBoxNationalNo, "National Number is Already Used in another Account");
                }
            }
            else
            {
                NationalNoCheck = false;
                errorProvider.SetError(textBoxNationalNo, "Cannot Left Empty");
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.EmailValditor(textBoxEmail.Text))
            {
                if (textBoxEmail.Text == person.Email)
                {
                    EmailCheck = true;
                    errorProvider.SetError(textBoxEmail, "");
                }
                else if (!clsPerson.IsEmailExist(textBoxEmail.Text))
                {
                    EmailCheck = true;
                    errorProvider.SetError(textBoxEmail, "");
                }
                else
                {
                    EmailCheck = false;
                    errorProvider.SetError(textBoxEmail, "Email Adress is Already Used in another Account");
                }
            }
            else
            {
                EmailCheck = false;
                errorProvider.SetError(textBoxEmail, "Email Adress is Invald or Empty");
            }
        }



        //----------------------------------------------------------------------------------//
        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.NameValditor(textBoxFirstName.Text))
            {
                FirstNameCheck = true;
                errorProvider.SetError(textBoxFirstName, "");
            }
            else
            {
                FirstNameCheck = false;
                errorProvider.SetError(textBoxFirstName, "invalid Name Or Empty");
            }
        }

        private void textBoxSecondName_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.NameValditor(textBoxSecondName.Text))
            {
                SecondNameCheck = true;
                errorProvider.SetError(textBoxSecondName, "");
            }
            else
            {
                SecondNameCheck = false;
                errorProvider.SetError(textBoxSecondName, "invalid Name Or Empty");
            }
        }

        private void textBoxThirdName_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.NameValditor(textBoxThirdName.Text))
            {
                ThirdNameCheck = true;
                errorProvider.SetError(textBoxThirdName, "");
            }
            else
            {
                ThirdNameCheck = false;
                errorProvider.SetError(textBoxThirdName, "invalid Name Or Empty");
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (InputValditionForLoginAndRegister.NameValditor(textBoxLastName.Text))
            {
                LastNameCheck = true;
                errorProvider.SetError(textBoxLastName, "");
            }
            else
            {
                LastNameCheck = false;
                errorProvider.SetError(textBoxLastName, "invalid Name Or Empty");
            }
        }

    }
}
