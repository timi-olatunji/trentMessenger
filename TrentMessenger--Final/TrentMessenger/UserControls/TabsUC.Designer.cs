namespace Trentmessenger
{
    partial class ucTabs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_chats_btn = new System.Windows.Forms.Button();
            this.button_contacts_btn = new System.Windows.Forms.Button();
            this.panelSelectedPanel = new System.Windows.Forms.Panel();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMain1 = new System.Windows.Forms.Panel();
            this.chatsPanel = new System.Windows.Forms.Panel();
            this.noMessagesLabel = new System.Windows.Forms.Label();
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.noContactsLabel = new System.Windows.Forms.Label();
            this.panelMain1.SuspendLayout();
            this.chatsPanel.SuspendLayout();
            this.contactsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_chats_btn
            // 
            this.button_chats_btn.BackColor = System.Drawing.Color.Purple;
            this.button_chats_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_chats_btn.FlatAppearance.BorderSize = 0;
            this.button_chats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chats_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chats_btn.ForeColor = System.Drawing.Color.White;
            this.button_chats_btn.Location = new System.Drawing.Point(0, 0);
            this.button_chats_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_chats_btn.Name = "button_chats_btn";
            this.button_chats_btn.Size = new System.Drawing.Size(237, 71);
            this.button_chats_btn.TabIndex = 0;
            this.button_chats_btn.Text = "Chats";
            this.button_chats_btn.UseVisualStyleBackColor = false;
            this.button_chats_btn.Click += new System.EventHandler(this.ChatsBtn_Click);
            // 
            // button_contacts_btn
            // 
            this.button_contacts_btn.BackColor = System.Drawing.Color.Purple;
            this.button_contacts_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_contacts_btn.FlatAppearance.BorderSize = 0;
            this.button_contacts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contacts_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contacts_btn.ForeColor = System.Drawing.Color.White;
            this.button_contacts_btn.Location = new System.Drawing.Point(237, 0);
            this.button_contacts_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_contacts_btn.Name = "button_contacts_btn";
            this.button_contacts_btn.Size = new System.Drawing.Size(238, 71);
            this.button_contacts_btn.TabIndex = 1;
            this.button_contacts_btn.Text = "Contacts";
            this.button_contacts_btn.UseVisualStyleBackColor = false;
            this.button_contacts_btn.Click += new System.EventHandler(this.ButtonTab_Click);
            // 
            // panelSelectedPanel
            // 
            this.panelSelectedPanel.BackColor = System.Drawing.Color.White;
            this.panelSelectedPanel.Location = new System.Drawing.Point(3, 66);
            this.panelSelectedPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSelectedPanel.Name = "panelSelectedPanel";
            this.panelSelectedPanel.Size = new System.Drawing.Size(238, 6);
            this.panelSelectedPanel.TabIndex = 0;
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.TimerAnimation_Tick);
            // 
            // panelMain1
            // 
            this.panelMain1.BackColor = System.Drawing.Color.Transparent;
            this.panelMain1.Controls.Add(this.chatsPanel);
            this.panelMain1.Controls.Add(this.contactsPanel);
            this.panelMain1.Location = new System.Drawing.Point(0, 71);
            this.panelMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain1.Name = "panelMain1";
            this.panelMain1.Size = new System.Drawing.Size(951, 488);
            this.panelMain1.TabIndex = 2;
            // 
            // chatsPanel
            // 
            this.chatsPanel.AutoScroll = true;
            this.chatsPanel.BackColor = System.Drawing.Color.Transparent;
            this.chatsPanel.Controls.Add(this.noMessagesLabel);
            this.chatsPanel.Location = new System.Drawing.Point(0, 0);
            this.chatsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chatsPanel.Name = "chatsPanel";
            this.chatsPanel.Size = new System.Drawing.Size(476, 489);
            this.chatsPanel.TabIndex = 1;
            // 
            // noMessagesLabel
            // 
            this.noMessagesLabel.AutoSize = true;
            this.noMessagesLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMessagesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.noMessagesLabel.Location = new System.Drawing.Point(70, 49);
            this.noMessagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noMessagesLabel.Name = "noMessagesLabel";
            this.noMessagesLabel.Size = new System.Drawing.Size(327, 24);
            this.noMessagesLabel.TabIndex = 1;
            this.noMessagesLabel.Text = "You have to active discussions here";
            this.noMessagesLabel.Visible = false;
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.BackColor = System.Drawing.Color.Transparent;
            this.contactsPanel.Controls.Add(this.noContactsLabel);
            this.contactsPanel.Location = new System.Drawing.Point(476, 0);
            this.contactsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(476, 489);
            this.contactsPanel.TabIndex = 0;
            // 
            // noContactsLabel
            // 
            this.noContactsLabel.AutoSize = true;
            this.noContactsLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noContactsLabel.Location = new System.Drawing.Point(124, 49);
            this.noContactsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noContactsLabel.Name = "noContactsLabel";
            this.noContactsLabel.Size = new System.Drawing.Size(233, 24);
            this.noContactsLabel.TabIndex = 0;
            this.noContactsLabel.Text = "You have no Contacts yet";
            this.noContactsLabel.Visible = false;
            // 
            // ucTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMain1);
            this.Controls.Add(this.panelSelectedPanel);
            this.Controls.Add(this.button_contacts_btn);
            this.Controls.Add(this.button_chats_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucTabs";
            this.Size = new System.Drawing.Size(476, 558);
            this.panelMain1.ResumeLayout(false);
            this.chatsPanel.ResumeLayout(false);
            this.chatsPanel.PerformLayout();
            this.contactsPanel.ResumeLayout(false);
            this.contactsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_chats_btn;
        private System.Windows.Forms.Button button_contacts_btn;
        private System.Windows.Forms.Panel panelSelectedPanel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Panel panelMain1;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.Panel chatsPanel;
        private System.Windows.Forms.Label noContactsLabel;
        private System.Windows.Forms.Label noMessagesLabel;
    }
}
