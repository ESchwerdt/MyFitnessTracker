using FTLibrary.DataAccess;
using FTLibrary.Models;
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
    public partial class ActivitesListForm : Form
    {
        private User _user;
        public ActivitesListForm(User user)
        {
            InitializeComponent();
            _user = user;
            WireActivityList();
        }

        private void WireActivityList()
        {
            //int userId = _user.Id;

            var context = new FitnessContext();

            var userActivites = context.Activities
                .Include("ActivityType")
                .Where(a => a.User.Id == _user.Id)
                .OrderByDescending(a => a.ActivityStart)
                .ToList();

            foreach (Activity a in userActivites)
            {
                var lvAct = new ListViewItem();
                lvAct.Text = a.ActivityStart.Date.ToString("M/d/yyyy");
                lvAct.SubItems.Add(a.Title);
                lvAct.SubItems.Add(a.ActivityType.ActivityName.ToString());
                lvAct.SubItems.Add(a.ActivityDuration.ToString());
                lvAct.SubItems.Add(a.ActivityDistance.ToString() + " mi");

                activitiesListView.Items.Add(lvAct);
            }

            activitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            activitiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //activitiesListView.Columns[1].TextAlign = HorizontalAlignment.Center;
            //activitiesListView.Columns[2].TextAlign = HorizontalAlignment.Center;
            //activitiesListView.Columns[3].TextAlign = HorizontalAlignment.Center;
            //activitiesListView.Columns[4].TextAlign = HorizontalAlignment.Center;

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newActivityButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form newActivityForm = new NewActivityForm(_user);
            newActivityForm.Show();

        }
    }
}
