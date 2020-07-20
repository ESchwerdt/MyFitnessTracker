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
        private FitnessContext _context;

        public NewActivityForm(User user)
        {
            InitializeComponent();

            _context = new FitnessContext();

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
        
        private bool IsValidated()
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
        
        private TimeSpan ParseDuration()
        {
            int durationHrs = String.IsNullOrWhiteSpace(activityHourTextBox.Text) ? 0
                    : int.Parse(activityHourTextBox.Text);
            int durationMins = String.IsNullOrWhiteSpace(activityMinsTextBox.Text) ? 0
                : int.Parse(activityMinsTextBox.Text);
            int durationSecs = String.IsNullOrWhiteSpace(activitySecTextBox.Text) ? 0
                : int.Parse(activitySecTextBox.Text);

            var duration = new TimeSpan(durationHrs, durationMins, durationSecs);

            return duration;
        }

        private void AddNewActivityToDB()
        {
            var duration = ParseDuration();

            var currentUser = _context.Users.Single(u => u.Username == _username);

            //If you don't do this, it will create a new ActivityType with every new Activity (Weird WinForms thing)
            var selectedActivityType = activityTypeDropDown.SelectedItem as ActivityType;
            var selectedActivityName = selectedActivityType.ActivityName.ToString();
            var currentActivityType = _context.ActivityTypes.Single(t => t.ActivityName == selectedActivityName);

            string notes = notesTextBox.Text.Replace(Environment.NewLine, "~");

            double distance = double.TryParse(distanceTextBox.Text, out distance) ?
                double.Parse(distanceTextBox.Text) : 0;

            //Create new activity and save to db
            var newActivity = new Activity
            {
                Title = activityTitleTextBox.Text,
                ActivityType = currentActivityType,
                ActivityStart = dateDateTimeChooser.Value,
                ActivityDuration = duration,
                ActivityDistance = distance,
                ActivityNotes = notes,
                User = currentUser
            };

            _context.Activities.Add(newActivity);
            _context.SaveChanges();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            if (!IsValidated()) return;

            AddNewActivityToDB();

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
