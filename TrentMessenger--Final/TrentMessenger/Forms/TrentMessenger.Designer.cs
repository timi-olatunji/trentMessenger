namespace Trentmessenger
{
    partial class ChatHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatHome));
            this.panel_header_PH = new System.Windows.Forms.Panel();
            this.button_settings_Btn = new System.Windows.Forms.Button();
            this.panel_searchBar_PH = new System.Windows.Forms.Panel();
            this.richTextBox_searchBar_RTB = new System.Windows.Forms.RichTextBox();
            this.TabsUC1 = new Trentmessenger.ucTabs();
            this.panel_header_PH.SuspendLayout();
            this.panel_searchBar_PH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header_PH
            // 
            this.panel_header_PH.BackColor = System.Drawing.Color.Violet;
            this.panel_header_PH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header_PH.Controls.Add(this.button_settings_Btn);
            this.panel_header_PH.Controls.Add(this.panel_searchBar_PH);
            this.panel_header_PH.Location = new System.Drawing.Point(0, 0);
            this.panel_header_PH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_header_PH.Name = "panel_header_PH";
            this.panel_header_PH.Size = new System.Drawing.Size(476, 95);
            this.panel_header_PH.TabIndex = 0;
            // 
            // button_settings_Btn
            // 
            this.button_settings_Btn.BackgroundImage = global::Trentmessenger.Properties.Resources.icon_settings_hoverOff;
            this.button_settings_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_settings_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings_Btn.FlatAppearance.BorderSize = 0;
            this.button_settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings_Btn.Location = new System.Drawing.Point(418, 14);
            this.button_settings_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_settings_Btn.Name = "button_settings_Btn";
            this.button_settings_Btn.Size = new System.Drawing.Size(51, 62);
            this.button_settings_Btn.TabIndex = 1;
            this.button_settings_Btn.UseVisualStyleBackColor = true;
            this.button_settings_Btn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // panel_searchBar_PH
            // 
            this.panel_searchBar_PH.BackColor = System.Drawing.Color.Azure;
            this.panel_searchBar_PH.Controls.Add(this.richTextBox_searchBar_RTB);
            this.panel_searchBar_PH.Location = new System.Drawing.Point(12, 14);
            this.panel_searchBar_PH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_searchBar_PH.Name = "panel_searchBar_PH";
            this.panel_searchBar_PH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_searchBar_PH.Size = new System.Drawing.Size(398, 62);
            this.panel_searchBar_PH.TabIndex = 0;
            // 
            // richTextBox_searchBar_RTB
            // 
            this.richTextBox_searchBar_RTB.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox_searchBar_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_searchBar_RTB.BulletIndent = 5;
            this.richTextBox_searchBar_RTB.DetectUrls = false;
            this.richTextBox_searchBar_RTB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_searchBar_RTB.ForeColor = System.Drawing.Color.Plum;
            this.richTextBox_searchBar_RTB.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_searchBar_RTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_searchBar_RTB.Multiline = false;
            this.richTextBox_searchBar_RTB.Name = "richTextBox_searchBar_RTB";
            this.richTextBox_searchBar_RTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_searchBar_RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_searchBar_RTB.Size = new System.Drawing.Size(372, 52);
            this.richTextBox_searchBar_RTB.TabIndex = 1;
            this.richTextBox_searchBar_RTB.Text = "Search";
            this.richTextBox_searchBar_RTB.Click += new System.EventHandler(this.SearchBarRichTextBox_Click_1);
            this.richTextBox_searchBar_RTB.Leave += new System.EventHandler(this.SearchBarRichText_Leave);
            // 
            // TabsUC1
            // 
            this.TabsUC1.BackColor = System.Drawing.Color.Transparent;
            this.TabsUC1.Location = new System.Drawing.Point(0, 94);
            this.TabsUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TabsUC1.Name = "TabsUC1";
            this.TabsUC1.Size = new System.Drawing.Size(476, 558);
            this.TabsUC1.TabIndex = 1;
            // 
            // ChatHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.TabsUC1);
            this.Controls.Add(this.panel_header_PH);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ChatHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrentMessenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrentMessenger_FormClosing);
            this.panel_header_PH.ResumeLayout(false);
            this.panel_searchBar_PH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header_PH;
        private System.Windows.Forms.Button button_settings_Btn;
        private System.Windows.Forms.RichTextBox richTextBox_searchBar_RTB;
        private System.Windows.Forms.Panel panel_searchBar_PH;
        private ucTabs TabsUC1;
    }
}

