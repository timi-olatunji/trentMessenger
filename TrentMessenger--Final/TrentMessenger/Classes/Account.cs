using System;
using System.Drawing;
namespace Trentmessenger
{
    class Account
    {
        private static int accountId;
        private static string username_;
        private static string userPassword;
        private static string telNumber;
        private static string aboutUser;
        private static Image image;
        private static string securityQuestion;
        private static string securityA;
        private static DateTime lastSeenOnline;
        private static DateTime userRegistrationDate;

        public static int AccountId { get { return accountId; } set { accountId = value; }}
        public static string Username_ { get { return username_; } set { username_ = value; }}
        public static string UserPassword { get { return userPassword; } set { userPassword = value; }}
        public static string TelNumber { get { return telNumber; } set { telNumber = value; }}
        public static string AboutUser { get { return aboutUser; } set { aboutUser = value; }}
        public static Image Image { get { return image; } set { image = value; }}
        public static string SecurityQuestion { get { return securityQuestion; } set { securityQuestion = value; }}
        public static string SecurityAnswer { get { return securityA; } set { securityA = value; }}
        public static DateTime LastSeenOnline { get { return lastSeenOnline; } set { lastSeenOnline = value; }}
        public static DateTime UserRegistrationDate { get { return userRegistrationDate; } set { userRegistrationDate = value; } }

        public Forms.AccountProfile AccountProfile
        {
            get => default;
            set
            {
            }
        }

        public static int ReturnMessageCount(int AccountID)
        {
            return (int)Connection.ReturnScalar("SELECT COUNT(*) FROM Msgs WHERE SenderID = " + AccountID + ";");
        }
    }
}
