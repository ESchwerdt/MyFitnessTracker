using FTLibrary.DataAccess;
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
    public partial class LoginForm : Form
    {
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
            MessageBox.Show("Signing in");

            Form newActivitiesListForm = new ActivitesListForm();
            newActivitiesListForm.Show();

            //TODO get all activities from current user and open AllActivitesForm
            //this.Hide();
            //Form newUserForm = new NewUserForm();
            //newUserForm.Show();
        }

        private void createProfileLink_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form newUserForm = new NewUserForm();
            newUserForm.Show();
        }
    }
}
