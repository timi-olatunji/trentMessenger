namespace Trentmessenger.Forms
{
    partial class Pairchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pairchat));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.ClockUC1 = new Trentmessenger.ucClock();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelNoMessages = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.button_emoticonList = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxForchatBox = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Purple;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.pictureBoxPhoto);
            this.panelHeader.Controls.Add(this.labelNumber);
            this.panelHeader.Controls.Add(this.labelUsername);
            this.panelHeader.Controls.Add(this.ClockUC1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panel_header";
            this.panelHeader.Size = new System.Drawing.Size(476, 74);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox_photo
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPhoto.Name = "pictureBox_photo";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(68, 66);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 3;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // label_number
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.White;
            this.labelNumber.Location = new System.Drawing.Point(75, 48);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "label_number";
            this.labelNumber.Size = new System.Drawing.Size(100, 21);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "07xxxxxxxx";
            // 
            // label_username
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.White;
            this.labelUsername.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Purple;
            this.labelUsername.Location = new System.Drawing.Point(78, 6);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "label_username";
            this.labelUsername.Size = new System.Drawing.Size(149, 35);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // ucClock1
            // 
            this.ClockUC1.BackColor = System.Drawing.Color.Transparent;
            this.ClockUC1.Location = new System.Drawing.Point(285, -8);
            this.ClockUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ClockUC1.Name = "ucClock1";
            this.ClockUC1.Size = new System.Drawing.Size(184, 37);
            this.ClockUC1.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.Controls.Add(this.labelNoMessages);
            this.panelMain.Location = new System.Drawing.Point(0, 72);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panel_main";
            this.panelMain.Size = new System.Drawing.Size(476, 517);
            this.panelMain.TabIndex = 1;
            this.panelMain.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainPanel_Scroll);
            // 
            // label_noMessages
            // 
            this.labelNoMessages.AutoSize = true;
            this.labelNoMessages.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoMessages.Location = new System.Drawing.Point(59, 215);
            this.labelNoMessages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoMessages.Name = "label_noMessages";
            this.labelNoMessages.Size = new System.Drawing.Size(333, 24);
            this.labelNoMessages.TabIndex = 2;
            this.labelNoMessages.Text = "You have no conversations here yet.\r\n";
            this.labelNoMessages.Visible = false;
            // 
            // panel_footer
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Purple;
            this.panelFooter.Controls.Add(this.button_emoticonList);
            this.panelFooter.Controls.Add(this.buttonSend);
            this.panelFooter.Controls.Add(this.textBoxForchatBox);
            this.panelFooter.Location = new System.Drawing.Point(0, 591);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFooter.Name = "panel_footer";
            this.panelFooter.Size = new System.Drawing.Size(476, 62);
            this.panelFooter.TabIndex = 1;
            // 
            // button_emojiList
            // 
            this.button_emoticonList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_emoticonList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_emoticonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_emoticonList.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_emoticonList.Location = new System.Drawing.Point(375, 12);
            this.button_emoticonList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_emoticonList.Name = "button_emojiList";
            this.button_emoticonList.Size = new System.Drawing.Size(45, 40);
            this.button_emoticonList.TabIndex = 1;
            this.button_emoticonList.Text = "😀";
            this.button_emoticonList.UseVisualStyleBackColor = true;
            this.button_emoticonList.Click += new System.EventHandler(this.EmoticonListButton_Click);
            // 
            // button_send
            // 
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Image = global::Trentmessenger.Properties.Resources.icon_apply;
            this.buttonSend.Location = new System.Drawing.Point(424, 12);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSend.Name = "button_send";
            this.buttonSend.Size = new System.Drawing.Size(45, 40);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_chatBox
            // 
            this.textBoxForchatBox.BackColor = System.Drawing.Color.Plum;
            this.textBoxForchatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxForchatBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForchatBox.ForeColor = System.Drawing.Color.White;
            this.textBoxForchatBox.Location = new System.Drawing.Point(8, 12);
            this.textBoxForchatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxForchatBox.Name = "textBox_chatBox";
            this.textBoxForchatBox.Size = new System.Drawing.Size(363, 37);
            this.textBoxForchatBox.TabIndex = 0;
            this.textBoxForchatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxChatBox_OnKeyPress);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation with x";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Shown += new System.EventHandler(this.ChatShown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TextBox textBoxForchatBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelUsername;
        private ucClock ClockUC1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label labelNoMessages;
        private System.Windows.Forms.Button button_emoticonList;
    }
}