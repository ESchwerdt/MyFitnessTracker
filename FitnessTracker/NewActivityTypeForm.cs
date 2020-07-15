using FTLibrary.DataAccess;
using FTLibrary.Models;
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
    public partial class NewActivityTypeForm : Form
    {
        public NewActivityTypeForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool validated = true;

            //TODO add validation that new activity type doesn't already exist

            if (newActivityNameTextBox.Text.Length < 1)
                validated = false;

            return validated;
        }

        private void addNewActivityTypeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var context = new FitnessContext();

                var newActivityType = new ActivityType
                {
                    ActivityName = newActivityNameTextBox.Text
                };

                context.ActivityTypes.Add(newActivityType);
                context.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Please enter an activity name and try again");

        }

        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
