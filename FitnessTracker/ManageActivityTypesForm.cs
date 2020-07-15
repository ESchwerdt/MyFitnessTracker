using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTLibrary.DataAccess;
using FTLibrary.Models;

namespace FitnessTracker
{
    public partial class ManageActivityTypesForm : Form
    {
        public ManageActivityTypesForm()
        {
            InitializeComponent();
            WireUpList();
        }

        private void WireUpList()
        {
            var context = new FitnessContext();

            var availableActivities = context.ActivityTypes.ToList();

            activityTypeListBox.DataSource = availableActivities;
            activityTypeListBox.DisplayMember = "ActivityName";
        }

        private void addActivityTypeButton_Click(object sender, EventArgs e)
        {
            var context = new FitnessContext();
            
            if(addActivityNameTextBox.Text.Length > 0)
            {

                var newActivity = new ActivityType();
                newActivity.ActivityName = addActivityNameTextBox.Text;

                context.ActivityTypes.Add(newActivity);
                context.SaveChanges();
                WireUpList();
            }
            else
            {
                MessageBox.Show("Please enter a valid activity type name and try again!");
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
