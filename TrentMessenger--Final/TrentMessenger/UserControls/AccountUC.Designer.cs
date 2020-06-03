namespace Trentmessenger.UserControls
{
    partial class AccountUC
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
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.SuspendLayout();
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
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_about.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_about.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_about.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_about.Location = new System.Drawing.Point(128, 6);
            this.richTextBox_about.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.ReadOnly = true;
            this.richTextBox_about.Size = new System.Drawing.Size(186, 94);
            this.richTextBox_about.TabIndex = 16;
            this.richTextBox_about.Text = "About text.";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Purple;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(326, 6);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 49);
            this.button_add.TabIndex = 17;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.richTextBox_about);
            this.Controls.Add(this.pictureBox_photo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(444, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.Button button_add;
    }
}
