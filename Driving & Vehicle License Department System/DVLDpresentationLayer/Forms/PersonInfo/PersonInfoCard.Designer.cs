namespace DVLDpresentationLayer.Forms.PersonInfo
{
    partial class ShowPersonInfo
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personCardInfo1 = new DVLDpresentationLayer.PersonCardInfo();
            this.linkLabelEditPersonInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::DVLDpresentationLayer.Properties.Resources.Button_close_24x24;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.Location = new System.Drawing.Point(798, 441);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(84, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person Details";
            // 
            // personCardInfo1
            // 
            this.personCardInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.personCardInfo1.Location = new System.Drawing.Point(12, 106);
            this.personCardInfo1.Name = "personCardInfo1";
            this.personCardInfo1.Size = new System.Drawing.Size(870, 329);
            this.personCardInfo1.TabIndex = 3;
            // 
            // linkLabelEditPersonInfo
            // 
            this.linkLabelEditPersonInfo.AutoSize = true;
            this.linkLabelEditPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEditPersonInfo.Location = new System.Drawing.Point(717, 179);
            this.linkLabelEditPersonInfo.Name = "linkLabelEditPersonInfo";
            this.linkLabelEditPersonInfo.Size = new System.Drawing.Size(123, 20);
            this.linkLabelEditPersonInfo.TabIndex = 4;
            this.linkLabelEditPersonInfo.TabStop = true;
            this.linkLabelEditPersonInfo.Text = "Edit Person Info";
            this.linkLabelEditPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditPersonInfo_LinkClicked);
            // 
            // ShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 476);
            this.Controls.Add(this.linkLabelEditPersonInfo);
            this.Controls.Add(this.personCardInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Name = "ShowPersonInfo";
            this.Text = "Person Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private PersonCardInfo personCardInfo1;
        private System.Windows.Forms.LinkLabel linkLabelEditPersonInfo;
    }
}