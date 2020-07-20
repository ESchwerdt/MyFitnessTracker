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
        public User user;
        private string _username;
        private TimeSpan _duration; 

        public NewActivityForm(User user)
        {
            InitializeComponent();
            WireActivityTypeList();

            _username = user.Username;
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

            if(activityTitleTextBox.Text.Length < 1)
            {
                validated = false;
                MessageBox.Show("Please enter a title for this workout");
            }

            if(activityTypeDropDown.SelectedIndex < 0)
            {
                validated = false;
                MessageBox.Show("Please select a valid activity type");
            }

            if(string.IsNullOrWhiteSpace(activityHourTextBox.Text) 
                && string.IsNullOrWhiteSpace(activityMinsTextBox.Text) 
                && string.IsNullOrWhiteSpace(activitySecTextBox.Text))
            {
                validated = false;
                MessageBox.Show("Please enter a duration for this workout");
            }
            
            if(!int.TryParse(activityHourTextBox.Text, out int durationHrs) 
                && !int.TryParse(activityMinsTextBox.Text, out int durationMins)
                && !int.TryParse(activitySecTextBox.Text, out int durationSec))
            {
                validated = false;
                MessageBox.Show("Please enter a valid duration time value");
            }


            return validated;
        }
        
        private void addActivityButton_Click(object sender, EventArgs e)
        {

            //Parse duration into a timespan variable

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

            var currentUser = context.Users.Single(u => u.Username == _username);

            var selectedActivityType = activityTypeDropDown.SelectedItem as ActivityType;
            var selectedActivityName = selectedActivityType.ActivityName.ToString();
            var currentActivityType = context.ActivityTypes.Single(t => t.ActivityName == selectedActivityName);

            string notes = notesTextBox.Text.Replace(Environment.NewLine,"~");
            
            
            double distance = 0;

            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                distance = double.Parse(distanceTextBox.Text);
            }
           

            var newActivity = new Activity {
                Title = activityTitleTextBox.Text,
                ActivityType = currentActivityType,
                ActivityStart = dateDateTimeChooser.Value,
                ActivityDuration = _duration,
                ActivityDistance = distance,
                ActivityNotes = notes,
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
