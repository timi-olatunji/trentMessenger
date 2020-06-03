using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Trentmessenger.Classes;
using System.IO;
namespace Trentmessenger.Forms
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();

            pictureBoxBackgImage.Image = Classes.AppSettings.AppBackgroundImage;
            panelBackgroundColor.BackColor = Classes.AppSettings.AppBackgroundColor;
            panelTextAccountColor.BackColor = Classes.AppSettings.AppAccountTextColor;
            panelTextContactColor.BackColor = Classes.AppSettings.AppContactTextColor;
            panel_backgAccountColor.BackColor = Classes.AppSettings.AppAccountBackgroundColor;
            panel_backgContactColor.BackColor = Classes.AppSettings.AppContactBackgroundColor;
        }

        private void PictureBox_BackgroundImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Title = "Choose an Image", InitialDirectory = "C:\\Pictures", Filter = "FilesPNG (*.png)|*.png|Files JPG (*.jpg)|*.jpg", FilterIndex = 2 };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBackgImage.Image = Image.FromFile(openFileDialog.FileName);
                Classes.AppSettings.AppBackgroundImage = pictureBoxBackgImage.Image;
            }
        }

        private void BackgroundColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog() { Color = panelBackgroundColor.BackColor };

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                panelBackgroundColor.BackColor = colourDialog.Color;
                Classes.AppSettings.AppBackgroundColor = colourDialog.Color;
            }
        }

        private void TextAccountColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog() { Color = panelTextAccountColor.BackColor };

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                panelTextAccountColor.BackColor = colourDialog.Color;
                Classes.AppSettings.AppAccountTextColor = colourDialog.Color;
            }
        }

        private void TextContactColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog() { Color = panelTextContactColor.BackColor };

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                panelTextContactColor.BackColor = colourDialog.Color;
                Classes.AppSettings.AppContactTextColor = colourDialog.Color;
            }
        }

        private void backgAccountColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog() { Color = panel_backgAccountColor.BackColor };

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                panel_backgAccountColor.BackColor = colourDialog.Color;
                Classes.AppSettings.AppAccountBackgroundColor = colourDialog.Color;
            }
        }

        private void backgContactColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog() { Color = panel_backgContactColor.BackColor };

            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                panel_backgContactColor.BackColor = colourDialog.Color;
                Classes.AppSettings.AppContactBackgroundColor = colourDialog.Color;
            }
        }

        private void ResetImageButtton_Click(object sender, EventArgs e)
        {
            pictureBoxBackgImage.Image = null;
            Classes.AppSettings.AppBackgroundImage = null;
        }

        private void AppSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            byte[] picture = null;
            if (pictureBoxBackgImage.Image != null)
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBoxBackgImage.Image.Save(memoryStream, pictureBoxBackgImage.Image.RawFormat);
                picture = memoryStream.GetBuffer();
            }

            Connection.sqlCommand.Parameters.Clear();
            Connection.sqlCommand.Parameters.AddWithValue("@photo", picture == null ? (object)System.DBNull.Value : picture).SqlDbType = SqlDbType.Image;
            Connection.IssueQuery("USE trentMessengerDB3; UPDATE appSettings SET AppBackgroundImage = @photo, BackgroundColorR = " + panelBackgroundColor.BackColor.R+", BackgroundColorG = "+ panelBackgroundColor.BackColor.G+ ", BackgroundColorB = "+ panelBackgroundColor.BackColor.B+ ", AccountBackgroundColorR = "+panel_backgAccountColor.BackColor.R+", AccountBackgroundColorG = "+panel_backgAccountColor.BackColor.G+", AccountBackgroundColorB = "+ panel_backgAccountColor.BackColor.B+ ", ContactBackgrounColorR = "+panel_backgContactColor.BackColor.R+", ContactBackgrounColorG = "+ panel_backgContactColor.BackColor.G+ ", ContactBackgrounColorB = "+ panel_backgContactColor.BackColor.B+ ", AccountTextColorR = "+panelTextAccountColor.BackColor.R+", AccountTextColorG = "+ panelTextAccountColor.BackColor.G+ ", AccountTextColorB = "+ panelTextAccountColor.BackColor.B+ ", ContactTextColorR = "+panelTextContactColor.BackColor.R+", ContactTextColorG = "+ panelTextContactColor.BackColor .G+ ", ContactTextColorB = "+ panelTextContactColor.BackColor.B+ " WHERE AccountID = "+Account.AccountId+";");
            Connection.CloseConnection();

            settings settingsForm = new settings(new ChatHome());
            settingsForm.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Classes.AppSettings.AppBackgroundImage = pictureBoxBackgImage.Image = null;
            Classes.AppSettings.AppBackgroundColor = panelBackgroundColor.BackColor = SystemColors.Control;
            Classes.AppSettings.AppAccountBackgroundColor = panel_backgAccountColor.BackColor = Color.Purple;
            Classes.AppSettings.AppContactBackgroundColor = panel_backgContactColor.BackColor = Color.White;
            Classes.AppSettings.AppAccountTextColor = panelTextAccountColor.BackColor = Color.Black;
            Classes.AppSettings.AppContactTextColor = panelTextContactColor.BackColor = Color.Black;
        }
    }
}
