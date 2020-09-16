namespace FitnessTracker
{
    partial class ActivitiesListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesListForm));
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activitiesListView = new MetroFramework.Controls.MetroListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivityType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerLabel = new System.Windows.Forms.Label();
            this.newActivityButton = new MetroFramework.Controls.MetroButton();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.viewSelButton = new MetroFramework.Controls.MetroButton();
            this.signoutButton = new MetroFramework.Controls.MetroButton();
            this.refreshListButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.distanceValueLabel = new MetroFramework.Controls.MetroLabel();
            this.durationValueLabel = new MetroFramework.Controls.MetroLabel();
            this.activityCountLabel = new MetroFramework.Controls.MetroLabel();
            this.monthValueLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Activity,
            this.Duration,
            this.Distance});
            this.metroListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(842, 730);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // Date
            // 
            this.Date.DisplayIndex = 1;
            // 
            // Activity
            // 
            this.Activity.DisplayIndex = 0;
            // 
            // activitiesListView
            // 
            this.activitiesListView.AllowSorting = true;
            this.activitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chDate,
            this.chActivityType,
            this.chDuration,
            this.chDistance});
            this.activitiesListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activitiesListView.FullRowSelect = true;
            this.activitiesListView.Location = new System.Drawing.Point(22, 75);
            this.activitiesListView.Name = "activitiesListView";
            this.activitiesListView.OwnerDraw = true;
            this.activitiesListView.Size = new System.Drawing.Size(581, 585);
            this.activitiesListView.TabIndex = 2;
            this.activitiesListView.UseCompatibleStateImageBehavior = false;
            this.activitiesListView.UseSelectable = true;
            this.activitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 200;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 75;
            // 
            // chActivityType
            // 
            this.chActivityType.Text = "Activity";
            this.chActivityType.Width = 100;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duration";
            this.chDuration.Width = 100;
            // 
            // chDistance
            // 
            this.chDistance.Text = "Distance";
            this.chDistance.Width = 100;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(15, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(182, 38);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "My Workouts";
            // 
            // newActivityButton
            // 
            this.newActivityButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.newActivityButton.Location = new System.Drawing.Point(618, 75);
            this.newActivityButton.Name = "newActivityButton";
            this.newActivityButton.Size = new System.Drawing.Size(202, 37);
            this.newActivityButton.TabIndex = 11;
            this.newActivityButton.Text = "+ Add New Workout";
            this.newActivityButton.UseSelectable = true;
            this.newActivityButton.Click += new System.EventHandler(this.newActivityButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.quitButton.Location = new System.Drawing.Point(22, 677);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 37);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseSelectable = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // viewSelButton
            // 
            this.viewSelButton.Location = new System.Drawing.Point(641, 130);
            this.viewSelButton.Name = "viewSelButton";
            this.viewSelButton.Size = new System.Drawing.Size(160, 34);
            this.viewSelButton.TabIndex = 14;
            this.viewSelButton.Text = "View Workout Details";
            this.viewSelButton.UseSelectable = true;
            this.viewSelButton.Click += new System.EventHandler(this.viewSelButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.signoutButton.Location = new System.Drawing.Point(122, 677);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(75, 37);
            this.signoutButton.TabIndex = 15;
            this.signoutButton.Text = "Sign Out";
            this.signoutButton.UseSelectable = true;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Location = new System.Drawing.Point(482, 680);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(121, 34);
            this.refreshListButton.TabIndex = 16;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseSelectable = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(641, 181);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(160, 34);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit Workout";
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(618, 369);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "To Date Totals:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(618, 411);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 20);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Total Distance:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(618, 444);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 20);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Total Duration:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(618, 477);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 20);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Workout Count:";
            // 
            // distanceValueLabel
            // 
            this.distanceValueLabel.AutoSize = true;
            this.distanceValueLabel.Location = new System.Drawing.Point(729, 411);
            this.distanceValueLabel.Name = "distanceValueLabel";
            this.distanceValueLabel.Size = new System.Drawing.Size(47, 20);
            this.distanceValueLabel.TabIndex = 23;
            this.distanceValueLabel.Text = "0.0 mi";
            // 
            // durationValueLabel
            // 
            this.durationValueLabel.AutoSize = true;
            this.durationValueLabel.Location = new System.Drawing.Point(729, 444);
            this.durationValueLabel.Name = "durationValueLabel";
            this.durationValueLabel.Size = new System.Drawing.Size(36, 20);
            this.durationValueLabel.TabIndex = 24;
            this.durationValueLabel.Text = "0:00";
            // 
            // activityCountLabel
            // 
            this.activityCountLabel.AutoSize = true;
            this.activityCountLabel.Location = new System.Drawing.Point(729, 477);
            this.activityCountLabel.Name = "activityCountLabel";
            this.activityCountLabel.Size = new System.Drawing.Size(17, 20);
            this.activityCountLabel.TabIndex = 25;
            this.activityCountLabel.Text = "0";
            // 
            // monthValueLabel
            // 
            this.monthValueLabel.AutoSize = true;
            this.monthValueLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.monthValueLabel.Location = new System.Drawing.Point(618, 335);
            this.monthValueLabel.Name = "monthValueLabel";
            this.monthValueLabel.Size = new System.Drawing.Size(65, 25);
            this.monthValueLabel.TabIndex = 26;
            this.monthValueLabel.Text = "month";
            // 
            // ActivitiesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 730);
            this.Controls.Add(this.monthValueLabel);
            this.Controls.Add(this.activityCountLabel);
            this.Controls.Add(this.durationValueLabel);
            this.Controls.Add(this.distanceValueLabel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.viewSelButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newActivityButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.activitiesListView);
            this.Controls.Add(this.metroListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActivitiesListForm";
            this.Text = "My Workouts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Activity;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Distance;
        private MetroFramework.Controls.MetroListView activitiesListView;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chActivityType;
        private System.Windows.Forms.ColumnHeader chDuration;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Label headerLabel;
        private MetroFramework.Controls.MetroButton newActivityButton;
        private MetroFramework.Controls.MetroButton quitButton;
        private System.Windows.Forms.ColumnHeader chTitle;
        private MetroFramework.Controls.MetroButton viewSelButton;
        private MetroFramework.Controls.MetroButton signoutButton;
        private MetroFramework.Controls.MetroButton refreshListButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel distanceValueLabel;
        private MetroFramework.Controls.MetroLabel durationValueLabel;
        private MetroFramework.Controls.MetroLabel activityCountLabel;
        private MetroFramework.Controls.MetroLabel monthValueLabel;
    }
}