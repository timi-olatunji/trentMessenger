namespace Trentmessenger.Forms
{
    partial class ContactUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUpdate));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_search_Bar = new System.Windows.Forms.Panel();
            this.richTextBoxSearchBar = new System.Windows.Forms.RichTextBox();
            this.panelMainPN = new System.Windows.Forms.Panel();
            this.label_result_LB = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_search_Bar.SuspendLayout();
            this.panelMainPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Purple;
            this.panel_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_header.Controls.Add(this.panel_search_Bar);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(476, 95);
            this.panel_header.TabIndex = 1;
            // 
            // panel_searchBar
            // 
            this.panel_search_Bar.BackColor = System.Drawing.Color.Plum;
            this.panel_search_Bar.Controls.Add(this.richTextBoxSearchBar);
            this.panel_search_Bar.Location = new System.Drawing.Point(36, 15);
            this.panel_search_Bar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_search_Bar.Name = "panel_searchBar";
            this.panel_search_Bar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_search_Bar.Size = new System.Drawing.Size(405, 62);
            this.panel_search_Bar.TabIndex = 0;
            // 
            // richTextBox_searchBar
            // 
            this.richTextBoxSearchBar.BackColor = System.Drawing.Color.Plum;
            this.richTextBoxSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSearchBar.BulletIndent = 5;
            this.richTextBoxSearchBar.DetectUrls = false;
            this.richTextBoxSearchBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSearchBar.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxSearchBar.Location = new System.Drawing.Point(25, 10);
            this.richTextBoxSearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxSearchBar.Multiline = false;
            this.richTextBoxSearchBar.Name = "richTextBox_searchBar";
            this.richTextBoxSearchBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxSearchBar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxSearchBar.Size = new System.Drawing.Size(372, 52);
            this.richTextBoxSearchBar.TabIndex = 1;
            this.richTextBoxSearchBar.Text = "Search";
            this.richTextBoxSearchBar.Click += new System.EventHandler(this.RichTextBoxSearchBar_Click);
            this.richTextBoxSearchBar.TextChanged += new System.EventHandler(this.RichTextBoxSearchBar_TextChanged);
            this.richTextBoxSearchBar.Leave += new System.EventHandler(this.RichTextBox_searchBar_Leave);
            // 
            // panel_main
            // 
            this.panelMainPN.AutoScroll = true;
            this.panelMainPN.Controls.Add(this.label_result_LB);
            this.panelMainPN.Location = new System.Drawing.Point(0, 97);
            this.panelMainPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMainPN.Name = "panel_main";
            this.panelMainPN.Size = new System.Drawing.Size(476, 554);
            this.panelMainPN.TabIndex = 2;
            // 
            // label_result
            // 
            this.label_result_LB.AutoSize = true;
            this.label_result_LB.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result_LB.Location = new System.Drawing.Point(63, 218);
            this.label_result_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result_LB.Name = "label_result";
            this.label_result_LB.Size = new System.Drawing.Size(286, 24);
            this.label_result_LB.TabIndex = 2;
            this.label_result_LB.Text = "There are no matching Results";
            this.label_result_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_result_LB.Visible = false;
            // 
            // AddContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.panelMainPN);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Contacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddContactForm_FormClosed);
            this.panel_header.ResumeLayout(false);
            this.panel_search_Bar.ResumeLayout(false);
            this.panelMainPN.ResumeLayout(false);
            this.panelMainPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_search_Bar;
        private System.Windows.Forms.RichTextBox richTextBoxSearchBar;
        private System.Windows.Forms.Panel panelMainPN;
        private System.Windows.Forms.Label label_result_LB;
    }
}