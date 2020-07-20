using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private bool ValidateForm()
        {
            var validated = true;

            var context = new FitnessContext();
            var availableActivities = context.ActivityTypes.ToList();

            List<string> aList = new List<string>();

            foreach(var a in availableActivities)
            {
                aList.Add(a.ActivityName);
            }

            if (aList.Contains(addActivityNameTextBox.Text))
            {
                MessageBox.Show("This activity type already exists.");
                validated = false;
            }

            if(addActivityNameTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid activity name.");
                validated = false;
            }

            return validated;
        }
        
        private void addActivityTypeButton_Click(object sender, EventArgs e)
        {
            var context = new FitnessContext();

            if (ValidateForm())
            {

                var newActivity = new ActivityType();
                newActivity.ActivityName = addActivityNameTextBox.Text;

                context.ActivityTypes.Add(newActivity);
                context.SaveChanges();
                WireUpList();
            }

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
