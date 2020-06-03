using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Trentmessenger.Forms;

namespace Trentmessenger.UserControls
{
    public partial class ChatUC : UserControl
    {
        private int messageID;
        private int contact_ID;
        private PictureBox photoPB;
        private Label numberPhn;
        private Label dateSentLB;
        private Label message;
        private Label spokenByLB;
        private Button messageCount;

        public ChatUC(int Message_ID, int Contact_ID)
        {
            InitializeComponent();

            this.Message_ID = Message_ID;
            this.Contact_ID = Contact_ID;
            PhotoPB = pictureBox_photo;
            NumberPhn = label_number;
            DateSentLB = label_messageDate;
            Message = label_message;
            SpokenBy_Label = label_spokenBy;
            MessageCounter = button_messageCount;

            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(photoPB.DisplayRectangle);
            photoPB.Region = new Region(gPath);

            gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(button_messageCount.DisplayRectangle);
            button_messageCount.Region = new Region(gPath);

            pictureBox_photo.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            pictureBox_photo.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            label_number.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            label_number.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            label_message.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            label_message.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            label_spokenBy.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            label_spokenBy.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            label_messageDate.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            label_messageDate.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);
            button_messageCount.MouseEnter += new System.EventHandler(this.ChatUC_MouseEnter);
            button_messageCount.MouseLeave += new System.EventHandler(this.ChatUC_MouseLeave);

            pictureBox_photo.Click += new System.EventHandler(this.ChatUC_Click);
            label_number.Click += new System.EventHandler(this.ChatUC_Click);
            label_messageDate.Click += new System.EventHandler(this.ChatUC_Click);
            label_spokenBy.Click += new System.EventHandler(this.ChatUC_Click);
            label_message.Click += new System.EventHandler(this.ChatUC_Click);
        }

        public int Message_ID { get { return messageID; } set { messageID = value; } }
        public int Contact_ID { get { return contact_ID; } set { contact_ID = value; } }
        public PictureBox PhotoPB { get { return photoPB; } set { photoPB = value; } }
        public Label NumberPhn { get { return numberPhn; } set { numberPhn = value; } }
        public Label DateSentLB { get { return dateSentLB; } set { dateSentLB = value; } }
        public Label Message { get { return message; } set { message = value; } }
        public Label SpokenBy_Label { get { return spokenByLB; } set { spokenByLB = value; } }
        public Button MessageCounter { get { return messageCount; } set { messageCount = value; } }

  

        private void ChatUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ChatUC_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        //Logic for the Chat Form and Interaction
        private void ChatUC_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            Pairchat chatForm = new Pairchat(Contact_ID);
            chatForm.Show();
            chatForm.Text = SpokenBy_Label.Text.EndsWith(":") ? SpokenBy_Label.Text.Substring(0, spokenByLB.Text.Length - 1) : SpokenBy_Label.Text;
        }

        private void Spoken_By_Label_MouseEnter(object sender, EventArgs e) { }

        private void Spoken_By_Label_MouseLeave(object sender, EventArgs e) { }

        private void Spoken_By_Label_Click(object sender, EventArgs e) { }
    }
}
