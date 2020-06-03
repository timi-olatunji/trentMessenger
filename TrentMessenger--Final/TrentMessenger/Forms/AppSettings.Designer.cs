namespace Trentmessenger.Forms
{
    partial class AppSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonResetImage = new System.Windows.Forms.Button();
            this.panelBackgroundColor = new System.Windows.Forms.Panel();
            this.labelBackgroundColor = new System.Windows.Forms.Label();
            this.pictureBoxBackgImage = new System.Windows.Forms.PictureBox();
            this.labelBackgroundImage = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelTextAccountColor = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.panel_backgContactColor = new System.Windows.Forms.Panel();
            this.panel_backgAccountColor = new System.Windows.Forms.Panel();
            this.panelTextContactColor = new System.Windows.Forms.Panel();
            this.panelTextAccountColor = new System.Windows.Forms.Panel();
            this.label_backgContactColor = new System.Windows.Forms.Label();
            this.label_backgAccountColor = new System.Windows.Forms.Label();
            this.labelTextContactColor = new System.Windows.Forms.Label();
            this.labelTextColor = new System.Windows.Forms.Label();
            this.buttn_reset = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgImage)).BeginInit();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Purple;
            this.panelBackground.Controls.Add(this.buttonResetImage);
            this.panelBackground.Controls.Add(this.panelBackgroundColor);
            this.panelBackground.Controls.Add(this.labelBackgroundColor);
            this.panelBackground.Controls.Add(this.pictureBoxBackgImage);
            this.panelBackground.Controls.Add(this.labelBackgroundImage);
            this.panelBackground.Location = new System.Drawing.Point(18, 100);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBackground.Name = "panel_background";
            this.panelBackground.Size = new System.Drawing.Size(440, 258);
            this.panelBackground.TabIndex = 0;
            // 
            // button_resetImage
            // 
            this.buttonResetImage.BackgroundImage = global::Trentmessenger.Properties.Resources.icon_remove;
            this.buttonResetImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonResetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetImage.FlatAppearance.BorderSize = 0;
            this.buttonResetImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonResetImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetImage.Location = new System.Drawing.Point(368, 109);
            this.buttonResetImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonResetImage.Name = "button_resetImage";
            this.buttonResetImage.Size = new System.Drawing.Size(48, 48);
            this.buttonResetImage.TabIndex = 5;
            this.buttonResetImage.UseVisualStyleBackColor = true;
            this.buttonResetImage.Click += new System.EventHandler(this.ResetImageButtton_Click);
            // 
            // panel_backgroundColor
            // 
            this.panelBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBackgroundColor.Location = new System.Drawing.Point(258, 180);
            this.panelBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBackgroundColor.Name = "panel_backgroundColor";
            this.panelBackgroundColor.Size = new System.Drawing.Size(158, 56);
            this.panelBackgroundColor.TabIndex = 4;
            this.panelBackgroundColor.Click += new System.EventHandler(this.BackgroundColorPanel_Click);
            // 
            // label_backgroundColor
            // 
            this.labelBackgroundColor.AutoSize = true;
            this.labelBackgroundColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackgroundColor.ForeColor = System.Drawing.Color.White;
            this.labelBackgroundColor.Location = new System.Drawing.Point(14, 200);
            this.labelBackgroundColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackgroundColor.Name = "label_backgroundColor";
            this.labelBackgroundColor.Size = new System.Drawing.Size(153, 20);
            this.labelBackgroundColor.TabIndex = 2;
            this.labelBackgroundColor.Text = "Background Color";
            // 
            // pictureBox_bgImage
            // 
            this.pictureBoxBackgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBackgImage.Location = new System.Drawing.Point(258, 18);
            this.pictureBoxBackgImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBackgImage.Name = "pictureBox_bgImage";
            this.pictureBoxBackgImage.Size = new System.Drawing.Size(158, 147);
            this.pictureBoxBackgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackgImage.TabIndex = 1;
            this.pictureBoxBackgImage.TabStop = false;
            this.pictureBoxBackgImage.Click += new System.EventHandler(this.PictureBox_BackgroundImage_Click);
            // 
            // label_backgroundImage
            // 
            this.labelBackgroundImage.AutoSize = true;
            this.labelBackgroundImage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackgroundImage.ForeColor = System.Drawing.Color.White;
            this.labelBackgroundImage.Location = new System.Drawing.Point(14, 23);
            this.labelBackgroundImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackgroundImage.Name = "label_backgroundImage";
            this.labelBackgroundImage.Size = new System.Drawing.Size(153, 20);
            this.labelBackgroundImage.TabIndex = 0;
            this.labelBackgroundImage.Text = "Background Image";
            // 
            // label_background
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.BackColor = System.Drawing.Color.White;
            this.labelBackground.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackground.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelBackground.Location = new System.Drawing.Point(30, 82);
            this.labelBackground.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBackground.Name = "label_background";
            this.labelBackground.Size = new System.Drawing.Size(95, 29);
            this.labelBackground.TabIndex = 1;
            this.labelBackground.Text = "Context";
            // 
            // label_textAccountColor
            // 
            this.labelTextAccountColor.AutoSize = true;
            this.labelTextAccountColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextAccountColor.ForeColor = System.Drawing.Color.White;
            this.labelTextAccountColor.Location = new System.Drawing.Point(14, 31);
            this.labelTextAccountColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextAccountColor.Name = "label_textAccountColor";
            this.labelTextAccountColor.Size = new System.Drawing.Size(126, 20);
            this.labelTextAccountColor.TabIndex = 0;
            this.labelTextAccountColor.Text = "My Text Color";
            // 
            // panel1
            // 
            this.panel_1.BackColor = System.Drawing.Color.Purple;
            this.panel_1.Controls.Add(this.panel_backgContactColor);
            this.panel_1.Controls.Add(this.panel_backgAccountColor);
            this.panel_1.Controls.Add(this.panelTextContactColor);
            this.panel_1.Controls.Add(this.panelTextAccountColor);
            this.panel_1.Controls.Add(this.label_backgContactColor);
            this.panel_1.Controls.Add(this.label_backgAccountColor);
            this.panel_1.Controls.Add(this.labelTextContactColor);
            this.panel_1.Controls.Add(this.labelTextAccountColor);
            this.panel_1.Location = new System.Drawing.Point(18, 392);
            this.panel_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_1.Name = "panel1";
            this.panel_1.Size = new System.Drawing.Size(440, 242);
            this.panel_1.TabIndex = 4;
            // 
            // panel_bgContactColor
            // 
            this.panel_backgContactColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_backgContactColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_backgContactColor.Location = new System.Drawing.Point(348, 180);
            this.panel_backgContactColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_backgContactColor.Name = "panel_bgContactColor";
            this.panel_backgContactColor.Size = new System.Drawing.Size(68, 39);
            this.panel_backgContactColor.TabIndex = 6;
            this.panel_backgContactColor.Click += new System.EventHandler(this.backgContactColorPanel_Click);
            // 
            // panel_bgAccountColor
            // 
            this.panel_backgAccountColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_backgAccountColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_backgAccountColor.Location = new System.Drawing.Point(348, 126);
            this.panel_backgAccountColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_backgAccountColor.Name = "panel_bgAccountColor";
            this.panel_backgAccountColor.Size = new System.Drawing.Size(68, 39);
            this.panel_backgAccountColor.TabIndex = 6;
            this.panel_backgAccountColor.Click += new System.EventHandler(this.backgAccountColorPanel_Click);
            // 
            // panel_textContactColor
            // 
            this.panelTextContactColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextContactColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTextContactColor.Location = new System.Drawing.Point(348, 72);
            this.panelTextContactColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTextContactColor.Name = "panel_textContactColor";
            this.panelTextContactColor.Size = new System.Drawing.Size(68, 39);
            this.panelTextContactColor.TabIndex = 6;
            this.panelTextContactColor.Click += new System.EventHandler(this.TextContactColorPanel_Click);
            // 
            // panel_textAccountColor
            // 
            this.panelTextAccountColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextAccountColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTextAccountColor.Location = new System.Drawing.Point(348, 18);
            this.panelTextAccountColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTextAccountColor.Name = "panel_textAccountColor";
            this.panelTextAccountColor.Size = new System.Drawing.Size(68, 39);
            this.panelTextAccountColor.TabIndex = 5;
            this.panelTextAccountColor.Click += new System.EventHandler(this.TextAccountColorPanel_Click);
            // 
            // label_bgContactColor
            // 
            this.label_backgContactColor.AutoSize = true;
            this.label_backgContactColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backgContactColor.ForeColor = System.Drawing.Color.White;
            this.label_backgContactColor.Location = new System.Drawing.Point(14, 191);
            this.label_backgContactColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_backgContactColor.Name = "label_bgContactColor";
            this.label_backgContactColor.Size = new System.Drawing.Size(261, 20);
            this.label_backgContactColor.TabIndex = 3;
            this.label_backgContactColor.Text = "My contact chat bubble color";
            // 
            // label_bgAccountColor
            // 
            this.label_backgAccountColor.AutoSize = true;
            this.label_backgAccountColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_backgAccountColor.ForeColor = System.Drawing.Color.White;
            this.label_backgAccountColor.Location = new System.Drawing.Point(14, 138);
            this.label_backgAccountColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_backgAccountColor.Name = "label_bgAccountColor";
            this.label_backgAccountColor.Size = new System.Drawing.Size(189, 20);
            this.label_backgAccountColor.TabIndex = 2;
            this.label_backgAccountColor.Text = "My chat Bubble Color";
            // 
            // label_textContactColor
            // 
            this.labelTextContactColor.AutoSize = true;
            this.labelTextContactColor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextContactColor.ForeColor = System.Drawing.Color.White;
            this.labelTextContactColor.Location = new System.Drawing.Point(14, 85);
            this.labelTextContactColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextContactColor.Name = "label_textContactColor";
            this.labelTextContactColor.Size = new System.Drawing.Size(171, 20);
            this.labelTextContactColor.TabIndex = 1;
            this.labelTextContactColor.Text = "Contact Text Color";
            // 
            // label_textColor
            // 
            this.labelTextColor.AutoSize = true;
            this.labelTextColor.BackColor = System.Drawing.Color.White;
            this.labelTextColor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextColor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTextColor.Location = new System.Drawing.Point(30, 371);
            this.labelTextColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextColor.Name = "label_textColor";
            this.labelTextColor.Size = new System.Drawing.Size(57, 29);
            this.labelTextColor.TabIndex = 5;
            this.labelTextColor.Text = "Text";
            // 
            // button_reset
            // 
            this.buttn_reset.BackColor = System.Drawing.Color.Transparent;
            this.buttn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttn_reset.ForeColor = System.Drawing.Color.White;
            this.buttn_reset.Location = new System.Drawing.Point(320, 20);
            this.buttn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttn_reset.Name = "button_reset";
            this.buttn_reset.Size = new System.Drawing.Size(138, 57);
            this.buttn_reset.TabIndex = 6;
            this.buttn_reset.Text = "Reset";
            this.buttn_reset.UseVisualStyleBackColor = false;
            this.buttn_reset.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // appSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trentmessenger.Properties.Resources.background_159244_12801;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.buttn_reset);
            this.Controls.Add(this.labelTextColor);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.labelBackground);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "appSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppSettingsForm_FormClosed);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgImage)).EndInit();
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelBackgroundImage;
        private System.Windows.Forms.PictureBox pictureBoxBackgImage;
        private System.Windows.Forms.Label labelBackgroundColor;
        private System.Windows.Forms.Label labelTextAccountColor;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label labelTextColor;
        private System.Windows.Forms.Label label_backgContactColor;
        private System.Windows.Forms.Label label_backgAccountColor;
        private System.Windows.Forms.Label labelTextContactColor;
        private System.Windows.Forms.Panel panelBackgroundColor;
        private System.Windows.Forms.Panel panelTextAccountColor;
        private System.Windows.Forms.Panel panel_backgContactColor;
        private System.Windows.Forms.Panel panel_backgAccountColor;
        private System.Windows.Forms.Panel panelTextContactColor;
        private System.Windows.Forms.Button buttonResetImage;
        private System.Windows.Forms.Button buttn_reset;
    }
}