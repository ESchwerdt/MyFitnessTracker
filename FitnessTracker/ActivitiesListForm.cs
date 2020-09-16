using FitnessLibrary.DataAccess;
using FTLibrary.DataAccess;
using FTLibrary.Models;
using MetroFramework.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class ActivitiesListForm : Form
    {
        private User _user;
        public ActivitiesListForm(User user)
        {
            InitializeComponent();
            _user = user;
            WireActivityList();
        }

        private async Task WireActivityList()
        {

            var currentMonth = DateTime.Now.ToString("MMMM");
            monthValueLabel.Text = currentMonth;

            int actCount = 0;
            double? _monthDist = 0;
            TimeSpan _monthDuration = new TimeSpan();

            IList<Activity> userActivities = await Queries.GetActivitiesAsync(_user);

            foreach (Activity a in userActivities)
            {
                var lvAct = new ListViewItem();

                lvAct.Text = a.Title;
                lvAct.SubItems.Add(a.ActivityStart.Date.ToString("M/d/yyyy"));
                lvAct.SubItems.Add(a.ActivityType.ActivityName.ToString());
                lvAct.SubItems.Add(a.ActivityDuration.ToString());
                lvAct.SubItems.Add(a.ActivityDistance.ToString() + " mi");
                lvAct.ToolTipText = a.Id.ToString();

                activitiesListView.Items.Add(lvAct);

                if(a.ActivityStart.Date.Month == DateTime.Now.Month)
                {
                    actCount++;
                    _monthDist += a.ActivityDistance;
                    _monthDuration += a.ActivityDuration;
                }

            }

            distanceValueLabel.Text = _monthDist.ToString() + " mi";
            durationValueLabel.Text = _monthDuration.ToString();
            activityCountLabel.Text = actCount.ToString();

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newActivityButton_Click(object sender, EventArgs e)
        {
            Form newActivityForm = new NewActivityForm(_user);
            newActivityForm.Show();
        }

        private void viewSelButton_Click(object sender, EventArgs e)
        {
            if (activitiesListView.SelectedItems.Count > 0)
            {
                var selAct = activitiesListView.SelectedItems[0];
                var actId = int.Parse(selAct.ToolTipText);

                var activity = Queries.GetActivity(actId);

                Form viewActivity = new ViewActivityForm(activity);
                viewActivity.Show();
            }
        }


        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form newLoginForm = new LoginForm();
            newLoginForm.Show();
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            activitiesListView.Items.Clear();
            WireActivityList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (activitiesListView.SelectedItems.Count > 0)
            {
                var selAct = activitiesListView.SelectedItems[0];
                var actId = int.Parse(selAct.ToolTipText);

                var activity = Queries.GetActivity(actId);

                Form editActivityForm = new EditActivityForm(activity);
                editActivityForm.Show();
            }
        }

    }
}
