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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();

        }

        //TODO add form validation
        private bool ValidateForm()
        {
            bool validated = true;
            
            //Has a username been entered?
            //TODO - check if username already exists?
            if(newUsernameTextBox.Text.Length < 1)
            {
                validated = false;
            }
            
            return validated;
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            var context = new FitnessContext();
            
            //add new user and set properties
            var newUser = new User {
                Username = newUsernameTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                EmailAddress = emailTextBox.Text,
                Location = locationTextBox.Text
                //TODO add ability to choose city, state from a dropdown list?
            };

            context.Users.Add(newUser);

            context.SaveChanges();

            this.Hide();

            Form newActivitiesListForm = new ActivitesListForm();
            newActivitiesListForm.Show();
        }
    }
}
