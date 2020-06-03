using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trentmessenger
{
    public partial class ChatHome : Form
    {
        public ChatHome()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings settingsForm = new settings(this);
            settingsForm.ShowDialog();
        }

        private void SearchBarRichTextBox_Click_1(object sender, EventArgs e)
        {
            if (richTextBox_searchBar_RTB.Text == "Search")
            {
                richTextBox_searchBar_RTB.Clear();
                richTextBox_searchBar_RTB.ForeColor = Color.White;
            }
        }

        private void SearchBarRichText_Leave(object sender, EventArgs e)
        {
            if (richTextBox_searchBar_RTB.Text.Length == 0 && richTextBox_searchBar_RTB.Text != "Search")
            {
                richTextBox_searchBar_RTB.Text = "Search";
                richTextBox_searchBar_RTB.ForeColor = Color.Plum;
            }
        }

        private void TrentMessenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            login SignInForm = new login();
            if (!SignInForm.Visible && this.Visible)
            {
                SignInForm.Show();
                MessageBox.Show("You have successfully logged out!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
