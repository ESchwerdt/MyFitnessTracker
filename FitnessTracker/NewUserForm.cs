using FTLibrary.DataAccess;
using FTLibrary.Models;
using MetroFramework.Controls;
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
        private FitnessContext _context;

        public NewUserForm()
        {
            InitializeComponent();
            _context = new FitnessContext();

        }

        private bool IsValidated()
        {
            bool validated = true;

            var userList = _context.Users.ToList();
            List<string> userNames = new List<string>();

            foreach(var u in userList)
            {
                userNames.Add(u.Username);
            }

            if (userNames.Contains(newUsernameTextBox.Text))
            {
                validated = false;
                MessageBox.Show("This username has already been taken.");
            }
            
            return validated;
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            if (!IsValidated()) return;

            //add new user and set properties
            var newUser = new User
            {
                Username = newUsernameTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                EmailAddress = emailTextBox.Text,
                Location = locationTextBox.Text
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();


            this.Hide();

            Form newActivitiesListForm = new ActivitiesListForm(newUser);
            newActivitiesListForm.Show(); 
        }
    }
}
