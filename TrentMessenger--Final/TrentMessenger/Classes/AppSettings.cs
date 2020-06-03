using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Trentmessenger.Classes
{
    class AppSettings
    {
        private static Color appBackgroundColor;
        private static Image appBackgroundImage;
        private static Color appAccountTextColor;
        private static Color appContactTextColor;
        private static Color appAccountBackgroundColor;
        private static Color appContactBackgroundColor;

        public static Color AppBackgroundColor { get { return appBackgroundColor; } set { appBackgroundColor = value; } }
        public static Image AppBackgroundImage { get { return appBackgroundImage; } set { appBackgroundImage = value; } }
        public static Color AppAccountTextColor { get { return appAccountTextColor; } set { appAccountTextColor = value; } }
        public static Color AppContactTextColor { get { return appContactTextColor; } set { appContactTextColor = value; } }
        public static Color AppAccountBackgroundColor { get { return appAccountBackgroundColor; } set { appAccountBackgroundColor = value; } }
        public static Color AppContactBackgroundColor { get { return appContactBackgroundColor; } set { appContactBackgroundColor = value; } }
    }
}
