using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class NewActivityForm : Form
    {
        public NewActivityForm()
        {
            InitializeComponent();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Activity Added");
        }

        private void cancelNewActivityButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
