using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Trentmessenger.UserControls;
using System.IO;

namespace Trentmessenger
{
    public partial class ucTabs : UserControl
    {
        private int tab_ID = 0;
        public int testUC;

        public ucTabs()
        {
            InitializeComponent();
            this.HorizontalScroll.Enabled = false;

            DownloadChats();
            DownloadContacts();
            ChangeTabs(tab_ID = 1);
        }

        private void ChatsBtn_Click(object sender, EventArgs e)
        {
            ChangeTabs(tab_ID = 1);
        }

        private void ButtonTab_Click(object sender, EventArgs e)
        {
            ChangeTabs(tab_ID = 2);
        }

        private void ChangeTabs(int tabID)
        {
            animationTimer.Start();
        }


        //Animation Design for the Tab Controls. Best Observed through the UI
        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            switch (tab_ID)
            {
                case 1:
                    {
                        if (panelSelectedPanel.Left > button_chats_btn.Left)
                        {
                            panelSelectedPanel.Left = panelSelectedPanel.Left - 10;
                            panelMain1.Left = panelMain1.Left + 20;
                        }

                        else
                        {
                            animationTimer.Stop();

                            if (panelSelectedPanel.Left != button_chats_btn.Left)
                                panelSelectedPanel.Left = button_chats_btn.Left;

                            if (panelMain1.Left != button_chats_btn.Left)
                                panelMain1.Left = button_chats_btn.Left;
                        }

                        break;
                    }

                case 2:
                    {
                        if (panelSelectedPanel.Left < button_contacts_btn.Left)
                        {
                            panelSelectedPanel.Left = panelSelectedPanel.Left + 10;
                            panelMain1.Left = panelMain1.Left - 20;
                        }

                        else
                        {
                            animationTimer.Stop();

                            if (panelSelectedPanel.Left != button_contacts_btn.Left)
                                panelSelectedPanel.Left = button_contacts_btn.Left;

                            if (panelMain1.Right != button_contacts_btn.Left)
                                panelMain1.Left = -(panelMain1.Width / 2);
                        }

                        break;
                    }
            }
        }

