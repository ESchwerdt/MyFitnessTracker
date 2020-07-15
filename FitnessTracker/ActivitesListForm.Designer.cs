namespace FitnessTracker
{
    partial class ActivitesListForm
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activitiesListView = new MetroFramework.Controls.MetroListView();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chActivityType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerLabel = new System.Windows.Forms.Label();
            this.newActivityButton = new MetroFramework.Controls.MetroButton();
            this.quitButton = new MetroFramework.Controls.MetroButton();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.metroListView1.Size = new System.Drawing.Size(775, 730);
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
            this.chDate,
            this.chTitle,
            this.chActivityType,
            this.chDuration,
            this.chDistance});
            this.activitiesListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activitiesListView.FullRowSelect = true;
            this.activitiesListView.Location = new System.Drawing.Point(22, 71);
            this.activitiesListView.Name = "activitiesListView";
            this.activitiesListView.OwnerDraw = true;
            this.activitiesListView.Size = new System.Drawing.Size(585, 585);
            this.activitiesListView.TabIndex = 2;
            this.activitiesListView.UseCompatibleStateImageBehavior = false;
            this.activitiesListView.UseSelectable = true;
            this.activitiesListView.View = System.Windows.Forms.View.Details;
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
            this.headerLabel.Size = new System.Drawing.Size(174, 38);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "My Activities";
            // 
            // newActivityButton
            // 
            this.newActivityButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.newActivityButton.Location = new System.Drawing.Point(328, 19);
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
            this.quitButton.Location = new System.Drawing.Point(22, 681);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 37);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseSelectable = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 200;
            // 
            // ActivitesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 730);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newActivityButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.activitiesListView);
            this.Controls.Add(this.metroListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActivitesListForm";
            this.Text = "My Activites";
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
    }
}