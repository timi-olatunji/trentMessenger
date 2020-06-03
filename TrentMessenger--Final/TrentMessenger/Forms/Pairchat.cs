using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Trentmessenger.UserControls;
using Trentmessenger.Classes;
using System.Data.SqlClient;
using System.IO;

namespace Trentmessenger.Forms
{
    public partial class Pairchat : Form
    {
        private int Contact_ID;
        EmojiUC EmoticonUC = new EmojiUC();

        public Pairchat(int Contact_ID)
        {
            InitializeComponent();

            this.Contact_ID = Contact_ID;

            EmoticonUC.Size = new Size(199, 140);
            EmoticonUC.Location = new Point(81, 205);
            EmoticonUC.Top += 39;
            EmoticonUC.Visible = false;
            EmoticonUC.EmojiClick += new EmojiUC.EmoticonClickEventHandler(OnEmoticon_Click);
            this.Controls.Add(EmoticonUC);
            EmoticonUC.BringToFront();

            FormCustomization();
            DownloadContactData();
            DownloadMessages();

            Connection.IssueQuery("USE trentMessengerDB3; UPDATE Msgs SET State = 1, DateR = '" + DateTime.Now+"' WHERE SenderID = "+ this.Contact_ID + " AND RecieverID = " + Account.AccountId + " AND State = 0;");
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChatHome trentMessenger = new ChatHome();
            trentMessenger.Show();
        }

        public void DownloadContactData()
        {
            SqlDataReader dataReader = Connection.FetchReader("USE trentMessengerDB3; SELECT Username_, TelNumber, Image FROM Accounts WHERE AccountID = " + Contact_ID + "");
            while (dataReader.Read())
            {
                labelUsername.Text = dataReader.GetString(0);
                labelNumber.Text = dataReader.GetString(1);
                MemoryStream memoryStream = new MemoryStream((byte[])dataReader.GetValue(2));
                pictureBoxPhoto.Image = Image.FromStream(memoryStream);
            }
            dataReader.Close();
            Connection.CloseConnection();
        }

        public void DownloadMessages()
        {
            SqlDataReader dataReader  = Connection.FetchReader("USE trentMessengerDB3; SELECT SenderID, Message, DateS, MessageID, State, DateR FROM Msgs WHERE SenderID IN (" + Account.AccountId+ ", " + this.Contact_ID + ") AND RecieverID IN (" + Account.AccountId + ", "+this.Contact_ID+");");
            while (dataReader.Read())
            {
                MessageUC MessageUC_ = new MessageUC();
                MessageUC_.Message_ID = int.Parse(dataReader.GetValue(3).ToString());
                MessageUC_.Info.Text = (int.Parse(dataReader.GetValue(0).ToString()) == Account.AccountId) ? Account.Username_ : labelUsername.Text;
                MessageUC_.Info.Text += " • " + ((DateTime.Now - DateTime.Parse(dataReader.GetValue(2).ToString())).TotalHours > 24 ? ((DateTime.Now - DateTime.Parse(dataReader.GetValue(2).ToString())).TotalHours < 48 ? "Yesterday" : DateTime.Parse(dataReader.GetValue(2).ToString()).ToShortDateString()) : DateTime.Parse(dataReader.GetValue(2).ToString()).ToShortTimeString());
                MessageUC_.MessageUc.Text = dataReader.GetString(1);
                MessageUC_.MessageUc.Height = ReturnMessageHeight(MessageUC_.MessageUc) * 15;
                MessageUC_.Height += (ReturnMessageHeight(MessageUC_.MessageUc) * 15) - 10;
                MessageUC_.Top = (5 + ReturnPreviousHeights()) + panelMain.Controls.OfType<MessageUC>().Count<MessageUC>() * 5;
                MessageUC_.Left = 20;
                MessageUC_.BackColor = Classes.AppSettings.AppContactBackgroundColor;
                MessageUC_.MessageUc.BackColor = Classes.AppSettings.AppContactBackgroundColor;
                MessageUC_.MessageUc.ForeColor = Classes.AppSettings.AppContactTextColor;
                MessageUC_.Info.ForeColor = Classes.AppSettings.AppContactTextColor;
                MessageUC_.MessagState.Top = MessageUC_.MessageUc.Bottom - 10;
                ToolTip tTipInfo = new ToolTip();
                tTipInfo.ToolTipIcon = ToolTipIcon.Info;
                tTipInfo.ToolTipTitle = "Unread Message";
                tTipInfo.SetToolTip(MessageUC_.MessagState, "User has not yet seen the message");

                if (int.Parse(dataReader.GetValue(0).ToString()) == Account.AccountId)
                {
                    MessageUC_.Left = (panelMain.Width - MessageUC_.Width) - 20;
                    MessageUC_.BackColor = Classes.AppSettings.AppAccountBackgroundColor;
                    MessageUC_.MessageUc.BackColor = Classes.AppSettings.AppAccountBackgroundColor;
                    MessageUC_.MessageUc.ForeColor = Classes.AppSettings.AppAccountTextColor;
                    MessageUC_.Info.ForeColor = Classes.AppSettings.AppAccountTextColor;
                    MessageUC_.MessagState.Visible = true;
                    if (bool.Parse(dataReader.GetValue(4).ToString()) == true)
                    {
                        MessageUC_.MessagState.Image = Properties.Resources.icon_messageRead;
                        tTipInfo.ToolTipTitle = "Message Read";
                        tTipInfo.SetToolTip(MessageUC_.MessagState, DateTime.Parse(dataReader.GetValue(5).ToString()).ToShortTimeString());
                    }
                }

                panelMain.Controls.Add(MessageUC_);
                MessageUC_.Scroll += new ScrollEventHandler(MainPanel_Scroll);
            }
            dataReader.Close();
            Connection.CloseConnection();

            if (panelMain.Controls.OfType<MessageUC>().Count<MessageUC>() == 0)
                labelNoMessages.Visible = true;
        }

