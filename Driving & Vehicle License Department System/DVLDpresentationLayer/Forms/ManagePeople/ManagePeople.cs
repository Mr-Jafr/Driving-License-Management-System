using DVLDbusinessLayer;
using DVLDpresentationLayer.Forms.PersonInfo;
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
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
            FillPersonsInfo();
        }

        public void FillPersonsInfo()
        {
            DataTable dt = clsPerson.GetAllPersons();
            FillFilter(dt);
            labelRecords.Text = "# " + dt.Rows.Count.ToString();
            dataGridViewPersonsInfo.DataSource = dt;

        }

        public void FillFilter(DataTable dt)
        {
            comboBoxFilterBy.Items.Clear(); // optional: clear old items
            foreach (DataColumn column in dt.Columns)
            {
                comboBoxFilterBy.Items.Add(column.ColumnName);
            }

        }


        //----------------//
        private bool _HasDataChanged = false;
        private void GetResulteDataBackHasDataChanged(object sender, bool HasDataChanged)
        {
            _HasDataChanged = HasDataChanged;
        }
        //----------------//

        public void OpenAdd_EditPersonForm(int PersonID)
        {
            Add_Update_Person f = new Add_Update_Person(PersonID);

            f.DataBackHasDataChanged += GetResulteDataBackHasDataChanged; // Subscribe to the event

            f.ShowDialog();

            if (_HasDataChanged)
            {
                FillPersonsInfo();
            }
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridViewPersonsInfo.Sort(dataGridViewPersonsInfo.Columns[comboBoxFilterBy.SelectedItem.ToString()], ListSortDirection.Ascending);
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            OpenAdd_EditPersonForm(-1);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPerson.isPersonExist(GetPersonIDFromDataTable()))
            {
                OpenAdd_EditPersonForm(GetPersonIDFromDataTable());
            }
            else
            {
                MessageBox.Show("Please Select Person @_@");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPerson.isPersonExist(GetPersonIDFromDataTable()))
            {
                if (MessageBox.Show("Are you sure about the delete?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsPerson.DeletePerson(GetPersonIDFromDataTable()))
                    {
                        MessageBox.Show("Delete is Done +_+");
                        FillPersonsInfo();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Person @_@");
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPerson.isPersonExist(GetPersonIDFromDataTable()))
            {
                ShowPersonDetails(GetPersonIDFromDataTable());
            }
            else
            {
                MessageBox.Show("Please Select Person @_@");
            }
        }



        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAdd_EditPersonForm(-1);
        }

        //----------------------------------------------------------------------------------//

        private int GetPersonIDFromDataTable()
        {
            if (dataGridViewPersonsInfo.SelectedRows.Count > 0)
            {
                int personID = Convert.ToInt32(dataGridViewPersonsInfo.SelectedRows[0].Cells["PersonID"].Value);
                return personID;
            }
            else
            {
                return (-1);
            }
        }

        private void ShowPersonDetails(int PersonID)
        {
            ShowPersonInfo f = new ShowPersonInfo(PersonID);
            f.ShowDialog();
            FillPersonsInfo();
        }

    }
}
