using DVLDbusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDpresentationLayer.Forms.ManageUsers
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            FillUsersInfo();
        }

        public void FillUsersInfo()
        {
            DataTable dt = clsPerson.GetAllUsers();
            FillFilter(dt);
            labelRecords.Text = "# " + dt.Rows.Count.ToString();
            dataGridViewUsersInfo.DataSource = dt;

        }

        public void FillFilter(DataTable dt)
        {
            comboBoxFilterBy.Items.Clear(); // optional: clear old items
            foreach (DataColumn column in dt.Columns)
            {
                comboBoxFilterBy.Items.Add(column.ColumnName);
            }

            comboBoxFilterBy.Items.Add("None");
            comboBoxFilterBy.SelectedItem = "None";
        }

        private void RestFillterToDefult()
        {
            DataTable dt = (DataTable)dataGridViewUsersInfo.DataSource;
            dt.DefaultView.RowFilter = ""; // Show all rows
        }

        //--------------------------------------------------------------//

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterBy.SelectedItem.ToString() == "IsActive")
            {
                comboBoxIsActiveChoice.Visible = true;
                textBoxMoreFillter.Visible = false;
            }
            else if (comboBoxFilterBy.SelectedItem.ToString() != "None")
            {
                textBoxMoreFillter.Visible = true;
                comboBoxIsActiveChoice.Visible = false;
            }
            else
            {
                comboBoxIsActiveChoice.Visible = false;
                textBoxMoreFillter.Visible = false;
            }
        }

        private void comboBoxIsActiveChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = comboBoxIsActiveChoice.SelectedItem.ToString();
            DataTable dt = (DataTable)dataGridViewUsersInfo.DataSource;

            if (dt != null)
            {
                if (choice == "All")
                {
                    dt.DefaultView.RowFilter = ""; // Show all rows
                }
                else if (choice == "Yes")
                {
                    dt.DefaultView.RowFilter = "IsActive = true";
                }
                else if (choice == "No")
                {
                    dt.DefaultView.RowFilter = "IsActive = false";
                }
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxMoreFillter_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridViewUsersInfo.DataSource;

            switch (comboBoxFilterBy.SelectedItem.ToString())
            {
                case "User ID":
                    {
                        // Assuming UserID is numeric
                        dt.DefaultView.RowFilter = $"Convert([User ID], 'System.String') LIKE '{textBoxMoreFillter.Text}%'";
                    }
                    break;

                case "Person ID":
                    {
                        dt.DefaultView.RowFilter = $"Convert([Person ID], 'System.String') LIKE '{textBoxMoreFillter.Text}%'";
                    }
                    break;

                case "Full Name":
                    {
                        dt.DefaultView.RowFilter = $"[Full Name] LIKE '{textBoxMoreFillter.Text}%'";
                    }
                    break;

                case "UserName":
                    {
                        dt.DefaultView.RowFilter = $"UserName LIKE '{textBoxMoreFillter.Text}%'";
                    }
                    break;

                default:
                    dt.DefaultView.RowFilter = ""; // Show all if nothing selected
                    break;
            }
        }

        //--------------------------------------------------------------//
    }
}
