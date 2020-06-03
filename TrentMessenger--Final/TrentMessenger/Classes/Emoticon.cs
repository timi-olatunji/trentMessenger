using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trentmessenger.Classes
{
    public class Emoticon
    {
        private string emoticonText;
        private string emoticonName;

        public Emoticon(string EmoticonText, string EmoticonName)
        {
            this.EmoticonText = EmoticonText;
            this.EmoticonName = EmoticonName;
        }

        public string EmoticonText { get { return emoticonText; } set { emoticonText = value; } }
        public string EmoticonName { get { return emoticonName; } set { emoticonName = value; } }
    }
}
