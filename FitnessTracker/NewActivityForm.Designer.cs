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
            this.headerLabel = new System.Windows.Forms.Label();
            this.activityTitleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.activityTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.activityTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.activityTypeDropDown = new MetroFramework.Controls.MetroComboBox();
            this.dateDateTimeChooser = new MetroFramework.Controls.MetroDateTime();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.addActivityTypeButton = new MetroFramework.Controls.MetroButton();
            this.durationLabel = new MetroFramework.Controls.MetroLabel();
            this.activityDurationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.distanceLabel = new MetroFramework.Controls.MetroLabel();
            this.milesRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.kmRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.activityNotesLabel = new MetroFramework.Controls.MetroLabel();
            this.notesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addActivityButton = new MetroFramework.Controls.MetroButton();
            this.cancelNewActivityButton = new MetroFramework.Controls.MetroButton();
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
            this.activityTitleTextBox.CustomButton.Location = new System.Drawing.Point(381, 1);
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
            this.activityTitleTextBox.Size = new System.Drawing.Size(403, 23);
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
            this.activityTypeDropDown.Size = new System.Drawing.Size(177, 30);
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
            // addActivityTypeButton
            // 
            this.addActivityTypeButton.Location = new System.Drawing.Point(345, 114);
            this.addActivityTypeButton.Name = "addActivityTypeButton";
            this.addActivityTypeButton.Size = new System.Drawing.Size(142, 23);
            this.addActivityTypeButton.TabIndex = 18;
            this.addActivityTypeButton.Text = "Add New Activity Type";
            this.addActivityTypeButton.UseSelectable = true;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.durationLabel.Location = new System.Drawing.Point(28, 201);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(184, 25);
            this.durationLabel.TabIndex = 19;
            this.durationLabel.Text = "Duration (HH:MM:SS):";
            // 
            // activityDurationTextBox
            // 
            // 
            // 
            // 
            this.activityDurationTextBox.CustomButton.Image = null;
            this.activityDurationTextBox.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.activityDurationTextBox.CustomButton.Name = "";
            this.activityDurationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.activityDurationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.activityDurationTextBox.CustomButton.TabIndex = 1;
            this.activityDurationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.activityDurationTextBox.CustomButton.UseSelectable = true;
            this.activityDurationTextBox.CustomButton.Visible = false;
            this.activityDurationTextBox.Lines = new string[0];
            this.activityDurationTextBox.Location = new System.Drawing.Point(218, 203);
            this.activityDurationTextBox.MaxLength = 32767;
            this.activityDurationTextBox.Name = "activityDurationTextBox";
            this.activityDurationTextBox.PasswordChar = '\0';
            this.activityDurationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.activityDurationTextBox.SelectedText = "";
            this.activityDurationTextBox.SelectionLength = 0;
            this.activityDurationTextBox.SelectionStart = 0;
            this.activityDurationTextBox.ShortcutsEnabled = true;
            this.activityDurationTextBox.Size = new System.Drawing.Size(222, 23);
            this.activityDurationTextBox.TabIndex = 20;
            this.activityDurationTextBox.UseSelectable = true;
            this.activityDurationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.activityDurationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(118, 249);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(105, 23);
            this.metroTextBox1.TabIndex = 22;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // milesRadioButton
            // 
            this.milesRadioButton.AutoSize = true;
            this.milesRadioButton.Checked = true;
            this.milesRadioButton.Location = new System.Drawing.Point(242, 255);
            this.milesRadioButton.Name = "milesRadioButton";
            this.milesRadioButton.Size = new System.Drawing.Size(38, 17);
            this.milesRadioButton.TabIndex = 23;
            this.milesRadioButton.TabStop = true;
            this.milesRadioButton.Text = "mi";
            this.milesRadioButton.UseSelectable = true;
            // 
            // kmRadioButton
            // 
            this.kmRadioButton.AutoSize = true;
            this.kmRadioButton.Location = new System.Drawing.Point(290, 255);
            this.kmRadioButton.Name = "kmRadioButton";
            this.kmRadioButton.Size = new System.Drawing.Size(41, 17);
            this.kmRadioButton.TabIndex = 24;
            this.kmRadioButton.Text = "km";
            this.kmRadioButton.UseSelectable = true;
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
            this.addActivityButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addActivityButton.Location = new System.Drawing.Point(259, 550);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(178, 44);
            this.addActivityButton.TabIndex = 27;
            this.addActivityButton.Text = "Add Workout";
            this.addActivityButton.UseSelectable = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // cancelNewActivityButton
            // 
            this.cancelNewActivityButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.cancelNewActivityButton.Location = new System.Drawing.Point(37, 550);
            this.cancelNewActivityButton.Name = "cancelNewActivityButton";
            this.cancelNewActivityButton.Size = new System.Drawing.Size(178, 44);
            this.cancelNewActivityButton.TabIndex = 28;
            this.cancelNewActivityButton.Text = "Cancel";
            this.cancelNewActivityButton.UseSelectable = true;
            this.cancelNewActivityButton.Click += new System.EventHandler(this.cancelNewActivityButton_Click);
            // 
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 613);
            this.Controls.Add(this.cancelNewActivityButton);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.activityNotesLabel);
            this.Controls.Add(this.kmRadioButton);
            this.Controls.Add(this.milesRadioButton);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.activityDurationTextBox);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.addActivityTypeButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateDateTimeChooser);
            this.Controls.Add(this.activityTypeDropDown);
            this.Controls.Add(this.activityTypeLabel);
            this.Controls.Add(this.activityTitleTextBox);
            this.Controls.Add(this.activityTitleLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private MetroFramework.Controls.MetroButton addActivityTypeButton;
        private MetroFramework.Controls.MetroLabel durationLabel;
        private MetroFramework.Controls.MetroTextBox activityDurationTextBox;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel distanceLabel;
        private MetroFramework.Controls.MetroRadioButton milesRadioButton;
        private MetroFramework.Controls.MetroRadioButton kmRadioButton;
        private MetroFramework.Controls.MetroLabel activityNotesLabel;
        private MetroFramework.Controls.MetroTextBox notesTextBox;
        private MetroFramework.Controls.MetroButton addActivityButton;
        private MetroFramework.Controls.MetroButton cancelNewActivityButton;
    }
}