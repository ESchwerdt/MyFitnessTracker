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
    public partial class LoginForm : Form
    {
        private User _user;
        public LoginForm()
        {
            InitializeComponent();
            WireUserList();
        }

        private void WireUserList()
        {
            var context = new FitnessContext();

            var availableUsers = context.Users.ToList();

            availableUserDropDown.DataSource = availableUsers;
            availableUserDropDown.DisplayMember = "Username";

        }
        
        
        private void signInButton_Click(object sender, EventArgs e)
        {
            _user = (User) availableUserDropDown.SelectedValue;
            
            Form newActivitiesListForm = new ActivitiesListForm(_user);
            newActivitiesListForm.Show();

            this.Hide();

        }

        private void createProfileLink_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form newUserForm = new NewUserForm();
            newUserForm.Show();
        }
    }
}
