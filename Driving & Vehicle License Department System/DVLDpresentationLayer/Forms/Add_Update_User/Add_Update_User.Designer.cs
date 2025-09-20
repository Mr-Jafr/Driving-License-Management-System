namespace DVLDpresentationLayer.Forms.Add_Update_User
{
    partial class Add_Update_User
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControlAdd_Update_User = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.personCardInfo1 = new DVLDpresentationLayer.PersonCardInfo();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.buttonFindPerson = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelResutlUserID = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.pictureBoxName = new System.Windows.Forms.PictureBox();
            this.pictureBoxNational = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageLoginInfo = new System.Windows.Forms.TabPage();
            this.tabControlAdd_Update_User.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNational)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(379, 72);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 31);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title Here";
            // 
            // tabControlAdd_Update_User
            // 
            this.tabControlAdd_Update_User.Controls.Add(this.tabPagePersonalInfo);
            this.tabControlAdd_Update_User.Controls.Add(this.tabPageLoginInfo);
            this.tabControlAdd_Update_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdd_Update_User.Location = new System.Drawing.Point(12, 158);
            this.tabControlAdd_Update_User.Name = "tabControlAdd_Update_User";
            this.tabControlAdd_Update_User.SelectedIndex = 0;
            this.tabControlAdd_Update_User.Size = new System.Drawing.Size(899, 513);
            this.tabControlAdd_Update_User.TabIndex = 9;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.groupBoxFilter);
            this.tabPagePersonalInfo.Controls.Add(this.buttonNext);
            this.tabPagePersonalInfo.Controls.Add(this.personCardInfo1);
            this.tabPagePersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(891, 482);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Personal Info";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // personCardInfo1
            // 
            this.personCardInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.personCardInfo1.Location = new System.Drawing.Point(10, 100);
            this.personCardInfo1.Name = "personCardInfo1";
            this.personCardInfo1.Size = new System.Drawing.Size(870, 329);
            this.personCardInfo1.TabIndex = 0;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonAddPerson);
            this.groupBoxFilter.Controls.Add(this.buttonFindPerson);
            this.groupBoxFilter.Controls.Add(this.textBoxFind);
            this.groupBoxFilter.Controls.Add(this.comboBoxFilterBy);
            this.groupBoxFilter.Controls.Add(this.labelFilter);
            this.groupBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(10, 13);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(870, 68);
            this.groupBoxFilter.TabIndex = 2;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Location = new System.Drawing.Point(87, 28);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(176, 24);
            this.comboBoxFilterBy.TabIndex = 14;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(13, 31);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(63, 16);
            this.labelFilter.TabIndex = 13;
            this.labelFilter.Text = "Find By:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(278, 28);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(196, 24);
            this.textBoxFind.TabIndex = 16;
            this.textBoxFind.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::DVLDpresentationLayer.Properties.Resources.close_button_32x32;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(693, 677);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(104, 35);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::DVLDpresentationLayer.Properties.Resources.save_button_32x32;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(803, 677);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 35);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.BackColor = System.Drawing.Color.White;
            this.buttonAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerson.Image = global::DVLDpresentationLayer.Properties.Resources.user_add_32x32;
            this.buttonAddPerson.Location = new System.Drawing.Point(554, 23);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(45, 35);
            this.buttonAddPerson.TabIndex = 13;
            this.buttonAddPerson.UseVisualStyleBackColor = false;
            // 
            // buttonFindPerson
            // 
            this.buttonFindPerson.BackColor = System.Drawing.Color.White;
            this.buttonFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindPerson.Image = global::DVLDpresentationLayer.Properties.Resources.user_find_32x32;
            this.buttonFindPerson.Location = new System.Drawing.Point(493, 23);
            this.buttonFindPerson.Name = "buttonFindPerson";
            this.buttonFindPerson.Size = new System.Drawing.Size(45, 35);
            this.buttonFindPerson.TabIndex = 12;
            this.buttonFindPerson.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Image = global::DVLDpresentationLayer.Properties.Resources.next_button_32x32;
            this.buttonNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNext.Location = new System.Drawing.Point(742, 435);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(138, 41);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword.Location = new System.Drawing.Point(249, 135);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 22);
            this.textBoxPassword.TabIndex = 63;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUserName.Location = new System.Drawing.Point(249, 85);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(155, 22);
            this.textBoxUserName.TabIndex = 61;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserName.Location = new System.Drawing.Point(48, 85);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 20);
            this.labelUserName.TabIndex = 62;
            this.labelUserName.Text = "User Name:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.Location = new System.Drawing.Point(48, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 20);
            this.labelPassword.TabIndex = 64;
            this.labelPassword.Text = "Password:";
            // 
            // labelResutlUserID
            // 
            this.labelResutlUserID.AutoSize = true;
            this.labelResutlUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResutlUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResutlUserID.Location = new System.Drawing.Point(306, 44);
            this.labelResutlUserID.Name = "labelResutlUserID";
            this.labelResutlUserID.Size = new System.Drawing.Size(36, 20);
            this.labelResutlUserID.TabIndex = 65;
            this.labelResutlUserID.Text = "???";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(249, 183);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(155, 22);
            this.textBoxConfirmPassword.TabIndex = 68;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelConfirmPassword.Location = new System.Drawing.Point(48, 185);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.labelConfirmPassword.TabIndex = 69;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(249, 223);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(81, 22);
            this.checkBoxIsActive.TabIndex = 70;
            this.checkBoxIsActive.Text = "Is Active";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserID.Location = new System.Drawing.Point(48, 44);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(71, 20);
            this.labelUserID.TabIndex = 71;
            this.labelUserID.Text = "UserID:";
            // 
            // pictureBoxName
            // 
            this.pictureBoxName.Image = global::DVLDpresentationLayer.Properties.Resources.Label_user_32x32;
            this.pictureBoxName.Location = new System.Drawing.Point(211, 75);
            this.pictureBoxName.Name = "pictureBoxName";
            this.pictureBoxName.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxName.TabIndex = 72;
            this.pictureBoxName.TabStop = false;
            // 
            // pictureBoxNational
            // 
            this.pictureBoxNational.Image = global::DVLDpresentationLayer.Properties.Resources.Label_barcode_32x32;
            this.pictureBoxNational.Location = new System.Drawing.Point(211, 32);
            this.pictureBoxNational.Name = "pictureBoxNational";
            this.pictureBoxNational.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNational.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxNational.TabIndex = 73;
            this.pictureBoxNational.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDpresentationLayer.Properties.Resources.Label_barcode_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(211, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDpresentationLayer.Properties.Resources.Label_barcode_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(211, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageLoginInfo
            // 
            this.tabPageLoginInfo.Controls.Add(this.pictureBox2);
            this.tabPageLoginInfo.Controls.Add(this.pictureBox1);
            this.tabPageLoginInfo.Controls.Add(this.pictureBoxNational);
            this.tabPageLoginInfo.Controls.Add(this.pictureBoxName);
            this.tabPageLoginInfo.Controls.Add(this.labelUserID);
            this.tabPageLoginInfo.Controls.Add(this.checkBoxIsActive);
            this.tabPageLoginInfo.Controls.Add(this.labelConfirmPassword);
            this.tabPageLoginInfo.Controls.Add(this.textBoxConfirmPassword);
            this.tabPageLoginInfo.Controls.Add(this.labelResutlUserID);
            this.tabPageLoginInfo.Controls.Add(this.labelPassword);
            this.tabPageLoginInfo.Controls.Add(this.labelUserName);
            this.tabPageLoginInfo.Controls.Add(this.textBoxUserName);
            this.tabPageLoginInfo.Controls.Add(this.textBoxPassword);
            this.tabPageLoginInfo.Location = new System.Drawing.Point(4, 27);
            this.tabPageLoginInfo.Name = "tabPageLoginInfo";
            this.tabPageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoginInfo.Size = new System.Drawing.Size(891, 482);
            this.tabPageLoginInfo.TabIndex = 1;
            this.tabPageLoginInfo.Text = "Login Info";
            this.tabPageLoginInfo.UseVisualStyleBackColor = true;
            // 
            // Add_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 721);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControlAdd_Update_User);
            this.Controls.Add(this.labelTitle);
            this.Name = "Add_Update_User";
            this.Text = "Add_Update_User";
            this.tabControlAdd_Update_User.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNational)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageLoginInfo.ResumeLayout(false);
            this.tabPageLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlAdd_Update_User;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private PersonCardInfo personCardInfo1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button buttonFindPerson;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.TabPage tabPageLoginInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxNational;
        private System.Windows.Forms.PictureBox pictureBoxName;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelResutlUserID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}