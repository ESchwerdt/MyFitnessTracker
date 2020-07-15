namespace FitnessTracker
{
    partial class NewActivityTypeForm
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
            this.newActivityNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.newActivityTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.addNewActivityTypeButton = new MetroFramework.Controls.MetroButton();
            this.cancelAddButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(91, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(295, 38);
            this.headerLabel.TabIndex = 10;
            this.headerLabel.Text = "Add New Activity Type";
            // 
            // newActivityNameTextBox
            // 
            // 
            // 
            // 
            this.newActivityNameTextBox.CustomButton.Image = null;
            this.newActivityNameTextBox.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.newActivityNameTextBox.CustomButton.Name = "";
            this.newActivityNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newActivityNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newActivityNameTextBox.CustomButton.TabIndex = 1;
            this.newActivityNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newActivityNameTextBox.CustomButton.UseSelectable = true;
            this.newActivityNameTextBox.CustomButton.Visible = false;
            this.newActivityNameTextBox.Lines = new string[0];
            this.newActivityNameTextBox.Location = new System.Drawing.Point(167, 67);
            this.newActivityNameTextBox.MaxLength = 32767;
            this.newActivityNameTextBox.Name = "newActivityNameTextBox";
            this.newActivityNameTextBox.PasswordChar = '\0';
            this.newActivityNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newActivityNameTextBox.SelectedText = "";
            this.newActivityNameTextBox.SelectionLength = 0;
            this.newActivityNameTextBox.SelectionStart = 0;
            this.newActivityNameTextBox.ShortcutsEnabled = true;
            this.newActivityNameTextBox.Size = new System.Drawing.Size(268, 23);
            this.newActivityNameTextBox.TabIndex = 13;
            this.newActivityNameTextBox.UseSelectable = true;
            this.newActivityNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newActivityNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newActivityTypeLabel
            // 
            this.newActivityTypeLabel.AutoSize = true;
            this.newActivityTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.newActivityTypeLabel.Location = new System.Drawing.Point(32, 65);
            this.newActivityTypeLabel.Name = "newActivityTypeLabel";
            this.newActivityTypeLabel.Size = new System.Drawing.Size(127, 25);
            this.newActivityTypeLabel.TabIndex = 12;
            this.newActivityTypeLabel.Text = "Activity Name:";
            // 
            // addNewActivityTypeButton
            // 
            this.addNewActivityTypeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addNewActivityTypeButton.Location = new System.Drawing.Point(139, 123);
            this.addNewActivityTypeButton.Name = "addNewActivityTypeButton";
            this.addNewActivityTypeButton.Size = new System.Drawing.Size(198, 51);
            this.addNewActivityTypeButton.TabIndex = 14;
            this.addNewActivityTypeButton.Text = "Add New Activity Type";
            this.addNewActivityTypeButton.UseSelectable = true;
            this.addNewActivityTypeButton.Click += new System.EventHandler(this.addNewActivityTypeButton_Click);
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.Location = new System.Drawing.Point(32, 138);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAddButton.TabIndex = 15;
            this.cancelAddButton.Text = "Cancel";
            this.cancelAddButton.UseSelectable = true;
            this.cancelAddButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // NewActivityTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 204);
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.addNewActivityTypeButton);
            this.Controls.Add(this.newActivityNameTextBox);
            this.Controls.Add(this.newActivityTypeLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewActivityTypeForm";
            this.Text = "Add New Activity Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private MetroFramework.Controls.MetroTextBox newActivityNameTextBox;
        private MetroFramework.Controls.MetroLabel newActivityTypeLabel;
        private MetroFramework.Controls.MetroButton addNewActivityTypeButton;
        private MetroFramework.Controls.MetroButton cancelAddButton;
    }
}