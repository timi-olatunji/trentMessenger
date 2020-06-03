namespace Trentmessenger.UserControls
{
    partial class ChatUC
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
            this.label_messageDate = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.label_message = new System.Windows.Forms.Label();
            this.button_messageCount = new System.Windows.Forms.Button();
            this.label_spokenBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_messageDate
            // 
            this.label_messageDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_messageDate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messageDate.ForeColor = System.Drawing.Color.Purple;
            this.label_messageDate.Location = new System.Drawing.Point(388, 0);
            this.label_messageDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.label_messageDate.Name = "label_messageDate";
            this.label_messageDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label_messageDate.Size = new System.Drawing.Size(82, 108);
            this.label_messageDate.TabIndex = 15;
            this.label_messageDate.Text = "LastSeen";
            this.label_messageDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_messageDate.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.label_messageDate.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.label_messageDate.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.ForeColor = System.Drawing.Color.Teal;
            this.label_number.Location = new System.Drawing.Point(122, 6);
            this.label_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(81, 20);
            this.label_number.TabIndex = 13;
            this.label_number.Text = "Username";
            this.label_number.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.label_number.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.label_number.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.Location = new System.Drawing.Point(4, 6);
            this.pictureBox_photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(112, 95);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 12;
            this.pictureBox_photo.TabStop = false;
            this.pictureBox_photo.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.pictureBox_photo.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.pictureBox_photo.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ForeColor = System.Drawing.Color.Teal;
            this.label_message.Location = new System.Drawing.Point(122, 75);
            this.label_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(135, 20);
            this.label_message.TabIndex = 16;
            this.label_message.Text = "LastSeenOnline";
            this.label_message.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.label_message.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.label_message.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // button_messageCount
            // 
            this.button_messageCount.Enabled = false;
            this.button_messageCount.FlatAppearance.BorderSize = 0;
            this.button_messageCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_messageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_messageCount.Location = new System.Drawing.Point(430, 66);
            this.button_messageCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_messageCount.Name = "button_messageCount";
            this.button_messageCount.Size = new System.Drawing.Size(34, 35);
            this.button_messageCount.TabIndex = 17;
            this.button_messageCount.Text = "0";
            this.button_messageCount.UseVisualStyleBackColor = true;
            this.button_messageCount.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.button_messageCount.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.button_messageCount.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // label_spokenBy
            // 
            this.label_spokenBy.AutoSize = true;
            this.label_spokenBy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spokenBy.ForeColor = System.Drawing.Color.DimGray;
            this.label_spokenBy.Location = new System.Drawing.Point(122, 55);
            this.label_spokenBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_spokenBy.Name = "label_spokenBy";
            this.label_spokenBy.Size = new System.Drawing.Size(27, 20);
            this.label_spokenBy.TabIndex = 18;
            this.label_spokenBy.Text = "x:";
            this.label_spokenBy.Click += new System.EventHandler(this.Spoken_By_Label_Click);
            this.label_spokenBy.MouseEnter += new System.EventHandler(this.Spoken_By_Label_MouseEnter);
            this.label_spokenBy.MouseLeave += new System.EventHandler(this.Spoken_By_Label_MouseLeave);
            // 
            // ChatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label_spokenBy);
            this.Controls.Add(this.button_messageCount);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_messageDate);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.pictureBox_photo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatUC";
            this.Size = new System.Drawing.Size(470, 108);
            this.Click += new System.EventHandler(this.ChatUC_Click);
            this.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_messageDate;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_messageCount;
        private System.Windows.Forms.Label label_spokenBy;
    }
}
