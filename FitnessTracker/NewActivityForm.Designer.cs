namespace FitnessTracker
{
    partial class NewActivityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewActivityForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.activityTitleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.activityTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.activityTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.activityTypeDropDown = new MetroFramework.Controls.MetroComboBox();
            this.dateDateTimeChooser = new MetroFramework.Controls.MetroDateTime();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.durationLabel = new MetroFramework.Controls.MetroLabel();
            this.activityHourTextBox = new MetroFramework.Controls.MetroTextBox();
            this.distanceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.distanceLabel = new MetroFramework.Controls.MetroLabel();
            this.activityNotesLabel = new MetroFramework.Controls.MetroLabel();
            this.notesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addActivityButton = new MetroFramework.Controls.MetroButton();
            this.cancelNewActivityButton = new MetroFramework.Controls.MetroButton();
            this.manageActivityTypesButton = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.hrLabel = new MetroFramework.Controls.MetroLabel();
            this.minLabel = new MetroFramework.Controls.MetroLabel();
            this.activityMinsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.secLabel = new MetroFramework.Controls.MetroLabel();
            this.activitySecTextBox = new MetroFramework.Controls.MetroTextBox();
            this.miLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(142, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(245, 38);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "Add New Workout";
            // 
            // activityTitleTextBox
            // 
            // 
            // 
            // 
            this.activityTitleTextBox.CustomButton.Image = null;
            this.activityTitleTextBox.CustomButton.Location = new System.Drawing.Point(393, 1);
            this.activityTitleTextBox.CustomButton.Name = "";
            this.activityTitleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.activityTitleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.activityTitleTextBox.CustomButton.TabIndex = 1;
            this.activityTitleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activityTitleTextBox.CustomButton.UseSelectable = true;
            this.activityTitleTextBox.CustomButton.Visible = false;
            this.activityTitleTextBox.Lines = new string[0];
            this.activityTitleTextBox.Location = new System.Drawing.Point(84, 68);
            this.activityTitleTextBox.MaxLength = 32767;
            this.activityTitleTextBox.Name = "activityTitleTextBox";
            this.activityTitleTextBox.PasswordChar = '\0';
            this.activityTitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activityTitleTextBox.SelectedText = "";
            this.activityTitleTextBox.SelectionLength = 0;
            this.activityTitleTextBox.SelectionStart = 0;
            this.activityTitleTextBox.ShortcutsEnabled = true;
            this.activityTitleTextBox.Size = new System.Drawing.Size(415, 23);
            this.activityTitleTextBox.TabIndex = 13;
            this.activityTitleTextBox.UseSelectable = true;
            this.activityTitleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.activityTitleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // activityTitleLabel
            // 
            this.activityTitleLabel.AutoSize = true;
            this.activityTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.activityTitleLabel.Location = new System.Drawing.Point(28, 68);
            this.activityTitleLabel.Name = "activityTitleLabel";
            this.activityTitleLabel.Size = new System.Drawing.Size(50, 25);
            this.activityTitleLabel.TabIndex = 12;
            this.activityTitleLabel.Text = "Title:";
            // 
            // activityTypeLabel
            // 
            this.activityTypeLabel.AutoSize = true;
            this.activityTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.activityTypeLabel.Location = new System.Drawing.Point(28, 112);
            this.activityTypeLabel.Name = "activityTypeLabel";
            this.activityTypeLabel.Size = new System.Drawing.Size(117, 25);
            this.activityTypeLabel.TabIndex = 14;
            this.activityTypeLabel.Text = "Activity Type:";
            // 
            // activityTypeDropDown
            // 
            this.activityTypeDropDown.FormattingEnabled = true;
            this.activityTypeDropDown.ItemHeight = 24;
            this.activityTypeDropDown.Location = new System.Drawing.Point(151, 107);
            this.activityTypeDropDown.Name = "activityTypeDropDown";
            this.activityTypeDropDown.Size = new System.Drawing.Size(180, 30);
            this.activityTypeDropDown.TabIndex = 15;
            this.activityTypeDropDown.UseSelectable = true;
            // 
            // dateDateTimeChooser
            // 
            this.dateDateTimeChooser.Location = new System.Drawing.Point(89, 152);
            this.dateDateTimeChooser.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateDateTimeChooser.Name = "dateDateTimeChooser";
            this.dateDateTimeChooser.Size = new System.Drawing.Size(200, 30);
            this.dateDateTimeChooser.TabIndex = 16;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateLabel.Location = new System.Drawing.Point(29, 157);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(54, 25);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.durationLabel.Location = new System.Drawing.Point(28, 201);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(85, 25);
            this.durationLabel.TabIndex = 19;
            this.durationLabel.Text = "Duration:";
            // 
            // activityHourTextBox
            // 
            // 
            // 
            // 
            this.activityHourTextBox.CustomButton.Image = null;
            this.activityHourTextBox.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.activityHourTextBox.CustomButton.Name = "";
            this.activityHourTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.activityHourTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.activityHourTextBox.CustomButton.TabIndex = 1;
            this.activityHourTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activityHourTextBox.CustomButton.UseSelectable = true;
            this.activityHourTextBox.CustomButton.Visible = false;
            this.activityHourTextBox.Lines = new string[0];
            this.activityHourTextBox.Location = new System.Drawing.Point(118, 203);
            this.activityHourTextBox.MaxLength = 32767;
            this.activityHourTextBox.Name = "activityHourTextBox";
            this.activityHourTextBox.PasswordChar = '\0';
            this.activityHourTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activityHourTextBox.SelectedText = "";
            this.activityHourTextBox.SelectionLength = 0;
            this.activityHourTextBox.SelectionStart = 0;
            this.activityHourTextBox.ShortcutsEnabled = true;
            this.activityHourTextBox.Size = new System.Drawing.Size(46, 23);
            this.activityHourTextBox.TabIndex = 17;
            this.activityHourTextBox.UseSelectable = true;
            this.activityHourTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.activityHourTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // distanceTextBox
            // 
            // 
            // 
            // 
            this.distanceTextBox.CustomButton.Image = null;
            this.distanceTextBox.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.distanceTextBox.CustomButton.Name = "";
            this.distanceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.distanceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.distanceTextBox.CustomButton.TabIndex = 1;
            this.distanceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.distanceTextBox.CustomButton.UseSelectable = true;
            this.distanceTextBox.CustomButton.Visible = false;
            this.distanceTextBox.Lines = new string[0];
            this.distanceTextBox.Location = new System.Drawing.Point(118, 249);
            this.distanceTextBox.MaxLength = 32767;
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.PasswordChar = '\0';
            this.distanceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.distanceTextBox.SelectedText = "";
            this.distanceTextBox.SelectionLength = 0;
            this.distanceTextBox.SelectionStart = 0;
            this.distanceTextBox.ShortcutsEnabled = true;
            this.distanceTextBox.Size = new System.Drawing.Size(105, 23);
            this.distanceTextBox.TabIndex = 22;
            this.distanceTextBox.UseSelectable = true;
            this.distanceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.distanceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.distanceLabel.Location = new System.Drawing.Point(29, 247);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(83, 25);
            this.distanceLabel.TabIndex = 21;
            this.distanceLabel.Text = "Distance:";
            // 
            // activityNotesLabel
            // 
            this.activityNotesLabel.AutoSize = true;
            this.activityNotesLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.activityNotesLabel.Location = new System.Drawing.Point(28, 291);
            this.activityNotesLabel.Name = "activityNotesLabel";
            this.activityNotesLabel.Size = new System.Drawing.Size(63, 25);
            this.activityNotesLabel.TabIndex = 25;
            this.activityNotesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            // 
            // 
            // 
            this.notesTextBox.CustomButton.Image = null;
            this.notesTextBox.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.notesTextBox.CustomButton.Name = "";
            this.notesTextBox.CustomButton.Size = new System.Drawing.Size(211, 211);
            this.notesTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notesTextBox.CustomButton.TabIndex = 1;
            this.notesTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notesTextBox.CustomButton.UseSelectable = true;
            this.notesTextBox.CustomButton.Visible = false;
            this.notesTextBox.Lines = new string[0];
            this.notesTextBox.Location = new System.Drawing.Point(29, 319);
            this.notesTextBox.MaxLength = 32767;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.PasswordChar = '\0';
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notesTextBox.SelectedText = "";
            this.notesTextBox.SelectionLength = 0;
            this.notesTextBox.SelectionStart = 0;
            this.notesTextBox.ShortcutsEnabled = true;
            this.notesTextBox.Size = new System.Drawing.Size(458, 213);
            this.notesTextBox.TabIndex = 26;
            this.notesTextBox.UseSelectable = true;
            this.notesTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notesTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addActivityButton
            // 
            this.addActivityButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addActivityButton.Location = new System.Drawing.Point(246, 550);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(178, 44);
            this.addActivityButton.TabIndex = 27;
            this.addActivityButton.Text = "Add Workout";
            this.addActivityButton.UseSelectable = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // cancelNewActivityButton
            // 
            this.cancelNewActivityButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cancelNewActivityButton.Location = new System.Drawing.Point(57, 550);
            this.cancelNewActivityButton.Name = "cancelNewActivityButton";
            this.cancelNewActivityButton.Size = new System.Drawing.Size(136, 44);
            this.cancelNewActivityButton.TabIndex = 28;
            this.cancelNewActivityButton.Text = "Cancel";
            this.cancelNewActivityButton.UseSelectable = true;
            this.cancelNewActivityButton.Click += new System.EventHandler(this.cancelNewActivityButton_Click);
            // 
            // manageActivityTypesButton
            // 
            this.manageActivityTypesButton.Location = new System.Drawing.Point(337, 114);
            this.manageActivityTypesButton.Name = "manageActivityTypesButton";
            this.manageActivityTypesButton.Size = new System.Drawing.Size(78, 23);
            this.manageActivityTypesButton.TabIndex = 29;
            this.manageActivityTypesButton.Text = "Manage";
            this.manageActivityTypesButton.UseSelectable = true;
            this.manageActivityTypesButton.Click += new System.EventHandler(this.manageActivityTypesButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(421, 114);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(78, 23);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseSelectable = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // hrLabel
            // 
            this.hrLabel.AutoSize = true;
            this.hrLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.hrLabel.Location = new System.Drawing.Point(165, 201);
            this.hrLabel.Name = "hrLabel";
            this.hrLabel.Size = new System.Drawing.Size(28, 25);
            this.hrLabel.TabIndex = 32;
            this.hrLabel.Text = "hr";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.minLabel.Location = new System.Drawing.Point(246, 201);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(42, 25);
            this.minLabel.TabIndex = 34;
            this.minLabel.Text = "min";
            // 
            // activityMinsTextBox
            // 
            // 
            // 
            // 
            this.activityMinsTextBox.CustomButton.Image = null;
            this.activityMinsTextBox.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.activityMinsTextBox.CustomButton.Name = "";
            this.activityMinsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.activityMinsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.activityMinsTextBox.CustomButton.TabIndex = 1;
            this.activityMinsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activityMinsTextBox.CustomButton.UseSelectable = true;
            this.activityMinsTextBox.CustomButton.Visible = false;
            this.activityMinsTextBox.Lines = new string[0];
            this.activityMinsTextBox.Location = new System.Drawing.Point(199, 203);
            this.activityMinsTextBox.MaxLength = 32767;
            this.activityMinsTextBox.Name = "activityMinsTextBox";
            this.activityMinsTextBox.PasswordChar = '\0';
            this.activityMinsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activityMinsTextBox.SelectedText = "";
            this.activityMinsTextBox.SelectionLength = 0;
            this.activityMinsTextBox.SelectionStart = 0;
            this.activityMinsTextBox.ShortcutsEnabled = true;
            this.activityMinsTextBox.Size = new System.Drawing.Size(46, 23);
            this.activityMinsTextBox.TabIndex = 18;
            this.activityMinsTextBox.UseSelectable = true;
            this.activityMinsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.activityMinsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.secLabel.Location = new System.Drawing.Point(341, 201);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(37, 25);
            this.secLabel.TabIndex = 36;
            this.secLabel.Text = "sec";
            // 
            // activitySecTextBox
            // 
            // 
            // 
            // 
            this.activitySecTextBox.CustomButton.Image = null;
            this.activitySecTextBox.CustomButton.Location = new System.Drawing.Point(24, 1);
            this.activitySecTextBox.CustomButton.Name = "";
            this.activitySecTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.activitySecTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.activitySecTextBox.CustomButton.TabIndex = 1;
            this.activitySecTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activitySecTextBox.CustomButton.UseSelectable = true;
            this.activitySecTextBox.CustomButton.Visible = false;
            this.activitySecTextBox.Lines = new string[0];
            this.activitySecTextBox.Location = new System.Drawing.Point(294, 203);
            this.activitySecTextBox.MaxLength = 32767;
            this.activitySecTextBox.Name = "activitySecTextBox";
            this.activitySecTextBox.PasswordChar = '\0';
            this.activitySecTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activitySecTextBox.SelectedText = "";
            this.activitySecTextBox.SelectionLength = 0;
            this.activitySecTextBox.SelectionStart = 0;
            this.activitySecTextBox.ShortcutsEnabled = true;
            this.activitySecTextBox.Size = new System.Drawing.Size(46, 23);
            this.activitySecTextBox.TabIndex = 19;
            this.activitySecTextBox.UseSelectable = true;
            this.activitySecTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.activitySecTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // miLabel
            // 
            this.miLabel.AutoSize = true;
            this.miLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.miLabel.Location = new System.Drawing.Point(225, 247);
            this.miLabel.Name = "miLabel";
            this.miLabel.Size = new System.Drawing.Size(32, 25);
            this.miLabel.TabIndex = 37;
            this.miLabel.Text = "mi";
            // 
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 613);
            this.Controls.Add(this.miLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.activitySecTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.activityMinsTextBox);
            this.Controls.Add(this.hrLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.manageActivityTypesButton);
            this.Controls.Add(this.cancelNewActivityButton);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.activityNotesLabel);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.activityHourTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateDateTimeChooser);
            this.Controls.Add(this.activityTypeDropDown);
            this.Controls.Add(this.activityTypeLabel);
            this.Controls.Add(this.activityTitleTextBox);
            this.Controls.Add(this.activityTitleLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewActivityForm";
            this.Text = "Add New Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private MetroFramework.Controls.MetroTextBox activityTitleTextBox;
        private MetroFramework.Controls.MetroLabel activityTitleLabel;
        private MetroFramework.Controls.MetroLabel activityTypeLabel;
        private MetroFramework.Controls.MetroComboBox activityTypeDropDown;
        private MetroFramework.Controls.MetroDateTime dateDateTimeChooser;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroLabel durationLabel;
        private MetroFramework.Controls.MetroTextBox activityHourTextBox;
        private MetroFramework.Controls.MetroTextBox distanceTextBox;
        private MetroFramework.Controls.MetroLabel distanceLabel;
        private MetroFramework.Controls.MetroLabel activityNotesLabel;
        private MetroFramework.Controls.MetroTextBox notesTextBox;
        private MetroFramework.Controls.MetroButton addActivityButton;
        private MetroFramework.Controls.MetroButton cancelNewActivityButton;
        private MetroFramework.Controls.MetroButton manageActivityTypesButton;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroLabel hrLabel;
        private MetroFramework.Controls.MetroLabel minLabel;
        private MetroFramework.Controls.MetroTextBox activityMinsTextBox;
        private MetroFramework.Controls.MetroLabel secLabel;
        private MetroFramework.Controls.MetroTextBox activitySecTextBox;
        private MetroFramework.Controls.MetroLabel miLabel;
    }
}