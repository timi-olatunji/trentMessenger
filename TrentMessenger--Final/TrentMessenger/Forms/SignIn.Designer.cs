namespace Trentmessenger
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_account = new System.Windows.Forms.Panel();
            this.maskedTextBox_number = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_passwordError = new System.Windows.Forms.PictureBox();
            this.button_showPass = new System.Windows.Forms.Button();
            this.linkLabel_recovery = new System.Windows.Forms.LinkLabel();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.timer_intro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logo.Image = global::Trentmessenger.Properties.Resources.reply_all_97621_1280;
            this.pictureBox_logo.Location = new System.Drawing.Point(114, 55);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(246, 189);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(68, 249);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(342, 48);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "TrentMessenger";
            // 
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.Color.Transparent;
            this.panel_account.Controls.Add(this.maskedTextBox_number);
            this.panel_account.Controls.Add(this.pictureBox_passwordError);
            this.panel_account.Controls.Add(this.button_showPass);
            this.panel_account.Controls.Add(this.linkLabel_recovery);
            this.panel_account.Controls.Add(this.button_login);
            this.panel_account.Controls.Add(this.button_register);
            this.panel_account.Controls.Add(this.textBox_password);
            this.panel_account.Location = new System.Drawing.Point(60, 323);
            this.panel_account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(350, 262);
            this.panel_account.TabIndex = 2;
            // 
            // maskedTextBox_number
            // 
            this.maskedTextBox_number.BackColor = System.Drawing.Color.Purple;
            this.maskedTextBox_number.BeepOnError = true;
            this.maskedTextBox_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_number.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox_number.ForeColor = System.Drawing.Color.GhostWhite;
            this.maskedTextBox_number.Location = new System.Drawing.Point(54, 26);
            this.maskedTextBox_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBox_number.Mask = "00-00-00-00-00-0";
            this.maskedTextBox_number.Name = "maskedTextBox_number";
            this.maskedTextBox_number.Size = new System.Drawing.Size(246, 30);
            this.maskedTextBox_number.TabIndex = 1;
            this.maskedTextBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_info.SetToolTip(this.maskedTextBox_number, "Enter a UK Number Starting with 07 and Containing only 11 Numbers");
            this.maskedTextBox_number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxNumber_MaskInputRejected);
            // 
            // pictureBox_passwordError
            // 
            this.pictureBox_passwordError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_passwordError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_passwordError.Image = global::Trentmessenger.Properties.Resources.exclamation_31198_1280;
            this.pictureBox_passwordError.Location = new System.Drawing.Point(303, 98);
            this.pictureBox_passwordError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_passwordError.Name = "pictureBox_passwordError";
            this.pictureBox_passwordError.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_passwordError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_passwordError.TabIndex = 17;
            this.pictureBox_passwordError.TabStop = false;
            this.pictureBox_passwordError.Visible = false;
            // 
            // button_showPass
            // 
            this.button_showPass.BackColor = System.Drawing.Color.Purple;
            this.button_showPass.BackgroundImage = global::Trentmessenger.Properties.Resources.key_2028593;
            this.button_showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showPass.Enabled = false;
            this.button_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showPass.Location = new System.Drawing.Point(278, 98);
            this.button_showPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_showPass.Name = "button_showPass";
            this.button_showPass.Size = new System.Drawing.Size(22, 23);
            this.button_showPass.TabIndex = 5;
            this.button_showPass.UseVisualStyleBackColor = false;
            this.button_showPass.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // linkLabel_recovery
            // 
            this.linkLabel_recovery.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_recovery.AutoSize = true;
            this.linkLabel_recovery.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_recovery.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel_recovery.Location = new System.Drawing.Point(69, 135);
            this.linkLabel_recovery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_recovery.Name = "linkLabel_recovery";
            this.linkLabel_recovery.Size = new System.Drawing.Size(210, 19);
            this.linkLabel_recovery.TabIndex = 4;
            this.linkLabel_recovery.TabStop = true;
            this.linkLabel_recovery.Text = "I\'ve Forgotten My Password";
            this.linkLabel_recovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RecoveryLinkLabel_LinkClicked);
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Enabled = false;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(54, 186);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(112, 48);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // button_register
            // 
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(189, 186);
            this.button_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 48);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.Purple;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox_password.Location = new System.Drawing.Point(54, 95);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(246, 30);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "Password";
            this.textBox_password.Click += new System.EventHandler(this.TextBoxPasswordClick);
            this.textBox_password.TextChanged += new System.EventHandler(this.TextBoxPasswordTextChanged);
            this.textBox_password.Leave += new System.EventHandler(this.TextBoxPasswordLeave);
            // 
            // toolTip_info
            // 
            this.toolTip_info.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolTip_info.ForeColor = System.Drawing.Color.White;
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip_info.ToolTipTitle = "Entry Error";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trentmessenger.Properties.Resources.background_159244_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.panel_account);
            this.Controls.Add(this.label_name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_account.ResumeLayout(false);
            this.panel_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_account;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.LinkLabel linkLabel_recovery;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_showPass;
        private System.Windows.Forms.PictureBox pictureBox_passwordError;
        private System.Windows.Forms.ToolTip toolTip_info;
        private System.Windows.Forms.Timer timer_intro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_number;
    }
}