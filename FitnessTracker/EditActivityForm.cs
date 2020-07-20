using FitnessLibrary.DataAccess;
using FTLibrary.DataAccess;
using FTLibrary.Models;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class EditActivityForm : Form
    {
        private Activity _activity;
        private FitnessContext _context;

        public EditActivityForm(Activity activity)
        {
            _activity = activity;
            _context = new FitnessContext();

            InitializeComponent();
            WireActivityTypeList();
            PopulateForm();
        }

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

        private bool IsValidated()
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

        private TimeSpan parseDuration()
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
        
        private void UpdateActivityInDB()
        {
            var duration = parseDuration();

            //If you don't do this, it will create a new ActivityType with every new Activity (Weird WinForms thing)
            var selectedActivityType = activityTypeDropDown.SelectedItem as ActivityType;
            var selectedActivityName = selectedActivityType.ActivityName.ToString();
            var currentActivityType = _context.ActivityTypes.Single(t => t.ActivityName == selectedActivityName);

            string notes = notesTextBox.Text.Replace(Environment.NewLine, "~");

            double distance = double.TryParse(distanceTextBox.Text, out distance) ?
                distance = double.Parse(distanceTextBox.Text) : 0;


            //Find and update current activity in the db
            var currentAct = _context.Activities.Find(_activity.Id);

            currentAct.Title = activityTitleTextBox.Text;
            currentAct.ActivityDuration = duration;
            currentAct.ActivityDistance = distance;
            currentAct.ActivityType = currentActivityType;
            currentAct.ActivityStart = dateDateTimeChooser.Value;
            currentAct.ActivityNotes = notes;

            _context.SaveChanges();
        }

        private void editActivityButton_Click(object sender, EventArgs e)
        {
            if (!IsValidated()) return;

            UpdateActivityInDB();

            MessageBox.Show("Activity successfully updated.");
            this.Close();
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentAct = _context.Activities.Find(_activity.Id);

            _context.Activities.Remove(currentAct);
            _context.SaveChanges();

            MessageBox.Show("Activity successfully deleted.");
            this.Close();
        }
    }
}