        //Logic for Handling Contacts Loading from the "trentMessengerDB3"
        public void DownloadContacts()
        {
            System.Data.SqlClient.SqlDataReader dataReader;

            if ((dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT acc_2.AccountID, acc_2.Username_, acc_2.TelNumber, acc_2.LastSeenOnline, acc_2.Image FROM Accounts acc_1 INNER JOIN Contacts ON acc_1.AccountID = Contacts.AccountID INNER JOIN Accounts acc_2 ON acc_2.AccountID = Contacts.Contact_ID WHERE acc_1.AccountID = " + Account.AccountId + " ORDER BY acc_2.LastSeenOnline DESC;")).HasRows)
            {
                while (dataReader.Read())
                {
                    ContactUC contactUC = new ContactUC();
                    contactUC.Account_ID = int.Parse(dataReader.GetValue(0).ToString());
                    contactUC.UsernameLB.Text = dataReader[1].ToString();
                    contactUC.NumberLB.Text = dataReader[2].ToString();
                    contactUC.LastSeenLB.Text = ((DateTime.Now - DateTime.Parse(dataReader.GetValue(3).ToString())).TotalHours > 24) ? DateTime.Parse(dataReader.GetValue(3).ToString()).ToShortDateString() : DateTime.Parse(dataReader.GetValue(3).ToString()).ToShortTimeString();
                    MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(4));
                    contactUC.PhotoPB.Image = Image.FromStream(memoryStream);
                    contactUC.LastSeenLB.Left = contactUC.Width - contactUC.LastSeenLB.Width - 15;
                    contactUC.Left = 2;
                    contactUC.Top = contactUC.Height * contactsPanel.Controls.OfType<ContactUC>().Count<ContactUC>();
                    contactsPanel.Controls.Add(contactUC);
                }
                dataReader.Close();
            }
            else
                noContactsLabel.Visible = true;

            Connection.CloseConnection();
        }

        //Logic for Handling Chats Loading from the "trentMessengerDB3"
        public void DownloadChats()
        {
            System.Data.SqlClient.SqlDataReader dataReader;
            if ((dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT DISTINCT ISNULL(m.MessageID, -1), Contact_ID, m.DateS FROM Contacts c OUTER APPLY (SELECT TOP 1  Msgs.MessageID, Msgs.DateS FROM Msgs WHERE c.Contact_ID IN (SenderID, RecieverID) AND AccountID IN (SenderID, RecieverID) ORDER BY DateS DESC) m WHERE AccountID = " + Account.AccountId+ " ORDER BY m.DateS DESC;")).HasRows)
            {
                while (dataReader.Read())
                {
                    ChatUC chatUC = new ChatUC(int.Parse(dataReader.GetValue(0).ToString()), int.Parse(dataReader.GetValue(1).ToString()));
                    chatUC.Message_ID = int.Parse(dataReader.GetValue(0).ToString());
                    chatUC.DateSentLB.Left = chatUC.Width - chatUC.DateSentLB.Width - 15;
                    chatUC.Left = 2;
                    chatUC.Top = chatUC.Height * chatsPanel.Controls.OfType<ChatUC>().Count<ChatUC>();

                    if(chatUC.Message_ID == -1)
                    {
                        chatUC.Message.Text = "This chat has not started yet";
                        chatUC.SpokenBy_Label.Visible = false;
                        chatUC.DateSentLB.Visible = false;
                    }

                    chatsPanel.Controls.Add(chatUC);
                }
                dataReader.Close();
            }
            else
                noMessagesLabel.Visible = true;

            Connection.CloseConnection();

            //chatsPanel.Controls return a List of chat objects
            if (chatsPanel.Controls.OfType<ChatUC>().Count<ChatUC>() > 0)
            {
                foreach (ChatUC chatUC in chatsPanel.Controls.OfType<ChatUC>())
                {
                    //Loads Messages only when there is an active chats
                    if (chatUC.Message_ID != -1)
                    {
                        dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT SenderID, Username_, TelNumber, Image, DateS, Message FROM Accounts INNER JOIN Msgs ON AccountID IN(Msgs.SenderID, Msgs.RecieverID) WHERE AccountID <> " + Account.AccountId + " AND MessageID = " + chatUC.Message_ID + ";");
                       
                        //Logic for the Display of Chat Messages
                        while (dataReader.Read())
                        {
                            chatUC.NumberPhn.Text = dataReader.GetString(2);
                            chatUC.SpokenBy_Label.Text = int.Parse(dataReader.GetValue(0).ToString()) == Account.AccountId ? "You:" : dataReader.GetString(1) + ":";
                            chatUC.DateSentLB.Text = (DateTime.Now - DateTime.Parse(dataReader.GetValue(4).ToString())).TotalHours > 24 ? 48 >= (DateTime.Now - DateTime.Parse(dataReader.GetValue(4).ToString())).TotalHours && (DateTime.Now - DateTime.Parse(dataReader.GetValue(4).ToString())).TotalHours > 24 ? "Yesterday" : DateTime.Parse(dataReader.GetValue(4).ToString()).ToShortDateString() : DateTime.Parse(dataReader.GetValue(4).ToString()).ToShortTimeString();
                            chatUC.DateSentLB.Left = chatUC.Width - chatUC.DateSentLB.Width - 15;
                            chatUC.Message.Text = dataReader.GetString(5).Length > 25 ? dataReader.GetString(5).Substring(0, 25) + "..." : dataReader.GetString(5);
                            MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(3));
                            chatUC.PhotoPB.Image = Image.FromStream(memoryStream);
                        }
                        dataReader.Close();
                        Connection.CloseConnection();
                    }

                    //Else, Only User Data is fetched for the receiver.
                    else
                    {
                        dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT TelNumber, Image, Username_ FROM Accounts WHERE AccountID = " + chatUC.Contact_ID + ";");
                        while (dataReader.Read())
                        {
                            chatUC.NumberPhn.Text = dataReader.GetString(2);
                            chatUC.SpokenBy_Label.Text = dataReader.GetString(2);
                            MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(1));
                            chatUC.PhotoPB.Image = Image.FromStream(memoryStream);
                        }
                        dataReader.Close();
                        Connection.CloseConnection();
                    }
                }

                //Computing the total number of messages in a pair chat.
                foreach (ChatUC chatUC in chatsPanel.Controls.OfType<ChatUC>())
                {
                    if (chatUC.Message_ID != -1)
                    {
                        int messageCounter = (int)Connection.ReturnScalar("USE trentMessengerDB3; SELECT COUNT(*) FROM Msgs WHERE State = 0 AND SenderID = " + chatUC.Contact_ID + " AND RecieverID = " + Account.AccountId + ";");
                        chatUC.MessageCounter.Text = messageCounter == 0 ? "✔" : messageCounter.ToString();
                        chatUC.MessageCounter.BackColor = messageCounter == 0 ? Color.Transparent : Color.Green;
                        if (chatsPanel.Controls.OfType<ChatUC>().Count<ChatUC>() > 4)
                        {
                            chatUC.MessageCounter.Left = chatUC.Width - chatUC.MessageCounter.Width - 17;
                            chatUC.DateSentLB.Padding = new Padding(0, 3, 15, 0);
                        }
                        Connection.CloseConnection();
                    }

                    else
                        chatUC.MessageCounter.Visible = false;
                }
            }
        }
    }
}
