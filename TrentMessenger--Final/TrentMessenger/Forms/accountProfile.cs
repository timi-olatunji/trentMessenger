using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Trentmessenger.Forms
{
    public partial class AccountProfile : Form
    {
        private int _accountID;

        public AccountProfile(int AccountID)
        {
            InitializeComponent();

            _accountID = AccountID;
            DownloadAccountData(AccountID);
            toolTip_info.SetToolTip(button_remove, "Remove this person from your contact list");
        }

        public void DownloadAccountData(int AccountID)
        {
            SqlDataReader dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT Username_, TelNumber, AboutUser, Image, LastSeenOnline FROM Accounts WHERE AccountID = " + AccountID);
            while (dataReader.Read())
            {
                Text = "Count of: " + dataReader.GetString(0);
                MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(3));
                pictureBox_photo.Image = Image.FromStream(memoryStream);
                label_username.Text = dataReader.GetString(0);
                label_number.Text = dataReader.GetString(1);
                richTextBox_about.Text = dataReader.GetString(2);
                label_lastSeen.Text = ((DateTime.Now - DateTime.Parse(dataReader.GetValue(4).ToString())).TotalHours > 24) ? DateTime.Parse(dataReader.GetValue(4).ToString()).ToShortDateString() : DateTime.Parse(dataReader.GetValue(4).ToString()).ToShortTimeString();
            }
            dataReader.Close();
            Connection.CloseConnection();

            label_friendSince.Text = DateTime.Parse(Connection.ReturnScalar("USE trentMessengerDB3; SELECT DateF FROM Contacts WHERE AccountID = " + Account.AccountId + " AND Contact_ID = " + AccountID + ";").ToString()).ToShortDateString();
            Connection.CloseConnection();

            int messageCounter = Account.ReturnMessageCount(AccountID);
            label_messages.Text = messageCounter + " message" + (messageCounter > 1 ? "s" : "");
            Connection.CloseConnection();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete? “" + label_username.Text + "” from your contact list? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM Contacts WHERE AccountID = " + Account.AccountId +" AND Contact_ID = "+ _accountID + ";");
                Connection.CloseConnection();

                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM Msgs WHERE SenderID IN(" + Account.AccountId + ", " + _accountID + ") AND RecieverID IN(" + Account.AccountId + ", " + _accountID + ");");
                Connection.CloseConnection();

                MessageBox.Show("You have successfully deleted “" + label_username.Text + "” from your contact list", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void AccountProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChatHome TrentMessenger = new ChatHome();
            TrentMessenger.Show();
        }
    }
}
