using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trentmessenger.UserControls
{
    public partial class MessageUC : UserControl
    {
        private int message_ID;
        private Label info;
        private RichTextBox messageUC;
        private PictureBox msgStateUC;

        public MessageUC()
        {
            InitializeComponent();

            Info = label_info;
            MessageUc = richTextBox_message;
            MessagState = pictureBox_msgState;
        }

        public int Message_ID { get { return message_ID; } set { message_ID = value; } }
        public Label Info { get { return info; } set { info = value; } }
        public RichTextBox MessageUc { get { return messageUC; } set { messageUC = value; } }
        public PictureBox MessagState { get { return msgStateUC; } set { msgStateUC = value; } }

    }
}
