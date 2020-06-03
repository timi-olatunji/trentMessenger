using System;
using System.Drawing;
using System.Windows.Forms;
using Trentmessenger.Forms;

namespace Trentmessenger.UserControls
{
    public partial class ContactUC : UserControl
    {
        private int account_ID;
        private Label usernameLB;
        private Label numberLB;
        private Label lastSeenLB;
        private PictureBox photoLB;

        public ContactUC()
        {
            InitializeComponent();

            UsernameLB = labelUsername;
            NumberLB = labelNumber;
            LastSeenLB = labelLastSeen;
            PhotoPB = pictureBox_photoPB;

            System.Drawing.Drawing2D.GraphicsPath gPath = new System.Drawing.Drawing2D.GraphicsPath();
            gPath.AddEllipse(PhotoPB.DisplayRectangle);
            PhotoPB.Region = new Region(gPath);

            this.pictureBox_photoPB.MouseEnter += new System.EventHandler(this.AccountUC_MouseEnter);
            this.pictureBox_photoPB.MouseLeave += new System.EventHandler(this.AccountUC_MouseLeave);
            this.labelUsername.MouseEnter += new System.EventHandler(this.AccountUC_MouseEnter);
            this.labelUsername.MouseLeave += new System.EventHandler(this.AccountUC_MouseLeave);
            this.labelNumber.MouseEnter += new System.EventHandler(this.AccountUC_MouseEnter);
            this.labelNumber.MouseLeave += new System.EventHandler(this.AccountUC_MouseLeave);
            this.labelLastSeen.MouseEnter += new System.EventHandler(this.AccountUC_MouseEnter);
            this.labelLastSeen.MouseLeave += new System.EventHandler(this.AccountUC_MouseLeave);

            this.pictureBox_photoPB.Click += new System.EventHandler(this.ContactUC_Click);
            this.labelUsername.Click += new System.EventHandler(this.ContactUC_Click);
            this.labelNumber.Click += new System.EventHandler(this.ContactUC_Click);
            this.labelLastSeen.Click += new System.EventHandler(this.ContactUC_Click);
        }

        public int Account_ID { get { return account_ID; } set { account_ID = value; } }
        public Label UsernameLB { get { return usernameLB; } set { usernameLB = value; } }
        public Label NumberLB { get { return numberLB; } set { numberLB = value; } }
        public Label LastSeenLB { get { return lastSeenLB; } set { lastSeenLB = value; } }
        public PictureBox PhotoPB { get { return photoLB; } set { photoLB = value; } }

   

        private void AccountUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void AccountUC_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void ContactUC_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            AccountProfile apForm = new AccountProfile(account_ID);
            apForm.ShowDialog();
        }

        private void LastSeenLB_MouseEnter(object sender, EventArgs e) { }

        private void LastSeenLabel_MouseLeave(object sender, EventArgs e) { }

        private void PhotoPictureBox_Click(object sender, EventArgs e) { }
    }
}
