using DVLDbusinessLayer;
using DVLDpresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDpresentationLayer
{
    public partial class PersonCardInfo : UserControl
    {
        public PersonCardInfo()
        {
            InitializeComponent();
        }

        public void LoadPersonCardInfo(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);

            if (person == null)
            {
                MessageBox.Show($"There is no Person with ID : {PersonID}");
            }
            else
            {

                lableshowPersonID.Text = person.PersonID.ToString();

                labelshowName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " "+ person.LastName;
                

                labelshowNationalNo.Text = person.NationalNo.ToString();

                labelshowEmail.Text = person.Email;

                labelshowAdress.Text = person.Address;

                labelshowPhone.Text = person.Phone;

                if (person.Gender == 0)
                {
                    labelshowGender.Text = "Male"; 
                pictureBoxGender.Image = Properties.Resources.Label_admin_32x32;
                    pictureBoxPersonProfile.Image  = Properties.Resources.ProfilePic_person_Male_72x72;


                }
                else
                {
                    labelshowGender.Text = "Female";
                pictureBoxGender.Image = Properties.Resources.Label_admin_female_32x32;
                    pictureBoxPersonProfile.Image  = Properties.Resources.ProfilePic_person_Female_72x72;
                }

                if (person.ImagePath != "")
                {
                    pictureBoxPersonProfile.ImageLocation = person.ImagePath;
                }
                
                labelshowCountry.Text = clsPerson.GetCountry(person.NationalityCountryID);

                labelshowDateOfBirth.Text = person.DateOfBirth.ToString("yyyy/MM/dd");
            }
        }
    }
}
