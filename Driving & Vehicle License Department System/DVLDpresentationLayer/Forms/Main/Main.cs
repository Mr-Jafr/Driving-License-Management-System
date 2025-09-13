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
    }
}
