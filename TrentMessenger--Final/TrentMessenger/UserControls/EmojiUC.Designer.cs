namespace Trentmessenger.UserControls
{
    partial class EmojiUC
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tool_TipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Purple;
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Location = new System.Drawing.Point(4, 5);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "panel_main";
            this.mainPanel.Size = new System.Drawing.Size(290, 206);
            this.mainPanel.TabIndex = 0;
            // 
            // label_title
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(27, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "label_title";
            this.titleLabel.Size = new System.Drawing.Size(109, 23);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Emoticons\r\n";
            // 
            // toolTip_info
            // 
            this.tool_TipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tool_TipInfo.ToolTipTitle = "Emoji";
            // 
            // EmojiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmojiUC";
            this.Size = new System.Drawing.Size(298, 215);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ToolTip tool_TipInfo;
    }
}
