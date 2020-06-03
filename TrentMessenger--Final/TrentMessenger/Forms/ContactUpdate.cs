using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Trentmessenger.UserControls;
using System.Data.SqlClient;

namespace Trentmessenger.Forms
{
    public partial class ContactUpdate : Form
    {
        private List<AcctProfile> accountList = new List<AcctProfile>();

        public ContactUpdate()
        {
            InitializeComponent();

            DownloadAccounts();
        }

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings settingsForm = new settings(new ChatHome());
            settingsForm.Show();
        }

        private void RichTextBoxSearchBar_Click(object sender, EventArgs e)
        {
            if (richTextBoxSearchBar.Text == "Search")
            {
                richTextBoxSearchBar.Clear();
                richTextBoxSearchBar.ForeColor = Color.Black;
            }
        }

        private void RichTextBox_searchBar_Leave(object sender, EventArgs e)
        {
            if (richTextBoxSearchBar.Text.Length == 0 && richTextBoxSearchBar.Text != "Search")
            {
                richTextBoxSearchBar.Text = "Search";
                richTextBoxSearchBar.ForeColor = Color.Black;
            }
        }

        public void DownloadAccounts()
        {
            SqlDataReader dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT acc.AccountID, acc.AboutUser, acc.Image FROM Accounts acc WHERE acc.AccountID <> " + Account.AccountId + " AND acc.AccountID NOT IN(SELECT con.Contact_ID FROM Contacts con WHERE con.AccountID  AND acc.AccountID NOT IN(SELECT con.Contact_ID FROM Contacts con WHERE con.AccountID = " + Account.AccountId + ");");
            while(dataReader.Read())
            {
                AccountUC accountUC = new AccountUC(int.Parse(dataReader.GetValue(0).ToString()));
                MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(2));
                accountUC.PhotoPB.Image = Image.FromStream(memoryStream);
                accountUC.About.Text = dataReader.GetString(1);
                accountUC.Left = 3;
                accountUC.Top = (accountUC.Height * panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>());
                panelMainPN.Controls.Add(accountUC);
                accountUC.AccountAddEvent += AccountUC_AccountAdd;

                accountList.Add(new AcctProfile(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetString(1).ToLower(), Image.FromStream(memoryStream)));
            }
            dataReader.Close();
            Connection.CloseConnection();

            if(panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>() <= 5)
            {
                foreach(AccountUC accountUC in panelMainPN.Controls.OfType<AccountUC>())
                {
                    accountUC.Width += 18;
                    accountUC.About.Width += 5;
                    accountUC.AddBtn.Left = (accountUC.Width - accountUC.AddBtn.Width) - 5;
                }
            }
        }

        private void RichTextBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if(richTextBoxSearchBar.Text != "Search" && richTextBoxSearchBar.Text.Length > 0)
            {
                panelMainPN.Controls.Clear();

                foreach(AcctProfile account in accountList)
                {
                    //Searching through the Account List
                    if(account.AboutUser.Contains(richTextBoxSearchBar.Text.ToLower()))
                    {
                        AccountUC accountUC= new AccountUC(account.AccountID);
                        accountUC.PhotoPB.Image = account.image;
                        accountUC.About.Text = account.AboutUser;
                        accountUC.Left = 3;
                        accountUC.Top = (accountUC.Height * panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>());
                        panelMainPN.Controls.Add(accountUC);
                    }
                }

                //Adjusting the dimensions of the controls programmatically and dynamically
                if (panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>() <= 5)
                {
                    foreach (AccountUC accountUC in panelMainPN.Controls.OfType<AccountUC>())
                    {
                        accountUC.Width += 18;
                        accountUC.About.Width += 5;
                        accountUC.AddBtn.Left = (accountUC.Width - accountUC.AddBtn.Width) - 5;
                    }
                }
            }

            else
            {
                panelMainPN.Controls.Clear();

                foreach (AcctProfile accountObject in accountList)
                {
                    AccountUC accountUC = new AccountUC(accountObject.AccountID);
                    accountUC.PhotoPB.Image = accountObject.image;
                    accountUC.About.Text = accountObject.AboutUser;
                    accountUC.Left = 3;
                    accountUC.Top = (accountUC.Height * panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>());
                    panelMainPN.Controls.Add(accountUC);
                }

                if (panelMainPN.Controls.OfType<AccountUC>().Count<AccountUC>() <= 5)
                {
                    foreach (AccountUC accountUC in panelMainPN.Controls.OfType<AccountUC>())
                    {
                        accountUC.Width += 18;
                        accountUC.About.Width += 5;
                        accountUC.AddBtn.Left = (accountUC.Width - accountUC.AddBtn.Width) - 5;
                    }
                }
            }
        }

        private void AccountUC_AccountAdd(object sender, EventArgs e)
        {
            panelMainPN.Controls.Clear();

            DownloadAccounts();
        }
    }

    class AcctProfile
    {
        public int AccountID;
        public string AboutUser;
        public Image image;

        public AcctProfile(int AccountID, string AboutUser, Image image)
        {
            this.AccountID = AccountID;
            this.AboutUser = AboutUser;
            this.image = image;
        }
    }
}