        public int ReturnMessageHeight(RichTextBox TextBox)
        {
            int charCount = 0, rowCount = 1;

            for(int i = 0; i<TextBox.Text.Length; i++)
            {
                if (++charCount == 34)
                {
                    rowCount++;
                    charCount = 0;
                }
            }

            return rowCount;
        }

        public int ReturnPreviousHeights()
        {
            int height = 0;

            foreach (MessageUC MessageUC_ in panelMain.Controls.OfType<MessageUC>())
                height += MessageUC_.Height;

            return height;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            MessageUC MessageUC_ = new MessageUC();
            MessageUC_.Info.Text = Account.Username_ + " • " + DateTime.Now.ToShortTimeString();
            MessageUC_.MessageUc.Text = textBoxForchatBox.Text;
            MessageUC_.MessageUc.Height = ReturnMessageHeight(MessageUC_.MessageUc) * 15;
            MessageUC_.Height += (ReturnMessageHeight(MessageUC_.MessageUc) * 15) - 15;
            MessageUC_.Top = (panelMain.Controls.OfType<MessageUC>().Count<MessageUC>() == 0) ? 5 : panelMain.Controls.OfType<MessageUC>().Last<MessageUC>().Bottom + 5;
            MessageUC_.Left = (panelMain.Width - MessageUC_.Width) - 20;
            MessageUC_.BackColor = Classes.AppSettings.AppAccountBackgroundColor;
            MessageUC_.MessageUc.BackColor = Classes.AppSettings.AppAccountBackgroundColor;
            MessageUC_.MessageUc.ForeColor = Classes.AppSettings.AppAccountTextColor;
            MessageUC_.Info.ForeColor = Classes.AppSettings.AppAccountTextColor;
            MessageUC_.MessagState.Top = MessageUC_.MessageUc.Bottom - 15;
            MessageUC_.MessagState.Visible = true;
            ToolTip tTipInfo = new ToolTip();
            tTipInfo.ToolTipIcon = ToolTipIcon.Info;
            tTipInfo.ToolTipTitle = "Unread Message";
            tTipInfo.SetToolTip(MessageUC_.MessagState, "User has not yet seen the message");

            panelMain.Controls.Add(MessageUC_);
            MessageUC_.Scroll += new ScrollEventHandler(MainPanel_Scroll);

            if (panelMain.Controls.OfType<MessageUC>().Count<MessageUC>() == 0)
                labelNoMessages.Visible = true;
            else
                labelNoMessages.Visible = false;

            Connection.sqlCommand.Parameters.Clear();
            Connection.sqlCommand.Parameters.AddWithValue("@message", textBoxForchatBox.Text);
            Connection.IssueQuery("USE trentMessengerDB3; INSERT INTO Msgs VALUES(" + Account.AccountId+", "+this.Contact_ID+", @message, '"+DateTime.Now+"', 0, '"+DateTime.Now+"');");
            Connection.CloseConnection();

            EmoticonUC.Visible = false;
            panelMain.ScrollControlIntoView(MessageUC_);
            textBoxForchatBox.Clear();
        }

        private void TextBoxChatBox_OnKeyPress(object sender, KeyPressEventArgs keyPressEvent)
        {
            if(keyPressEvent.KeyChar == (char)Keys.Enter)
                button_send_Click(this, EventArgs.Empty);
        }

        public void FormCustomization()
        {
            panelMain.BackColor = Classes.AppSettings.AppBackgroundColor;
            if (Classes.AppSettings.AppBackgroundImage != null)
                panelMain.BackgroundImage = Classes.AppSettings.AppBackgroundImage;
        }

        private void MainPanel_Scroll(object sender, ScrollEventArgs e) { }

        private void EmoticonListButton_Click(object sender, EventArgs e)
        {
            if(EmoticonUC.Visible == false)
                EmoticonUC.Visible = true;
            else
                EmoticonUC.Visible = false;
        }

        private void OnEmoticon_Click(object sender, EventArgs e)
        {
            textBoxForchatBox.Text += ((Emoticon)((Button)sender).Tag).EmoticonText;
        }

        private void ChatShown(object sender, EventArgs e)
        {
            if(panelMain.Controls.OfType<MessageUC>().Count<MessageUC>() > 0)
                panelMain.ScrollControlIntoView(panelMain.Controls.OfType<MessageUC>().Last<MessageUC>());
        }
    }
}
