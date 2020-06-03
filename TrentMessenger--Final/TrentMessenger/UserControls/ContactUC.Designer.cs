namespace Trentmessenger.UserControls
{
    partial class ContactUC
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
            this.labelLastSeen = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox_photoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label_lastSeen
            // 
            this.labelLastSeen.AutoSize = true;
            this.labelLastSeen.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastSeen.ForeColor = System.Drawing.Color.Teal;
            this.labelLastSeen.Location = new System.Drawing.Point(384, 6);
            this.labelLastSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastSeen.Name = "label_lastSeen";
            this.labelLastSeen.Size = new System.Drawing.Size(81, 20);
            this.labelLastSeen.TabIndex = 11;
            this.labelLastSeen.Text = "LastSeen";
            this.labelLastSeen.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            this.labelLastSeen.MouseEnter += new System.EventHandler(this.LastSeenLB_MouseEnter);
            this.labelLastSeen.MouseLeave += new System.EventHandler(this.LastSeenLabel_MouseLeave);
            // 
            // label_number
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.Purple;
            this.labelNumber.Location = new System.Drawing.Point(123, 46);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber.Name = "label_number";
            this.labelNumber.Size = new System.Drawing.Size(63, 20);
            this.labelNumber.TabIndex = 10;
            this.labelNumber.Text = "Number";
            this.labelNumber.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            this.labelNumber.MouseEnter += new System.EventHandler(this.LastSeenLB_MouseEnter);
            this.labelNumber.MouseLeave += new System.EventHandler(this.LastSeenLabel_MouseLeave);
            // 
            // label_username
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Purple;
            this.labelUsername.Location = new System.Drawing.Point(123, 6);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "label_username";
            this.labelUsername.Size = new System.Drawing.Size(81, 20);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            this.labelUsername.MouseEnter += new System.EventHandler(this.LastSeenLB_MouseEnter);
            this.labelUsername.MouseLeave += new System.EventHandler(this.LastSeenLabel_MouseLeave);
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photoPB.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_photoPB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_photoPB.Name = "pictureBox_photo";
            this.pictureBox_photoPB.Size = new System.Drawing.Size(112, 95);
            this.pictureBox_photoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photoPB.TabIndex = 8;
            this.pictureBox_photoPB.TabStop = false;
            this.pictureBox_photoPB.Click += new System.EventHandler(this.PhotoPictureBox_Click);
            this.pictureBox_photoPB.MouseEnter += new System.EventHandler(this.LastSeenLB_MouseEnter);
            this.pictureBox_photoPB.MouseLeave += new System.EventHandler(this.LastSeenLabel_MouseLeave);
            // 
            // ContactUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelLastSeen);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox_photoPB);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContactUC";
            this.Size = new System.Drawing.Size(470, 108);
            this.Click += new System.EventHandler(this.ContactUC_Click);
            this.MouseEnter += new System.EventHandler(this.AccountUC_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.AccountUC_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastSeen;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBox_photoPB;
    }
}
