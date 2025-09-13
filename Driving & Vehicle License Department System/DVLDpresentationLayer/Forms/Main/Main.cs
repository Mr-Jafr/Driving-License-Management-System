using Login_And_Regester;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDpresentationLayer.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButtonPeople_Click(object sender, EventArgs e)
        {
            ManagePeople f = new ManagePeople();
            f.ShowDialog();
        }

        
        //--------------------------------------------------------------------//
        private void toolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemCurrentUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSignOut_Click(object sender, EventArgs e)
        {
            clsCurrentPerson.CurrentPerson = null;

            Login f = new Login();
            f.Show();
            this.Hide();
        }

    }
}
