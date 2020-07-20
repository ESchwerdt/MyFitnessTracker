namespace FitnessTracker
{
    partial class ViewActivityForm
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
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.durationLabel = new MetroFramework.Controls.MetroLabel();
            this.durationValueLabel = new MetroFramework.Controls.MetroLabel();
            this.distanceValueLabel = new MetroFramework.Controls.MetroLabel();
            this.distanceLabel = new MetroFramework.Controls.MetroLabel();
            this.notesLabel = new MetroFramework.Controls.MetroLabel();
            this.notesValueLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(39, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(85, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "workout title";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.dateLabel.Location = new System.Drawing.Point(39, 64);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "workout date";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(39, 103);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(65, 20);
            this.durationLabel.TabIndex = 2;
            this.durationLabel.Text = "Duration:";
            // 
            // durationValueLabel
            // 
            this.durationValueLabel.AutoSize = true;
            this.durationValueLabel.Location = new System.Drawing.Point(110, 103);
            this.durationValueLabel.Name = "durationValueLabel";
            this.durationValueLabel.Size = new System.Drawing.Size(42, 20);
            this.durationValueLabel.TabIndex = 3;
            this.durationValueLabel.Text = "value";
            // 
            // distanceValueLabel
            // 
            this.distanceValueLabel.AutoSize = true;
            this.distanceValueLabel.Location = new System.Drawing.Point(110, 133);
            this.distanceValueLabel.Name = "distanceValueLabel";
            this.distanceValueLabel.Size = new System.Drawing.Size(42, 20);
            this.distanceValueLabel.TabIndex = 5;
            this.distanceValueLabel.Text = "value";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(39, 133);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(65, 20);
            this.distanceLabel.TabIndex = 4;
            this.distanceLabel.Text = "Distance:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(39, 166);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(49, 20);
            this.notesLabel.TabIndex = 6;
            this.notesLabel.Text = "Notes:";
            // 
            // notesValueLabel
            // 
            this.notesValueLabel.AutoSize = true;
            this.notesValueLabel.Location = new System.Drawing.Point(39, 195);
            this.notesValueLabel.Name = "notesValueLabel";
            this.notesValueLabel.Size = new System.Drawing.Size(42, 20);
            this.notesValueLabel.TabIndex = 7;
            this.notesValueLabel.Text = "value";
            this.notesValueLabel.WrapToLine = true;
            // 
            // ViewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 389);
            this.Controls.Add(this.notesValueLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.distanceValueLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.durationValueLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewActivityForm";
            this.Text = "Workout Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroLabel durationLabel;
        private MetroFramework.Controls.MetroLabel durationValueLabel;
        private MetroFramework.Controls.MetroLabel distanceValueLabel;
        private MetroFramework.Controls.MetroLabel distanceLabel;
        private MetroFramework.Controls.MetroLabel notesLabel;
        private MetroFramework.Controls.MetroLabel notesValueLabel;
    }
}