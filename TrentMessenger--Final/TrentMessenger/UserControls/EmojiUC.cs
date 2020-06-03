using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trentmessenger.Classes;

namespace Trentmessenger.UserControls
{
    public partial class EmojiUC : UserControl
    {
        public delegate void EmoticonClickEventHandler(object sender, EventArgs e);
        public event EmoticonClickEventHandler EmojiClick;
        List<Emoticon> emoticonList = new List<Emoticon>();

        public EmojiUC()
        {
            InitializeComponent();

            CreateEmojiList();
        }

        public void CreateAllEmojis()
        {
            emoticonList.Add(new Emoticon(":)", "Smile"));
            emoticonList.Add(new Emoticon(":D", "happy"));
            emoticonList.Add(new Emoticon(":(", "sad"));
            emoticonList.Add(new Emoticon(":'(", "cry"));
            emoticonList.Add(new Emoticon(";)", "wink"));
            emoticonList.Add(new Emoticon("XD", "laugh"));
            emoticonList.Add(new Emoticon(";(", "Angry"));
            emoticonList.Add(new Emoticon(":@", "Rage"));
            emoticonList.Add(new Emoticon(":3", "Cute"));
            emoticonList.Add(new Emoticon(">:", "Annoyed"));
            emoticonList.Add(new Emoticon(":-|", "Palmed Face"));
            emoticonList.Add(new Emoticon("B-D", "Glasses"));
            emoticonList.Add(new Emoticon(":S", "Sick"));
            emoticonList.Add(new Emoticon("._.", "Dissapointed"));
            emoticonList.Add(new Emoticon("O.o", "Schoked"));
            emoticonList.Add(new Emoticon("O_O", "Surprised"));
            emoticonList.Add(new Emoticon("X.X", "Dead"));
            emoticonList.Add(new Emoticon("°__°", "Robot"));
            emoticonList.Add(new Emoticon("$_$", "Rich"));
            emoticonList.Add(new Emoticon(":-J", "Tongue on the Chick"));
            emoticonList.Add(new Emoticon("=^_^=", "Blush"));
            emoticonList.Add(new Emoticon(":-o", "Alarm"));
            emoticonList.Add(new Emoticon(">_<", "Stress"));
            emoticonList.Add(new Emoticon("(*_*)", "Lover"));
            emoticonList.Add(new Emoticon("(-_-)", "Bored"));
            emoticonList.Add(new Emoticon("8[+]", "Gift"));
            emoticonList.Add(new Emoticon("(*V*)", "Bird"));
            emoticonList.Add(new Emoticon(":o3", "Dog"));
            emoticonList.Add(new Emoticon("ʕ•́ᴥ•̀ʔ", "Puppy"));
            emoticonList.Add(new Emoticon("=^.^=", "Cat"));
            emoticonList.Add(new Emoticon("<>< ", "Fish"));
            emoticonList.Add(new Emoticon("^o,o^", "Owl"));
            emoticonList.Add(new Emoticon("( *)>", "Penguin"));
            emoticonList.Add(new Emoticon("(‘.’)", "Rabbit"));
            emoticonList.Add(new Emoticon("_@_v", "Snail"));
            emoticonList.Add(new Emoticon("♥", "Heart"));
        }

        public void CreateEmojiList()
        {
            CreateAllEmojis();
            int btnCount = 0;

            foreach(Emoticon emoji in emoticonList)
            {
                Button btnEmoji = new Button();
                btnEmoji.Size = new Size(40, 36);
                btnEmoji.FlatStyle = FlatStyle.Flat;
                btnEmoji.FlatAppearance.MouseDownBackColor = Color.Cyan;
                btnEmoji.Cursor = Cursors.Hand;
                btnEmoji.Font = new Font("Bahnschrift", 6.75f);
                btnEmoji.Text = emoji.EmoticonText;
                btnEmoji.Top = (mainPanel.Controls.OfType<Button>().Count<Button>() / 4) * (1 + btnEmoji.Height) + 23;
                btnEmoji.Left = (btnEmoji.Width + 1) * btnCount + 6;
                mainPanel.Controls.Add(btnEmoji);
                btnEmoji.Tag = emoji;
                tool_TipInfo.SetToolTip(btnEmoji, emoji.EmoticonName);
                btnEmoji.Click += new EventHandler(EmojiClickEvent);
                btnCount++;

                if (btnCount == 4)
                    btnCount = 0;
            }
        }

        protected virtual void EmojiClickEvent(object sender, EventArgs e)
        {
            if (this.EmojiClick != null)
                EmojiClick(sender, EventArgs.Empty);
        }
    }    
}
