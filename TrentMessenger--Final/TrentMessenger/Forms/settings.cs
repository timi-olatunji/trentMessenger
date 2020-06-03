using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trentmessenger.Forms;

namespace Trentmessenger
{
    public partial class settings : Form
    {
        private Form Form_Parent;

        public settings(ChatHome Form_Parent)
        {
            InitializeComponent();

            this.Form_Parent = Form_Parent;
            pictureBoxPhotoPB.Image = Account.Image;
            labelUsernameLB.Text = Account.Username_;
            richTextBoxAboutRT.Text = Account.AboutUser;
            label_UserRegistrationDate.Text = "Registered on:  " + Account.UserRegistrationDate.ToShortDateString();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            accountSettings AccSettingsForm = new accountSettings();
            AccSettingsForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This action will result in the permanent deletion of your account, there will be no account recovery afterwards. Do you want to continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM Contacts WHERE AccountID = " + Account.AccountId + " OR Contact_ID = " + Account.AccountId + ";");
                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM Msgs WHERE SenderID = " + Account.AccountId + " OR RecieverID = " + Account.AccountId + ";");
                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM appSettings WHERE AccountID = " + Account.AccountId + ";");
                Connection.IssueQuery("USE trentMessengerDB3; DELETE FROM Accounts WHERE AccountID = " + Account.AccountId + ";");

                login SignInForm = new login();
                SignInForm.Show();

                this.Close();
                //same as Form_Parent.Close();

                MessageBox.Show("Your account has been deleted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple Enterprise-grade Chat App, built using .Net Framework(C#) while using SQL Server for Data Storage. \n \n Refer to Documention for more Info", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChatHome MessengerForm = new ChatHome();
            MessengerForm.Show();
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUpdate AddContactForm = new ContactUpdate();
            AddContactForm.ShowDialog();
        }

        private void AppButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppSettings ApplicationForm = new AppSettings();
            ApplicationForm.ShowDialog();
        }
    }
}
