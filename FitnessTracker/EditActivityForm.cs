using FitnessLibrary.DataAccess;
using FTLibrary.DataAccess;
using FTLibrary.Models;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class EditActivityForm : Form
    {
        private Activity _activity;
        private TimeSpan _duration;
        public EditActivityForm(Activity activity)
        {
            _activity = activity;
            InitializeComponent();
            WireActivityTypeList();
            PopulateForm();
        }

        //TODO Implement save changes & delete functions

        private void WireActivityTypeList()
        {
            var availableActivities = Queries.GetActivityTypes();
            
            activityTypeDropDown.DataSource = availableActivities;
            activityTypeDropDown.DisplayMember = "ActivityName";
        }
        
        private void PopulateForm()
        {

            var notes = _activity.ActivityNotes.Replace("~", Environment.NewLine);

            //Write activity details to form
            activityTitleTextBox.Text = _activity.Title;
            activityTypeDropDown.Text = _activity.ActivityType.ActivityName;
            dateDateTimeChooser.Text = _activity.ActivityStart.ToString();
            activityHourTextBox.Text = _activity.ActivityDuration.Hours.ToString();
            activityMinsTextBox.Text = _activity.ActivityDuration.Minutes.ToString();
            activitySecTextBox.Text = _activity.ActivityDuration.Seconds.ToString();
            distanceTextBox.Text = _activity.ActivityDistance.ToString();
            notesTextBox.Text = notes;
        }

        private bool ValidateForm()
        {
            bool validated = true;

            if (activityTitleTextBox.Text.Length < 1)
            {
                validated = false;
                MessageBox.Show("Please enter a title for this workout");
            }

            if (activityTypeDropDown.SelectedIndex < 0)
            {
                validated = false;
                MessageBox.Show("Please select a valid activity type");
            }

            if (string.IsNullOrWhiteSpace(activityHourTextBox.Text)
                && string.IsNullOrWhiteSpace(activityMinsTextBox.Text)
                && string.IsNullOrWhiteSpace(activitySecTextBox.Text))
            {
                validated = false;
                MessageBox.Show("Please enter a duration for this workout");
            }

            if (!int.TryParse(activityHourTextBox.Text, out int durationHrs)
                && !int.TryParse(activityMinsTextBox.Text, out int durationMins)
                && !int.TryParse(activitySecTextBox.Text, out int durationSec))
            {
                validated = false;
                MessageBox.Show("Please enter a valid duration time value");
            }


            return validated;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editActivityButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //Parse duration into a timespan variable
                int durationHrs = 0;
                int durationMins = 0;
                int durationSecs = 0;

                if (!String.IsNullOrWhiteSpace(activityHourTextBox.Text))
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

                var selectedActivityType = activityTypeDropDown.SelectedItem as ActivityType;
                var selectedActivityName = selectedActivityType.ActivityName.ToString();
                var currentActivityType = context.ActivityTypes.Single(t => t.ActivityName == selectedActivityName);

                string notes = notesTextBox.Text.Replace(Environment.NewLine, "~");


                double distance = 0;

                if (double.TryParse(distanceTextBox.Text, out distance))
                {
                    distance = double.Parse(distanceTextBox.Text);
                }

                //Find and update current activity in the db
                var currentAct = context.Activities.Find(_activity.Id);

                currentAct.Title = activityTitleTextBox.Text;
                currentAct.ActivityDuration = _duration;
                currentAct.ActivityDistance = distance;
                currentAct.ActivityType = currentActivityType;
                currentAct.ActivityStart = dateDateTimeChooser.Value;
                currentAct.ActivityNotes = notes;

                context.SaveChanges();

                MessageBox.Show("Activity successfully updated.");
                this.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var context = new FitnessContext();

            var currentAct = context.Activities.Find(_activity.Id);

            context.Activities.Remove(currentAct);
            context.SaveChanges();

            MessageBox.Show("Activity successfully deleted.");
            this.Close();
        }
    }
}
