namespace Trentmessenger
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxQuestionS = new System.Windows.Forms.ComboBox();
            this.textBoxResponseS = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelQuestionS = new System.Windows.Forms.Label();
            this.labelAnswerS = new System.Windows.Forms.Label();
            this.pictureBoxNomError = new System.Windows.Forms.PictureBox();
            this.pictureBoxNumberError = new System.Windows.Forms.PictureBox();
            this.pictureBox_aboutError = new System.Windows.Forms.PictureBox();
            this.pictureBox_reponseError = new System.Windows.Forms.PictureBox();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.label_password_LB = new System.Windows.Forms.Label();
            this.textBox_password_pass = new System.Windows.Forms.TextBox();
            this.pictureBox_passwordError = new System.Windows.Forms.PictureBox();
            this.button_showPass_pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNomError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_aboutError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reponseError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.Color.Purple;
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxNumber.Location = new System.Drawing.Point(42, 162);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(176, 26);
            this.textBoxNumber.TabIndex = 2;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Purple;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(42, 82);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // comboBoxQuestionS
            // 
            this.comboBoxQuestionS.BackColor = System.Drawing.Color.Purple;
            this.comboBoxQuestionS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuestionS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuestionS.ForeColor = System.Drawing.Color.Transparent;
            this.comboBoxQuestionS.FormattingEnabled = true;
            this.comboBoxQuestionS.Items.AddRange(new object[] {
            "Favorite color",
            "Your father\'s place of birth",
            "Your best friend\'s name",
            "Your slogan",
            "The name of your first teacher",
            "The name of your first pet",
            "Your favorite place",
            "Your hobby",
            "Your favorite soccer club"});
            this.comboBoxQuestionS.Location = new System.Drawing.Point(42, 402);
            this.comboBoxQuestionS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxQuestionS.Name = "comboBoxQuestionS";
            this.comboBoxQuestionS.Size = new System.Drawing.Size(391, 27);
            this.comboBoxQuestionS.TabIndex = 5;
            this.comboBoxQuestionS.SelectedIndexChanged += new System.EventHandler(this.QuestionComboBox_SelectedIndexChanged);
            // 
            // textBoxResponseS
            // 
            this.textBoxResponseS.BackColor = System.Drawing.Color.Purple;
            this.textBoxResponseS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResponseS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponseS.ForeColor = System.Drawing.Color.White;
            this.textBoxResponseS.Location = new System.Drawing.Point(42, 485);
            this.textBoxResponseS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxResponseS.Name = "textBoxResponseS";
            this.textBoxResponseS.Size = new System.Drawing.Size(392, 26);
            this.textBoxResponseS.TabIndex = 6;
            this.textBoxResponseS.TextChanged += new System.EventHandler(this.ReponseTextBox_TextChanged);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPhoto.Image = global::Trentmessenger.Properties.Resources.Pic_Placeholder_Male;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(262, 57);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(172, 180);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.Enabled = false;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(42, 560);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(110, 57);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Enabled = false;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(323, 560);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(110, 57);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.BackColor = System.Drawing.Color.Purple;
            this.textBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAbout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout.ForeColor = System.Drawing.Color.White;
            this.textBoxAbout.Location = new System.Drawing.Point(42, 242);
            this.textBoxAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(176, 26);
            this.textBoxAbout.TabIndex = 3;
            this.textBoxAbout.TextChanged += new System.EventHandler(this.AboutTextBox_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(38, 57);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Username";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.White;
            this.labelNumber.Location = new System.Drawing.Point(38, 137);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(117, 20);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Phone Number";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelAbout.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.ForeColor = System.Drawing.Color.White;
            this.labelAbout.Location = new System.Drawing.Point(38, 217);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(90, 20);
            this.labelAbout.TabIndex = 11;
            this.labelAbout.Text = "Position ";
            // 
            // labelQuestionS
            // 
            this.labelQuestionS.AutoSize = true;
            this.labelQuestionS.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestionS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionS.ForeColor = System.Drawing.Color.White;
            this.labelQuestionS.Location = new System.Drawing.Point(38, 377);
            this.labelQuestionS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionS.Name = "labelQuestionS";
            this.labelQuestionS.Size = new System.Drawing.Size(162, 20);
            this.labelQuestionS.TabIndex = 12;
            this.labelQuestionS.Text = "Security Question";
            // 
            // labelAnswerS
            // 
            this.labelAnswerS.AutoSize = true;
            this.labelAnswerS.BackColor = System.Drawing.Color.Transparent;
            this.labelAnswerS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerS.ForeColor = System.Drawing.Color.White;
            this.labelAnswerS.Location = new System.Drawing.Point(38, 460);
            this.labelAnswerS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswerS.Name = "labelAnswerS";
            this.labelAnswerS.Size = new System.Drawing.Size(144, 20);
            this.labelAnswerS.TabIndex = 13;
            this.labelAnswerS.Text = "Security Answer";
            // 
            // pictureBoxNomError
            // 
            this.pictureBoxNomError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNomError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNomError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNomError.Image")));
            this.pictureBoxNomError.Location = new System.Drawing.Point(220, 82);
            this.pictureBoxNomError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxNomError.Name = "pictureBoxNomError";
            this.pictureBoxNomError.Size = new System.Drawing.Size(30, 31);
            this.pictureBoxNomError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNomError.TabIndex = 14;
            this.pictureBoxNomError.TabStop = false;
            this.pictureBoxNomError.Visible = false;
            // 
            // pictureBoxNumberError
            // 
            this.pictureBoxNumberError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNumberError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNumberError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNumberError.Image")));
            this.pictureBoxNumberError.Location = new System.Drawing.Point(220, 162);
            this.pictureBoxNumberError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxNumberError.Name = "pictureBoxNumberError";
            this.pictureBoxNumberError.Size = new System.Drawing.Size(30, 31);
            this.pictureBoxNumberError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNumberError.TabIndex = 15;
            this.pictureBoxNumberError.TabStop = false;
            this.pictureBoxNumberError.Visible = false;
            // 
            // pictureBox_aboutError
            // 
            this.pictureBox_aboutError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_aboutError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_aboutError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_aboutError.Image")));
            this.pictureBox_aboutError.Location = new System.Drawing.Point(220, 242);
            this.pictureBox_aboutError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_aboutError.Name = "pictureBox_aboutError";
            this.pictureBox_aboutError.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_aboutError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_aboutError.TabIndex = 16;
            this.pictureBox_aboutError.TabStop = false;
            this.pictureBox_aboutError.Visible = false;
            // 
            // pictureBox_reponseError
            // 
            this.pictureBox_reponseError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_reponseError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_reponseError.Image = global::Trentmessenger.Properties.Resources.exclamation_31198_1280;
            this.pictureBox_reponseError.Location = new System.Drawing.Point(436, 485);
            this.pictureBox_reponseError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_reponseError.Name = "pictureBox_reponseError";
            this.pictureBox_reponseError.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_reponseError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reponseError.TabIndex = 17;
            this.pictureBox_reponseError.TabStop = false;
            this.pictureBox_reponseError.Visible = false;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.BackColor = System.Drawing.Color.Teal;
            this.toolTipInfo.ForeColor = System.Drawing.Color.White;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTipInfo.ToolTipTitle = "Entry Error";
            // 
            // label_password_LB
            // 
            this.label_password_LB.AutoSize = true;
            this.label_password_LB.BackColor = System.Drawing.Color.Transparent;
            this.label_password_LB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_LB.ForeColor = System.Drawing.Color.White;
            this.label_password_LB.Location = new System.Drawing.Point(38, 300);
            this.label_password_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password_LB.Name = "label_password_LB";
            this.label_password_LB.Size = new System.Drawing.Size(81, 20);
            this.label_password_LB.TabIndex = 19;
            this.label_password_LB.Text = "Password";
            // 
            // textBox_password_pass
            // 
            this.textBox_password_pass.BackColor = System.Drawing.Color.Purple;
            this.textBox_password_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password_pass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password_pass.ForeColor = System.Drawing.Color.White;
            this.textBox_password_pass.Location = new System.Drawing.Point(42, 322);
            this.textBox_password_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password_pass.Name = "textBox_password_pass";
            this.textBox_password_pass.Size = new System.Drawing.Size(176, 26);
            this.textBox_password_pass.TabIndex = 4;
            this.textBox_password_pass.UseSystemPasswordChar = true;
            this.textBox_password_pass.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // pictureBox_passwordError
            // 
            this.pictureBox_passwordError.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_passwordError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_passwordError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_passwordError.Image")));
            this.pictureBox_passwordError.Location = new System.Drawing.Point(220, 322);
            this.pictureBox_passwordError.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_passwordError.Name = "pictureBox_passwordError";
            this.pictureBox_passwordError.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_passwordError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_passwordError.TabIndex = 20;
            this.pictureBox_passwordError.TabStop = false;
            this.pictureBox_passwordError.Visible = false;
            // 
            // button_showPass_pass
            // 
            this.button_showPass_pass.BackColor = System.Drawing.Color.Purple;
            this.button_showPass_pass.BackgroundImage = global::Trentmessenger.Properties.Resources.key_2028593;
            this.button_showPass_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_showPass_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showPass_pass.Enabled = false;
            this.button_showPass_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showPass_pass.Location = new System.Drawing.Point(196, 322);
            this.button_showPass_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_showPass_pass.Name = "button_showPass_pass";
            this.button_showPass_pass.Size = new System.Drawing.Size(22, 23);
            this.button_showPass_pass.TabIndex = 21;
            this.button_showPass_pass.UseVisualStyleBackColor = false;
            this.button_showPass_pass.Click += new System.EventHandler(this.ShowPassButton_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trentmessenger.Properties.Resources.background_159244_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.button_showPass_pass);
            this.Controls.Add(this.pictureBox_passwordError);
            this.Controls.Add(this.label_password_LB);
            this.Controls.Add(this.textBox_password_pass);
            this.Controls.Add(this.pictureBox_reponseError);
            this.Controls.Add(this.pictureBox_aboutError);
            this.Controls.Add(this.pictureBoxNumberError);
            this.Controls.Add(this.pictureBoxNomError);
            this.Controls.Add(this.labelAnswerS);
            this.Controls.Add(this.labelQuestionS);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxResponseS);
            this.Controls.Add(this.comboBoxQuestionS);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNumber);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNomError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumberError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_aboutError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reponseError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passwordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxQuestionS;
        private System.Windows.Forms.TextBox textBoxResponseS;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelQuestionS;
        private System.Windows.Forms.Label labelAnswerS;
        private System.Windows.Forms.PictureBox pictureBoxNomError;
        private System.Windows.Forms.PictureBox pictureBoxNumberError;
        private System.Windows.Forms.PictureBox pictureBox_aboutError;
        private System.Windows.Forms.PictureBox pictureBox_reponseError;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Label label_password_LB;
        private System.Windows.Forms.TextBox textBox_password_pass;
        private System.Windows.Forms.PictureBox pictureBox_passwordError;
        private System.Windows.Forms.Button button_showPass_pass;
    }
}