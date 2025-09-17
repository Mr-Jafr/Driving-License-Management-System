namespace DVLDpresentationLayer.Forms
{
    partial class Main
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonApplications = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPeople = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDrivers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonApplications,
            this.toolStripButtonPeople,
            this.toolStripButtonDrivers,
            this.toolStripButtonUsers,
            this.toolStripButtonSettings});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1584, 55);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "s";
            // 
            // toolStripButtonApplications
            // 
            this.toolStripButtonApplications.Image = global::DVLDpresentationLayer.Properties.Resources.ToolStripMenu_Application_48x48;
            this.toolStripButtonApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApplications.Name = "toolStripButtonApplications";
            this.toolStripButtonApplications.Size = new System.Drawing.Size(125, 52);
            this.toolStripButtonApplications.Text = "Applications";
            // 
            // toolStripButtonPeople
            // 
            this.toolStripButtonPeople.Image = global::DVLDpresentationLayer.Properties.Resources.ToolStripMenu_People_48x48;
            this.toolStripButtonPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPeople.Name = "toolStripButtonPeople";
            this.toolStripButtonPeople.Size = new System.Drawing.Size(95, 52);
            this.toolStripButtonPeople.Text = "People";
            this.toolStripButtonPeople.Click += new System.EventHandler(this.toolStripButtonPeople_Click);
            // 
            // toolStripButtonDrivers
            // 
            this.toolStripButtonDrivers.Image = global::DVLDpresentationLayer.Properties.Resources.ToolStripMenu_Drivers_48x48;
            this.toolStripButtonDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDrivers.Name = "toolStripButtonDrivers";
            this.toolStripButtonDrivers.Size = new System.Drawing.Size(95, 52);
            this.toolStripButtonDrivers.Text = "Drivers";
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.Image = global::DVLDpresentationLayer.Properties.Resources.ToolStripMenu_user_config_48x48;
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(87, 52);
            this.toolStripButtonUsers.Text = "Users";
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonUsers_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCurrentUserInfo,
            this.toolStripMenuItemChangePassword,
            this.toolStripMenuItem4,
            this.toolStripMenuItemSignOut});
            this.toolStripButtonSettings.Image = global::DVLDpresentationLayer.Properties.Resources.ToolStripMenu_Settings_48x48;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(158, 52);
            this.toolStripButtonSettings.Text = "Account Settings";
            // 
            // toolStripMenuItemCurrentUserInfo
            // 
            this.toolStripMenuItemCurrentUserInfo.Image = global::DVLDpresentationLayer.Properties.Resources.info_of_media;
            this.toolStripMenuItemCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemCurrentUserInfo.Name = "toolStripMenuItemCurrentUserInfo";
            this.toolStripMenuItemCurrentUserInfo.Size = new System.Drawing.Size(184, 38);
            this.toolStripMenuItemCurrentUserInfo.Text = "Current User Info";
            this.toolStripMenuItemCurrentUserInfo.Click += new System.EventHandler(this.toolStripMenuItemCurrentUserInfo_Click);
            // 
            // toolStripMenuItemChangePassword
            // 
            this.toolStripMenuItemChangePassword.Image = global::DVLDpresentationLayer.Properties.Resources.context_Menu_Change_Password24x24;
            this.toolStripMenuItemChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemChangePassword.Name = "toolStripMenuItemChangePassword";
            this.toolStripMenuItemChangePassword.Size = new System.Drawing.Size(184, 38);
            this.toolStripMenuItemChangePassword.Text = "Change Password";
            this.toolStripMenuItemChangePassword.Click += new System.EventHandler(this.toolStripMenuItemChangePassword_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItemSignOut
            // 
            this.toolStripMenuItemSignOut.Image = global::DVLDpresentationLayer.Properties.Resources.user_delete;
            this.toolStripMenuItemSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemSignOut.Name = "toolStripMenuItemSignOut";
            this.toolStripMenuItemSignOut.Size = new System.Drawing.Size(184, 38);
            this.toolStripMenuItemSignOut.Text = "Sign Out";
            this.toolStripMenuItemSignOut.Click += new System.EventHandler(this.toolStripMenuItemSignOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Main";
            this.Text = " ";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonApplications;
        private System.Windows.Forms.ToolStripButton toolStripButtonPeople;
        private System.Windows.Forms.ToolStripButton toolStripButtonDrivers;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSignOut;
    }
}