using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Trentmessenger
{

    //Logic for Account Settings includes Updating the Password, Profile Picture, About User, Username and other details
    //See the UserSettings.cs[Design] for Visualization of UI elements and Control Feautures
    public partial class accountSettings : Form
    {
        public accountSettings()
        {
            InitializeComponent();

            pictureBoxPhoto.Image = Account.Image;
            textBoxUsername.Text = Account.Username_;
            textBoxNumber.Text = Account.TelNumber;
            textBoxAbout.Text = Account.AboutUser;

            toolTipInfo.SetToolTip(pictureBoxUsernameError, "Username_ must not exceed 30 characters!");
            toolTipInfo.SetToolTip(pictureBoxNumberError, "Phone number must not exceed 11 numbers!");
            toolTipInfo.SetToolTip(pictureBoxAboutError, "AboutUser must not exceed 100 characters!");
            toolTipInfo.SetToolTip(pictureBoxPasswordConError, "UserPassword must not exceed 30 characters");
            toolTipInfo.SetToolTip(pictureBoxPasswordNewError, "UserPassword must not exceed 30 characters");
            toolTipInfo.SetToolTip(pictureBoxReponsSError, "Security Answer must not exceed 40 characters");
        }

        public Forms.ContactUpdate ContactUpdate
        {
            get => default;
            set
            {
            }
        }

        //Edit/UPDATE QUERY for the Username
        private void PictureBoxUsernameEdit_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.ReadOnly == true)
            {
                pictureBoxusernameEdit.Image = Properties.Resources.icon_save;
                textBoxUsername.ReadOnly = false;
                textBoxUsername.BackColor = Color.CornflowerBlue;
                textBoxUsername.Focus();
            }
            else
            {
                try
                {
                    if (textBoxUsername.Text.Length == 0) throw new Exception("You must first enter a username_");
                    if (textBoxUsername.Text.Length > 30) throw new Exception("Username_ must not exceed 30 characters!");

                    pictureBoxusernameEdit.Image = Properties.Resources.icon_modify;
                    textBoxUsername.ReadOnly = true;
                    textBoxUsername.BackColor = Color.Purple;

                    Account.Username_ = textBoxUsername.Text;
                    Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET Username_ = '" + textBoxUsername.Text + "' WHERE AccountID = " + Account.AccountId + ";");
                    MessageBox.Show("You successfully changed your Username_", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Edit/UPDATE QUERY for the TelNumber
        private void PictureBoxNumberEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.ReadOnly == true)
            {
                pictureBoxNumberEdit.Image = Properties.Resources.icon_save;
                textBoxNumber.ReadOnly = false;
                textBoxNumber.BackColor = Color.CornflowerBlue;
                textBoxNumber.Focus();
            }
            else
            {
                try
                {
                    Regex phoneNumber = new Regex(@"^(07)\d{9}$");
                    if (!phoneNumber.IsMatch(textBoxNumber.Text)) throw new Exception("You entered an invalid phone number");

                    pictureBoxNumberEdit.Image = Properties.Resources.icon_modify;
                    textBoxNumber.ReadOnly = true;
                    textBoxNumber.BackColor = Color.DarkSlateGray;

                    Account.TelNumber = textBoxNumber.Text;
                    Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET TelNumber = '" + textBoxNumber.Text + "' WHERE AccountID = " + Account.AccountId + ";");
                    MessageBox.Show("You successfully changed your Phone Number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Edit/UPDATE QUERY for the About User
        private void PictureBoxAboutEdit_Click(object sender, EventArgs e)
        {
            if (textBoxAbout.ReadOnly == true)
            {
                pictureBoxAboutEdit.Image = Properties.Resources.icon_save;
                textBoxAbout.ReadOnly = false;
                textBoxAbout.BackColor = Color.Plum;
                textBoxAbout.Focus();
            }
            else
            {
                try
                {
                    if (textBoxAbout.Text.Length == 0) throw new Exception("You must first enter a text");
                    if (textBoxAbout.Text.Length > 100) throw new Exception("AboutUser must not exceed 100 characters");

                    pictureBoxAboutEdit.Image = Properties.Resources.icon_modify;
                    textBoxAbout.ReadOnly = true;
                    textBoxAbout.BackColor = Color.DarkSlateGray;

                    Account.AboutUser = textBoxAbout.Text;
                    Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET AboutUser = '" + textBoxAbout.Text + "' WHERE AccountID = " + Account.AccountId + ";");
                    MessageBox.Show("You successfully changed your AboutUser", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length > 30)
                pictureBoxUsernameError.Visible = true;
            else
                pictureBoxUsernameError.Visible = false;
        }

        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumber.Text.Length > 11)
                pictureBoxNumberError.Visible = true;
            else
                pictureBoxNumberError.Visible = false;
        }

        private void AboutTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAbout.Text.Length > 100)
                pictureBoxAboutError.Visible = true;
            else
                pictureBoxAboutError.Visible = false;
        }

        //Error-- UI Element...set to Visible
        private void PictureBoxPhotoIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Title = "Choose an Image", InitialDirectory = "C:\\Pictures", Filter = "FilesPNG (*.png)|*.png|Files JPG (*.jpg)|*.jpg|Files GIF (*.gif)|*.gif", FilterIndex = 2 };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);


                MemoryStream memoryStream = new MemoryStream();
                pictureBoxPhoto.Image.Save(memoryStream, pictureBoxPhoto.Image.RawFormat);
                byte[] picture = memoryStream.GetBuffer();
                memoryStream.Close();
                Connection.sqlCommand.Parameters.Clear();
                Connection.sqlCommand.Parameters.AddWithValue("@photo", picture);
                Account.Image = pictureBoxPhoto.Image;
                Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET Image = @photo WHERE AccountID = " + Account.AccountId + ";");
                MessageBox.Show("You have successfully changed your Account Image!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void PictureBoxPasswordConEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPasswordCon.Text.Length == 0) throw new Exception("You must first enter your current password");
                if (textBoxPasswordCon.Text.Length > 30) throw new Exception("UserPassword must not exceed 30 characters");
                if (textBoxPasswordCon.Text != Account.UserPassword) throw new Exception("You entered an incorrect password");

                comboBoxQuestionS.Text = Account.SecurityQuestion;
                textBoxReponsS.Text = Account.SecurityAnswer;
                textBoxPasswordCon.Enabled = false;
                pictureBoxPasswordConEdit.Enabled = false;
                textBoxPasswordNew.Enabled = true;
                comboBoxQuestionS.Enabled = true;
                textBoxReponsS.Enabled = true;
                pictureBoxPasswordNewEdit.Visible = true;
                pictureBoxReponsSEdit.Visible = true;
                textBoxPasswordNew.Focus();
                MessageBox.Show("You have confirmed your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Error-- UI Element...set to Visible
        private void TextBoxPasswordCon_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordCon.Text.Length > 30)
            {
                pictureBoxPasswordConError.Visible = true;
                pictureBoxPasswordConEdit.Visible = false;
            }
            else
            {
                pictureBoxPasswordConError.Visible = false;
                pictureBoxPasswordConEdit.Visible = true;
            }

            button_showPasswordCon.Enabled = textBoxPasswordCon.Text.Length == 0 ? false : true;
        }

        //Error-- UI Element...set to Visible
        private void TextBoxPasswordNew_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordNew.Text.Length > 30)
            {
                pictureBoxPasswordNewError.Visible = true;
                pictureBoxPasswordNewEdit.Visible = false;
            }
            else
            {
                pictureBoxPasswordNewError.Visible = false;
                pictureBoxPasswordNewEdit.Visible = true;
            }

            button_showPasswordNew.Enabled = textBoxPasswordNew.Text.Length == 0 ? false : true;
        }

        //Error-- UI Element...set to Visible
        private void TextBoxReponsS_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReponsS.Text.Length > 40)
            {
                pictureBoxReponsSError.Visible = true;
                pictureBoxReponsSEdit.Visible = false;
            }
            else
            {
                pictureBoxReponsSError.Visible = false;
                pictureBoxReponsSEdit.Visible = true;
            }
        }
        //Edit/UPDATE QUERY for the Password
        private void PictureBoPasswordNewEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPasswordNew.Text.Length == 0) throw new Exception("You must first enter a new password");
                if (textBoxPasswordNew.Text.Length > 30) throw new Exception("UserPassword must not exceed 30 characters");
                if (textBoxPasswordNew.Text == Account.UserPassword) throw new Exception("This password is the same as your current password");

                Account.UserPassword = textBoxPasswordNew.Text;
                Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET UserPassword = '" + textBoxPasswordNew.Text + "' WHERE AccountID = " + Account.AccountId + ";");
                MessageBox.Show("You have successfully changed your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Edit/UPDATE QUERY for the Security Answer
        private void PictureBoxReponsSEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxReponsS.Text.Length == 0) throw new Exception("You must first enter an answer for the security question");
                if (textBoxReponsS.Text.Length > 40) throw new Exception("Response should not exceed 40 characters");
                if (comboBoxQuestionS.Text == Account.SecurityQuestion && textBoxReponsS.Text == Account.SecurityAnswer) throw new Exception("This security question and / or answer is / is identical to your current one");

                Account.SecurityQuestion = comboBoxQuestionS.Text;
                Account.SecurityAnswer = textBoxReponsS.Text;
                Connection.IssueQuery("USE trentMessengerDB3; UPDATE Accounts SET SecurityQuestion = '" + comboBoxQuestionS.Text + "', SecurityR = '" + textBoxReponsS.Text + "' WHERE AccountID = " + Account.AccountId + ";");
                MessageBox.Show("You have successfully changed your security question and answer", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On User Settings Form Closed
        private void Account_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings settingsForm  = new settings(new ChatHome());
            settingsForm.Show();
        }

        private void ButtonShowPassCon_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordCon.UseSystemPasswordChar == false)
                textBoxPasswordCon.UseSystemPasswordChar = true;
            else
                textBoxPasswordCon.UseSystemPasswordChar = false;
        }

        private void ButtonShowPassNew_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordNew.UseSystemPasswordChar == false)
                textBoxPasswordNew.UseSystemPasswordChar = true;
            else
                textBoxPasswordNew.UseSystemPasswordChar = false;
        }
    }
}
