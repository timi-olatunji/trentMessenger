using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Trentmessenger.UserControls
{
    public partial class AccountUC : UserControl
    {
        public delegate void AddAccountEventHandler(object sender, EventArgs e);
        public event AddAccountEventHandler AccountAddEvent;

        private int accountID;
        private PictureBox image;
        private RichTextBox aboutUser;
        private Button addUser;

        public AccountUC(int AccountID)
        {
            InitializeComponent();

            this.AccountID = AccountID;
            PhotoPB = pictureBox_photo;
            About = richTextBox_about;
            AddBtn = button_add;

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(PhotoPB.DisplayRectangle);
            PhotoPB.Region = new Region(graphicsPath);
        }

        public int AccountID { get { return accountID; } set { accountID = value; } }
        public PictureBox PhotoPB { get { return image; } set { image = value; } }
        public RichTextBox About { get { return aboutUser; } set { aboutUser = value; } }
        public Button AddBtn { get { return addUser; } set { addUser = value; } }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (button_add.Text == "Add")
            {
                Connection.IssueQuery("USE trentMessengerDB3; INSERT INTO Contacts(AccountID, Contact_ID) VALUES(" + Account.AccountId + ", " + this.AccountID + ");");
                Connection.CloseConnection();
                Connection.IssueQuery("USE trentMessengerDB3; INSERT INTO Contacts(AccountID, Contact_ID) VALUES(" + this.AccountID + ", " + Account.AccountId + ");");
                Connection.CloseConnection();
                MessageBox.Show("You have successfully added this account to your contact list", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnAccountAddEvent(sender, e);
            }
        }

        protected virtual void OnAccountAddEvent(object sender, EventArgs e)
        {
            if (this.AccountAddEvent != null)
                this.AccountAddEvent(this, EventArgs.Empty);
        }
    }
}
