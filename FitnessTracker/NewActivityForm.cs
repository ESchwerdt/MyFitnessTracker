using FTLibrary.DataAccess;
using FTLibrary.Models;
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

namespace FitnessTracker
{
    public partial class NewActivityForm : Form
    {
        private string _user;
        private TimeSpan _duration; 

        public NewActivityForm(User user)
        {
            InitializeComponent();
            WireActivityTypeList();
            
            _user = user.Username;
        }

        /// <summary>
        /// Loads existing Activity Types into the drop down list
        /// </summary>
        private void WireActivityTypeList()
        {
            var context = new FitnessContext();

            var availableActivities = context.ActivityTypes.ToList();

            activityTypeDropDown.DataSource = availableActivities;
            activityTypeDropDown.DisplayMember = "ActivityName";
        }
        
        private bool ValidateForm()
        {
            bool validated = true;

            //if(!(int.TryParse(ac)))

            //var durationValue = activityDurationTextBox.Text;
            //var durationTest = durationValue.Split(':');
            //if (durationTest.Length.Equals(3))
            //{
            //    _duration = TimeSpan.Parse(durationValue);
            //}


            return validated;
        }
        
        private void addActivityButton_Click(object sender, EventArgs e)
        {
            //TODO Add form validation for this input data!
            //In validation, just check to make sure each hr/min/sec is either null or an integer

            int durationHrs = 0;
            int durationMins = 0;
            int durationSecs = 0;
            
            if(!String.IsNullOrWhiteSpace(activityHourTextBox.Text))
            {
                durationHrs = int.Parse(activityHourTextBox.Text);
            }
            if (!String.IsNullOrWhiteSpace(activityMinsTextBox.Text))
            {
                durationMins = int.Parse(activityMinsTextBox.Text);
            }
            if (!String.IsNullOrWhiteSpace(activityMinsTextBox.Text))
            {
                durationSecs = int.Parse(activitySecTextBox.Text);
            }

            _duration = new TimeSpan(durationHrs, durationMins, durationSecs);

            var context = new FitnessContext();


            var currentUser = context.Users.Single(u => u.Username == _user);

            //var selectedActivityType = (ActivityType) activityTypeDropDown.SelectedItem;
            var selectedActivityType = activityTypeDropDown.SelectedItem as ActivityType;
            var selectedActivityName = selectedActivityType.ActivityName.ToString();
            var currentActivityType = context.ActivityTypes.Single(t => t.ActivityName == selectedActivityName);

            var newActivity = new Activity {
                Title = activityTitleTextBox.Text,
                ActivityType = currentActivityType,
                ActivityStart = dateDateTimeChooser.Value,
                ActivityDuration = _duration,
                ActivityDistance = Convert.ToDouble(distanceTextBox.Text),
                ActivityNotes = notesTextBox.Text,
                User = currentUser
            };

            context.Activities.Add(newActivity);
            context.SaveChanges();

            MessageBox.Show("Activity Successfully Added!");
            this.Close();
        }

        private void cancelNewActivityButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageActivityTypesButton_Click(object sender, EventArgs e)
        {
            Form manageActivityTypes = new ManageActivityTypesForm();
            manageActivityTypes.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            WireActivityTypeList();
        }
    }
}
