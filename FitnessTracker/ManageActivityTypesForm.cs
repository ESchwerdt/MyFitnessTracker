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
        private FitnessContext _context;

        public ManageActivityTypesForm()
        {
            InitializeComponent();
            _context = new FitnessContext();
            WireUpList();
        }

        private void WireUpList()
        {
            var availableActivities = _context.ActivityTypes.ToList();

            activityTypeListBox.DataSource = availableActivities;
            activityTypeListBox.DisplayMember = "ActivityName";
        }

        private bool isValidated()
        {
            var validated = true;

            var availableActivities = _context.ActivityTypes.ToList();

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
        
        private void AddActivityTypeToDB()
        {
            var newActivity = new ActivityType();
            newActivity.ActivityName = addActivityNameTextBox.Text;

            _context.ActivityTypes.Add(newActivity);
            _context.SaveChanges();
        }

        private void addActivityTypeButton_Click(object sender, EventArgs e)
        {

            if (!isValidated()) return;
            
            AddActivityTypeToDB();

            WireUpList();

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
