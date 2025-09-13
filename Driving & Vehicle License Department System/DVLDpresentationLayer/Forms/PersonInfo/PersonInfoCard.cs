using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDpresentationLayer.Forms.PersonInfo
{
    public partial class ShowPersonInfo : Form
    {
        private int CurrentPersonID;
        private bool _HasDataChanged = false;
        public ShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            CurrentPersonID = PersonID;

            LoadPersonCardInfo();
        }

        private void CloseForm()
        {
            this.Close();
        }
        public void LoadPersonCardInfo()
        {
            personCardInfo1.LoadPersonCardInfo(CurrentPersonID);
        }

        //---------------------------------------------------------//

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void GetResulteDataBackHasDataChanged(object sender, bool HasDataChanged)
        {
            _HasDataChanged = HasDataChanged;
        }
        private void linkLabelEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Update_Person f = new Add_Update_Person(CurrentPersonID);

            f.DataBackHasDataChanged += GetResulteDataBackHasDataChanged; // Subscribe to the event

            f.ShowDialog();

            if (_HasDataChanged)
            {
                LoadPersonCardInfo();
            }
        }
    }
}
