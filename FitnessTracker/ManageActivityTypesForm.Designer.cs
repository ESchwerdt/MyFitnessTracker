namespace FitnessTracker
{
    partial class ManageActivityTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageActivityTypesForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.activityTypeListBox = new System.Windows.Forms.ListBox();
            this.addActivityTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.addActivityNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addActivityTypeButton = new MetroFramework.Controls.MetroButton();
            this.addActivityTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.activityLabel = new MetroFramework.Controls.MetroLabel();
            this.doneButton = new MetroFramework.Controls.MetroButton();
            this.addActivityTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(141, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(293, 38);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Manage Activity Types";
            // 
            // activityTypeListBox
            // 
            this.activityTypeListBox.FormattingEnabled = true;
            this.activityTypeListBox.ItemHeight = 23;
            this.activityTypeListBox.Location = new System.Drawing.Point(19, 112);
            this.activityTypeListBox.Name = "activityTypeListBox";
            this.activityTypeListBox.Size = new System.Drawing.Size(177, 257);
            this.activityTypeListBox.TabIndex = 12;
            // 
            // addActivityTypeLabel
            // 
            this.addActivityTypeLabel.AutoSize = true;
            this.addActivityTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.addActivityTypeLabel.Location = new System.Drawing.Point(90, 39);
            this.addActivityTypeLabel.Name = "addActivityTypeLabel";
            this.addActivityTypeLabel.Size = new System.Drawing.Size(127, 25);
            this.addActivityTypeLabel.TabIndex = 15;
            this.addActivityTypeLabel.Text = "Activity Name:";
            // 
            // addActivityNameTextBox
            // 
            // 
            // 
            // 
            this.addActivityNameTextBox.CustomButton.Image = null;
            this.addActivityNameTextBox.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.addActivityNameTextBox.CustomButton.Name = "";
            this.addActivityNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addActivityNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addActivityNameTextBox.CustomButton.TabIndex = 1;
            this.addActivityNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addActivityNameTextBox.CustomButton.UseSelectable = true;
            this.addActivityNameTextBox.CustomButton.Visible = false;
            this.addActivityNameTextBox.Lines = new string[0];
            this.addActivityNameTextBox.Location = new System.Drawing.Point(245, 179);
            this.addActivityNameTextBox.MaxLength = 32767;
            this.addActivityNameTextBox.Name = "addActivityNameTextBox";
            this.addActivityNameTextBox.PasswordChar = '\0';
            this.addActivityNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addActivityNameTextBox.SelectedText = "";
            this.addActivityNameTextBox.SelectionLength = 0;
            this.addActivityNameTextBox.SelectionStart = 0;
            this.addActivityNameTextBox.ShortcutsEnabled = true;
            this.addActivityNameTextBox.Size = new System.Drawing.Size(288, 23);
            this.addActivityNameTextBox.TabIndex = 16;
            this.addActivityNameTextBox.UseSelectable = true;
            this.addActivityNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addActivityNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addActivityTypeButton
            // 
            this.addActivityTypeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addActivityTypeButton.Location = new System.Drawing.Point(117, 109);
            this.addActivityTypeButton.Name = "addActivityTypeButton";
            this.addActivityTypeButton.Size = new System.Drawing.Size(75, 23);
            this.addActivityTypeButton.TabIndex = 17;
            this.addActivityTypeButton.Text = "Add";
            this.addActivityTypeButton.UseSelectable = true;
            this.addActivityTypeButton.Click += new System.EventHandler(this.addActivityTypeButton_Click);
            // 
            // addActivityTypeGroupBox
            // 
            this.addActivityTypeGroupBox.Controls.Add(this.addActivityTypeLabel);
            this.addActivityTypeGroupBox.Controls.Add(this.addActivityTypeButton);
            this.addActivityTypeGroupBox.Location = new System.Drawing.Point(230, 112);
            this.addActivityTypeGroupBox.Name = "addActivityTypeGroupBox";
            this.addActivityTypeGroupBox.Size = new System.Drawing.Size(322, 159);
            this.addActivityTypeGroupBox.TabIndex = 19;
            this.addActivityTypeGroupBox.TabStop = false;
            this.addActivityTypeGroupBox.Text = "Add New Activity Type";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.activityLabel.Location = new System.Drawing.Point(19, 73);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(124, 25);
            this.activityLabel.TabIndex = 20;
            this.activityLabel.Text = "Activity Types:";
            // 
            // doneButton
            // 
            this.doneButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.doneButton.Location = new System.Drawing.Point(238, 398);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(98, 39);
            this.doneButton.TabIndex = 21;
            this.doneButton.Text = "DONE";
            this.doneButton.UseSelectable = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // ManageActivityTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 460);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.addActivityNameTextBox);
            this.Controls.Add(this.activityTypeListBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.addActivityTypeGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageActivityTypesForm";
            this.Text = "Manage Activity Types";
            this.addActivityTypeGroupBox.ResumeLayout(false);
            this.addActivityTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox activityTypeListBox;
        private MetroFramework.Controls.MetroLabel addActivityTypeLabel;
        private MetroFramework.Controls.MetroTextBox addActivityNameTextBox;
        private MetroFramework.Controls.MetroButton addActivityTypeButton;
        private System.Windows.Forms.GroupBox addActivityTypeGroupBox;
        private MetroFramework.Controls.MetroLabel activityLabel;
        private MetroFramework.Controls.MetroButton doneButton;
    }
}