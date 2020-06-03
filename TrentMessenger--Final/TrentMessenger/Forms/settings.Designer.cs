namespace Trentmessenger
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.panelAccount = new System.Windows.Forms.Panel();
            this.richTextBoxAboutRT = new System.Windows.Forms.RichTextBox();
            this.labelUsernameLB = new System.Windows.Forms.Label();
            this.pictureBoxPhotoPB = new System.Windows.Forms.PictureBox();
            this.button_account_btn = new System.Windows.Forms.Button();
            this.buttonApp_btn = new System.Windows.Forms.Button();
            this.buttonDeleteBtn = new System.Windows.Forms.Button();
            this.buttonAboutBtn = new System.Windows.Forms.Button();
            this.buttonContactsBtn = new System.Windows.Forms.Button();
            this.panelFooterPN = new System.Windows.Forms.Panel();
            this.label_UserRegistrationDate = new System.Windows.Forms.Label();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoPB)).BeginInit();
            this.panelFooterPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_account
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Purple;
            this.panelAccount.Controls.Add(this.richTextBoxAboutRT);
            this.panelAccount.Controls.Add(this.labelUsernameLB);
            this.panelAccount.Controls.Add(this.pictureBoxPhotoPB);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAccount.Name = "panel_account";
            this.panelAccount.Size = new System.Drawing.Size(476, 154);
            this.panelAccount.TabIndex = 0;
            // 
            // richTextBox_about
            // 
            this.richTextBoxAboutRT.BackColor = System.Drawing.Color.Purple;
            this.richTextBoxAboutRT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAboutRT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxAboutRT.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAboutRT.ForeColor = System.Drawing.Color.White;
            this.richTextBoxAboutRT.HideSelection = false;
            this.richTextBoxAboutRT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBoxAboutRT.Location = new System.Drawing.Point(176, 63);
            this.richTextBoxAboutRT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxAboutRT.Name = "richTextBox_about";
            this.richTextBoxAboutRT.ReadOnly = true;
            this.richTextBoxAboutRT.Size = new System.Drawing.Size(282, 86);
            this.richTextBoxAboutRT.TabIndex = 2;
            this.richTextBoxAboutRT.Text = "About";
            // 
            // label_username
            // 
            this.labelUsernameLB.AutoSize = true;
            this.labelUsernameLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameLB.ForeColor = System.Drawing.Color.White;
            this.labelUsernameLB.Location = new System.Drawing.Point(170, 14);
            this.labelUsernameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsernameLB.Name = "label_username";
            this.labelUsernameLB.Size = new System.Drawing.Size(116, 28);
            this.labelUsernameLB.TabIndex = 1;
            this.labelUsernameLB.Text = "Username";
            // 
            // pictureBox_photo
            // 
            this.pictureBoxPhotoPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhotoPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhotoPB.Image = global::Trentmessenger.Properties.Resources.Pic_Placeholder_Male;
            this.pictureBoxPhotoPB.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxPhotoPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPhotoPB.Name = "pictureBox_photo";
            this.pictureBoxPhotoPB.Size = new System.Drawing.Size(161, 144);
            this.pictureBoxPhotoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoPB.TabIndex = 0;
            this.pictureBoxPhotoPB.TabStop = false;
            // 
            // button_account
            // 
            this.button_account_btn.BackColor = System.Drawing.Color.Transparent;
            this.button_account_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_account_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_account_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account_btn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account_btn.Image = global::Trentmessenger.Properties.Resources.icon_accout1;
            this.button_account_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account_btn.Location = new System.Drawing.Point(0, 154);
            this.button_account_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_account_btn.Name = "button_account";
            this.button_account_btn.Size = new System.Drawing.Size(476, 91);
            this.button_account_btn.TabIndex = 1;
            this.button_account_btn.Text = "   Account Settings";
            this.button_account_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_account_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_account_btn.UseVisualStyleBackColor = false;
            this.button_account_btn.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // button_app
            // 
            this.buttonApp_btn.BackColor = System.Drawing.Color.Transparent;
            this.buttonApp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonApp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApp_btn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApp_btn.Image = ((System.Drawing.Image)(resources.GetObject("button_app.Image")));
            this.buttonApp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApp_btn.Location = new System.Drawing.Point(0, 332);
            this.buttonApp_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApp_btn.Name = "button_app";
            this.buttonApp_btn.Size = new System.Drawing.Size(476, 91);
            this.buttonApp_btn.TabIndex = 2;
            this.buttonApp_btn.Text = "    Application Settings";
            this.buttonApp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApp_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApp_btn.UseVisualStyleBackColor = false;
            this.buttonApp_btn.Click += new System.EventHandler(this.AppButton_Click);
            // 
            // button_delete
            // 
            this.buttonDeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBtn.Image = global::Trentmessenger.Properties.Resources.icon_delete;
            this.buttonDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteBtn.Location = new System.Drawing.Point(0, 422);
            this.buttonDeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteBtn.Name = "button_delete";
            this.buttonDeleteBtn.Size = new System.Drawing.Size(476, 91);
            this.buttonDeleteBtn.TabIndex = 3;
            this.buttonDeleteBtn.Text = "      Delete My Account";
            this.buttonDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeleteBtn.UseVisualStyleBackColor = false;
            this.buttonDeleteBtn.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button_about
            // 
            this.buttonAboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.buttonAboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutBtn.Image = global::Trentmessenger.Properties.Resources.if_about_2639759;
            this.buttonAboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAboutBtn.Location = new System.Drawing.Point(0, 511);
            this.buttonAboutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAboutBtn.Name = "button_about";
            this.buttonAboutBtn.Size = new System.Drawing.Size(476, 91);
            this.buttonAboutBtn.TabIndex = 4;
            this.buttonAboutBtn.Text = "    About this App";
            this.buttonAboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutBtn.UseVisualStyleBackColor = false;
            this.buttonAboutBtn.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // button_contacts
            // 
            this.buttonContactsBtn.BackColor = System.Drawing.Color.Transparent;
            this.buttonContactsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContactsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonContactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContactsBtn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactsBtn.Image = ((System.Drawing.Image)(resources.GetObject("button_contacts.Image")));
            this.buttonContactsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContactsBtn.Location = new System.Drawing.Point(0, 243);
            this.buttonContactsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContactsBtn.Name = "button_contacts";
            this.buttonContactsBtn.Size = new System.Drawing.Size(476, 91);
            this.buttonContactsBtn.TabIndex = 5;
            this.buttonContactsBtn.Text = "   Add New Contacts";
            this.buttonContactsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonContactsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonContactsBtn.UseVisualStyleBackColor = false;
            this.buttonContactsBtn.Click += new System.EventHandler(this.ContactsButton_Click);
            // 
            // panel_footer
            // 
            this.panelFooterPN.BackColor = System.Drawing.Color.Purple;
            this.panelFooterPN.Controls.Add(this.label_UserRegistrationDate);
            this.panelFooterPN.Location = new System.Drawing.Point(0, 602);
            this.panelFooterPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFooterPN.Name = "panel_footer";
            this.panelFooterPN.Size = new System.Drawing.Size(476, 51);
            this.panelFooterPN.TabIndex = 6;
            // 
            // label_registrationDate
            // 
            this.label_UserRegistrationDate.AutoSize = true;
            this.label_UserRegistrationDate.BackColor = System.Drawing.Color.Transparent;
            this.label_UserRegistrationDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserRegistrationDate.ForeColor = System.Drawing.Color.White;
            this.label_UserRegistrationDate.Location = new System.Drawing.Point(4, 15);
            this.label_UserRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_UserRegistrationDate.Name = "label_registrationDate";
            this.label_UserRegistrationDate.Size = new System.Drawing.Size(225, 20);
            this.label_UserRegistrationDate.TabIndex = 0;
            this.label_UserRegistrationDate.Text = "Registered on xx/xx/xxxx";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trentmessenger.Properties.Resources.background_159244_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.panelFooterPN);
            this.Controls.Add(this.buttonContactsBtn);
            this.Controls.Add(this.buttonAboutBtn);
            this.Controls.Add(this.buttonDeleteBtn);
            this.Controls.Add(this.buttonApp_btn);
            this.Controls.Add(this.button_account_btn);
            this.Controls.Add(this.panelAccount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoPB)).EndInit();
            this.panelFooterPN.ResumeLayout(false);
            this.panelFooterPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.PictureBox pictureBoxPhotoPB;
        private System.Windows.Forms.Label labelUsernameLB;
        private System.Windows.Forms.RichTextBox richTextBoxAboutRT;
        private System.Windows.Forms.Button button_account_btn;
        private System.Windows.Forms.Button buttonApp_btn;
        private System.Windows.Forms.Button buttonDeleteBtn;
        private System.Windows.Forms.Button buttonAboutBtn;
        private System.Windows.Forms.Button buttonContactsBtn;
        private System.Windows.Forms.Panel panelFooterPN;
        private System.Windows.Forms.Label label_UserRegistrationDate;
    }
}