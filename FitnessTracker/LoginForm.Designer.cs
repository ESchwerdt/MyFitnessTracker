namespace FitnessTracker
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.credentialsLabel = new MetroFramework.Controls.MetroLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.signInButton = new MetroFramework.Controls.MetroButton();
            this.createProfileLink = new MetroFramework.Controls.MetroLink();
            this.headerLabel = new System.Windows.Forms.Label();
            this.availableUserDropDown = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.usernameLabel.Location = new System.Drawing.Point(58, 123);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 25);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // credentialsLabel
            // 
            this.credentialsLabel.AutoSize = true;
            this.credentialsLabel.Location = new System.Drawing.Point(69, 76);
            this.credentialsLabel.Name = "credentialsLabel";
            this.credentialsLabel.Size = new System.Drawing.Size(256, 20);
            this.credentialsLabel.TabIndex = 1;
            this.credentialsLabel.Text = "Choose an existing Username to sign in:";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(199, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(59, 271);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(266, 35);
            this.htmlLabel1.TabIndex = 5;
            this.htmlLabel1.Text = "Not signed up yet? No problem!";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.SteelBlue;
            this.signInButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.signInButton.Location = new System.Drawing.Point(121, 187);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(194, 38);
            this.signInButton.TabIndex = 6;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseSelectable = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // createProfileLink
            // 
            this.createProfileLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.createProfileLink.Location = new System.Drawing.Point(59, 296);
            this.createProfileLink.Name = "createProfileLink";
            this.createProfileLink.Size = new System.Drawing.Size(188, 23);
            this.createProfileLink.TabIndex = 7;
            this.createProfileLink.Text = "Create a new profile now";
            this.createProfileLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createProfileLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.createProfileLink.UseSelectable = true;
            this.createProfileLink.Click += new System.EventHandler(this.createProfileLink_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.headerLabel.Location = new System.Drawing.Point(79, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(246, 38);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "My Fitness Tracker";
            // 
            // availableUserDropDown
            // 
            this.availableUserDropDown.FormattingEnabled = true;
            this.availableUserDropDown.ItemHeight = 24;
            this.availableUserDropDown.Location = new System.Drawing.Point(160, 118);
            this.availableUserDropDown.Name = "availableUserDropDown";
            this.availableUserDropDown.Size = new System.Drawing.Size(181, 30);
            this.availableUserDropDown.TabIndex = 10;
            this.availableUserDropDown.UseSelectable = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 357);
            this.Controls.Add(this.availableUserDropDown);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.createProfileLink);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.credentialsLabel);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "My Fitness Tracker - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel credentialsLabel;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton signInButton;
        private MetroFramework.Controls.MetroLink createProfileLink;
        private System.Windows.Forms.Label headerLabel;
        private MetroFramework.Controls.MetroComboBox availableUserDropDown;
    }
}

