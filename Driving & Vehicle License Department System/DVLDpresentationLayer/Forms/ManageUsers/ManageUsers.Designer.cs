namespace DVLDpresentationLayer.Forms.ManageUsers
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsersInfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStripForPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelManageUsers = new System.Windows.Forms.Label();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.comboBoxIsActiveChoice = new System.Windows.Forms.ComboBox();
            this.textBoxMoreFillter = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersInfo)).BeginInit();
            this.contextMenuStripForPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsersInfo
            // 
            this.dataGridViewUsersInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsersInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersInfo.ContextMenuStrip = this.contextMenuStripForPeople;
            this.dataGridViewUsersInfo.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewUsersInfo.Name = "dataGridViewUsersInfo";
            this.dataGridViewUsersInfo.Size = new System.Drawing.Size(960, 198);
            this.dataGridViewUsersInfo.TabIndex = 9;
            // 
            // contextMenuStripForPeople
            // 
            this.contextMenuStripForPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStripForPeople.Name = "contextMenuStrip1";
            this.contextMenuStripForPeople.Size = new System.Drawing.Size(171, 196);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // labelManageUsers
            // 
            this.labelManageUsers.AutoSize = true;
            this.labelManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelManageUsers.Location = new System.Drawing.Point(372, 170);
            this.labelManageUsers.Name = "labelManageUsers";
            this.labelManageUsers.Size = new System.Drawing.Size(202, 31);
            this.labelManageUsers.TabIndex = 7;
            this.labelManageUsers.Text = "Manage Users";
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Location = new System.Drawing.Point(86, 219);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(176, 24);
            this.comboBoxFilterBy.TabIndex = 12;
            this.comboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBy_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(12, 222);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(68, 16);
            this.labelFilter.TabIndex = 11;
            this.labelFilter.Text = "Filter By:";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(12, 452);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(86, 16);
            this.labelRecords.TabIndex = 10;
            this.labelRecords.Text = "# Records: ";
            // 
            // comboBoxIsActiveChoice
            // 
            this.comboBoxIsActiveChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIsActiveChoice.FormattingEnabled = true;
            this.comboBoxIsActiveChoice.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBoxIsActiveChoice.Location = new System.Drawing.Point(268, 219);
            this.comboBoxIsActiveChoice.Name = "comboBoxIsActiveChoice";
            this.comboBoxIsActiveChoice.Size = new System.Drawing.Size(98, 24);
            this.comboBoxIsActiveChoice.TabIndex = 14;
            this.comboBoxIsActiveChoice.Visible = false;
            this.comboBoxIsActiveChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxIsActiveChoice_SelectedIndexChanged);
            // 
            // textBoxMoreFillter
            // 
            this.textBoxMoreFillter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoreFillter.Location = new System.Drawing.Point(268, 219);
            this.textBoxMoreFillter.Multiline = true;
            this.textBoxMoreFillter.Name = "textBoxMoreFillter";
            this.textBoxMoreFillter.Size = new System.Drawing.Size(196, 24);
            this.textBoxMoreFillter.TabIndex = 15;
            this.textBoxMoreFillter.Visible = false;
            this.textBoxMoreFillter.TextChanged += new System.EventHandler(this.textBoxMoreFillter_TextChanged);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.Snow;
            this.buttonCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseForm.Image = global::DVLDpresentationLayer.Properties.Resources.Button_close_another_24x24;
            this.buttonCloseForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCloseForm.Location = new System.Drawing.Point(893, 455);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(79, 33);
            this.buttonCloseForm.TabIndex = 16;
            this.buttonCloseForm.Text = "Close";
            this.buttonCloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Menu_info_of_media_24x24;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Button_Add_person_man_24x24;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Menu_edit_24x24;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Menu_Delete_24x24;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Menu_mailbox_24x24;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLDpresentationLayer.Properties.Resources.Menu_mobile_phone_24x24;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Image = global::DVLDpresentationLayer.Properties.Resources.user_add;
            this.buttonAddUser.Location = new System.Drawing.Point(918, 197);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(54, 48);
            this.buttonAddUser.TabIndex = 13;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDpresentationLayer.Properties.Resources.user_config;
            this.pictureBox1.Location = new System.Drawing.Point(378, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.comboBoxIsActiveChoice);
            this.Controls.Add(this.dataGridViewUsersInfo);
            this.Controls.Add(this.labelManageUsers);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMoreFillter);
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersInfo)).EndInit();
            this.contextMenuStripForPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsersInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Label labelManageUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxIsActiveChoice;
        private System.Windows.Forms.TextBox textBoxMoreFillter;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}